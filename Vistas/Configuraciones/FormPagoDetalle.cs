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
            TxtMonto.Text = pago.MontoEstacionamiento.ToString();
            TxtDescuento.Text = pago.MontoDescuento.ToString();
            TxtMontoFinal.Text = pago.MontoFinal.ToString();
            TxtFecha.Text = pago.FechaHoraPago.ToShortTimeString();
            lbMetodo.Text = pago.MetodoDePago != null ? pago.MetodoDePago.ToString() : "No especificado";
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

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fuentes mejoradas
            Font fontTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fontSubtitulo = new Font("Arial", 11, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10);
            Font fontPequeño = new Font("Arial", 8);

            // Colores y brochas
            Brush brushNegro = Brushes.Black;
            Brush brushGris = Brushes.DarkGray;
            Pen penLinea = new Pen(Color.Black, 1);
            Pen penLineaPunteada = new Pen(Color.Gray, 1);
            penLineaPunteada.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            int y = 20;
            int margenIzq = 15;
            int anchoRecibo = 220;
            int separacionColumna = 120; // Ajustado para mejor separación

            // Encabezado - Logo/Nombre del estacionamiento
            g.DrawString("ESTACIONAMIENTO", fontTitulo, brushNegro, new PointF(margenIzq + 25, y));
            y += 25;
            g.DrawString("Sistema de Gestión", fontPequeño, brushGris, new PointF(margenIzq + 55, y));
            y += 20;

            // Línea separadora
            g.DrawLine(penLinea, margenIzq, y, margenIzq + anchoRecibo, y);
            y += 15;

            // Información del recibo
            string recibo = Pago.GenerarRecibo();
            string[] lineas = recibo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    // Línea punteada para separadores vacíos
                    y += 5;
                    g.DrawLine(penLineaPunteada, margenIzq, y, margenIzq + anchoRecibo, y);
                    y += 10;
                }
                else if (linea.Contains("TOTAL") || linea.Contains("Total") || linea.Contains("MONTO FINAL"))
                {
                    // Destacar totales
                    y += 5;
                    g.DrawLine(penLinea, margenIzq, y, margenIzq + anchoRecibo, y);
                    y += 10;
                    g.DrawString(linea, fontSubtitulo, brushNegro, new PointF(margenIzq, y));
                    y += 25;
                    g.DrawLine(penLinea, margenIzq, y, margenIzq + anchoRecibo, y);
                    y += 5;
                }
                else if (linea.Contains(":"))
                {
                    // Formato clave: valor con alineación
                    string[] partes = linea.Split(new[] { ':' }, 2);
                    if (partes.Length == 2)
                    {
                        // Dibujar etiqueta (clave)
                        g.DrawString(partes[0] + ":", fontNormal, brushGris, new PointF(margenIzq, y));

                        // Dibujar valor alineado a la derecha del recibo
                        string valor = partes[1].Trim();
                        SizeF tamañoValor = g.MeasureString(valor, fontNormal);
                        float posicionValor = margenIzq + anchoRecibo - tamañoValor.Width;
                        g.DrawString(valor, fontNormal, brushNegro, new PointF(posicionValor, y));
                    }
                    else
                    {
                        g.DrawString(linea, fontNormal, brushNegro, new PointF(margenIzq, y));
                    }
                    y += 22;
                }
                else
                {
                    // Líneas normales centradas o alineadas a la izquierda
                    if (linea.Contains("*") || linea.StartsWith("Software") || linea.StartsWith("Calle"))
                    {
                        // Centrar estas líneas
                        SizeF tamañoLinea = g.MeasureString(linea, fontNormal);
                        float posicionCentro = margenIzq + (anchoRecibo - tamañoLinea.Width) / 2;
                        g.DrawString(linea, fontNormal, brushNegro, new PointF(posicionCentro, y));
                    }
                    else
                    {
                        g.DrawString(linea, fontNormal, brushNegro, new PointF(margenIzq, y));
                    }
                    y += 22;
                }
            }

            // Pie de página
            y += 10;
            g.DrawLine(penLineaPunteada, margenIzq, y, margenIzq + anchoRecibo, y);
            y += 15;

            string mensajeFinal = "¡Gracias por su visita!";
            SizeF tamañoMensaje = g.MeasureString(mensajeFinal, fontPequeño);
            float posicionMensaje = margenIzq + (anchoRecibo - tamañoMensaje.Width) / 2;
            g.DrawString(mensajeFinal, fontPequeño, brushGris, new PointF(posicionMensaje, y));

            y += 15;
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            SizeF tamañoFecha = g.MeasureString(fecha, fontPequeño);
            float posicionFecha = margenIzq + (anchoRecibo - tamañoFecha.Width) / 2;
            g.DrawString(fecha, fontPequeño, brushGris, new PointF(posicionFecha, y));

            // Liberar recursos
            fontTitulo.Dispose();
            fontSubtitulo.Dispose();
            fontNormal.Dispose();
            fontPequeño.Dispose();
            penLinea.Dispose();
            penLineaPunteada.Dispose();
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
