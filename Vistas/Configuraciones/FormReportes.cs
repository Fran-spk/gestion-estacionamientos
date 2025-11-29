
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
            var Tickets = ControladoraTicketsBase.Instancia.getAllTickets()
                .Where(x => x.FechaHoraEmision.Date >= Desde.Value.Date && x.FechaHoraEmision.Date <= Hasta.Value.Date).ToList();

            var pagos = ControladoraPagos.Instancia.getAllPagos()
               .Where(x => x.FechaHoraPago >= Desde.Value.Date && x.FechaHoraPago.Date <= Hasta.Value.Date).ToList();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar reporte como PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var servicio = ReporteEstacionamientoService.Instancia;
                servicio.GenerarReportePdf(saveFileDialog.FileName, Tickets, pagos);
                MessageBox.Show("Reporte generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


