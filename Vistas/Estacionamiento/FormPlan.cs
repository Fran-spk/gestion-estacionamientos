using Controladora;
using MODELO;
using MODELO.seguridad;
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
            txtNombre.Text = Plan.NombreCliente.ToString();
            txttelefono.Text = Plan.Telefono.ToString();
            txtdni.Text = Plan.Dni.ToString();
            txtPatente.Text = Plan.Patente.ToString();
            dateTimePicker1.Value = Plan.FechaHoraAlta;
            txtPatente.Enabled = false;
            var cuota = Plan.Cuotas;
            txttipoVehiculo.Text = cuota.FirstOrDefault().TarifaEstacionamiento.TipoVehiculo.ToString();
            txttipoVehiculo.Enabled = false;
            plan = Plan;
            dataGridView1.Enabled = false;
            this.Load += FormPlan_Load;
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Gestionar planes");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }

        void LlenarCom()
        {
            var descuentos = ControladoraDescuentos.Instancia.getAllDescuentosActivos().ToList();
            TxtDescuento.DataSource = descuentos;
            txttipoVehiculo.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();
            TxtDescuento.Enabled = false;
        }


        private bool Validaciones() //validaciones del formulario
        {
            var ok = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese nombre valido");
                ok = false;
            }
            if (string.IsNullOrEmpty(txtPatente.Text))
            {
                MessageBox.Show("Ingrese patente valida");
                ok = false;
            }
            return ok;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                if (plan == null) { plan = new Plan(); }
                try 
                {
                    plan.NombreCliente = txtNombre.Text;
                    plan.Telefono = long.Parse(txttelefono.Text);
                    plan.Dni = int.Parse(txtdni.Text);
                    plan.Patente = txtPatente.Text;
                    if (checkDesc.Checked)
                    {
                        plan.Descuento = TxtDescuento.SelectedItem as Descuento;
                    }
                    else
                    {
                        plan.Descuento = null;
                    }                
                    plan.FechaHoraAlta = dateTimePicker1.Value;
                    plan.EstadoPlan = true;                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingreso invalido de datos");
                    return;
                }
                if (txtPatente.Enabled) //para altas                          
                {
                    Cuota cuota = new Cuota();
                    cuota.Actual = true;
                    cuota.Plan = plan;
                    cuota.FechaHoraEmision = dateTimePicker1.Value;
                    cuota.Patente = plan.Patente;
                    var tarifa = ControladoraTarifas.Instancia.getAllTarifasActuales().FirstOrDefault(x => x.TipoVehiculo == (TipoVehiculo)txttipoVehiculo.SelectedItem);
                    if (tarifa != null)
                    {
                        cuota.TarifaEstacionamiento = tarifa;
                    }
                    else
                    {
                        MessageBox.Show("Tarifa no encontrada");
                        return;
                    }
                    cuota.Estado = ControladoraTicketsBase.Instancia.getAllEstados().FirstOrDefault(x => x.Nombre == "Pendiente") ?? new Estado_Ticket();


                    if (dataGridView1.CurrentRow != null)
                    {
                        var espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                        if (espacio.Disponibilidad)
                        {
                            cuota.Espacio = espacio;
                        }
                        else
                        {
                            MessageBox.Show("Espacio ocupado a su totalidad");
                            return;
                        }
                    }
                    if(cuota.Espacio == null) 
                    {
                        MessageBox.Show("NO se selecciono ningun espacio");
                        return;
                    }
                    if (ControladoraTicketsBase.Instancia.IsPresenteByPatente(cuota.Patente))
                    {
                        MessageBox.Show("Vehiculo: " + cuota.Patente + " ya se encuentra estacionado");
                        return;
                    }
                    var ok = ControladoraPlanes.Instancia.AgregarPlan(plan);
                    if (ok)
                    {
                        ControladoraTicketsBase.Instancia.AgregarTicket(cuota);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un plan con Esta patente asociada");
                        return;
                    }
                    MessageBox.Show("Vehiculo ingresado al estacionamiento de forma exitosa");
                }
                else
                {             
                    var ok = ControladoraPlanes.Instancia.ModificarPlan(plan);
                    MessageBox.Show(ok);
                }
                this.Close();
            }


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkDesc_CheckedChanged(object sender, EventArgs e)
        {
            TxtDescuento.Enabled = checkDesc.Checked;
        }

        private void txttipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var TipoVehiculo = (TipoVehiculo)txttipoVehiculo.SelectedItem;
            if (TipoVehiculo != null)
            {
                if (TipoVehiculo.Disponibilidad)
                {
                    LabelNoLugar.Visible = false;
                    llenarGrilla(TipoVehiculo);
                }
                else { LabelNoLugar.Visible = true; }
            }
            else
            {
                LabelNoLugar.Visible = false;
            }
        }
        public void llenarGrilla(TipoVehiculo tipo)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraEspacios.Instancia.getAllEspaciosByTipoVehiculo(tipo);
        }
    }
}
