using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Controladora;
using MODELO;
using MODELO.seguridad;
using Modelo_Ids;
using Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Vista.Estacionamiento
{
    public partial class FormAltaServicioPlan : Form
    {
        private Plan? Plan;
        private Ticket_Diario? ticketDiario;

        public FormAltaServicioPlan(Plan plan)
        {
            InitializeComponent();
            Plan = plan;
            InicializarFormulario();
        }

        public FormAltaServicioPlan(Ticket_Diario ticket)
        {
            InitializeComponent();
            ticketDiario = ticket;
            InicializarFormulario();
        }

        // ================= INIT =================

        private void InicializarFormulario()
        {
            LlenarTxt();
            CargarServiciosDisponibles();
            CargarServiciosAsignados();
        }

        // ================= DATOS BASE =================

        private string ObtenerPatente()
        {
            if (ticketDiario != null)
                return ticketDiario.Patente;

            return Plan!.Patente;
        }

        private TipoVehiculo ObtenerTipoVehiculo()
        {
            if (ticketDiario != null)
                return ticketDiario.TarifaEstacionamiento.TipoVehiculo;

            return Plan!.Cuotas
                .First()
                .TarifaEstacionamiento
                .TipoVehiculo;
        }

        private IEnumerable<ServicioConsumido> ObtenerServiciosPendientes()
        {
            if (ticketDiario != null)
                return ticketDiario.ObtenerServiciosPendientes();

            return Plan!.ObtenerServiciosPendientes();
        }

        private void RegistrarServicio(TarifaServicio tarifa)
        {
            try
            {
                if (ticketDiario != null)
                {
                    var ok = ControladoraTicketsDiarios.Instancia.AgregarServicio(ticketDiario,tarifa,Sesion.Instancia.Perfil.PER_ID);
                    if (!ok)
                    {
                        MessageBox.Show("Servicio ya asignado");
                    }
                }
                    
                else
                    Plan!.RegistrarServicio(tarifa);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void AnularServicio(int servicioConsumidoId)
        {
            if (ticketDiario != null)
               ControladoraTicketsDiarios.Instancia.QuitarServicio(ticketDiario.TicketBaseId, servicioConsumidoId, Sesion.Instancia.Perfil.PER_ID);
            else
                Plan!.AnularServicio(servicioConsumidoId);
        }

        // ================= UI =================

        private void LlenarTxt()
        {
            lbPatente.Text = ObtenerPatente();
            txtTipo.Text = ObtenerTipoVehiculo().NombreVehiculo;
        }

        public void CargarServiciosDisponibles()
        {
            var tipoVehiculo = ObtenerTipoVehiculo();
            var servicios = ControladoraTarifasServicio.Instancia
                .getAllTarifasActualesByVehiculo(tipoVehiculo);
            var tickets = ControladoraTicketsDiarios.Instancia.getAllTickets();
            flowLayoutServiciosDisponibles.Controls.Clear();

            foreach (var tarifa in servicios)
            {
                Panel panelServicio = new Panel
                {
                    Width = 650,
                    Height = 80,
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(45, 45, 48),
                    Padding = new Padding(10, 5, 10, 5)
                };

                Label lblNombre = new Label
                {
                    Text = tarifa.ServicioVehiculo.Servicio.Descripcion,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 8)
                };

                Label lblPrecio = new Label
                {
                    Text = $"${tarifa.Precio:N2}",
                    ForeColor = Color.FromArgb(76, 175, 80),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(450, 8)
                };

                Button btnAgregar = new Button
                {
                    Text = "+ Agregar",
                    BackColor = Color.FromArgb(0, 122, 204),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Size = new Size(100, 30),
                    Location = new Point(530, 5),
                    Tag = tarifa,
                    Cursor = Cursors.Hand
                };
                btnAgregar.FlatAppearance.BorderSize = 0;
                btnAgregar.Click += BtnAgregar_Click;
                Label lblDemora = new Label
                {
                    Text = DemoraByServicioService.CalcularDemora(tarifa, tickets),
                    ForeColor = Color.FromArgb(189, 189, 189),
                    Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                    AutoSize = false,
                    Width = 620,
                    Height = 35,
                    Location = new Point(10, 38)
                };

                panelServicio.Controls.Add(lblNombre);
                panelServicio.Controls.Add(lblPrecio);
                panelServicio.Controls.Add(btnAgregar);
                if (Plan == null)    panelServicio.Controls.Add(lblDemora);
                flowLayoutServiciosDisponibles.Controls.Add(panelServicio);
            }
        }

        public void CargarServiciosAsignados()
        {
            flowLayoutServiciosAsignados.Controls.Clear();

            var servicios = ObtenerServiciosPendientes().ToList();

            if (!servicios.Any())
            {
                Label lblVacio = new Label
                {
                    Text = "No hay servicios asignados",
                    ForeColor = Color.FromArgb(150, 150, 150),
                    Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                    AutoSize = true,
                    Padding = new Padding(10)
                };
                flowLayoutServiciosAsignados.Controls.Add(lblVacio);
                return;
            }

            foreach (var servicio in servicios)
            {
                Panel panel = new Panel
                {
                    Width = 650,
                    Height = 80,
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(45, 45, 48),
                    Padding = new Padding(10, 5, 10, 5)
                };

                Label lblNombre = new Label
                {
                    Text = servicio.TarifaServicio.ServicioVehiculo.Servicio.Descripcion,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 8)
                };

                Label lblPrecio = new Label
                {
                    Text = $"${servicio.TarifaServicio.Precio:N2}",
                    ForeColor = Color.FromArgb(76, 175, 80),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(450, 8)
                };

                Button btnQuitar = new Button
                {
                    Text = "❌ Quitar",
                    BackColor = Color.FromArgb(220, 53, 69),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Size = new Size(100, 30),
                    Location = new Point(530, 5),
                    Tag = servicio.ServicioConsumidoId,
                    Cursor = Cursors.Hand
                };
                btnQuitar.FlatAppearance.BorderSize = 0;
                btnQuitar.Click += BtnQuitar_Click;

                Label lblFecha = new Label
                {
                    Text = $"Fecha: {servicio.FechaHoraAsignado:dd/MM/yyyy}",
                    ForeColor = Color.FromArgb(189, 189, 189),
                    Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                    AutoSize = false,
                    Width = 620,
                    Height = 35,
                    Location = new Point(10, 38)
                };

                panel.Controls.Add(lblNombre);
                panel.Controls.Add(lblPrecio);
                panel.Controls.Add(btnQuitar);
                panel.Controls.Add(lblFecha);

                flowLayoutServiciosAsignados.Controls.Add(panel);
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var tarifa = (TarifaServicio)((Button)sender).Tag;
            RegistrarServicio(tarifa);
            CargarServiciosAsignados();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            int servicioId = (int)((Button)sender).Tag;
            AnularServicio(servicioId);
            CargarServiciosAsignados();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Plan != null)
                ControladoraPlanes.Instancia.ModificarPlan(Plan);
            Close();
        }

    }
}
