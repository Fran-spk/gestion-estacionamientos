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
using MODELO;
using MODELO.seguridad;
using Modelo_Ids;

namespace Vista.Configuraciones
{
    public partial class FormPagoServicios : Form
    {
        private Plan _plan;
        private List<ServicioConsumido> _servicios;
        private Pago _pagoPreview;

        public FormPagoServicios(List<ServicioConsumido> servicios, Plan plan)
        {
            InitializeComponent();
            _plan = plan;
            _servicios = servicios;
            LlenarTxt(plan);
            CargarServiciosAdicionales(servicios);
            GenerarPagoPreview();
        }

        void LlenarTxt(Plan plan)
        {
            lbPatente.Text = plan.Patente.ToString();
            cbmMetodo.DataSource = ControladoraMetodosDePago.Instancia.getAllMetodosDePagoActivos();
            txtTipo.Text = plan.Cuotas.FirstOrDefault()?.TarifaEstacionamiento.TipoVehiculo.NombreVehiculo;
        }

        private void CargarServiciosAdicionales(List<ServicioConsumido> serviciosImpagos)
        {
            flowLayoutServicios.Controls.Clear();

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
            _pagoPreview = PagoFactory.CrearPagoServiciosPlan(_servicios, cbmMetodo.SelectedItem as MetodoDePago,_plan);
            TxtPrecioFinal.Text = _pagoPreview.MontoTotal.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPago_Click(object sender, EventArgs e)
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

            var pago = PagoFactory.CrearPagoServiciosPlan(_servicios, metodoPago, _plan);
            var ok = ControladoraPagos.Instancia.AgregarPago(pago);
            if (ok)
            {
                if (checkBox1.Checked)
                {
                    var recibo = new FormPagoDetalle(pago);
                }
                MessageBox.Show("Pago realizado!");
            }
            else
            {
                MessageBox.Show("El pago no pudo realizarse");
            }
            this.Close();
        }
    }
}