using MODELO.seguridad;
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
using Servicios;

namespace Vista.Seguridad
{
    public partial class FormClaveNueva : Form
    {
        public FormClaveNueva()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var clave = txtClaveActual.Text;
            clave = ServiciosUsuario.Instancia.EncriptarClave(clave);
            if (!ValidarCampos())
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            if (Sesion.Instancia.Perfil.USU_CLAVE == clave)
            {
                if (txtClaveNueva.Text == txtConfirmar.Text)
                {
                    var claveNueva = ServiciosUsuario.Instancia.EncriptarClave(txtClaveNueva.Text);
                    Sesion.Instancia.Perfil.USU_CLAVE = claveNueva;
                    var ok = ControladoraUsuarios.Instancia.ModificarUsuario(Sesion.Instancia.Perfil);
                    if (ok)
                    {
                        MessageBox.Show("Clave modificada con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La accion no se pudo realizar");
                    }
                }
                else
                {
                    MessageBox.Show("Las claves no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
            }
        }

        bool ValidarCampos()
        {
            if (txtClaveActual.Text == string.Empty || txtClaveNueva.Text == string.Empty || txtConfirmar.Text == string.Empty)
            { return false; }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
