using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using MODELO.seguridad;
using MODELO;
using Modelo_Ids;
using System.Numerics;

namespace Vista.Configuraciones
{
    public partial class FormPagoPlanes : Form
    {
        private Cuota _cuota;
        private Plan _plan;
        private Pago _pagoPreview;

        public FormPagoPlanes(Cuota cuota)
        {
            InitializeComponent();
            _cuota = cuota;
            _plan = ControladoraPlanes.Instancia.getPlanActivoByPatente(cuota.Patente);
            LlenarTxt(cuota);
            CargarServiciosAdicionales();
            GenerarPagoPreview();
            chCobroDeServicios.Checked = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LlenarTxt(Cuota cuota)
        {
            lbPatente.Text = cuota.Patente.ToString();
            TxtFechaVencimiento.Text = cuota.FechaHoraVencimiento.ToString();
            var cuotasOrdenadas = cuota.Plan.Cuotas.OrderBy(c => c.FechaHoraEmision).ToList();
            int numeroCuota = cuotasOrdenadas.IndexOf(cuota) + 1;
            TxtCuotaNro.Text = numeroCuota.ToString();
            cbmMetodo.DataSource = ControladoraMetodosDePago.Instancia.getAllMetodosDePagoActivos();
            txtTipo.Text = cuota.TarifaEstacionamiento.TipoVehiculo.NombreVehiculo;
        }

        private void CargarServiciosAdicionales()
        {
            flowLayoutServicios.Controls.Clear();

            var serviciosImpagos = _plan.ObtenerServiciosPendientes();

            if (!serviciosImpagos.Any())
            {
                flowLayoutServicios.Controls.Add(new Label
                {
                    Text = "Sin servicios adicionales pendientes",
                    ForeColor = Color.FromArgb(150, 150, 150),
                    Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                    AutoSize = true,
                    Padding = new Padding(5, 2, 5, 2)
                });
                return;
            }

            foreach (var servicio in serviciosImpagos)
            {
                var tarifa = servicio.TarifaServicio;

                Panel panelServicio = new Panel
                {
                    Width = 350,
                    Height = 25,
                    Margin = new Padding(1),
                    BackColor = Color.FromArgb(45, 45, 48)
                };

                string descripcion = tarifa?.ServicioVehiculo?.Servicio?.Descripcion ?? "Servicio";
                string vehiculo = tarifa?.ServicioVehiculo?.Vehiculo?.NombreVehiculo ?? "";

                Label lblNombre = new Label
                {
                    Text = $"{descripcion} {(vehiculo != "" ? "para " + vehiculo : "")}",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    AutoSize = true,
                    Location = new Point(5, 2)
                };

                panelServicio.Controls.Add(lblNombre);

                Label lblPrecio = new Label
                {
                    Text = $"${tarifa.Precio:N2}",
                    ForeColor = Color.FromArgb(76, 175, 80),
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(lblNombre.Right + 8, 2)
                };

                panelServicio.Controls.Add(lblPrecio);
                flowLayoutServicios.Controls.Add(panelServicio);
            }
        }

        void GenerarPagoPreview()
        {
            var servicios = chCobroDeServicios.Checked
                ? _plan.ObtenerServiciosPendientes()
                : new List<ServicioConsumido>();

            _pagoPreview = servicios.Any()
                ? PagoFactory.CrearPagoCuotaConServicios(_cuota, (List<ServicioConsumido>)servicios, cbmMetodo.SelectedItem as MetodoDePago)
                : PagoFactory.CrearPagoCuota(_cuota, cbmMetodo.SelectedItem as MetodoDePago);

            TxtPrecio.Text = _pagoPreview.Monto.ToString();
            txtdesc.Text = _pagoPreview.MontoDescuento.ToString();
            TxtPrecioFinal.Text = _pagoPreview.MontoTotal.ToString();
        }

        private void btnPago_Click_1(object sender, EventArgs e)
        {
            var accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Generar pago");
            if (accion == null)
            {
                MessageBox.Show("Necesita permisos");
                return;
            }

            var metodoPago = cbmMetodo.SelectedItem as MetodoDePago;
            if (metodoPago == null)
            {
                MessageBox.Show("Debe seleccionar algún método de pago");
                return;
            }

            // Regenerar con el método de pago seleccionado definitivo
            var servicios = chCobroDeServicios.Checked
                ? _plan.ObtenerServiciosPendientes()
                : new List<ServicioConsumido>();

            var pago = servicios.Any()
                ? PagoFactory.CrearPagoCuotaConServicios(_cuota, (List<ServicioConsumido>)servicios, metodoPago)
                : PagoFactory.CrearPagoCuota(_cuota, metodoPago);

            var ok = ControladoraPagos.Instancia.AgregarPago(pago);
            if (ok)
            {
                _cuota.Estado = ControladoraCuotas.Instancia.getAllEstados()
                    .FirstOrDefault(x => x.Nombre == "Pagado") ?? new Estado_Ticket();
                ControladoraCuotas.Instancia.ModificarCuota(_cuota);

                if (checkBox1.Checked)
                {
                    var recibo = new FormPagoDetalle(pago);
                }

                MessageBox.Show("Pago realizado!");
            }
            else
            {
                MessageBox.Show("El ticket ya se encuentra pagado");
            }

            this.Close();
        }

        private void chCobroDeServicios_CheckedChanged(object sender, EventArgs e)
        {
            if (chCobroDeServicios.Checked)
                CargarServiciosAdicionales();
            else
                flowLayoutServicios.Controls.Clear();

            GenerarPagoPreview();
        }
    }
}