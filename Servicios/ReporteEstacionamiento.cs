using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ScottPlot;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MODELO;
using MODELO.seguridad;
using Modelo_Ids;

namespace Servicios
{
    public class ReporteEstacionamientoService
    {

        private static readonly BaseColor ColorPrimario = new BaseColor(20, 60, 100);  // Azul marino
        private static readonly BaseColor ColorSecundario = new BaseColor(41, 128, 185);  // Azul medio
        private static readonly BaseColor ColorAcento = new BaseColor(26, 188, 156);  // Verde agua
        private static readonly BaseColor ColorHeaderTabla = new BaseColor(52, 73, 94);  // Gris oscuro
        private static readonly BaseColor ColorFilaPar = new BaseColor(236, 240, 241); // Gris claro
        private static readonly BaseColor ColorFilaImpar = BaseColor.WHITE;
        private static readonly BaseColor ColorTotal = new BaseColor(230, 246, 234); // Verde suave
        private static readonly BaseColor ColorTextoClaro = BaseColor.WHITE;
        private static readonly BaseColor ColorTextoOscuro = new BaseColor(44, 62, 80);


        private static readonly Font FuenteTituloPrincipal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, ColorTextoClaro);
        private static readonly Font FuenteSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA, 11, ColorTextoClaro);
        private static readonly Font FuenteSeccionTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13, ColorPrimario);
        private static readonly Font FuenteHeaderTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, ColorTextoClaro);
        private static readonly Font FuenteCeldaNormal = FontFactory.GetFont(FontFactory.HELVETICA, 9, ColorTextoOscuro);
        private static readonly Font FuenteCeldaNegrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, ColorTextoOscuro);
        private static readonly Font FuenteTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, ColorTextoOscuro);
        private static readonly Font FuentePiePagina = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.GRAY);

        private static readonly CultureInfo CulturaAR = CultureInfo.CreateSpecificCulture("es-AR");


        private static ReporteEstacionamientoService _instancia;
        private ReporteEstacionamientoService() { }
        public static ReporteEstacionamientoService Instancia =>
            _instancia ??= new ReporteEstacionamientoService();



        public void GenerarReportePdf(string rutaDestinoPdf, List<TicketBase> tickets, List<Pago> pagos, List<ServicioConsumido>servicios)
        {
            string carpeta = Path.GetDirectoryName(rutaDestinoPdf)!;
            string rutaGrafVehiculos = Path.Combine(carpeta, "_tmp_grafico_vehiculos.png");
            string rutaGrafServicios = Path.Combine(carpeta, "_tmp_grafico_servicios.png");

            GraficoByTipoVehiculo(tickets, rutaGrafVehiculos);
            GraficoServiciosMasUtilizados(tickets, rutaGrafServicios);

            ExportarPdf(rutaDestinoPdf, tickets, pagos, servicios, rutaGrafVehiculos, rutaGrafServicios);
        }



        private void ExportarPdf(
            string rutaPdf,
            List<TicketBase> tickets,
            List<Pago> pagos,
            List<ServicioConsumido> servicios,
            string graficoVehiculos,
            string graficoServicios)
        {
            using var fs = new FileStream(rutaPdf, FileMode.Create);
            using var doc = new Document(PageSize.A4, 40, 40, 50, 50);
            var writer = PdfWriter.GetInstance(doc, fs);

            // Evento para encabezado/pie en cada página
            writer.PageEvent = new PaginaEventHandler();

            doc.Open();
            doc.AddTitle("Informe de Estacionamiento");
            doc.AddCreator("Sistema de Gestión de Estacionamiento");

            AgregarEncabezado(doc);
            AgregarResumenEjecutivo(doc, tickets, pagos);
            doc.Add(Separador());

            AgregarSeccion(doc, "📋  Movimientos del Sistema", BuildTablaMovimientos(tickets, pagos));
            doc.Add(Separador());

            AgregarSeccion(doc, "🔧  Servicios Más Utilizados", BuildTablaServiciosMasUtilizados(servicios));
            AgregarSeccion(doc, "❌  Servicios Anulados", BuildTablaServiciosAnulados(servicios));
            doc.Add(Separador());

            AgregarGraficos(doc, graficoVehiculos, graficoServicios);

            doc.Close();
        }


        private void AgregarEncabezado(Document doc)
        {
            // Banda de color principal
            var tablaBanda = new PdfPTable(1) { WidthPercentage = 100 };

            var celdaBanda = new PdfPCell
            {
                BackgroundColor = ColorPrimario,
                Border = Rectangle.NO_BORDER,
                Padding = 20,
                PaddingLeft = 30
            };

            celdaBanda.AddElement(new Paragraph("INFORME DE ESTACIONAMIENTO", FuenteTituloPrincipal)
            { SpacingAfter = 4 });
            celdaBanda.AddElement(new Paragraph(
                $"Generado el {DateTime.Now:dddd, dd \\de MMMM \\de yyyy}  •  Usuario: {Sesion.Instancia.Perfil.PER_NOMBRE}",
                FuenteSubtitulo));

            tablaBanda.AddCell(celdaBanda);
            doc.Add(tablaBanda);
            doc.Add(new Paragraph(" ") { SpacingAfter = 8 });
        }

        private void AgregarResumenEjecutivo(Document doc, List<TicketBase> tickets, List<Pago> pagos)
        {
            int totalVehiculos = tickets.OfType<Ticket_Diario>().Count();

            int totalPlanes = tickets.OfType<Cuota>()
                .Count(c => c.Plan != null && c.FechaHoraEmision == c.Plan.FechaHoraAlta);

            int totalServicios = pagos
                .SelectMany(p => p.Detalles)
                .Count(d => d.ServicioConsumido != null && !d.ServicioConsumido.Anulado);

            // Total recaudado: suma de detalles que corresponden a tickets (estacionamiento)
            decimal totalRecaudado = pagos
                .SelectMany(p => p.Detalles)
                .Where(d => d.Ticket != null)
                .Sum(d => d.Monto);

            var tabla = new PdfPTable(4) { WidthPercentage = 100, SpacingBefore = 10 };
            tabla.SetWidths(new float[] { 1, 1, 1, 1 });

            AgregarTarjeta(tabla, "🚗  Vehículos", totalVehiculos.ToString(), ColorSecundario);
            AgregarTarjeta(tabla, "📅  Planes Mensuales", totalPlanes.ToString(), ColorAcento);
            AgregarTarjeta(tabla, "🔧  Servicios", totalServicios.ToString(), ColorPrimario);
            AgregarTarjeta(tabla, "💰  Recaudado", totalRecaudado.ToString("C2", CulturaAR), new BaseColor(192, 57, 43));

            doc.Add(tabla);
        }

        private static void AgregarTarjeta(PdfPTable tabla, string titulo, string valor, BaseColor color)
        {
            var fTitulo = FontFactory.GetFont(FontFactory.HELVETICA, 9, ColorTextoClaro);
            var fValor = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, ColorTextoClaro);

            var celda = new PdfPCell { BackgroundColor = color, Border = Rectangle.NO_BORDER, Padding = 12 };
            celda.AddElement(new Paragraph(titulo, fTitulo) { SpacingAfter = 3 });
            celda.AddElement(new Paragraph(valor, fValor));
            tabla.AddCell(celda);
        }


        private void AgregarSeccion(Document doc, string titulo, PdfPTable tabla)
        {
            doc.Add(new Paragraph(titulo, FuenteSeccionTitulo)
            { SpacingBefore = 16, SpacingAfter = 6 });
            doc.Add(tabla);
        }

        private static PdfPTable Separador()
        {
            var t = new PdfPTable(1) { WidthPercentage = 100, SpacingBefore = 8, SpacingAfter = 4 };
            t.AddCell(new PdfPCell
            {
                BackgroundColor = ColorSecundario,
                Border = Rectangle.NO_BORDER,
                FixedHeight = 2
            });
            return t;
        }



        private PdfPTable BuildTablaMovimientos(List<TicketBase> tickets, List<Pago> pagos)
        {
            var movimientos = new List<(DateTime Fecha, string Tipo, string Patente, string TipoVehiculo, decimal? Monto)>();

            foreach (var ticket in tickets)
            {
                if (ticket is Ticket_Diario)
                    movimientos.Add((ticket.FechaHoraEmision, "Entrada",
                        ticket.Patente, ticket.TarifaEstacionamiento.TipoVehiculo.ToString(), null));

                else if (ticket is Cuota cuota && cuota.Plan != null && cuota.FechaHoraEmision == cuota.Plan.FechaHoraAlta)
                    movimientos.Add((ticket.FechaHoraEmision, "Nuevo plan mensual",
                        ticket.Patente, ticket.TarifaEstacionamiento.TipoVehiculo.ToString(), null));
            }

            foreach (var pago in pagos)
            {
                // Buscar si el pago tiene algún detalle con ticket para determinar tipo y patente
                var detalleTicket = pago.Detalles.FirstOrDefault(d => d.Ticket != null);

                if (detalleTicket == null) continue; // pago solo de servicios, no va en movimientos de entrada/salida

                string tipo = detalleTicket.Ticket is Cuota ? "Cobro ticket mensual" : "Salida";

                // Monto de estacionamiento: suma de detalles con ticket
                decimal montoEstacionamiento = pago.Detalles
                    .Where(d => d.Ticket != null)
                    .Sum(d => d.Monto);

                movimientos.Add((
                    pago.FechaHoraPago,
                    tipo,
                    detalleTicket.Ticket!.Patente,
                    detalleTicket.Ticket.TarifaEstacionamiento.TipoVehiculo.ToString(),
                    montoEstacionamiento
                ));
            }

            var ordenados = movimientos.OrderBy(m => m.Fecha).ToList();
            decimal total = ordenados.Where(m => m.Monto.HasValue).Sum(m => m.Monto!.Value);

            // ... resto igual que antes
            var tabla = new PdfPTable(5) { WidthPercentage = 100 };
            tabla.SetWidths(new float[] { 3f, 2.8f, 2f, 2.5f, 2.2f });

            string[] headers = { "Tipo de Movimiento", "Fecha / Hora", "Patente", "Tipo Vehículo", "Monto" };
            foreach (var h in headers)
                tabla.AddCell(HeaderCell(h));

            for (int i = 0; i < ordenados.Count; i++)
            {
                var m = ordenados[i];
                var bg = i % 2 == 0 ? ColorFilaImpar : ColorFilaPar;

                var (icon, tColor) = m.Tipo switch
                {
                    "Entrada" => ("↓ ", ColorAcento),
                    "Salida" => ("↑ ", new BaseColor(192, 57, 43)),
                    "Nuevo plan mensual" => ("★ ", ColorSecundario),
                    _ => ("● ", ColorPrimario)
                };

                var fTipo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, tColor);
                tabla.AddCell(DataCellCustom(new Paragraph(icon + m.Tipo, fTipo), bg, Element.ALIGN_LEFT));
                tabla.AddCell(DataCell(m.Fecha.ToString("dd/MM/yyyy HH:mm"), bg));
                tabla.AddCell(DataCell(m.Patente, bg));
                tabla.AddCell(DataCell(m.TipoVehiculo, bg));
                tabla.AddCell(DataCell(m.Monto.HasValue ? m.Monto.Value.ToString("C2", CulturaAR) : "—", bg, Element.ALIGN_RIGHT));
            }

            tabla.AddCell(new PdfPCell(new Phrase("", FuenteTotal))
            { Colspan = 3, Border = Rectangle.NO_BORDER, BackgroundColor = ColorTotal });
            tabla.AddCell(new PdfPCell(new Phrase("Total recaudado", FuenteTotal))
            { Border = Rectangle.NO_BORDER, BackgroundColor = ColorTotal, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 7 });
            tabla.AddCell(new PdfPCell(new Phrase(total.ToString("C2", CulturaAR), FuenteTotal))
            { Border = Rectangle.NO_BORDER, BackgroundColor = ColorTotal, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 7 });

            return tabla;
        }

        private PdfPTable BuildTablaServiciosMasUtilizados(List<ServicioConsumido> serviciosConsumidos)
        {
            var servicios = serviciosConsumidos
                .Where(s => !s.Anulado)
                .GroupBy(s => s.TarifaServicio.ServicioVehiculo.Servicio.Descripcion)
                .Select(g => new { Servicio = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            var tabla = new PdfPTable(3) { WidthPercentage = 100 };
            tabla.SetWidths(new float[] { 5f, 2f, 2f });

            string[] headers = { "Servicio", "Cantidad", "Participación" };
            foreach (var h in headers) tabla.AddCell(HeaderCell(h));

            if (!servicios.Any())
            {
                tabla.AddCell(new PdfPCell(new Phrase("Sin registros", FuenteCeldaNormal))
                { Colspan = 3, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 10 });
                return tabla;
            }

            int totalCount = servicios.Sum(s => s.Cantidad);
            for (int i = 0; i < servicios.Count; i++)
            {
                var s = servicios[i];
                var bg = i % 2 == 0 ? ColorFilaImpar : ColorFilaPar;
                decimal pct = (decimal)s.Cantidad / totalCount * 100;

                tabla.AddCell(DataCell(s.Servicio, bg));
                tabla.AddCell(DataCell(s.Cantidad.ToString(), bg, Element.ALIGN_CENTER));
                tabla.AddCell(DataCell($"{pct:0.0}%", bg, Element.ALIGN_CENTER));
            }

            return tabla;
        }

        private PdfPTable BuildTablaServiciosAnulados(List<ServicioConsumido> servicios)
        {
            var anulados = servicios
                .Where(s => s.Anulado)
                .OrderByDescending(s => s.FechaHoraAsignado)
                .ToList();

            var tabla = new PdfPTable(2) { WidthPercentage = 100 };
            tabla.SetWidths(new float[] { 5f, 3f });

            string[] headers = { "Servicio Anulado", "Fecha / Hora" };
            foreach (var h in headers) tabla.AddCell(HeaderCell(h));

            if (!anulados.Any())
            {
                tabla.AddCell(new PdfPCell(new Phrase("Sin registros", FuenteCeldaNormal))
                { Colspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 10 });
                return tabla;
            }

            for (int i = 0; i < anulados.Count; i++)
            {
                var s = anulados[i];
                var bg = i % 2 == 0 ? ColorFilaImpar : ColorFilaPar;
                var fAnulado = FontFactory.GetFont(FontFactory.HELVETICA, 9, new BaseColor(192, 57, 43));

                tabla.AddCell(DataCellCustom(new Paragraph(s.TarifaServicio.ServicioVehiculo.Servicio.Descripcion, fAnulado), bg, Element.ALIGN_LEFT));
                tabla.AddCell(DataCell(s.FechaHoraAsignado.ToString("dd/MM/yyyy HH:mm"), bg));
            }

            return tabla;
        }


        private void GraficoByTipoVehiculo(List<TicketBase> tickets, string rutaImagen)
        {
            var datos = tickets
                .GroupBy(t => t.TarifaEstacionamiento.TipoVehiculo.ToString())
                .Select(g => new { Tipo = g.Key, Cantidad = g.Count() })
                .ToList();

            if (!datos.Any()) return;

            var plot = new ScottPlot.Plot();
            var valores = datos.Select(d => (double)d.Cantidad).ToArray();
            var pie = plot.Add.Pie(valores);

            pie.ExplodeFraction = 0.08;
            pie.SliceLabelDistance = 1.25;

            double total = valores.Sum();
            for (int i = 0; i < pie.Slices.Count; i++)
                pie.Slices[i].Label = $"{datos[i].Tipo}\n{valores[i] / total * 100:0.0}%";

            plot.Title("Distribución por Tipo de Vehículo");
            plot.Axes.Frameless();
            plot.HideGrid();
            plot.SavePng(rutaImagen, 540, 320);
        }

        private void GraficoServiciosMasUtilizados(List<TicketBase> tickets, string rutaImagen)
        {
            // Ahora los servicios vienen por parámetro desde pagos, 
            // pero el método recibe tickets así que lo mantenemos consistente
            var servicios = tickets
                .OfType<Ticket_Diario>()
                .SelectMany(t => t.ServiciosConsumidos)
                .Where(s => !s.Anulado)
                .GroupBy(s => s.TarifaServicio.ServicioVehiculo.Servicio.Descripcion)
                .Select(g => new { Servicio = g.Key, Cantidad = g.Count() })
                .ToList();

            if (!servicios.Any()) return;

            var plot = new ScottPlot.Plot();
            var valores = servicios.Select(s => (double)s.Cantidad).ToArray();
            var pie = plot.Add.Pie(valores);

            pie.ExplodeFraction = 0.08;
            pie.SliceLabelDistance = 1.25;

            double total = valores.Sum();
            for (int i = 0; i < pie.Slices.Count; i++)
                pie.Slices[i].Label = $"{servicios[i].Servicio}\n{valores[i] / total * 100:0.0}%";

            plot.Title("Servicios Más Utilizados");
            plot.Axes.Frameless();
            plot.HideGrid();
            plot.SavePng(rutaImagen, 540, 320);
        }
        // ─── Sección de gráficos─────────────────────────────────
        private void AgregarGraficos(Document doc, string graficoVehiculos, string graficoServicios)
        {
            doc.Add(new Paragraph("📊 Analisis Grafico", FuenteSeccionTitulo)
            { SpacingBefore = 16, SpacingAfter = 6 });

            var tablaGraficos = new PdfPTable(2) { WidthPercentage = 100 };
            tablaGraficos.SetWidths(new float[] { 1f, 1f });

            tablaGraficos.AddCell(BuildCeldaGrafico(graficoVehiculos, "Por tipo de vehículo"));
            tablaGraficos.AddCell(BuildCeldaGrafico(graficoServicios, "Servicios utilizados"));

            doc.Add(tablaGraficos);
        }

        private static PdfPCell BuildCeldaGrafico(string rutaImagen, string titulo)
        {
            var fTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.DARK_GRAY);
            var celda = new PdfPCell { Border = Rectangle.NO_BORDER, Padding = 6 };

            celda.AddElement(new Paragraph(titulo, fTitulo) { SpacingAfter = 4 });

            if (File.Exists(rutaImagen))
            {
                var img = iTextSharp.text.Image.GetInstance(rutaImagen);
                img.ScaleToFit(240f, 160f);
                celda.AddElement(img);
                File.Delete(rutaImagen);
            }

            return celda;
        }



        private static PdfPCell HeaderCell(string texto)
        {
            return new PdfPCell(new Phrase(texto.ToUpper(), FuenteHeaderTabla))
            {
                BackgroundColor = ColorHeaderTabla,
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 8,
                PaddingLeft = 10,
                BorderColor = BaseColor.GRAY,
                BorderWidth = 0.5f
            };
        }

        private static PdfPCell DataCell(string texto, BaseColor fondo,
            int alineacion = Element.ALIGN_LEFT)
        {
            return new PdfPCell(new Phrase(texto, FuenteCeldaNormal))
            {
                BackgroundColor = fondo,
                HorizontalAlignment = alineacion,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 7,
                PaddingLeft = 10,
                BorderColor = new BaseColor(200, 200, 200),
                BorderWidth = 0.3f
            };
        }

        private static PdfPCell DataCellCustom(Paragraph contenido, BaseColor fondo,
            int alineacion = Element.ALIGN_LEFT)
        {
            var celda = new PdfPCell
            {
                BackgroundColor = fondo,
                HorizontalAlignment = alineacion,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 7,
                PaddingLeft = 10,
                BorderColor = new BaseColor(200, 200, 200),
                BorderWidth = 0.3f
            };
            celda.AddElement(contenido);
            return celda;
        }
    }


    internal class PaginaEventHandler : PdfPageEventHelper
    {
        private static readonly Font FPie = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.GRAY);

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            var cb = writer.DirectContent;
            var rect = document.PageSize;
            float margenH = 40;


            cb.SetColorStroke(new BaseColor(41, 128, 185));
            cb.SetLineWidth(2f);
            cb.MoveTo(margenH, rect.Height - 12);
            cb.LineTo(rect.Width - margenH, rect.Height - 12);
            cb.Stroke();


            cb.SetColorStroke(new BaseColor(200, 200, 200));
            cb.SetLineWidth(0.5f);
            cb.MoveTo(margenH, 42);
            cb.LineTo(rect.Width - margenH, 42);
            cb.Stroke();


            var pie = new PdfPTable(2) { TotalWidth = rect.Width - margenH * 2 };
            pie.SetWidths(new float[] { 3f, 1f });

            pie.AddCell(new PdfPCell(new Phrase("Sistema de Gestión de Estacionamiento — Informe", FPie))
            { Border = Rectangle.NO_BORDER, VerticalAlignment = Element.ALIGN_MIDDLE });

            pie.AddCell(new PdfPCell(new Phrase($"Pág. {writer.PageNumber}", FPie))
            { Border = Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

            pie.WriteSelectedRows(0, -1, margenH, 38, cb);
        }
    }
}