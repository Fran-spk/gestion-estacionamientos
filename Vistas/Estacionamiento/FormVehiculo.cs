using Controladora;
using MODELO;
using MODELO.seguridad;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vista
{
    public partial class FormVehiculo : Form
    {

        public FormVehiculo()
        {
            InitializeComponent();
            llenarCombos();
            this.Load += FormVehiculo_Load;
        }


        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Generar ingreso");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }

        public void llenarGrilla(TipoVehiculo tipo)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraEspacios.Instancia.getAllEspaciosByTipoVehiculo(tipo);
        }

        public void llenarCombos()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculoActivos();
        }



        public FormVehiculo(Ticket ticket)
        {
            InitializeComponent();
            llenarCombos();
            txtpatente.Enabled = false;
            txtpatente.Text = ticket.Patente;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            HoraActual.Text = DateTime.Now.ToLongTimeString();
        }

        private bool Validaciones() //validaciones del formulario
        {
            var ok = true;
            if (string.IsNullOrEmpty(txtpatente.Text))
            {
                MessageBox.Show("Ingrese patente valido");
                ok = false;
            }

            return ok;

        }





        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Ticket ticket = new Ticket();
                Espacio espacio;
                ticket.FechaHoraEmision = DateTime.Now;
                if (CbxManual.Checked)
                {
                    var DiaString = DateTime.Now.ToString("yyyy/MM/dd");
                    var HoraString = DiaString + " " + txtManual.Text + ":00";
                    try
                    {
                        ticket.FechaHoraEmision = DateTime.Parse(HoraString);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Formato de horario invalido, debe ser ' aa:bb '");
                        return;
                    }
                }
                ticket.Patente = txtpatente.Text;

                ticket.Estado = ControladoraTicketsBase.Instancia.getAllEstados().FirstOrDefault(x => x.Nombre == "Pendiente") ?? new Estado_Ticket();
                if (dataGridView1.CurrentRow != null)
                {
                    espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                    if (espacio.Disponibilidad)
                    {
                        ticket.Espacio = espacio;
                    }
                    else
                    {
                        MessageBox.Show("Espacio ocupado a su totalidad");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un espacio para el ingreso del vehiculo");
                    return;
                }

                if (ControladoraTicketsBase.Instancia.IsPresenteByPatente(ticket.Patente))
                {
                    MessageBox.Show("Vehiculo: " + ticket.Patente + " ya se encuentra estacionado");
                    return;
                }
                var tipovehiculo = (TipoVehiculo)comboBox1.SelectedItem;
                var tarifa = ControladoraTarifas.Instancia.getAllTarifasActuales().FirstOrDefault(x => x.TipoVehiculo.NombreVehiculo == tipovehiculo.NombreVehiculo);
                if (tarifa != null)
                {
                    ticket.TarifaEstacionamiento = tarifa;
                }
                else
                {
                    MessageBox.Show("Tarifa no encontrada");
                    return;
                }
                var ok = ControladoraTicketsBase.Instancia.AgregarTicket(ticket);
                if (ok)
                {
                    MessageBox.Show("Vehiculo ingresado al estacionamiento de forma exitosa");
                }
                else
                {
                    MessageBox.Show("El vehiculo no pudo ser ingresado al sistema");
                }
            }
            this.Close();

        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxManual_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxManual.Checked) { txtManual.Visible = true; }
            else { txtManual.Visible = false; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var espacios = ControladoraEspacios.Instancia.getAllEspacios();
            var TipoVehiculo = (TipoVehiculo)comboBox1.SelectedItem;
            
            if (TipoVehiculo != null)
            {
                if (TipoVehiculo.Disponibilidad)
                {
                    LabelNoLugar.Visible = false;
                    llenarGrilla(TipoVehiculo);
                }
                else 
                { 
                    LabelNoLugar.Visible = true;
                    llenarGrilla(null);
                }
            }
            else
            {
                LabelNoLugar.Visible = false;
            }

        }
    }
}
