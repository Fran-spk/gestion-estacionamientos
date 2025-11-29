
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Pago
    {
        private int pagoId;
        private TicketBase ticketBase;
        private int ticketbaseId;
        private decimal monto;
        private decimal montodescuento;
        private decimal montofinal;
        private string tipo;
        private DateTime fechahorapago;
        private MetodoDePago metododepago;
        private int metododepagoid;


        public int PagoId
        {
            get { return pagoId; }
            set { pagoId = value; }
        }

        public int MetodoDePagoId
        {
            get { return metododepagoid; }
            set { metododepagoid = value; }
        }

        public int TicketBaseId
        {
            get { return ticketbaseId; }
            set { ticketbaseId = value; }
        }

        public TicketBase Ticket
        {
            get { return ticketBase; }
            set { ticketBase = value; }
        }

        public decimal Monto
        {
            get { return monto; }
            private set { monto = value; }
        }

        public decimal MontoDescuento
        {
            get { return montodescuento; }
        }

        public decimal MontoFinal
        {
            get { return montofinal; }
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

        public void RealizarPago()
        {
            if (ticketBase is Ticket ticket)
            {
                if (ticket.Estadia is Estadia_Media_Hora)
                {
                    monto += ticket.Tarifa.PrecioMediaHora;
                }
                else if (ticket.Estadia is Estadia_Hora)
                {
                    monto += (Decimal)ticket.Horas * ticket.Tarifa.PrecioHora;

                    if (ticket.Minutos < 30 && ticket.Minutos > 0)
                    {
                        monto += ticket.Tarifa.PrecioMediaHora;
                    }
                    else if (ticket.Minutos >= 30)
                    {
                        monto += ticket.Tarifa.PrecioHora;
                    }
                }
                else if (ticket.Estadia is Estadia_Dia)
                {
                    monto = ticket.Tarifa.PrecioDia;
                }
            }
            else if (ticketBase is Cuota cuota)
            {
                monto = cuota.Tarifa.PrecioMes;

                if (cuota.Plan?.Descuento != null)
                {
                    montodescuento = monto * (cuota.Plan.Descuento.Porcentaje / 100);
                }
            }

            montofinal = Monto - MontoDescuento;
            fechahorapago = DateTime.Now;
        }

        public string GenerarRecibo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("******* RECIBO DE PAGO *******");
            sb.AppendLine("Software de Estacionamiento");
            sb.AppendLine("Calle 123");
            sb.AppendLine($"Ticket nro: {Ticket.TicketBaseId}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Datos del Vehículo");
            sb.AppendLine($"Patente: {Ticket.Patente}");
            sb.AppendLine($"Tipo de vehículo: {Ticket.Tarifa.TipoVehiculo}");
            if (Ticket is Cuota cuota)
            {
                sb.AppendLine("--------------------------------");
                sb.AppendLine("Datos del Plan");
                sb.AppendLine($"Nombre: {cuota.Plan.PER_NOMBRE}");
                sb.AppendLine($"DNI: {cuota.Plan.Dni}");
                sb.AppendLine($"Telefono: {cuota.Plan.Dni}");   
                sb.AppendLine($"Estadía: {Ticket.Estadia}");
                sb.AppendLine("--------------------------------");
                sb.AppendLine($"Fecha emision: {Ticket.FechaHoraEmision}");
                sb.AppendLine($"Fecha de Pago: {FechaHoraPago}");
            }
            else
            {
                sb.AppendLine($"Estadía: {Ticket.Estadia}");
                sb.AppendLine("--------------------------------");
                sb.AppendLine($"Fecha de ingreso: {Ticket.FechaHoraEmision}");
                sb.AppendLine($"Fecha de salida: {FechaHoraPago}");
            }
            sb.AppendLine($"Método de Pago: {MetodoDePago}");
            sb.AppendLine($"Monto: {Monto}");
            sb.AppendLine($"Descuento: {MontoDescuento}");
            sb.AppendLine($"Monto Final: {MontoFinal}");
            sb.AppendLine("--------------------------------");
            return sb.ToString();
        }
    }
}
