using MODELO;
using Controladora;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using MODELO.seguridad;

namespace Vista
{
    public partial class FormPagoDetalle : Form
    {
        PrintDocument pd = new PrintDocument(); 
        PrintPreviewDialog ppd = new PrintPreviewDialog();
        int longpaper;
        Pago Pago;
        public FormPagoDetalle(Pago pago)
        {
            InitializeComponent();
            LlenarDatos(pago);
            Pago = pago;          
            changelongerpaper();
        }

        public FormPagoDetalle(Pago pago, String Salida)
        {
            InitializeComponent();
            if (!ValidarPermisoImprimir())
            {
                this.Close();
                return;
            }
            Pago = pago;
            changelongerpaper();
            ppd.Document = pd;
            ppd.ShowDialog();
        }
        private bool ValidarPermisoImprimir()
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Imprimir tickets");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                return false;
            }
            return true;
        }

       

        void changelongerpaper()
        {
            pd.BeginPrint += new PrintEventHandler(PD_BeginPrint);
            pd.PrintPage += new PrintPageEventHandler(PD_PrintPage);
            if (Pago.Ticket is Cuota)
            {
                longpaper = 15 * 17 + 230;
            }
            else
            {
                longpaper = 15 * 12 + 230;
            }
                
        }

        void LlenarDatos(Pago pago)
        {
            Txtpatente.Text = pago.Ticket.Patente.ToString();
            TxtEstadia.Text = pago.Ticket.Estadia.ToString();
            TxtMonto.Text = pago.Monto.ToString();
            TxtDescuento.Text = pago.MontoDescuento.ToString();
            TxtMontoFinal.Text = pago.MontoFinal.ToString();
            TxtFecha.Text = pago.FechaHoraPago.ToString();
            lbMetodo.Text = pago.MetodoDePago != null ? pago.MetodoDePago.ToString() : "No especificado";
            Txtticket.Text = Txtticket.Text + pago.Ticket.Codigo.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void PD_BeginPrint(object sender, PrintEventArgs e) //valores del papel
        {
            PageSettings page = new PageSettings();
            page.PaperSize = new PaperSize("Custom", 250, longpaper);
            pd.DefaultPageSettings = page;
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e) //lo que va a hacer nuestro recibo, fuentes, formato y tamaño
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10); 
            Brush brush = Brushes.Black;
            int y = 20;

            string recibo = Pago.GenerarRecibo();
            string[] lineas = recibo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string linea in lineas)
            {
                g.DrawString(linea, font, brush, new PointF(10, y));
                y += 20;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if(ValidarPermisoImprimir())
            {
                ppd.Document = pd;
                ppd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Necesita permisos");
            }
        }

    }
}
