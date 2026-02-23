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
    public partial class FormRecuperarClave : Form
    {
        public FormRecuperarClave()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string claveNueva = ServiciosUsuario.GenerarPassword();
                var ok = ControladoraUsuarios.Instancia.RecuperarClave(txtUsuario.Text,txtEmail.Text,claveNueva);
                if (ok)
                {
                    MessageBox.Show("La nueva clave sera enviada a su E-mail registrado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecta");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
