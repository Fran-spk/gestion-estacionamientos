
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Modelo_Ids;

namespace MODELO
{
    public class Pago
    {
        private int pagoId;
        private string patente;
        private int? ticketbaseId;
        private List<PagoDetalle> detalles =new List<PagoDetalle>();
        private decimal monto;
        private decimal montoTotal;
        private decimal montoDescuento;
        private DateTime fechahorapago;
        private MetodoDePago metododepago;
        private int metododepagoid;


        public string DisplayText
        {
            get
            {
                string icono = metododepago?.ToString().ToLower() switch
                {
                    var m when m.Contains("efectivo") => "💵",
                    var m when m.Contains("tarjeta") => "💳",
                    var m when m.Contains("transferencia") => "🏦",
                    _ => "💰"
                };

                return $"{icono} Pago #{pagoId} - ${montoTotal:N2} - {metododepago} - {fechahorapago:dd/MM/yyyy HH:mm}";
            }
        }
        public int PagoId
        {
            get { return pagoId; }
            set { pagoId = value; }
        }

        public string Patente
        {
            get => patente; set {   patente = value; }
        }

        public decimal MontoTotal
        {
            get { return montoTotal; }
        }
        public decimal MontoDescuento
        {
            get { return montoDescuento; }
            set {  montoDescuento = value; }
        }

        public decimal Monto
        {
            get { return monto; }
        }
        public int MetodoDePagoId
        {
            get { return metododepagoid; }
            set { metododepagoid = value; }
        }

        public int? TicketBaseId
        {
            get { return ticketbaseId; }
            set { ticketbaseId = value; }
        }


        public DateTime FechaHoraPago
        {
            get { return fechahorapago; }
        }


        public MetodoDePago MetodoDePago
        {
            get { return metododepago; }
            set { metododepago = value; }
        }



        public List<PagoDetalle> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }

        public void AgregarServicio(ServicioConsumido servicio) //valido solo pendientes
        {
            if (servicio.Pendiente)
            {
                this.detalles.Add(new PagoDetalle { ServicioConsumido = servicio });
            }
        }

        public void AgregarTicketCuota(TicketBase ticket) //valido un ticket o cuota por pago
        {
            var ok = detalles.Any(x => x.Ticket != null);
            if (!ok)
            {
                this.detalles.Add(new PagoDetalle { Ticket = ticket });
            }
        }


        public void CalcularMontos()
        {
            foreach (var detalle in Detalles)
            {
                detalle.Calcular(); 
            }
            monto = detalles.Sum(d => d.Monto);
            montoDescuento = detalles.Sum(d=>d.MontoDescuento);
            montoTotal = monto - montoDescuento;
            fechahorapago = DateTime.Now;
        }

    }
}
