using MODELO;
using Controladora;
using MODELO.seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
    public partial class formTarifa : Form
    {
        char Modo = 'A';
        Tarifa Tarifa;
        public formTarifa()
        {
            InitializeComponent();
            llenarComboTipos();
            Tarifa = new Tarifa();
        }



        public void llenarComboTipos()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();
        }

        void LlenarTxt(Tarifa tarifa)
        {
            if (tarifa != null)
            {
                txtMedHora.Text = tarifa.PrecioMediaHora.ToString();
                txtHora.Text = tarifa.PrecioHora.ToString();
                txtDia.Text = tarifa.PrecioDia.ToString();
                textMes.Text = tarifa.PrecioMes.ToString();
            }
            else
            {
                txtMedHora.Text = string.Empty;
                txtHora.Text = string.Empty;
                txtDia.Text = string.Empty;
                textMes.Text = string.Empty;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipovehiculo = (TipoVehiculo)comboBox1.SelectedItem;
            var tarifa = ControladoraTarifas.Instancia.getAllTarifasActuales().FirstOrDefault(x => x.TipoVehiculo.NombreVehiculo == tipovehiculo.NombreVehiculo);
            LlenarTxt(tarifa);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Gestionar Tarifas");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("seleccione un vehiculo");
                return;
            }
            try
            {
                Tarifa.PrecioMediaHora = decimal.Parse(txtMedHora.Text);
                Tarifa.PrecioHora = decimal.Parse(txtHora.Text);
                Tarifa.PrecioDia = decimal.Parse(txtDia.Text);
                Tarifa.PrecioMes = decimal.Parse(textMes.Text);

                Tarifa.TipoVehiculo = (TipoVehiculo)comboBox1.SelectedItem;
                Tarifa.FechaHoraActualizacion = DateTime.Now;
                Tarifa.Vigente = true;
                var msj = ControladoraTarifas.Instancia.ActualizarTarifa(Tarifa);
                MessageBox.Show(msj, "Atencion");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingreso invalido, intente nuevamente");
                return;
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
