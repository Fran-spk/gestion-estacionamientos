using Controladora;
using MODELO;
using MODELO.seguridad;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FormPlan : Form
    {
        private Plan plan;

        public FormPlan()
        {
            InitializeComponent();
            LlenarCom();
            this.Load += FormPlan_Load;
        }

        public FormPlan(Plan Plan)
        {
            InitializeComponent();
            LlenarCom();
            plan = Plan;
            txtNombre.Text = Plan.NombreCliente;
            txttelefono.Text = Plan.Telefono.ToString();
            txtdni.Text = Plan.Dni.ToString();
            txtPatente.Text = Plan.Patente;
            txtPatente.Enabled = false;

            dateTimePicker1.Value = Plan.FechaHoraAlta;

            var cuota = Plan.Cuotas.FirstOrDefault();
            if (cuota != null)
            {
                txttipoVehiculo.Text = cuota.TarifaEstacionamiento.TipoVehiculo.ToString();
                txttipoVehiculo.Enabled = false;
            }

            dataGridView1.Enabled = false;

            this.Load += FormPlan_Load;
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar planes"))
            {
                MessageBox.Show("Necesita permisos");
                Close();
            }
        }

        void LlenarCom()
        {
            TxtDescuento.DataSource =
                ControladoraDescuentos.Instancia.getAllDescuentosActivos().ToList();

            txttipoVehiculo.DataSource =
                ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();

            TxtDescuento.Enabled = false;
        }

        private bool Validaciones()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese nombre valido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("Ingrese patente valida");
                return false;
            }

            return true;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones())
                return;

            if (plan == null)
                plan = new Plan();

            try
            {
                plan.NombreCliente = txtNombre.Text;
                plan.Telefono = long.Parse(txttelefono.Text);
                plan.Dni = int.Parse(txtdni.Text);
                plan.Patente = txtPatente.Text;
                plan.FechaHoraAlta = dateTimePicker1.Value;
                plan.EstadoPlan = true;
                plan.Descuento = checkDesc.Checked
                    ? TxtDescuento.SelectedItem as Descuento
                    : null;
            }
            catch
            {
                MessageBox.Show("Ingreso invalido de datos");
                return;
            }

            // === ALTA ===
            if (txtPatente.Enabled)
            {
                if (!CrearCuotaInicial())
                    return;

                MessageBox.Show("Vehiculo ingresado al estacionamiento de forma exitosa");
            }
            else
            {
                var resultado = ControladoraPlanes.Instancia.ModificarPlan(plan);
                MessageBox.Show(resultado);
            }

            Close();
        }

        private bool CrearCuotaInicial()
        {
            var cuota = new Cuota
            {
                Actual = true,
                Plan = plan,
                FechaHoraEmision = dateTimePicker1.Value,
                Patente = plan.Patente,
                Estado = ControladoraCuotas.Instancia
                    .getAllEstados()
                    .FirstOrDefault(x => x.Nombre == "Pendiente") ?? new Estado_Ticket()
            };

            var tarifa = ControladoraTarifasEstacionamiento.Instancia
                .getAllTarifasActuales()
                .FirstOrDefault(x => x.TipoVehiculo == (TipoVehiculo)txttipoVehiculo.SelectedItem);

            if (tarifa == null)
            {
                MessageBox.Show("Tarifa no encontrada");
                return false;
            }

            cuota.TarifaEstacionamiento = tarifa;

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("NO se selecciono ningun espacio");
                return false;
            }

            var espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
            if (!espacio.Disponibilidad)
            {
                MessageBox.Show("Espacio ocupado a su totalidad");
                return false;
            }

            cuota.Espacio = espacio;

            if (ControladoraTicketsDiarios.Instancia.IsPresenteByPatente(cuota.Patente))
            {
                MessageBox.Show($"Vehiculo: {cuota.Patente} ya se encuentra estacionado");
                return false;
            }

            if (!ControladoraPlanes.Instancia.AgregarPlan(plan))
            {
                MessageBox.Show("Ya existe un plan con esta patente asociada");
                return false;
            }

            ControladoraCuotas.Instancia.AgregarCuota(cuota);
            return true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkDesc_CheckedChanged(object sender, EventArgs e)
        {
            TxtDescuento.Enabled = checkDesc.Checked;
        }

        private void txttipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoVehiculo = txttipoVehiculo.SelectedItem as TipoVehiculo;

            if (tipoVehiculo == null)
            {
                LabelNoLugar.Visible = false;
                return;
            }

            if (!tipoVehiculo.Disponibilidad)
            {
                LabelNoLugar.Visible = true;
                return;
            }

            LabelNoLugar.Visible = false;
            llenarGrilla(tipoVehiculo);
        }

        public void llenarGrilla(TipoVehiculo tipo)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =
                ControladoraEspacios.Instancia.getAllEspaciosByTipoVehiculo(tipo);
        }
    }

}
