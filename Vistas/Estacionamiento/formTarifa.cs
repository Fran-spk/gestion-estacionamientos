using MODELO;
using Controladora;
using MODELO.seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Modelo_Ids;
using Servicios;

namespace Vista
{
    public partial class formTarifa : Form
    {
        char Modo = 'A';
        TarifaEstacionamiento Tarifa;
        public formTarifa()
        {
            InitializeComponent();
            llenarComboTipos();
            Tarifa = new TarifaEstacionamiento();
        }



        public void llenarComboTipos()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();
        }

        void LlenarTxt(TarifaEstacionamiento tarifa)
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
            var tarifa = ControladoraTarifasEstacionamiento.Instancia.getAllTarifasActuales().FirstOrDefault(x => x.TipoVehiculo.NombreVehiculo == tipovehiculo.NombreVehiculo);
            LlenarTxt(tarifa);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar Tarifas"))
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
                var tarifa = TarifaFactory.CrearTarifa(
                    tipoVehiculo: (TipoVehiculo)comboBox1.SelectedItem,
                    precioMediaHora: decimal.Parse(txtMedHora.Text),
                    precioHora: decimal.Parse(txtHora.Text),
                    precioDia: decimal.Parse(txtDia.Text),
                    precioMes: decimal.Parse(textMes.Text)
                );

                var msj = ControladoraTarifasEstacionamiento.Instancia.ActualizarTarifa(tarifa as TarifaEstacionamiento);

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
