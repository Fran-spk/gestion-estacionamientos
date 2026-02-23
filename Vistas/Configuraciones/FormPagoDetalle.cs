using MODELO;
using Controladora;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using MODELO.seguridad;
using Modelo_Ids;
using Servicios;

namespace Vista
{
    public partial class FormPagoDetalle : Form
    {
   
        private readonly PrintDocument _pd = new PrintDocument();
        private readonly PrintPreviewDialog _ppd = new PrintPreviewDialog();
        private readonly ReciboService _reciboService = new ReciboService();
        private readonly Pago _pago;
        private int _longPaper;


        private const int MargenIzq = 15;
        private const int AnchoRecibo = 300;

        private static readonly Font FontTitulo = new Font("Arial", 12, FontStyle.Bold);
        private static readonly Font FontSubtitulo = new Font("Arial", 9, FontStyle.Bold);
        private static readonly Font FontNormal = new Font("Arial", 8);
        private static readonly Font FontPequeño = new Font("Arial", 7);

      
        public FormPagoDetalle(Pago pago)
        {
            InitializeComponent();
            _pago = pago;
            CalcularLongitudPapel();
            _pd.BeginPrint += PD_BeginPrint;
            _pd.PrintPage += PD_PrintPage;
            _ppd.Document = _pd;
            _ppd.ShowDialog();
            LlenarDatos();
        }

        // ─── Inicialización del form ─────────────────────────────────────
        void CalcularLongitudPapel()
        {
            string recibo = _reciboService.GenerarRecibo(_pago);
            int cantLineas = recibo.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;

            // 15px por línea + margen generoso para encabezado y pie
            _longPaper = (cantLineas * 15) + 120;
        }

        void LlenarDatos()
        {
            Txtpatente.Text = _pago.Patente;
            TxtDescuento.Text = _pago.MontoDescuento.ToString("N2");
            TxtMontoFinal.Text = _pago.MontoTotal.ToString("N2");
            TxtFecha.Text = _pago.FechaHoraPago.ToShortTimeString();
            lbMetodo.Text = _pago.MetodoDePago?.ToString() ?? "No especificado";
            labelSelectorPago.Text = $"💳 Nro de pago {_pago.PagoId}";

            var montoBase = _pago.Detalles.Where(d => d.Ticket != null).Sum(d => d.Monto);
            TxtMonto.Text = montoBase.ToString("N2");

            var ticketDiario = _pago.Detalles.Select(d => d.Ticket).OfType<Ticket_Diario>().FirstOrDefault();
            TxtEstadia.Text = ticketDiario?.Estadia.ToString() ?? "Sin estadía";

            CargarServiciosAdicionales();
        }

        void CargarServiciosAdicionales()
        {
            flowLayoutServicios.Controls.Clear();

            var servicios = _pago.Detalles
                .Where(d => d.ServicioConsumido != null)
                .Select(d => d.ServicioConsumido!)
                .ToList();

            if (!servicios.Any())
            {
                flowLayoutServicios.Controls.Add(new Label
                {
                    Text = "Sin servicios adicionales",
                    ForeColor = Color.FromArgb(150, 150, 150),
                    Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                    AutoSize = true,
                    Padding = new Padding(5, 2, 5, 2)
                });
                return;
            }

            foreach (var servicio in servicios)
            {
                var panel = new Panel
                {
                    Width = 310,
                    Height = 25,
                    Margin = new Padding(1),
                    BackColor = Color.FromArgb(45, 45, 48)
                };

                string descripcion =
                    servicio.TarifaServicio.ServicioVehiculo.Servicio.Descripcion +
                    " para " +
                    servicio.TarifaServicio.ServicioVehiculo.Vehiculo.NombreVehiculo;

                var lblNombre = new Label
                {
                    Text = descripcion,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 8F),
                    AutoSize = true,
                    Location = new Point(5, 2)
                };
                panel.Controls.Add(lblNombre);

                Label lblEstado;
                if (servicio.Anulado)
                    lblEstado = new Label { Text = "ANULADO", ForeColor = Color.FromArgb(220, 53, 69), Font = new Font("Segoe UI", 8F, FontStyle.Bold) };
                else if (servicio.Pagado)
                    lblEstado = new Label { Text = $"${servicio.TarifaServicio.Precio:N2}", ForeColor = Color.FromArgb(76, 175, 80), Font = new Font("Segoe UI", 8F, FontStyle.Bold) };
                else
                    lblEstado = new Label { Text = "PENDIENTE", ForeColor = Color.FromArgb(255, 193, 7), Font = new Font("Segoe UI", 8F, FontStyle.Italic) };

                lblEstado.AutoSize = true;
                lblEstado.Location = new Point(lblNombre.Right + 8, 2);
                panel.Controls.Add(lblEstado);
                flowLayoutServicios.Controls.Add(panel);
            }
        }

        // ─── Impresión ───────────────────────────────────────────────────
        void PD_BeginPrint(object sender, PrintEventArgs e)
        {
            _pd.DefaultPageSettings = new PageSettings
            {
                PaperSize = new PaperSize("Custom", 330, _longPaper) 
            };
        }

        void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            string recibo = _reciboService.GenerarRecibo(_pago);
            Graphics g = e.Graphics;

