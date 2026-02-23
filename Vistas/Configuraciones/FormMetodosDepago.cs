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
    public partial class FormMetodosDepago : Form
    {
        public FormMetodosDepago()
        {
            InitializeComponent();
            llenarCombo();
            checkActivo.Enabled = false;
            this.Load += FormMetodosDepago_Load;
        }


        private void FormMetodosDepago_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar Métodos de pago"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }

        void llenarCombo()
        {
            cbxMetd.DataSource = ControladoraMetodosDePago.Instancia.getAllMetodosDePago();
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cbxMetd.SelectedItem != null)
            {
                var metodoPago = cbxMetd.SelectedItem as MetodoDePago;
                if (!metodoPago.Estado)
                {
                    MessageBox.Show("El metodo de pago ya se encuentra dado de baja");
                    return;
                }
                else
                {
                    metodoPago.Estado = false;
                    var ok = ControladoraMetodosDePago.Instancia.ModificarMetodo(metodoPago);
                    if (ok)
                    {
                        MessageBox.Show("El metodo de pago fue dado de baja de manera exitosa");
                        checkActivo.Checked = metodoPago.Estado;
                    }
                    else
                    {
                        MessageBox.Show("El metodo de pago no fue encontrado");
                    }
                }

            }
        }

        private void cbxMetd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMetd.SelectedItem != null)
            {
                var metodoPago = cbxMetd.SelectedItem as MetodoDePago;
                checkActivo.Checked = metodoPago.Estado;
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (cbxMetd.SelectedItem != null)
            {
                var metodoPago = cbxMetd.SelectedItem as MetodoDePago;
                if (metodoPago.Estado)
                {
                    MessageBox.Show("El metodo de pago ya se encuentra activo");
                    return;
                }
                else
                {
                    metodoPago.Estado = true;
                    var ok = ControladoraMetodosDePago.Instancia.ModificarMetodo(metodoPago);
                    if (ok)
                    {
                        MessageBox.Show("El metodo de pago fue activado de manera exitosa");
                        checkActivo.Checked = metodoPago.Estado;
                    }
                    else
                    {
                        MessageBox.Show("El metodo de pago no fue encontrado");
                    }
                }

            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MetodoDePago metodoDePago = new MetodoDePago();
            metodoDePago.Estado = true;
            if (txtNombre.Text != string.Empty)
            {
                metodoDePago.NombreMetodo = txtNombre.Text;
                var ok = ControladoraMetodosDePago.Instancia.AgregarMetodo(metodoDePago);
                if (ok)
                {
                    MessageBox.Show("El metodo de pago fue cargado correctamente");
                    txtNombre.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El metodo de pago ya existe en el sistema");
                }
            }
            llenarCombo();
        }
       
    }
}
