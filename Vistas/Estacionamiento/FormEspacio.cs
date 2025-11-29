using Controladora;
using MODELO;
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
    public partial class FormEspacio : Form
    {
        Espacio espacio;
        bool Mod= false;
        public FormEspacio()
        {
            InitializeComponent();
        }
        public FormEspacio(Espacio Espacio)
        {
            InitializeComponent();
            TxtNombre.Text = Espacio.NombreEspacio;
            TxtCapacidad.Text = Espacio.Capacidad.ToString();
            ChboxMensual.Checked = Espacio.EsMenusal;
            espacio = Espacio;
            Mod = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(!Validar())
            {
                MessageBox.Show("Campos invalidos");
                return;
            }
            if (espacio == null)
            {
                espacio= new Espacio();
            }
            espacio.NombreEspacio = TxtNombre.Text;
            espacio.Capacidad = int.Parse(TxtCapacidad.Text);
            espacio.EsMenusal = ChboxMensual.Checked;
            if (!Mod)
            {
                var ok = ControladoraEspacios.Instancia.AgregarEspacio(espacio);
                if (ok)
                {
                    MessageBox.Show("Nuevo espacio agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El espacio no pudo ser cargado");
                }
            }
            else
            {
                var ok = ControladoraEspacios.Instancia.ModificarEspacio(espacio);
                if (ok)
                {
                    MessageBox.Show("Espacio modificado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El espacio no pudo ser modificado");
                }
            }
        }

        bool Validar()
        {
            if(TxtNombre.Text == string.Empty || TxtCapacidad.Text == string.Empty)
            { return false; }
            if (!int.TryParse(TxtCapacidad.Text, out  int a))
            {
               return false;
            }
            return true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
