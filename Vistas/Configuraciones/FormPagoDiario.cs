using Controladora;
using Microsoft.VisualBasic.ApplicationServices;
using MODELO;
using MODELO.seguridad;
using Modelo_Ids;
using Servicios;
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
    public partial class FormPago : Form
    {
        Ticket_Diario Ticket;
        public FormPago(Ticket_Diario ticket)
        {
            Ticket = ticket;
            InitializeComponent();
            ControladoraTicketsDiarios.Instancia.ActualizarTicketsVencidos();
            LlenarTxt(ticket);
            GenerarPago(ticket);
            CargarServiciosAdicionales(ticket);
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            HoraActual.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LlenarTxt(TicketBase ticket)
        {
            lbPatente.Text = ticket.Patente.ToString();
            TxtEstadia.Text = ticket.Estadia.ToString();
            TxtHoraLlegada.Text = ticket.FechaHoraEmision.ToString();
            cbmMetodo.DataSource = ControladoraMetodosDePago.Instancia.getAllMetodosDePagoActivos();
            txtTipo.Text = ticket.TarifaEstacionamiento.TipoVehiculo.NombreVehiculo;
        }


        private void CargarServiciosAdicionales(Ticket_Diario ticket)
        {
            flowLayoutServicios.Controls.Clear();

            if (ticket.ServiciosConsumidos == null || !ticket.ServiciosConsumidos.Any())
            {
                // Si no hay servicios, mostrar mensaje
                Label lblSinServicios = new Label
                {
                    Text = "Sin servicios adicionales",
                    ForeColor = Color.FromArgb(150, 150, 150),
                    Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                    AutoSize = true,
                    Padding = new Padding(5, 2, 5, 2)
                };
                flowLayoutServicios.Controls.Add(lblSinServicios);
                return;
            }

            // Agregar cada servicio adicional
            foreach (var servicios in ticket.ObtenerServiciosPendientes()) //solo mostrar los impagos a liquidar
            {
                     var tarifaServicio = ControladoraTarifasServicio.Instancia.getTarifaById(servicios.TarifaServicio.TarifaServicioId);
                    Panel panelServicio = new Panel
                    {
                        Width = 350,
                        Height = 25,
                        Margin = new Padding(1),
                        BackColor = Color.FromArgb(45, 45, 48)
                    };

                    // Nombre del servicio
                    Label lblNombre = new Label
                    {
                        Text = tarifaServicio.ServicioVehiculo.Servicio.Descripcion + " para " + tarifaServicio.ServicioVehiculo.Vehiculo.NombreVehiculo ?? "Servicio",
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                        AutoSize = true,
                        Location = new Point(5, 2)
                    };

                    panelServicio.Controls.Add(lblNombre);


                    Label lblPrecio = new Label
                    {
                        Text = $"${servicios.TarifaServicio.Precio:N2}",
                        ForeColor = Color.FromArgb(76, 175, 80),
                        Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                        AutoSize = true,
                        Location = new Point(lblNombre.Right + 5, 2)
                    };

                    panelServicio.Controls.Add(lblPrecio);
                    flowLayoutServicios.Controls.Add(panelServicio);
                }       
        }

        private void btnPago_Click_1(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Generar pago"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }

            var MetodoDePago = cbmMetodo.SelectedItem as MetodoDePago;
            if (MetodoDePago == null) { MessageBox.Show("Debe seleccionar algun metodo de pago"); return; }
            var pago = PagoFactory.CrearPagoTicketDiario(Ticket, MetodoDePago);
            var ok = ControladoraPagos.Instancia.AgregarPago(pago);
            if (ok)
            {
                Ticket.EstacionamientoPago = true;
                ControladoraTicketsDiarios.Instancia.RegistrarSalida(Ticket,DateTime.Now,Sesion.Instancia.Perfil.PER_ID);
                
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

        void GenerarPago(Ticket_Diario ticket)
        {
            var pago = PagoFactory.CrearPagoTicketDiario(ticket, cbmMetodo.SelectedItem as MetodoDePago);
            TxtPrecio.Text = pago.Monto.ToString();
            TxtPrecioFinal.Text = pago.MontoTotal.ToString();
            txtdesc.Text = pago.MontoDescuento.ToString();
        }
    }
}