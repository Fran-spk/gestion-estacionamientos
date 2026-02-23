using Controladora;
using MODELO;
using MODELO.seguridad;
using Servicios;
using System;
using System.Linq;
using System.Windows.Forms;
using Vista.Configuraciones;
using Vista.Estacionamiento;

namespace Vista
{
    public partial class FormPlanes : Form
    {
        public FormPlanes()
        {
            InitializeComponent();
            LlenarCombo();
            ActualizoGrilla();
            Load += FormPlanes_Load;
        }

        private void FormPlanes_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Ver planes"))
            {
                MessageBox.Show("Necesita permisos");
                Close();
            }
        }



        void LlenarCombo()
        {
            CbxEstado.Checked = true;
            cbxPatente.DataSource = ControladoraPlanes.Instancia
                .getAllPlanesActivos()
                .ToList();
        }

        void ActualizoGrilla()
        {
            ControladoraCuotas.Instancia.ProcesarCuotasVencidas();

            var plan = cbxPatente.SelectedItem as Plan;
            if (plan == null)
                return;

            var cuotas = ControladoraCuotas.Instancia
                .getAllCuotasByPlanId(plan.PER_ID);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cuotas;
        }

        private void cbxPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var plan = cbxPatente.SelectedItem as Plan;
            if (plan == null)
                return;

            TxtNombre.Text = plan.NombreCliente;
            TxtDesc.Text = plan.Descuento?.NombreDescuento;
            txtDate.Text = plan.FechaHoraAlta.ToString();


            var cuota = ControladoraCuotas.Instancia
                .getAllCuotasByPlanId(plan.PER_ID)
                .LastOrDefault();

            if (cuota != null)
                TxtTipo.Text = cuota.TarifaEstacionamiento.TipoVehiculo.ToString();
            else
                MessageBox.Show("No existen cuotas asociadas");

            if (!plan.EstadoPlan)
                MessageBox.Show("Este plan se encuentra dado de baja");
            if (cuota.Plan.ObtenerServiciosPendientes().Any())
            {
                lbSeriviciosPendientes.Text = "Tiene servicios pendiente a pagar";
            }
            else
            {
                lbSeriviciosPendientes.Text = "";
            }
            btnBaja.Enabled = plan.EstadoPlan;
            btnModificar.Enabled = plan.EstadoPlan;
            BtnCobrar.Enabled = plan.EstadoPlan;

            ActualizoGrilla();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Liquidar Cuotas"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un vehículo");
                return;
            }

            var cuota = (Cuota)dataGridView1.CurrentRow.DataBoundItem;
            var pagado = ControladoraCuotas.Instancia.getAllEstados().
                       FirstOrDefault(x => x.Nombre == "Pagado") ?? new Estado_Ticket();
            if (cuota.Estado.EstadoId != pagado.EstadoId)
            {
                var form = new FormPagoPlanes(cuota);
                Hide();
                form.ShowDialog();
                Show();
                LlenarCombo();
                ActualizoGrilla();
            }
            else
            {
                MessageBox.Show("Esta cuota ya está paga");
            }
        }
        //manejar los estaos de los servicios a la hora de pagarlosss
        //mejorar ticket no se ve bien entero
        private void BtnVerPago_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            var cuota = (Cuota)dataGridView1.CurrentRow.DataBoundItem;

            var pago = ControladoraPagos.Instancia.getPagoByTicket(cuota.TicketBaseId);

            if (pago != null)
            {
                var form = new FormPagoDetalle(pago);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen pagos asociados");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var plan = cbxPatente.SelectedItem as Plan;
            if (plan == null)
                return;

            var form = new FormPlan(plan);
            form.ShowDialog();
            LlenarCombo();
            ActualizoGrilla();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar planes"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }

            var plan = cbxPatente.SelectedItem as Plan;
            if (plan == null)
                return;
            if (plan.ObtenerServiciosPendientes().Any())
            {
                MessageBox.Show("El plan adeuda servicios a pagar");
                return;
            }
            var ok = ControladoraPlanes.Instancia.BajarPlan(plan);
            MessageBox.Show(ok
                ? "Plan dado de baja correctamente"
                : "El vehículo adeuda cuotas");

            LlenarCombo();
            VaciarTxt();
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

        private void CbxEstado_Click(object sender, EventArgs e)
        {
            cbxPatente.DataSource = CbxEstado.Checked
                ? ControladoraPlanes.Instancia.getAllPlanesActivos().ToList()
                : ControladoraPlanes.Instancia.getAllPlanes().ToList();
        }

        private void btnServicios_Click_1(object sender, EventArgs e)
        {
            var plan = cbxPatente.SelectedItem as Plan;
            if (plan == null)
                return;

            if (!plan.EstadoPlan)
            {
                MessageBox.Show("Plan inactivo");
                return;
            }

            var form = new FormAltaServicioPlan(plan);
            form.ShowDialog();
            ActualizoGrilla();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGestionServicios_Click(object sender, EventArgs e)
        {
            var plan = cbxPatente.SelectedItem as Plan;
            if (plan == null)
                return;


            if (!plan.EstadoPlan)
            {
                MessageBox.Show("Plan inactivo");
                return;
            }

            var form = new FormGestionServiciosPlan(plan);
            form.Show();
            ActualizoGrilla();
        }
    }
}
