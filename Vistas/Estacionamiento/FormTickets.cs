
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
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Gestionar Tickets");
            if (Accion == null)
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
            var Tickets = ControladoraTicketsBase.Instancia.getAllTickets().Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            var T = Tickets.Where(x => x.Estadia.GetType() == comboBox1.SelectedItem.GetType()).ToList();
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
            var Tickets = ControladoraTicketsBase.Instancia.getAllTickets().Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Tickets;
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
                if (ticket is Ticket)
                {
                    var estado = ControladoraTicketsBase.Instancia.getAllEstados().FirstOrDefault(x => x.Nombre == "Cancelado") ?? new Estado_Ticket();
                    var ok = ControladoraTicketsBase.Instancia.AnularTicket(ticket, estado);
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
    }
}

