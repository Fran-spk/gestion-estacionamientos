using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ScottPlot;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MODELO;
using MODELO.seguridad;

namespace Servicios
{
    public class ReporteEstacionamientoService
    {
        private static ReporteEstacionamientoService instancia;
        private ReporteEstacionamientoService() { }
        public static ReporteEstacionamientoService Instancia => instancia ??= new ReporteEstacionamientoService();

        public void GenerarReportePdf(string rutaDestinoPdf, List<TicketBase> tickets, List<Pago> pagos)
        {
            string htmlTabla = GenerarTablaMovimientos(tickets, pagos);
            string rutaImagen = Path.Combine(Path.GetDirectoryName(rutaDestinoPdf), "grafico.png");
            GraficobyTipoVehiculo(tickets, rutaImagen);
            ExportarPdf(htmlTabla, rutaDestinoPdf, rutaImagen);
        }

        private string GenerarTablaMovimientos(List<TicketBase> tickets, List<Pago> pagos)
        {
            var movimientos = new List<(DateTime Fecha, string Tipo, string Patente, string TipoVehiculo, string Monto)>();

            foreach (var ticket in tickets)
            {
                if(ticket is Ticket)
                {
                    movimientos.Add((
                    ticket.FechaHoraEmision,
                    "Entrada",
                    ticket.Patente,
                    ticket.Tarifa.TipoVehiculo.ToString(),
                    "-"
                    ));
                }
                else
                {
                    if (ticket is Cuota cuota)
                    {
                        if (cuota.FechaHoraEmision == cuota.Plan.FechaHoraAlta)
                        {
                            movimientos.Add((
                            ticket.FechaHoraEmision,
                            "Nuevo plan mensual",
                            ticket.Patente,
                            ticket.Tarifa.TipoVehiculo.ToString(),
                            "-"
                            ));
                        }
                    }
                }
            }

            foreach (var pago in pagos)
            {
                if (pago.Ticket != null)
                {
                    var tipo = pago.Ticket is Cuota ? "Cobro ticket mensual" : "Salida";
                    movimientos.Add((
                        pago.FechaHoraPago,
                        tipo,
                        pago.Ticket.Patente,
                        pago.Ticket.Tarifa.TipoVehiculo.ToString(),
                        pago.Monto.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"))
                    ));
                }
            }

            var ordenados = movimientos.OrderBy(m => m.Fecha).ToList();

            decimal total = ordenados
                .Where(m => decimal.TryParse(m.Monto, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-AR"), out _))
                .Sum(m => decimal.Parse(m.Monto, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-AR")));

            var html = "<table border='1' width='100%' cellpadding='5' cellspacing='0'>";
            html += "<tr><th>Tipo</th><th>Fecha/Hora</th><th>Patente</th><th>Tipo Vehículo</th><th>Monto</th></tr>";

            foreach (var m in ordenados)
            {
                html += $"<tr><td>{m.Tipo}</td><td>{m.Fecha:dd/MM/yyyy HH:mm}</td><td>{m.Patente}</td><td>{m.TipoVehiculo}</td><td>{m.Monto}</td></tr>";
            }

            html += $"<tr><td colspan='4' style='text-align:right; font-weight:bold;'>Total</td><td style='font-weight:bold;'>{total.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"))}</td></tr>";
            html += "</table>";
            return html;
        }


        private void GraficobyTipoVehiculo(List<TicketBase> tickets, string rutaImagen)
        {
            var myPlot = new ScottPlot.Plot();

            var ticketsValidos = tickets.Where(t =>
            {
                if (t is Cuota cuota)
                {
                    return cuota.Plan != null && cuota.FechaHoraEmision == cuota.Plan.FechaHoraAlta;
                }
                return true; 
            }).ToList();


            // Agrupar por tipo de vehículo y contar
            var datos = ticketsValidos
                .GroupBy(t => t.Tarifa.TipoVehiculo.ToString())
                .Select(g => new
                {
                    TipoVehiculo = g.Key,
                    Cantidad = g.Count()
                })
                .ToList();

            if (!datos.Any())
                return;

            double[] valores = datos.Select(d => (double)d.Cantidad).ToArray();
            var pie = myPlot.Add.Pie(valores);
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 1.2;

            double total = valores.Sum();
            double[] porcentajes = valores.Select(v => v / total * 100).ToArray();

            for (int i = 0; i < pie.Slices.Count; i++)
            {
                pie.Slices[i].Label = $"{datos[i].TipoVehiculo} ({porcentajes[i]:0.0}%)";
                pie.Slices[i].LabelFontSize = 16;
                pie.Slices[i].LabelBold = true;
                pie.Slices[i].LabelFontColor = Colors.Black.WithAlpha(.9);
            }

            myPlot.Axes.Frameless();
            myPlot.HideGrid();
            myPlot.SavePng(rutaImagen, width: 500, height: 300);
        }



        private void ExportarPdf(string htmlContenido, string rutaPdf, string rutaImagen)
        {
            try
            {
                using var fs = new FileStream(rutaPdf, FileMode.Create);
                using var doc = new Document(PageSize.A4, 25, 25, 30, 30);
                var writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Cabecera del informe
                doc.Add(new Paragraph("Informe de Movimientos"));
                doc.Add(new Paragraph("Generado por Sistema de Gestión"));
                doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}"));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Reporte generado por:  "+ Sesion.Instancia.Perfil.PER_NOMBRE));
                // Tabla de movimientos (HTML)
                using (var sr = new StringReader(htmlContenido))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, sr);
                }

                doc.Add(new Paragraph("\n"));

                // Crear contenedor con borde para el gráfico
                PdfPTable tablaGrafico = new PdfPTable(1);
                tablaGrafico.WidthPercentage = 100;

                var celdaTitulo = new PdfPCell(new Phrase("Distribución de ingresos por tipo de vehículo"))
                {
                    Border = Rectangle.BOX,
                    Padding = 5,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                tablaGrafico.AddCell(celdaTitulo);

                if (File.Exists(rutaImagen))
                {
                    var img = iTextSharp.text.Image.GetInstance(rutaImagen);
                    img.ScaleToFit(500f, 400f);
                    img.Alignment = Element.ALIGN_CENTER;

                    var celdaImagen = new PdfPCell(img, fit: true)
                    {
                        Border = Rectangle.BOX,
                        Padding = 10,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };

                    tablaGrafico.AddCell(celdaImagen);
                    File.Delete(rutaImagen); // Limpieza
                }

                doc.Add(tablaGrafico);
                doc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al exportar PDF: {ex.Message}");
            }
        }

    }
}
