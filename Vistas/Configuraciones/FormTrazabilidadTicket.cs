using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MODELO;
using Servicios;

namespace Vista.Configuraciones
{
    public partial class FormTrazabilidadTicket : Form
    {
        Ticket_Diario Ticket_Diario;
        public FormTrazabilidadTicket(Ticket_Diario ticket)
        {
            InitializeComponent();
            Ticket_Diario = ticket;
            cargarGrilla();
        }
        void cargarGrilla()
        {
            lblAuditoria.Text = lblAuditoria.Text + Ticket_Diario.TicketBaseId + "Patente:" + Ticket_Diario.Patente;
            var auditoria = ControladoraTicketsDiarios.Instancia.ObtenerHistorialTicketById(Ticket_Diario.TicketBaseId);
            dataGridView1.DataSource = auditoria;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTrazabilidadTicket_Load(object sender, EventArgs e)
        {
            if(!PermisoService.TienePermiso("Ver historial de ticket"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close(); 
            }
        }
    }
}
