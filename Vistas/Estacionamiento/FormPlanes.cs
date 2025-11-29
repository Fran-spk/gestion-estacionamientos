using Controladora;
using MODELO;
using MODELO.seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormPlanes : Form
    {
        public FormPlanes()
        {
            InitializeComponent();
            LlenarCombo();
            ActualizoGrilla();
            this.Load += FormPlanes_Load;
        }

        private async void FormPlanes_Load(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Ver planes");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
                return;
            }

            await Task.Delay(500); 
            await TicketsAutomaticos(); 
        }



        void LlenarCombo()
        {
            CbxEstado.Checked = true;
            var planes = ControladoraPlanes.Instancia.getAllPlanesActivos().ToList();
            cbxPatente.DataSource = planes;
        }

        void ActualizoGrilla()
        {

            var plan = cbxPatente.SelectedItem as Plan;
            if (plan != null)
            {
                var cuotas = plan.Cuotas;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cuotas;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var plan = cbxPatente.SelectedItem as Plan;
            TxtNombre.Text = plan.NombreCliente;
            if (plan.Descuento != null) { TxtDesc.Text = plan.Descuento.ToString(); }
            txtDate.Text = plan.FechaHoraAlta.ToString();
            TxtDesc.Text = plan.Descuento?.NombreDescuento;
            //buscar cuota ult
            var cuota = ControladoraTicketsBase.Instancia.getAllCuotasByPlanId(plan.PER_ID).Last();
            TxtTipo.Text = cuota.Tarifa.TipoVehiculo.ToString();
            if (!plan.EstadoPlan)
            {
                MessageBox.Show("Este plan se encuentra dado de baja");
            }
            btnBaja.Enabled = plan.EstadoPlan;
            btnModificar.Enabled = plan.EstadoPlan;
            BtnCobrar.Enabled = plan.EstadoPlan;
            ActualizoGrilla();
        }


        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Liquidar Cuotas");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
            if (dataGridView1.CurrentRow != null)
            {
                var cuota = (Cuota)dataGridView1.CurrentRow.DataBoundItem;
                if (cuota.Estado.Nombre == "Pendiente")
                {
                    var form = new FormPago(cuota);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                    LlenarCombo();
                }
                else
                {
                    MessageBox.Show("Esta cuota ya esta paga");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehículo");
            }
            LlenarCombo();
        }

        private void BtnVerPago_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var cuota = (Cuota)dataGridView1.CurrentRow.DataBoundItem;
                var pago = ControladoraPagos.Instancia.getAllPagos().FirstOrDefault(x => x.Ticket.Codigo == cuota.Codigo);
                if (pago != null)
                {
                    var form = new FormPagoDetalle(pago);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Esta cuota aun no esta pagada");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbxPatente.SelectedItem != null)
            {
                var plan = cbxPatente.SelectedItem as Plan;
                var form = new FormPlan(plan);
                form.ShowDialog();
                LlenarCombo();
                ActualizoGrilla();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Gestionar planes");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
            if (cbxPatente.SelectedItem != null)
            {
                var plan = cbxPatente.SelectedItem as Plan;
                var ok = ControladoraPlanes.Instancia.BajarPlan(plan);
                if (!ok)
                {
                    MessageBox.Show("El vehiculo adeuda cuotas");
                }
                else
                {
                    MessageBox.Show("Plan dado de baja correctamente");
                }
                LlenarCombo();
                VaciarTxt();
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            var form = new FormPlan();
            form.ShowDialog();
            LlenarCombo();
            ActualizoGrilla();
        }

        void VaciarTxt()
        {
            TxtDesc.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtTipo.Text = string.Empty;
            txtDate.Text = string.Empty;
            dataGridView1.DataSource = null;
        }

        async Task TicketsAutomaticos()
        {
            await Task.Run(() =>
            {
                var CuotasActuales = ControladoraTicketsBase.Instancia.getAllTickets().OfType<Cuota>().Where(x => x.Actual == true).ToList();
                for (int i = 0; i < CuotasActuales.Count; i++)
                {
                    var CuotaVencida = CuotasActuales[i];
                    if (CuotaVencida.FechaHoraVencimiento <= DateTime.Now)
                    {
                        CuotaVencida.Actual = false;
                        var plan = ControladoraPlanes.Instancia.getPlanActivoByPatente(CuotaVencida.Patente);
                        Cuota cuota = new Cuota();
                        cuota.Actual = true;
                        cuota.Plan = plan;
                        cuota.FechaHoraEmision = CuotaVencida.FechaHoraVencimiento;
                        cuota.Espacio = CuotaVencida.Espacio;
                        cuota.Patente = plan.Patente;

                        var tarifa = ControladoraTarifas.Instancia.getAllTarifasActuales().FirstOrDefault(x => x.TipoVehiculo.TipoVehiculoId == CuotaVencida.Tarifa.TipoVehiculoId);
                        if (tarifa != null)
                        {
                            cuota.Tarifa = tarifa;
                        }
                        else
                        {
                            MessageBox.Show("Tarifa no encontrada");
                            return;
                        }
                        cuota.Estado = ControladoraTicketsBase.Instancia.getAllEstados().FirstOrDefault(x => x.Nombre == "Pendiente") ?? new Estado_Ticket();

                        ControladoraTicketsBase.Instancia.AgregarTicket(cuota);
                        ControladoraTicketsBase.Instancia.ModificarTicket(CuotaVencida);
                        CuotasActuales.Add(cuota); //Para corroborar que esta misma agregada no este vencida y si es asi seguir creando cuota
                    }
                }
            });
        }



        private void CbxEstado_Click(object sender, EventArgs e)
        {
            if (!CbxEstado.Checked)
            {
                var planes = ControladoraPlanes.Instancia.getAllPlanes().ToList();
                cbxPatente.DataSource = planes;
            }
            else
            {
                LlenarCombo();
            }
        }

        private void FormPlanes_Load_1(object sender, EventArgs e)
        {

        }
    }
}




