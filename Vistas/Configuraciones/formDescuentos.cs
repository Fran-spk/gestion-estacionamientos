using Controladora;
using MODELO;
using MODELO.seguridad;
using Servicios;
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
    public partial class formDescuentos : Form
    {
        public formDescuentos()
        {
            this.Load += formDescuentos_Load;
            InitializeComponent();
            LlenarCampos();
        }


        private void formDescuentos_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar Descuentos"))
            {
                MessageBox.Show("Acceso denegado");
                this.Close();
            }
        }


        void LlenarCampos()
        {
            comboBox1.DataSource = ControladoraDescuentos.Instancia.getAllDescuentos();
            txtNombre.Text = string.Empty;
            TxtDesc.Text = string.Empty;
            checkBox1.Checked = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Descuento descuento = new Descuento();
            try
            {
                descuento.Porcentaje = decimal.Parse(TxtDesc.Text);
                if(txtNombre.Text==string.Empty) 
                { MessageBox.Show("Ingreso invalido de datos"); return; }
                descuento.NombreDescuento = txtNombre.Text;
                descuento.Estado = checkBox1.Checked;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingreso invalido de datos");
                return;
            }          
            var ok = ControladoraDescuentos.Instancia.AgregarDescuento(descuento);
            if(ok)
            {
                MessageBox.Show("Descuento Agregado");
                LlenarCampos();
            }
            else
            {
                MessageBox.Show("El descuento no pudo ser agregado correctamente");
                LlenarCampos();
            }                     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Descuento desc = comboBox1.SelectedItem as Descuento;
            if(desc != null) 
            {
                TxtDesc.Text = desc.Porcentaje.ToString();
                checkBox1.Checked = desc.Estado;
                txtNombre.Text = desc.NombreDescuento.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Descuento descuento = comboBox1.SelectedItem as Descuento;
            if (comboBox1.SelectedItem is Descuento)
            {
                var ok= ControladoraDescuentos.Instancia.EliminarDescuento(descuento);
                if(ok)
                {
                    MessageBox.Show("El descuento fue eliminado de manera correcta");
                    LlenarCampos();
                }
                else
                {
                    MessageBox.Show("El descuento no pudo ser eliminado");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Descuento");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var descuento = comboBox1.SelectedItem as Descuento;
            try
            {
                descuento.Porcentaje = decimal.Parse(TxtDesc.Text);
                descuento.NombreDescuento = txtNombre.Text;
                descuento.Estado = checkBox1.Checked;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingreso invalido de datos");
                return;
            }
            var ok = ControladoraDescuentos.Instancia.ModificarDescuento(descuento);
            if(ok)
            {
                MessageBox.Show("Cambios guardados");
                LlenarCampos();
            }
            else
            {
                MessageBox.Show("El descuento no pudo ser modificado");
            }
            
            
        }

    }
}
