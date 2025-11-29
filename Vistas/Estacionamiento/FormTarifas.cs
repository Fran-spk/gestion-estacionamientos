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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MODELO.seguridad;

namespace Vista
{
    public partial class FormTarifas : Form
    {
        public FormTarifas()
        {
            this.Load += FormTarifas_Load;
            InitializeComponent();
            ActualizarGrilla();
            ActualizarCombo();
        }



        private void FormTarifas_Load(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Gestionar Tarifas");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }

        void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraTarifas.Instancia.getAllTarifasActuales();
            var tarifas = ControladoraTarifas.Instancia.getAllTarifasActuales();
        }

        void ActualizarCombo()
        {
            cbmTipo.DataSource = null;
            cbmTipo.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var form = new formTarifa();
            form.ShowDialog();
            ActualizarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var Tarifa = (Tarifa)dataGridView1.CurrentRow.DataBoundItem;
                var mensaje = ControladoraTarifas.Instancia.EliminarTarifa(Tarifa);
                MessageBox.Show(mensaje, "Atencion");
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una tarifa");
            }

        }

        private void cmbTiempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Tarifas = ControladoraTarifas.Instancia.getAllTarifas().Where(x => x.TipoVehiculo == (TipoVehiculo)cbmTipo.SelectedItem).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Tarifas;
        }

        private void BtnActuales_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }

}
