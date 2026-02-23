using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using MODELO;
using MODELO.seguridad;

namespace Servicios
{
    /// <summary>
    /// Servicio para la generación de reportes de auditoría en formato PDF
    /// </summary>
    public class ReporteAuditoriasService
    {
        #region Singleton

        private static ReporteAuditoriasService _instancia;
        private static readonly object _lock = new object();

        private ReporteAuditoriasService() { }

        public static ReporteAuditoriasService Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_lock)
                    {
                        if (_instancia == null)
                            _instancia = new ReporteAuditoriasService();
                    }
                }
                return _instancia;
            }
        }

        #endregion

        #region Configuración de Colores y Fuentes

        private static class Colores
        {
            // Paleta moderna inspirada en diseño contemporáneo
            public static readonly BaseColor MoradoPrincipal = new BaseColor(102, 51, 153);      // #663399 - Rebeccapurple
            public static readonly BaseColor AzulElectrico = new BaseColor(79, 70, 229);         // #4F46E5 - Indigo
            public static readonly BaseColor CyanVibrante = new BaseColor(6, 182, 212);          // #06B6D4 - Cyan
            public static readonly BaseColor VerdeEsmeralda = new BaseColor(16, 185, 129);       // #10B981 - Emerald
            public static readonly BaseColor AmbarCalido = new BaseColor(245, 158, 11);          // #F59E0B - Amber
            public static readonly BaseColor RojoVino = new BaseColor(220, 38, 38);              // #DC2626 - Red
            public static readonly BaseColor RosaSuave = new BaseColor(244, 114, 182);           // #F472B6 - Pink
            public static readonly BaseColor GrisModerno = new BaseColor(71, 85, 105);           // #475569 - Slate
            public static readonly BaseColor GrisClaro = new BaseColor(248, 250, 252);           // #F8FAFC - Slate 50
            public static readonly BaseColor Blanco = BaseColor.WHITE;
            public static readonly BaseColor Negro = new BaseColor(15, 23, 42);                  // #0F172A - Slate 900

            // Gradientes simulados con opacidad
            public static readonly BaseColor FondoDegradado = new BaseColor(249, 250, 251);     // #F9FAFB
            public static readonly BaseColor AcentoSuave = new BaseColor(238, 242, 255);        // #EEF2FF - Indigo 50
        }

        private static class Fuentes
        {
            public static readonly Font Titulo = FontFactory.GetFont(
                FontFactory.HELVETICA_BOLD, 20, Colores.MoradoPrincipal);

            public static readonly Font Subtitulo = FontFactory.GetFont(
                FontFactory.HELVETICA_BOLD, 15, Colores.AzulElectrico);

            public static readonly Font Seccion = FontFactory.GetFont(
                FontFactory.HELVETICA_BOLD, 12, Colores.GrisModerno);

            public static readonly Font Header = FontFactory.GetFont(
                FontFactory.HELVETICA_BOLD, 9, Colores.Blanco);

            public static readonly Font Normal = FontFactory.GetFont(
                FontFactory.HELVETICA, 8, Colores.Negro);

            public static readonly Font NormalBold = FontFactory.GetFont(
                FontFactory.HELVETICA_BOLD, 8, Colores.GrisModerno);

            public static readonly Font Pequena = FontFactory.GetFont(
                FontFactory.HELVETICA, 7, Colores.Negro);

            public static readonly Font Pie = FontFactory.GetFont(
                FontFactory.HELVETICA, 8, Colores.GrisModerno);
        }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Genera un reporte completo de auditorías de tickets y sesiones
        /// </summary>
        public ResultadoReporte GenerarReporteAuditoriasPdf(
            string rutaDestinoPdf,
            List<AuditoriaTicket> auditoriasTickets,
            List<AuditoriaSesion> auditoriasSesiones,
            FiltrosReporte filtros = null)
        {
            try
            {
                ValidarParametros(rutaDestinoPdf, auditoriasTickets, auditoriasSesiones);

                // Aplicar filtros si existen
                if (filtros != null)
                {
                    auditoriasTickets = AplicarFiltrosTickets(auditoriasTickets, filtros);
                    auditoriasSesiones = AplicarFiltrosSesiones(auditoriasSesiones, filtros);
                }

                using var fs = new FileStream(rutaDestinoPdf, FileMode.Create, FileAccess.Write);
                using var doc = new Document(PageSize.A4.Rotate(), 40, 40, 60, 50);
                var writer = PdfWriter.GetInstance(doc, fs);

                writer.PageEvent = new PaginaEventHandlerAuditorias();

                doc.Open();

                // Portada
                AgregarPortada(doc, filtros);

                // Resumen ejecutivo
                AgregarResumenEjecutivo(doc, auditoriasTickets, auditoriasSesiones);

                // Nueva página para detalles
                doc.NewPage();

                // Auditoría de Tickets
                if (auditoriasTickets?.Any() == true)
                {
                    AgregarSeccionTickets(doc, auditoriasTickets);
                    doc.NewPage();
                }

                // Auditoría de Sesiones
                if (auditoriasSesiones?.Any() == true)
                {
                    AgregarSeccionSesiones(doc, auditoriasSesiones);
                }

                doc.Close();

                return new ResultadoReporte
                {
                    Exitoso = true,
                    RutaArchivo = rutaDestinoPdf,
                    Mensaje = "Reporte generado exitosamente",
                    TotalRegistrosTickets = auditoriasTickets?.Count ?? 0,
                    TotalRegistrosSesiones = auditoriasSesiones?.Count ?? 0
                };
            }
            catch (Exception ex)
            {
                return new ResultadoReporte
                {
                    Exitoso = false,
                    Mensaje = $"Error al generar reporte: {ex.Message}"
                };
            }
        }

        /// <summary>
        /// Genera reporte solo de auditoría de tickets
        /// </summary>
        public ResultadoReporte GenerarReporteTicketsPdf(
            string rutaDestinoPdf,
            List<AuditoriaTicket> auditorias,
            FiltrosReporte filtros = null)
        {
            return GenerarReporteAuditoriasPdf(rutaDestinoPdf, auditorias, null, filtros);
        }

        /// <summary>
        /// Genera reporte solo de auditoría de sesiones
        /// </summary>
        public ResultadoReporte GenerarReporteSesionesPdf(
            string rutaDestinoPdf,
            List<AuditoriaSesion> auditorias,
            FiltrosReporte filtros = null)
        {
            return GenerarReporteAuditoriasPdf(rutaDestinoPdf, null, auditorias, filtros);
        }

        #endregion

        #region Validación

        private void ValidarParametros(string ruta, List<AuditoriaTicket> tickets, List<AuditoriaSesion> sesiones)
        {
            if (string.IsNullOrWhiteSpace(ruta))
                throw new ArgumentException("La ruta del archivo no puede estar vacía", nameof(ruta));

            if ((tickets == null || !tickets.Any()) && (sesiones == null || !sesiones.Any()))
                throw new ArgumentException("Debe proporcionar al menos una lista de auditorías con datos");

            // Validar que el directorio existe
            var directorio = Path.GetDirectoryName(ruta);
            if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
        }

        #endregion

        #region Filtros

        private List<AuditoriaTicket> AplicarFiltrosTickets(List<AuditoriaTicket> auditorias, FiltrosReporte filtros)
        {
            var resultado = auditorias.AsQueryable();

            if (filtros.FechaDesde.HasValue)
                resultado = resultado.Where(a => a.FechaHora >= filtros.FechaDesde.Value);

            if (filtros.FechaHasta.HasValue)
                resultado = resultado.Where(a => a.FechaHora <= filtros.FechaHasta.Value);

            if (filtros.UsuarioId.HasValue)
                resultado = resultado.Where(a => a.UsuarioId == filtros.UsuarioId.Value);

            if (!string.IsNullOrEmpty(filtros.Operacion))
                resultado = resultado.Where(a => a.Operacion.Contains(filtros.Operacion));

            return resultado.ToList();
        }

        private List<AuditoriaSesion> AplicarFiltrosSesiones(List<AuditoriaSesion> auditorias, FiltrosReporte filtros)
        {
            var resultado = auditorias.AsQueryable();

            if (filtros.FechaDesde.HasValue)
                resultado = resultado.Where(a => a.FechaHoraLogin >= filtros.FechaDesde.Value);

            if (filtros.FechaHasta.HasValue)
                resultado = resultado.Where(a => a.FechaHoraLogin <= filtros.FechaHasta.Value);

            if (filtros.UsuarioId.HasValue)
                resultado = resultado.Where(a => a.UsuarioId == filtros.UsuarioId.Value);

            return resultado.ToList();
        }

        #endregion

        #region Construcción de Portada

        private void AgregarPortada(Document doc, FiltrosReporte filtros)
        {
            // Logo o título principal
            var titulo = new Paragraph("INFORME DE AUDITORÍAS", Fuentes.Titulo)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 30
            };
            doc.Add(titulo);

            // Información del reporte
            var tabla = new PdfPTable(2) { WidthPercentage = 60 };
            tabla.SetWidths(new float[] { 1f, 2f });
            tabla.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.SpacingBefore = 20;
            tabla.SpacingAfter = 30;

            AgregarFilaInfo(tabla, "Fecha de generación:", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            AgregarFilaInfo(tabla, "Sistema:", "Gestión de Estacionamiento");

            if (filtros != null)
            {
                if (filtros.FechaDesde.HasValue)
                    AgregarFilaInfo(tabla, "Período desde:", filtros.FechaDesde.Value.ToString("dd/MM/yyyy"));

                if (filtros.FechaHasta.HasValue)
                    AgregarFilaInfo(tabla, "Período hasta:", filtros.FechaHasta.Value.ToString("dd/MM/yyyy"));
            }

            doc.Add(tabla);

            // Línea separadora con gradiente visual
            var lineaSeparadora = new LineSeparator(2f, 100f, Colores.CyanVibrante, Element.ALIGN_CENTER, -5);
            doc.Add(lineaSeparadora);
        }

        private void AgregarFilaInfo(PdfPTable tabla, string etiqueta, string valor)
        {
            tabla.AddCell(new PdfPCell(new Phrase(etiqueta, Fuentes.NormalBold))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                PaddingRight = 10,
                PaddingBottom = 5
            });

            tabla.AddCell(new PdfPCell(new Phrase(valor, Fuentes.Normal))
            {
                Border = Rectangle.NO_BORDER,
                PaddingBottom = 5
            });
        }

        #endregion

        #region Resumen Ejecutivo

        private void AgregarResumenEjecutivo(Document doc, List<AuditoriaTicket> tickets, List<AuditoriaSesion> sesiones)
        {
            doc.Add(new Paragraph("RESUMEN EJECUTIVO", Fuentes.Subtitulo)
            {
                SpacingBefore = 20,
                SpacingAfter = 15
            });

            var tabla = new PdfPTable(2) { WidthPercentage = 80 };
            tabla.SetWidths(new float[] { 3f, 1f });

            // Estadísticas de Tickets
            if (tickets?.Any() == true)
            {
                AgregarEstadisticasTickets(tabla, tickets);
            }

            // Estadísticas de Sesiones
            if (sesiones?.Any() == true)
            {
                AgregarEstadisticasSesiones(tabla, sesiones);
            }

            doc.Add(tabla);
        }

        private void AgregarEstadisticasTickets(PdfPTable tabla, List<AuditoriaTicket> tickets)
        {
            AgregarCeldaResumen(tabla, "AUDITORÍA DE TICKETS", "", true);
            AgregarCeldaResumen(tabla, "Total de operaciones registradas", tickets.Count.ToString());

            var porOperacion = tickets.GroupBy(t => t.Operacion)
                .OrderByDescending(g => g.Count());

            foreach (var grupo in porOperacion)
            {
                AgregarCeldaResumen(tabla, $"  • {grupo.Key}", grupo.Count().ToString());
            }

            var usuariosMasActivos = tickets.GroupBy(t => t.Usuario?.PER_NOMBRE ?? "N/A")
                .OrderByDescending(g => g.Count())
                .Take(3);

            AgregarCeldaResumen(tabla, "Usuarios más activos", "", true);
            foreach (var usuario in usuariosMasActivos)
            {
                AgregarCeldaResumen(tabla, $"  • {usuario.Key}", usuario.Count().ToString());
            }
        }

        private void AgregarEstadisticasSesiones(PdfPTable tabla, List<AuditoriaSesion> sesiones)
        {
            AgregarCeldaResumen(tabla, "AUDITORÍA DE SESIONES", "", true);
            AgregarCeldaResumen(tabla, "Total de sesiones registradas", sesiones.Count.ToString());
            AgregarCeldaResumen(tabla, "Sesiones activas",
                sesiones.Count(s => s.SesionActiva).ToString());
            AgregarCeldaResumen(tabla, "Sesiones finalizadas",
                sesiones.Count(s => !s.SesionActiva).ToString());

            var cierresForzados = sesiones.Count(s => s.TipoLogout == "Cierre forzado");
            if (cierresForzados > 0)
            {
                AgregarCeldaResumen(tabla, "⚠ Cierres anormales", cierresForzados.ToString(), false, Colores.RojoVino);
            }

            var timeouts = sesiones.Count(s => s.TipoLogout == "Timeout por inactividad");
            if (timeouts > 0)
            {
                AgregarCeldaResumen(tabla, "⏱ Timeouts", timeouts.ToString(), false, Colores.AmbarCalido);
            }

            // Duración promedio
            var duracionesValidas = sesiones.Where(s => s.TiempoSesion.HasValue)
                .Select(s => s.TiempoSesion.Value);

            if (duracionesValidas.Any())
            {
                var promedioMinutos = duracionesValidas.Average() / 60;
                AgregarCeldaResumen(tabla, "Duración promedio de sesión",
                    $"{promedioMinutos:F1} min");
            }
        }

        private void AgregarCeldaResumen(PdfPTable tabla, string texto, string valor,
            bool esHeader = false, BaseColor colorValor = null)
        {
            var fuenteTexto = esHeader ? Fuentes.NormalBold : Fuentes.Normal;
            var fuenteValor = esHeader ? Fuentes.NormalBold : Fuentes.Normal;

            if (colorValor != null)
            {
                fuenteValor = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, colorValor);
            }

            tabla.AddCell(new PdfPCell(new Phrase(texto, fuenteTexto))
            {
                Border = Rectangle.NO_BORDER,
                PaddingTop = esHeader ? 10 : 3,
                PaddingBottom = 3,
                BackgroundColor = esHeader ? Colores.AcentoSuave : null
            });

            tabla.AddCell(new PdfPCell(new Phrase(valor, fuenteValor))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                PaddingTop = esHeader ? 10 : 3,
                PaddingBottom = 3,
                BackgroundColor = esHeader ? Colores.AcentoSuave : null
            });
        }

        #endregion

        #region Sección Tickets

        private void AgregarSeccionTickets(Document doc, List<AuditoriaTicket> auditorias)
        {
            doc.Add(new Paragraph("DETALLE DE AUDITORÍA DE TICKETS", Fuentes.Seccion)
            {
                SpacingBefore = 10,
                SpacingAfter = 10
            });

            doc.Add(new Paragraph($"Total de registros: {auditorias.Count}", Fuentes.Pequena)
            {
                SpacingAfter = 10
            });

            var tabla = BuildTablaAuditoriaTickets(auditorias);
            doc.Add(tabla);
        }

        private PdfPTable BuildTablaAuditoriaTickets(List<AuditoriaTicket> auditorias)
        {
            var tabla = new PdfPTable(8) { WidthPercentage = 100 };
            tabla.SetWidths(new float[] { 2f, 2f, 1.5f, 2f, 2.5f, 2f, 2.5f, 2.5f });

            string[] headers = {
                "Fecha/Hora", "Usuario", "Ticket", "Patente",
                "Operación", "Campo", "Valor Anterior", "Valor Nuevo"
            };

            foreach (var h in headers)
                tabla.AddCell(HeaderCell(h));

            if (auditorias == null || !auditorias.Any())
            {
                tabla.AddCell(CeldaSinDatos(8));
                return tabla;
            }

            foreach (var a in auditorias.OrderByDescending(x => x.FechaHora))
            {
                tabla.AddCell(CeldaNormal(a.FechaHora.ToString("dd/MM/yyyy\nHH:mm")));
                tabla.AddCell(CeldaNormal(a.Usuario?.PER_NOMBRE ?? "N/A"));
                tabla.AddCell(CeldaNormal(a.TicketBaseId.ToString(), Element.ALIGN_CENTER));
                tabla.AddCell(CeldaNormal(a.Ticket?.Patente ?? "N/A"));
                tabla.AddCell(CeldaOperacion(a.Operacion));
                tabla.AddCell(CeldaNormal(a.CampoModificado ?? "-"));
                tabla.AddCell(CeldaNormal(a.ValorAnterior ?? "-"));
                tabla.AddCell(CeldaNormal(a.ValorNuevo ?? "-"));
            }

            return tabla;
        }

        private PdfPCell CeldaOperacion(string operacion)
        {
            BaseColor color = Colores.Negro;
            Font fuente = Fuentes.Pequena;

            if (operacion != null)
            {
                if (operacion.Contains("INSERT") || operacion.Contains("CREAR") || operacion.Contains("agrego"))
                {
                    color = Colores.VerdeEsmeralda;
                    fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, color);
                }
                else if (operacion.Contains("DELETE") || operacion.Contains("ELIMINAR") || operacion.Contains("elimino"))
                {
                    color = Colores.RojoVino;
                    fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, color);
                }
                else if (operacion.Contains("UPDATE") || operacion.Contains("agrego_servicio") || operacion.Contains("elimino_servicio"))
                {
                    color = Colores.AzulElectrico;
                    fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, color);
                }
            }

            return new PdfPCell(new Phrase(operacion ?? "-", fuente))
            {
                Padding = 5,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_CENTER
            };
        }

        #endregion

        #region Sección Sesiones

        private void AgregarSeccionSesiones(Document doc, List<AuditoriaSesion> auditorias)
        {
            doc.Add(new Paragraph("DETALLE DE AUDITORÍA DE SESIONES", Fuentes.Seccion)
            {
                SpacingBefore = 10,
                SpacingAfter = 10
            });

            doc.Add(new Paragraph($"Total de registros: {auditorias.Count}", Fuentes.Pequena)
            {
                SpacingAfter = 10
            });

            var tabla = BuildTablaAuditoriaSesiones(auditorias);
            doc.Add(tabla);
        }

        private PdfPTable BuildTablaAuditoriaSesiones(List<AuditoriaSesion> auditorias)
        {
            var tabla = new PdfPTable(6) { WidthPercentage = 100 };
            tabla.SetWidths(new float[] { 2.5f, 2f, 2f, 2f, 2.5f, 1.5f});

            string[] headers = {
                "Usuario", "Login", "Logout", "Duración",
                "Tipo Logout", "Estado"
            };

            foreach (var h in headers)
                tabla.AddCell(HeaderCell(h));

            if (auditorias == null || !auditorias.Any())
            {
                tabla.AddCell(CeldaSinDatos(7));
                return tabla;
            }

            foreach (var a in auditorias.OrderByDescending(x => x.FechaHoraLogin))
            {
                var textoLogout = a.FechaHoraLogout?.ToString("dd/MM/yyyy\nHH:mm")
                   ?? (a.SesionActiva ? "En curso" : "Sin registros");

                tabla.AddCell(CeldaNormal(a.Usuario?.PER_NOMBRE ?? "N/A"));
                tabla.AddCell(CeldaNormal(a.FechaHoraLogin.ToString("dd/MM/yyyy\nHH:mm")));
                tabla.AddCell(CeldaNormal(textoLogout));//fecha logout 
                tabla.AddCell(CeldaDuracion(a.TiempoSesion));
                tabla.AddCell(CeldaNormal(a.TipoLogout ?? "-"));
                tabla.AddCell(CeldaEstadoSesion(a.SesionActiva));
            }

            return tabla;
        }

        private PdfPCell CeldaDuracion(int? segundos)
        {
            if (!segundos.HasValue)
                return CeldaNormal("-", Element.ALIGN_CENTER);

            var tiempo = TimeSpan.FromSeconds(segundos.Value);
            string texto;

            if (tiempo.TotalHours >= 1)
                texto = $"{(int)tiempo.TotalHours}h {tiempo.Minutes}m";
            else if (tiempo.TotalMinutes >= 1)
                texto = $"{(int)tiempo.TotalMinutes}m";
            else
                texto = $"{tiempo.Seconds}s";

            return CeldaNormal(texto, Element.ALIGN_CENTER);
        }

        private PdfPCell CeldaEstadoSesion( bool activa)
        {
            BaseColor color;
            string texto;

            if (activa)
            {
                color = Colores.VerdeEsmeralda;
                texto = "● Activa";
            }
            else
            {
                color = Colores.GrisModerno;
                texto = "○ Cerrada";
            }

            var fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7, color);

            return new PdfPCell(new Phrase(texto, fuente))
            {
                Padding = 5,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_CENTER
            };
        }

        #endregion

        #region Helpers de Celdas

        private PdfPCell HeaderCell(string texto)
        {
            return new PdfPCell(new Phrase(texto, Fuentes.Header))
            {
                BackgroundColor = Colores.MoradoPrincipal,
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 8
            };
        }

        private PdfPCell CeldaNormal(string texto, int alineacion = Element.ALIGN_LEFT)
        {
            return new PdfPCell(new Phrase(texto, Fuentes.Pequena))
            {
                HorizontalAlignment = alineacion,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 5
            };
        }

        private PdfPCell CeldaSinDatos(int colspan)
        {
            return new PdfPCell(new Phrase("Sin registros para mostrar", Fuentes.Normal))
            {
                Colspan = colspan,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 20,
                BackgroundColor = Colores.GrisClaro
            };
        }

        #endregion
    }

    #region Event Handler para Páginas

    internal class PaginaEventHandlerAuditorias : PdfPageEventHelper
    {
        private static readonly Font FuentePie = FontFactory.GetFont(
            FontFactory.HELVETICA, 8, BaseColor.GRAY);

        private static readonly Font FuentePieNegrita = FontFactory.GetFont(
            FontFactory.HELVETICA_BOLD, 8, BaseColor.GRAY);

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            // Header
            AgregarHeader(writer, document);

            // Footer
            AgregarFooter(writer, document);
        }

        private void AgregarHeader(PdfWriter writer, Document document)
        {
            var tabla = new PdfPTable(1)
            {
                TotalWidth = document.PageSize.Width - 80
            };

            tabla.AddCell(new PdfPCell(new Phrase("Sistema de Gestión de Estacionamiento", FuentePieNegrita))
            {
                Border = Rectangle.BOTTOM_BORDER,
                BorderColor = new BaseColor(46, 117, 182),
                BorderWidth = 2,
                PaddingBottom = 5,
                HorizontalAlignment = Element.ALIGN_CENTER
            });

            tabla.WriteSelectedRows(
                0, -1,
                40,
                document.PageSize.Height - 30,
                writer.DirectContent);
        }

        private void AgregarFooter(PdfWriter writer, Document document)
        {
            var tabla = new PdfPTable(3)
            {
                TotalWidth = document.PageSize.Width - 80
            };

            tabla.SetWidths(new float[] { 2f, 2f, 1f });

            // Fecha
            tabla.AddCell(new PdfPCell(new Phrase(
                $"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}", FuentePie))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_LEFT
            });

            // Sistema
            tabla.AddCell(new PdfPCell(new Phrase(
                "Auditorías del Sistema", FuentePie))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_CENTER
            });

            // Número de página
            tabla.AddCell(new PdfPCell(new Phrase(
                $"Página {writer.PageNumber}", FuentePieNegrita))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });

            tabla.WriteSelectedRows(
                0, -1,
                40,
                30,
                writer.DirectContent);
        }
    }

    #endregion

    #region Clases auxiliares

    /// <summary>
    /// Filtros para el reporte de auditorías
    /// </summary>
    public class FiltrosReporte
    {
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? UsuarioId { get; set; }
        public string Operacion { get; set; }
        public string EstadoSesion { get; set; }
    }

    /// <summary>
    /// Resultado de la generación del reporte
    /// </summary>
    public class ResultadoReporte
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
        public string RutaArchivo { get; set; }
        public int TotalRegistrosTickets { get; set; }
        public int TotalRegistrosSesiones { get; set; }
    }

    #endregion
}