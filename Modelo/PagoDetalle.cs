using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class PagoDetalle
    {
        public int PagoDetalleId { get; set; }
        public int PagoId { get; set; }
        public Pago Pago { get; set; }
        public ServicioConsumido? ServicioConsumido { get; set; }
        public int? ServicioConsumidoId { get; set; }    
        public TicketBase? Ticket { get; set; }   
        public int? TicketBaseId { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoDescuento{ get; set; }
        public string Detalle { get; set; }


        public void Calcular()
        {
            var calculador = ObtenerCalculador();
            calculador.CalcularMonto(this);
        }
        CalculadorPago ObtenerCalculador()
        {
            if(Ticket == null)
            {
                if(ServicioConsumido != null)
                {
                    return new CalculadorPagoServicio();
                }
                else
                {
                    throw new InvalidOperationException("No se asigno ningun elemento");
                }
            }
            else
            {
                if (this.Ticket is Cuota)
                {
                    return new CalculadorPagoMensual();
                }

                if (Ticket is Ticket_Diario ticket)
                {
                    if (ticket.Estadia is Estadia_Dia)
                        return new CalculadorPagoDia();

                    return new CalculadorPagoHoras();
                }
                throw new InvalidOperationException("Tipo de ticket no válido");
            }

            
        }

    }

}
