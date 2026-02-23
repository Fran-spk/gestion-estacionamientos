using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controladora;
using MODELO;
using Modelo_Ids;
using Vista.Configuraciones;

namespace Vista.Estacionamiento
{
    public partial class FormGestionServiciosPlan : Form
    {
        private Plan Plan;

        public FormGestionServiciosPlan(Plan plan)
        {
            InitializeComponent();
            Plan = plan;

            InicializarComboEstado();
            LlenarTxt();
            ActualizarGrilla();
        }


        private void InicializarComboEstado()
        {
            cbmEstadoServicios.Items.Clear();
            cbmEstadoServicios.Items.Add("Pendientes");
            cbmEstadoServicios.Items.Add("Pagados");
            cbmEstadoServicios.Items.Add("Anulados");
            cbmEstadoServicios.Items.Add("Todos");

            cbmEstadoServicios.SelectedIndex = 0;
            cbmEstadoServicios.SelectedIndexChanged += (_, __) => ActualizarGrilla();
        }

        private void LlenarTxt()
        {
            TxtNombre.Text = Plan.NombreCliente;
            txtDate.Text = Plan.FechaHoraAlta.ToString("dd/MM/yyyy HH:mm");

            var cuota = ControladoraCuotas.Instancia
                .getAllCuotasByPlanId(Plan.PER_ID)
                .LastOrDefault();

            if (cuota != null)
                TxtTipo.Text = cuota.TarifaEstacionamiento.TipoVehiculo.ToString();
        }


        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;

            var servicios = Plan.ServiciosConsumidos ?? new List<ServicioConsumido>();
            IEnumerable<ServicioConsumido> filtrados = servicios;

            switch (cbmEstadoServicios.SelectedItem?.ToString())
            {
                case "Pendientes": filtrados = servicios.Where(s => !s.Pagado && !s.Anulado); break;
                case "Pagados": filtrados = servicios.Where(s => s.Pagado && !s.Anulado); break;
                case "Anulados": filtrados = servicios.Where(s => s.Anulado); break;
                default: filtrados = servicios; break;
            }

            dataGridView1.AutoGenerateColumns = true; 
            dataGridView1.DataSource = filtrados.Select(s => new
            {
                Servicio = s.TarifaServicio?.ServicioVehiculo?.Servicio?.Descripcion ?? "Sin descripción",
                Fecha = s.FechaHoraAsignado.ToString("dd/MM/yyyy HH:mm"),
                Precio = s.TarifaServicio?.Precio.ToString("C2") ?? "-",
                Estado = s.Anulado ? "❌ Anulado" : s.Pagado ? "✅ Pagado" : "⏳ Pendiente",
                _ServicioConsumidoId = s.ServicioConsumidoId
            }).ToList();


            dataGridView1.Columns["Servicio"].HeaderText = "Servicio";
            dataGridView1.Columns["Fecha"].HeaderText = "Fecha asignado";
            dataGridView1.Columns["Precio"].HeaderText = "Precio";
            dataGridView1.Columns["Estado"].HeaderText = "Estado";
            dataGridView1.Columns["_ServicioConsumidoId"].Visible = false;
        }


        private ServicioConsumido? ObtenerServicioSeleccionado()
        {
            if (dataGridView1.CurrentRow == null) return null;

            var id = (int)dataGridView1.CurrentRow.Cells["_ServicioConsumidoId"].Value;
            return Plan.ServiciosConsumidos.FirstOrDefault(s => s.ServicioConsumidoId == id);
        }
        private void BtnVerPago_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            var servicio = ObtenerServicioSeleccionado();

            var pago = ControladoraPagos.Instancia
                .getPagoByServicioId(servicio.ServicioConsumidoId);

            if (pago != null)
            {
                using var form = new FormPagoDetalle(pago);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen pagos asociados");
            }
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            var servicios = Plan.ObtenerServiciosPendientes();

            if (!servicios.Any())
            {
                MessageBox.Show("No posee servicios pendientes");
                return;
            }

            using var form = new FormPagoServicios(servicios.ToList(), Plan);
            Hide();
            form.ShowDialog();
            Show();

            ActualizarGrilla();
        }

        private void btnCobrarUna_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un servicio");
                return;
            }

            var servicio = ObtenerServicioSeleccionado();

            if (!servicio.Pendiente || servicio.Anulado)
            {
                MessageBox.Show("Seleccione un servicio pendiente");
                return;
            }

            using var form = new FormPagoServicios(
                new List<ServicioConsumido> { servicio },
                Plan
            );

            Hide();
            form.ShowDialog();
            Show();

            ActualizarGrilla();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            using var form = new FormAltaServicioPlan(Plan);
            form.ShowDialog();
            ActualizarGrilla();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbmEstadoServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
