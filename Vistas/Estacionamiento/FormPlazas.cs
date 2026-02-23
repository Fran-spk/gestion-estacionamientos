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
using Vista;

namespace Vista
{
    public partial class FormPlazas : Form
    {
        public FormPlazas()
        {
            InitializeComponent();
            Llenarcombo();
            LlenarGrilla();
            this.Load += FormPlazas_Load;
        }
        private void FormPlazas_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar espacios de parqueo"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }
  

        void Llenarcombo()
        {
            cbxTipoVehiculo.DataSource = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();
        }
        void LlenarGrilla()
        {
            ControladoraTicketsDiarios.Instancia.ActualizarTicketsVencidos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraEspacios.Instancia.getAllEspacios();
            listBoxVehiculos.DataSource = null;
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnAgregarEspacio_Click(object sender, EventArgs e)
        {
            var form = new FormEspacio();
            form.ShowDialog();
            LlenarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                var form = new FormEspacio(espacio);
                form.ShowDialog();
            }
            LlenarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                var ok = ControladoraEspacios.Instancia.EliminarEspacio(espacio);
                if (ok)
                {
                    MessageBox.Show("Espacio Eliminado");
                }
                else
                {
                    MessageBox.Show("El espacio no pudo ser eliminado");
                }
            }
            LlenarGrilla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                listBoxVehiculos.DataSource = espacio.Vehiculos;
            }

        }

        private void BtnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (cbxTipoVehiculo.SelectedItem != null)
            {
                var tipoVehi = (TipoVehiculo)cbxTipoVehiculo.SelectedItem;
                if (dataGridView1.CurrentRow != null)
                {
                    var espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                    espacio.Agregar(tipoVehi);
                    var ok = ControladoraEspacios.Instancia.ModificarEspacio(espacio);
                    listBoxVehiculos.DataSource = null;
                    listBoxVehiculos.DataSource = espacio.Vehiculos;
                }

            }
        }

        private void BtnQuitarVehi_Click(object sender, EventArgs e)
        {
            if (listBoxVehiculos.SelectedItem != null)
            {
                var tipoVehi = (TipoVehiculo)listBoxVehiculos.SelectedItem;
                if (dataGridView1.CurrentRow != null)
                {
                    var espacio = (Espacio)dataGridView1.CurrentRow.DataBoundItem;
                    espacio.Quitar(tipoVehi);
                    var ok = ControladoraEspacios.Instancia.ModificarEspacio(espacio);
                    listBoxVehiculos.DataSource = null;
                    listBoxVehiculos.DataSource = espacio.Vehiculos;
                }

            }
        }
    }
}
