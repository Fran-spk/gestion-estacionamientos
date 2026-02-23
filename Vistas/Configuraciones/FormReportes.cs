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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Forms.DataVisualization.Charting;
using Servicios;
using ScottPlot.Colormaps;

namespace Vista
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            var Tickets = ControladoraTicketsDiarios.Instancia.getAllTickets()
                 .Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            var cuotas = ControladoraCuotas.Instancia.getAllCuotas()
                .Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();
            List<TicketBase> todos = Tickets.Cast<TicketBase>()
            .Concat(cuotas.Cast<TicketBase>())
            .ToList();
            var pagos = ControladoraPagos.Instancia.getAllPagos()
               .Where(x => x.FechaHoraPago >= Desde.Value.Date && x.FechaHoraPago.Date <= Hasta.Value.Date).ToList();

            var servicios = ControladoraTiposServicio.Instancia.getAllServiciosConsumidos()
                 .Where(x => x.FechaHoraAsignado >= Desde.Value.Date && x.FechaHoraAsignado.Date <= Hasta.Value.Date).ToList();


            var archivo = generarReporte();
            if (archivo != null)
            {
                var servicio = ReporteEstacionamientoService.Instancia;
                servicio.GenerarReportePdf(archivo.FileName, todos, pagos, servicios);
                MessageBox.Show("Reporte generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var auditoriaTickets = ControladoraTicketsDiarios.Instancia.AllHistorialTicket()
                .Where(x => x.FechaHora.Date >= Desde.Value.Date && x.FechaHora.Date <= Hasta.Value.Date).ToList();
            var auditoriaSesiones = ControladoraSesiones.Instancia.AllHistorialSesiones()
                .Where(x => x.FechaHoraLogin.Date >= Desde.Value.Date && x.FechaHoraLogin.Date <= Hasta.Value.Date).ToList();

            var archivo = generarReporte();
            if (archivo != null)
            {
                var servicio = ReporteAuditoriasService.Instancia;
                servicio.GenerarReporteAuditoriasPdf(archivo.FileName, auditoriaTickets, auditoriaSesiones);
                MessageBox.Show("Reporte generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        SaveFileDialog? generarReporte()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar reporte como PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog;
            }
            return null;

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            if(!PermisoService.TienePermiso("Ver reportes"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }
    }
}


