using Controladora;
using MODELO;
using MODELO.seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormPago : Form
    {
        Pago pago;
        public FormPago(TicketBase ticket)
        {
            pago = new Pago();
            InitializeComponent();
            LlenarTxt(ticket);
            GenerarPago(ticket);

        }


        private void TimerHora_Tick(object sender, EventArgs e)
        {
            HoraActual.Text = DateTime.Now.ToLongTimeString();

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void LlenarTxt(TicketBase ticket)
        {

            lbPatente.Text = ticket.Patente.ToString();
            TxtEstadia.Text = ticket.Estadia.ToString();
            TxtHoraLlegada.Text = ticket.FechaHoraEmision.ToString();
            cbmMetodo.DataSource = ControladoraMetodosDePago.Instancia.getAllMetodosDePagoActivos();
            txtTipo.Text = ticket.TarifaEstacionamiento.TipoVehiculo.NombreVehiculo;
        }




        private void btnPago_Click_1(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Generar pago");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            pago.MetodoDePago = cbmMetodo.SelectedItem as MetodoDePago;
            if (pago.MetodoDePago == null) { MessageBox.Show("Debe seleccionar algun metodo de pago"); return; }
            var ok = ControladoraPagos.Instancia.AgregarPago(pago);
            if (ok)
            {
                if (pago.Ticket is Ticket)
                {

                    var ticket = pago.Ticket as Ticket;
                    ticket.FechaHoraSalida = DateTime.Now;
                    ticket.Estado = ControladoraTicketsBase.Instancia.getAllEstados().  
                        FirstOrDefault(x => x.Nombre == "Pagado") ?? new Estado_Ticket();
                    ControladoraTicketsBase.Instancia.ModificarTicket(ticket);
                }
                else
                {
                    var cuota = pago.Ticket as Cuota;
                    cuota.Estado = ControladoraTicketsBase.Instancia.getAllEstados().
                        FirstOrDefault(x => x.Nombre == "Pagado") ?? new Estado_Ticket();
                    ControladoraTicketsBase.Instancia.ModificarTicket(cuota);
                }
                if(checkBox1.Checked)
                {
                    var recibo = new FormPagoDetalle(pago, "Salida");
                }
                MessageBox.Show("Pago realizado!");
            }
            else
            {
                MessageBox.Show("El ticket ya se encuentra pagado");
            }
        }

        void GenerarPago(TicketBase ticket)
        {
            pago.Ticket = ticket;
            pago.RealizarPago();
            TxtPrecio.Text = pago.MontoEstacionamiento.ToString();
            TxtPrecioFinal.Text = pago.MontoFinal.ToString();
            txtdesc.Text = pago.MontoDescuento.ToString();
        }



    }
}
