using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Estacionamiento;


namespace Vista
{
    public partial class FormConfiguracion : Form
    {
        public FormConfiguracion()
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            TxtExplicacion.Text = "Gestion de la cantidad de plazas disponibles en el estacionamiento para cada tipo de vehiculo";
        }

        private void BtnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            TxtExplicacion.Text = "Modificar el porcentaje de descuentos otorgados a las personas de mayoria de edad";
        }

        private void BtnActividades_MouseMove(object sender, MouseEventArgs e)
        {
            TxtExplicacion.Text = "Gestion de los metodos de pagos existentes en el sistema";
        }

        private void BtnTarifas_MouseMove(object sender, MouseEventArgs e)
        {
            TxtExplicacion.Text = "Gestion de las tarifas actuales como tambien de las anteriores";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            TxtExplicacion.Text = string.Empty;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var form = new FormPlazas();
            form.ShowDialog();
        }

        private void BtnTarifas_Click(object sender, EventArgs e)
        {
            var form = new FormTarifas();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void BtnActividades_Click(object sender, EventArgs e)
        {
            var form = new FormMetodosDepago();
            form.ShowDialog();

        }

        private void BtnDescuentos_Click(object sender, EventArgs e)
        {
            var form = new formDescuentos();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormTiposVehiculos();
            form.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FormTarifasServicios();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new FormTiposServicio();
            form.ShowDialog();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            TxtExplicacion.Text = "Gestion de las tarifas de los servicios";
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            TxtExplicacion.Text = "Gestion de los tipos de servicios del sistema";
        }
    }
}
