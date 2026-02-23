
using MODELO;
using Controladora;
using MODELO.seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Vista.Configuraciones;
using Servicios;


namespace Vista
{
    public partial class FormTickets : Form
    {
        public FormTickets()
        {
            InitializeComponent();
            LlenarCombo();
            ActualizoGrilla();
            this.Load += FormVehiculo_Load;
        }


        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar Tickets"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }

        void LlenarCombo()
        {
            List<object> estadias = new List<object>
            {
                new Estadia_Dia(),
                new Estadia_Media_Hora(),
                new Estadia_Mensual(),
                new Estadia_Vencida(),
                new Estadia_Hora()
        };

            comboBox1.DataSource = estadias;
            checkBox1.Checked = true;

        }

        void ActualizoGrillaFiltro()
        {
            ControladoraTicketsDiarios.Instancia.ActualizarTicketsVencidos();
            var Tickets = ControladoraTicketsDiarios.Instancia.getAllTickets()
                 .Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            var cuotas = ControladoraCuotas.Instancia.getAllCuotas()
                .Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            List<TicketBase> todos = Tickets.Cast<TicketBase>()
            .Concat(cuotas.Cast<TicketBase>())
            .ToList();
            var T = todos.Where(x => x.Estadia.GetType() == comboBox1.SelectedItem.GetType()).ToList();
            if (checkBox1.Checked || checkBoxAnulados.Checked)
            {
                T = T.Where(x =>
                    (checkBox1.Checked && x.Estado.Nombre == "Pagado") ||
                    (checkBoxAnulados.Checked && x.Estado.Nombre == "Cancelado")
                ).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = T;
        }




        void ActualizoGrilla()
        {
            ControladoraTicketsDiarios.Instancia.ActualizarTicketsVencidos();
            var Tickets = ControladoraTicketsDiarios.Instancia.getAllTickets()
                .Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            var cuotas = ControladoraCuotas.Instancia.getAllCuotas()
                .Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            List<TicketBase> todos = Tickets.Cast<TicketBase>()
            .Concat(cuotas.Cast<TicketBase>())
            .ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = todos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var ticket = (TicketBase)dataGridView1.CurrentRow.DataBoundItem;
                if (ticket is Ticket_Diario ticketDiario)
                {
                    var estado = ControladoraCuotas.Instancia.getAllEstados().FirstOrDefault(x => x.Nombre == "Cancelado") ?? new Estado_Ticket();
                    var ok = ControladoraTicketsDiarios.Instancia.AnularTicket(ticketDiario, estado, Sesion.Instancia.Perfil.PER_ID);
                    MessageBox.Show(ok);
                    ActualizoGrilla();
                }
                else
                {
                    MessageBox.Show("Las cuotas no se pueden anular");
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un ticket");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizoGrilla();
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var ticket = (TicketBase)dataGridView1.CurrentRow.DataBoundItem;
                var pago = ControladoraPagos.Instancia.getPagoByTicket(ticket.TicketBaseId);
                if (pago != null)
                {
                    var form = new FormPagoDetalle(pago);
                    form.ShowDialog();
                    ActualizoGrilla();
                }
                else
                {
                    MessageBox.Show("Este ticket aún no está pagado");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizoGrillaFiltro();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un ticket.");
                return;
            }

            var ticket = dataGridView1.CurrentRow.DataBoundItem as TicketBase;

            if (ticket == null)
            {
                MessageBox.Show("No se pudo obtener el ticket seleccionado.");
                return;
            }

            if (ticket is Ticket_Diario t)
            {
                var form = new FormTrazabilidadTicket(t);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un ticket diario.");
            }
        }
    }
}

