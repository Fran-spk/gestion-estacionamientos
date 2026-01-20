
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Modelo_Ids;

namespace MODELO
{
    public class Pago
    {
        private int pagoId;
        private TicketBase ticketBase;
        private int ticketbaseId;
        private decimal montoEstacionamiento;
        private decimal montoServicios;
        private decimal montoDescuento;
        private decimal montofinal;
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

        public decimal MontoEstacionamiento
        {
            get { return montoEstacionamiento; }
            set { montoEstacionamiento = value; }
        }

        public decimal MontoServicios
        {
            get { return montoServicios; }
            set { montoServicios = value; }
        }

        public decimal MontoDescuento
        {
            get { return montoDescuento; }
            set {  montoDescuento = value; }
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

        private CalculadorPago ObtenerCalculador()
        {
            if (ticketBase is Cuota)
            {
                return new CalculadorMensual();
            }

            if (ticketBase is Ticket ticket)
            {
                if (ticket.Estadia is Estadia_Dia)
                    return new CalculadorDia();

                return new CalculadorHoras();
            }

            throw new InvalidOperationException("Tipo de ticket no válido");
        }

        void CalculoPagoAdicionales()
        {
            var Servicios = ticketBase.TarifasAdicionales.Select(a => a.Precio);
            this.montoServicios = Servicios.Sum();
        }
        public void RealizarPago()
        {
            CalculadorPago calculador = ObtenerCalculador();
            calculador.CalcularMonto(this);
            CalculoPagoAdicionales();
            //Totales
            montofinal = montoServicios + montoEstacionamiento - montoDescuento;
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
            sb.AppendLine($"Tipo de vehículo: {Ticket.TarifaEstacionamiento.TipoVehiculo}");

            if (Ticket is Cuota cuota)
            {
                sb.AppendLine("--------------------------------");
                sb.AppendLine("Datos del Plan");
                sb.AppendLine($"Nombre: {cuota.Plan.PER_NOMBRE}");
                sb.AppendLine($"DNI: {cuota.Plan.Dni}");
                sb.AppendLine($"Telefono: {cuota.Plan.Telefono}");
                sb.AppendLine($"Estadía: {Ticket.Estadia}");
                sb.AppendLine("--------------------------------");
                sb.AppendLine($"Emision: {Ticket.FechaHoraEmision.ToString("d/M/yy HH:mm")}");
                sb.AppendLine($"Fecha de Pago: {FechaHoraPago.ToString("d/M/yy HH:mm")}");
            }
            else
            {
                sb.AppendLine($"Estadía: {Ticket.Estadia}");
                sb.AppendLine("--------------------------------");
                sb.AppendLine($"Ingreso: {Ticket.FechaHoraEmision.ToString("d/M/yy HH:mm")}");
                sb.AppendLine($"Salida: {FechaHoraPago.ToString("d/M/yy HH:mm")}");
            }

            sb.AppendLine("--------------------------------");
            sb.AppendLine("Detalle de Costos");
            sb.AppendLine($"Estacionamiento: ${MontoEstacionamiento:F2}");

            // Mostrar servicios adicionales si existen
            if (Ticket.TarifasAdicionales != null && Ticket.TarifasAdicionales.Count > 0)
            {
                sb.AppendLine("Servicios Adicionales:");
                foreach (var servicio in Ticket.TarifasAdicionales)
                {
                    sb.AppendLine($"  - {servicio.Servicio.Descripcion}: ${servicio.Precio:F2}");
                }
                sb.AppendLine($"Subtotal Servicios: ${montoServicios:F2}");
            }

            if (MontoDescuento > 0)
            {
                sb.AppendLine($"Descuento: -${MontoDescuento:F2}");
            }

            sb.AppendLine("--------------------------------");
            sb.AppendLine($"Forma Pago: {MetodoDePago}");
            sb.AppendLine($"TOTAL A PAGAR: ${MontoFinal:F2}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Gracias por su visita");

            return sb.ToString();
        }
    }
}
