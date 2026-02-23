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
    public partial class FormGrupos : Form
    {
        public FormGrupos()
        {
            InitializeComponent();
            LlenarGrilla();
            this.Load += FormGrupos_Load;
        }

        private void FormGrupos_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar grupos"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }

        void LlenarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraGrupos.Instancia.getAllGrupos();

            var Todos = new Estado_Grupo();
            Todos.EST_GRU_NOMBRE = "Todos";
            var Estados = ControladoraGrupos.Instancia.getAllEstadosGrupo().ToList();
            Estados.Add(Todos);
            CBestados.DataSource = null;
            CBestados.DataSource = Estados;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormGrupo();
            form.ShowDialog();
            LlenarGrilla();
        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Eliminar Registro"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            if (dataGridView1.CurrentRow != null)
            {
                var grupo = (Grupo)dataGridView1.CurrentRow.DataBoundItem;
                var msj = ControladoraGrupos.Instancia.EliminarGrupo(grupo);
                MessageBox.Show(msj);
            }
            LlenarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Guardar Registro"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            if (dataGridView1.CurrentRow != null)
            {
                var grupo = (Grupo)dataGridView1.CurrentRow.DataBoundItem;
                var form = new FormGrupo(grupo);
                form.ShowDialog();
            }
            LlenarGrilla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Grupo> grupos;
            var estado = CBestados.SelectedItem as Estado_Grupo;
            if (estado.EST_GRU_NOMBRE != "Todos")
            {

                grupos = ControladoraGrupos.Instancia.getAllGruposByEstado(estado).ToList();
            }
            else
            {
                grupos = ControladoraGrupos.Instancia.getAllGrupos().ToList();            
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = grupos.Where(x => x.GRU_NOMBRE == txtnombre.Text).ToList(); 
        }
    }
}