            using var penLinea = new Pen(Color.Black, 1);
            using var penLineaPunteada = new Pen(Color.Gray, 1);
            penLineaPunteada.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            int y = 15;

            // Encabezado fijo del ticket físico
            DibujarCentrado(g, "ESTACIONAMIENTO", FontTitulo, Brushes.Black, ref y, 18);
            DibujarCentrado(g, "Sistema de Gestión", FontPequeño, Brushes.DarkGray, ref y, 15);
            g.DrawLine(penLinea, MargenIzq, y, MargenIzq + AnchoRecibo, y);
            y += 12;

            foreach (var linea in recibo.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
                RenderizarLinea(g, linea, penLinea, penLineaPunteada, ref y);

            // Pie
            y += 8;
            g.DrawLine(penLineaPunteada, MargenIzq, y, MargenIzq + AnchoRecibo, y);
            y += 12;
            DibujarCentrado(g, "¡Gracias por su visita!", FontPequeño, Brushes.DarkGray, ref y, 12);
            DibujarCentrado(g, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), FontPequeño, Brushes.DarkGray, ref y, 0);
        }

        // ─── Renderizado de cada línea del recibo ────────────────────────
        void RenderizarLinea(Graphics g, string linea, Pen penLinea, Pen penPunteada, ref int y)
        {
            if (string.IsNullOrWhiteSpace(linea))
            {
                y += 3;
                g.DrawLine(penPunteada, MargenIzq, y, MargenIzq + AnchoRecibo, y);
                y += 6;
                return;
            }

            if (linea.Contains("--------------------------------"))
            {
                y += 2;
                g.DrawLine(penPunteada, MargenIzq, y, MargenIzq + AnchoRecibo, y);
                y += 6;
                return;
            }

            if (linea.Contains("TOTAL PAGADO"))
            {
                y += 3;
                g.DrawLine(penLinea, MargenIzq, y, MargenIzq + AnchoRecibo, y);
                y += 8;
                g.DrawString(linea, FontSubtitulo, Brushes.Black, new PointF(MargenIzq, y));
                y += 18;
                g.DrawLine(penLinea, MargenIzq, y, MargenIzq + AnchoRecibo, y);
                y += 3;
                return;
            }

            if (linea.Contains("*") || EsLineaCentrada(linea))
            {
                var fuente = linea.Contains("*") ? FontSubtitulo : FontPequeño;
                DibujarCentrado(g, linea, fuente,
                    linea.Contains("*") ? Brushes.Black : Brushes.DarkGray,
                    ref y, linea.Contains("*") ? 18 : 15);
                return;
            }

            if (EsEncabezadoSeccion(linea))
            {
                g.DrawString(linea, FontSubtitulo, Brushes.Black, new PointF(MargenIzq, y));
                y += 16;
                return;
            }

            if (linea.Contains(":"))
            {
                RenderizarLineaClave(g, linea, ref y);
                return;
            }

            // Línea genérica
            g.DrawString(linea, FontNormal, Brushes.Black, new PointF(MargenIzq, y));
            y += 15;
        }

        void RenderizarLineaClave(Graphics g, string linea, ref int y)
        {
            var partes = linea.Split(new[] { ':' }, 2);

            // Sin valor a la derecha → encabezado de sección ("Servicios Adicionales:")
            if (partes.Length < 2 || string.IsNullOrWhiteSpace(partes[1]))
            {
                g.DrawString(linea, FontSubtitulo, Brushes.Black, new PointF(MargenIzq, y));
                y += 16;
                return;
            }

            string clave = partes[0].Trim();
            string valor = partes[1].Trim();
            bool esDetalle = linea.StartsWith("  "); // indentada = línea de detalle

            Font fuente = esDetalle ? FontPequeño : FontNormal;
            float xClave = esDetalle ? MargenIzq + 15 : MargenIzq;

            g.DrawString(clave + ":", fuente, Brushes.DarkGray, new PointF(xClave, y));

            SizeF tamValor = g.MeasureString(valor, fuente);
            float xValor = MargenIzq + AnchoRecibo - tamValor.Width;
            g.DrawString(valor, fuente, Brushes.Black, new PointF(xValor, y));

            y += 15;
        }

        void DibujarCentrado(Graphics g, string texto, Font fuente, Brush brush, ref int y, int espaciadoPost)
        {
            SizeF tam = g.MeasureString(texto, fuente);
            float x = MargenIzq + (AnchoRecibo - tam.Width) / 2;
            g.DrawString(texto, fuente, brush, new PointF(x, y));
            y += espaciadoPost;
        }

        bool EsEncabezadoSeccion(string linea)
        {
            string[] encabezados =
            {
                "Detalle", "Forma", "Datos del", "Servicios", "Plan Mensual",
                "Cuota", "Ticket Nro", "Hora llegada", "Estadía", "Patente"
            };
            return encabezados.Any(e => linea.TrimStart().StartsWith(e));
        }

        bool EsLineaCentrada(string linea) =>
            linea.StartsWith("Software") ||
            linea.StartsWith("Calle") ||
            linea.Contains("Gracias");


        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            _ppd.Document = _pd;
            _ppd.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e) => Close();
    }
}