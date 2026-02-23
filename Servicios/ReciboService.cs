// ─── ReciboService ───────────────────────────────────────────
using MODELO;
using Servicios;

public class ReciboService
{
    public string GenerarRecibo(Pago pago)
    {
        IGeneradorRecibo generador = ObtenerGenerador(pago);
        return generador.Generar(pago);
    }

    private IGeneradorRecibo ObtenerGenerador(Pago pago)
    {
        bool tieneTicketDiario = pago.Detalles.Any(d => d.Ticket is Ticket_Diario);
        bool tieneCuota = pago.Detalles.Any(d => d.Ticket is Cuota);

        if (tieneTicketDiario) return new ReciboTicketDiario();
        if (tieneCuota) return new ReciboCuota();
        return new ReciboSoloServicios();
    }
}