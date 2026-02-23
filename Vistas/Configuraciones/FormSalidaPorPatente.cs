using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Servicios;

namespace Vista.Configuraciones
{
    public partial class FormSalidaPorPatente : Form
    {
        public FormSalidaPorPatente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Generar pago"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            var Patente = txtPatente.Text;
            var ticket = ControladoraTicketsDiarios.Instancia.getTicketPendienteByPatente(Patente);
            if (ticket != null)
            {
                var form = new FormPago(ticket);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vehiculo no encontrado");
            }
               
        }
    }
}
