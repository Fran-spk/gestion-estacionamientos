using MODELO;
using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO.seguridad;
using Servicios;

namespace Vista
{
    public partial class FormTiposVehiculos : Form
    {
        TipoVehiculo TipoVehiculo;
        public FormTiposVehiculos()
        {        
            this.Load += FormMetodosDepago_Load;
            InitializeComponent();
            LlenarCombo();         
        }

        private void FormMetodosDepago_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar Tipos de vehículos"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }


        void LlenarCombo()
        {
            cbxTiposVehiculos.DataSource = null;
            cbxTiposVehiculos.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();
        }

        private void cbxTiposVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTiposVehiculos.SelectedItem != null)
            {
                var Tipo = cbxTiposVehiculos.SelectedItem as TipoVehiculo;
                TXTnombre.Text = Tipo.NombreVehiculo;
                TxtDesc.Text = Tipo.Descripcion;
                ChboxEstado.Checked = Tipo.Estado;
                TipoVehiculo = Tipo;
            }
        }

        private void chboxNuevoVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxNuevoVehiculo.Checked)
            {
                VaciarCampos();       
            }
            cbxTiposVehiculos.Enabled = !chboxNuevoVehiculo.Checked;
        }

        void VaciarCampos()
        {
            TXTnombre.Text = string.Empty;
            TxtDesc.Text = string.Empty;
            ChboxEstado.Checked = true;
            TipoVehiculo = new TipoVehiculo();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var ok = true;

            if (TxtDesc.Text == string.Empty || TXTnombre.Text == string.Empty)
            {
                MessageBox.Show("Campos incompletos!");
                return;
            }

            TipoVehiculo.NombreVehiculo = TXTnombre.Text;
            TipoVehiculo.Descripcion = TxtDesc.Text;
            TipoVehiculo.Estado = ChboxEstado.Checked;

            if (chboxNuevoVehiculo.Checked)
            {
                ok = ControladoraTiposVehiculo.Instancia.Agregar(TipoVehiculo);
                if (ok)
                {
                    MessageBox.Show("Vehiculo agregado de forma exitosa");
                }
                else
                {
                    MessageBox.Show("No fue posible ingresar ek tipo de vehiculo");
                }
            }
            else
            {

                ok = ControladoraTiposVehiculo.Instancia.Modificar(TipoVehiculo);
                if (ok)
                {
                    MessageBox.Show("Vehiculo Modificado de forma exitosa");
                }
                else
                {
                    MessageBox.Show("No fue posible la modificacion");
                }
            }
            LlenarCombo();
            VaciarCampos();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
