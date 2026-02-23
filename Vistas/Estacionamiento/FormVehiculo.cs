using Controladora;
using MODELO;
using MODELO.seguridad;
using Modelo_Ids;
using Servicios;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using Vista.Estacionamiento;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vista
{
    public partial class FormVehiculo : Form
    {

        public FormVehiculo()
        {
            InitializeComponent();
            ControladoraTicketsDiarios.Instancia.ActualizarTicketsVencidos();
            llenarCombos();
            this.Load += FormVehiculo_Load;
            CargarServicios();
        }


     private Dictionary<int, CheckBox> checkBoxesServicios = new Dictionary<int, CheckBox>();

        public void CargarServicios()
        {
            var tipovehiculo = (TipoVehiculo)comboVehiculo.SelectedItem;
            var servicios = ControladoraTarifasServicio.Instancia.getAllTarifasActualesByVehiculo(tipovehiculo);
            var tickets = ControladoraTicketsDiarios.Instancia.getAllTicketsPendientes();
            flowLayoutServicios.Controls.Clear();
            checkBoxesServicios.Clear();

            foreach (var Tarifaservicio in servicios)
            {
                Panel panelServicio = new Panel
                {
                    Width = 380,
                    Height = 65,
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(45, 45, 48),
                    Padding = new Padding(10, 5, 10, 5)
                };

                // Crear checkbox
                CheckBox chk = new CheckBox
                {
                    Text = $"{Tarifaservicio.ServicioVehiculo.Servicio.Descripcion}",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 8),
                    Tag = Tarifaservicio
                };

                // Crear label para el precio 
                Label lblPrecio = new Label
                {
                    Text = $"${Tarifaservicio.Precio:N2}",
                    ForeColor = Color.FromArgb(76, 175, 80),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(300, 8)
                };

                // Tiempo de demora 
                Label lblTiempoDemora = new Label
                {
                    Text = DemoraByServicioService.CalcularDemora(Tarifaservicio, tickets),
                    ForeColor = Color.FromArgb(189, 189, 189), // Gris claro
                    Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                    AutoSize = false,
                    Width = 360,
                    Height = 30,
                    Location = new Point(10, 32)
                };

                panelServicio.Controls.Add(chk);
                panelServicio.Controls.Add(lblPrecio);
                panelServicio.Controls.Add(lblTiempoDemora);
                flowLayoutServicios.Controls.Add(panelServicio);

                checkBoxesServicios.Add(Tarifaservicio.TarifaServicioId, chk);
            }
        }

        // Método para obtener los servicios seleccionados
        public List<TarifaServicio> CrearServiciosConsumidos()
        {
            List<TarifaServicio> nuevosServicios = new List<TarifaServicio>();


            foreach (var kvp in checkBoxesServicios)
            {
                if (!kvp.Value.Checked)
                    continue;

                var tarifa = (TarifaServicio)kvp.Value.Tag;
                nuevosServicios.Add(tarifa);
            }

            return nuevosServicios;
        }

        
    public void LimpiarServicios()
    {
        foreach (var kvp in checkBoxesServicios)
        {
            kvp.Value.Checked = false;
        }
    }
    private void FormVehiculo_Load(object sender, EventArgs e)
    {
        if (!PermisoService.TienePermiso("Generar ingreso"))
        {       
            MessageBox.Show("Necesita permisos");
            this.Close();
        }
    }

        public void llenarGrilla(TipoVehiculo tipo)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraEspacios.Instancia.getAllEspaciosByTipoVehiculo(tipo);
        }

        public void llenarCombos()
        {
            comboVehiculo.DataSource = null;
            comboVehiculo.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculoActivos();
        }



        public FormVehiculo(Ticket_Diario ticket)
        {
            InitializeComponent();
            llenarCombos();
            txtpatente.Enabled = false;
            txtpatente.Text = ticket.Patente;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            HoraActual.Text = DateTime.Now.ToLongTimeString();
        }

        private bool Validaciones() //validaciones del formulario
        {
            var ok = true;
            if (string.IsNullOrEmpty(txtpatente.Text))
            {
                MessageBox.Show("Ingrese patente valido");
                ok = false;
            }

            return ok;
        }





        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Ticket_Diario ticket = new Ticket_Diario();
                Espacio espacio;
                ticket.FechaHoraEmision = DateTime.Now;
                if (CbxManual.Checked)
                {
                    var DiaString = DateTime.Now.ToString("yyyy/MM/dd");
                    var HoraString = DiaString + " " + txtManual.Text + ":00";
                    try
                    {
                        ticket.FechaHoraEmision = DateTime.Parse(HoraString);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Formato de horario invalido, debe ser ' aa:bb '");
                        return;
                    }
                }
                ticket.Patente = txtpatente.Text;
                ticket.Estado = ControladoraCuotas.Instancia.getAllEstados().FirstOrDefault(x => x.Nombre == "Pendiente") ?? new Estado_Ticket();
                if (dataGridView1.CurrentRow != null)
                {
                    espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                    if (espacio.Disponibilidad)
                    {
                        ticket.Espacio = espacio;
                    }
                    else
                    {
                        MessageBox.Show("Espacio ocupado a su totalidad");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un espacio para el ingreso del vehiculo");
                    return;
                }

                if (ControladoraTicketsDiarios.Instancia.IsPresenteByPatente(ticket.Patente))
                {
                    MessageBox.Show("Vehiculo: " + ticket.Patente + " ya se encuentra estacionado");
                    return;
                }
                var tipovehiculo = (TipoVehiculo)comboVehiculo.SelectedItem;
                var tarifa = ControladoraTarifasEstacionamiento.Instancia.getAllTarifasActuales().FirstOrDefault(x => x.TipoVehiculo.NombreVehiculo == tipovehiculo.NombreVehiculo);
                if (tarifa != null)
                {
                    ticket.TarifaEstacionamiento = tarifa;
                }
                else
                {
                    MessageBox.Show("Tarifa no encontrada");
                    return;
                }
                //logica para insertar servicios
                foreach (var servicios in CrearServiciosConsumidos())
                {
                    ticket.RegistrarServicio(servicios);
                }
                var ok = ControladoraTicketsDiarios.Instancia.AgregarTicket(ticket, Sesion.Instancia.Perfil.PER_ID);
                if (ok)
                {
                    MessageBox.Show("Vehiculo ingresado al estacionamiento de forma exitosa");
                }
                else
                {
                    MessageBox.Show("El vehiculo no pudo ser ingresado al sistema");
                }
            }
            this.Close();

        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxManual_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxManual.Checked) { txtManual.Visible = true; }
            else { txtManual.Visible = false; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var espacios = ControladoraEspacios.Instancia.getAllEspacios();
            var TipoVehiculo = (TipoVehiculo)comboVehiculo.SelectedItem;
            CargarServicios();
            LimpiarServicios();
            if (TipoVehiculo != null)
            {
                if (TipoVehiculo.Disponibilidad)
                {
                    LabelNoLugar.Visible = false;
                    llenarGrilla(TipoVehiculo);
                }
                else 
                { 
                    LabelNoLugar.Visible = true;
                    llenarGrilla(null);
                }
            }
            else
            {
                LabelNoLugar.Visible = false;
            }

        }
    }
}
