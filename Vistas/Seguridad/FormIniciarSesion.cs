using MODELO.seguridad;
using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista.Seguridad
{
    public partial class FormIniciarSesion : Form
    {
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                var Usuario = ControladoraUsuarios.Instancia.IniciarSesion(txtUsuario.Text, txtClave.Text);
                if (Usuario != null)
                {
                    try
                    {
                        var sesion = ControladoraSesiones.Instancia.RegistrarLogin(Usuario);
                        Sesion.Instancia.Perfil = Usuario;
                        Form form = new Menu();
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecta");
                }
            }
            txtClave.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbRecuperarClave_Click(object sender, EventArgs e)
        {
            var form = new FormRecuperarClave();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
