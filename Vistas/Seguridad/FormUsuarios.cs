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
    public partial class FormUsuarios : Form
    {

        public FormUsuarios()
        {
            InitializeComponent();
            LlenarGrilla();
            LlenarCombos();
            this.Load += FormUsuarios_Load;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar usuarios"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }


        void LlenarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraUsuarios.Instancia.getAllUsuarios();
        }

        void LlenarCombos()
        {
            var Todos = new Estado_Usuario();
            Todos.EST_USU_NOMBRE = "Todos";
            var Estados = ControladoraUsuarios.Instancia.getAllEstadosUsuario().ToList();
            Estados.Add(Todos);
            cmbEstados.DataSource = null;
            cmbEstados.DataSource = Estados;

            var todosgrupos = new Grupo();
            todosgrupos.GRU_NOMBRE = "Todos";
            var Grupos = ControladoraGrupos.Instancia.getAllGrupos().ToList();
            Grupos.Add(todosgrupos);
            cmbGrupos.DataSource = null;
            cmbGrupos.DataSource = Grupos;

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Guardar Registro"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            var formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
            LlenarGrilla();
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
                var usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                var msj = ControladoraUsuarios.Instancia.EliminarUsuario(usuario);
                MessageBox.Show(msj);
            }
            LlenarGrilla();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Eliminar Registro"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            DialogResult resul = MessageBox.Show("¿Desea resetear el sistema?", "Atencion", MessageBoxButtons.YesNo);

            if (resul == DialogResult.Yes)
            {
                var ok = ControladoraUsuarios.Instancia.ResetearUsuarios();
                if (ok)
                {
                    LlenarGrilla();
                    MessageBox.Show("Usuarios reseteados exitosamente");
                    Sesion.Instancia.Perfil = null;

                }
                else
                {
                    MessageBox.Show("No fue posible realizar la accion o no existen usuarios en el sistema");
                }
            }
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
                var usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                var FormUsuario = new FormUsuario(usuario);
                FormUsuario.ShowDialog();
                LlenarGrilla();
            }
        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios;
            var grupo = cmbGrupos.SelectedItem as Grupo;
            var estado = cmbEstados.SelectedItem as Estado_Usuario;
            if (grupo.GRU_NOMBRE!="Todos")
            {
                
                usuarios = ControladoraUsuarios.Instancia.getAllUsuariosByGrupo(txtNombre.Text,grupo ).ToList();
            }
            else
            {
                usuarios = ControladoraUsuarios.Instancia.getAllUsuarios().Where(x => x.PER_NOMBRE == txtNombre.Text).ToList();
            }
            if (estado.EST_USU_NOMBRE != "Todos")
            {               
                usuarios = usuarios.Where(x=>x.Estado_Usuario.EST_USU_ID == estado.EST_USU_ID).ToList();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuarios;
        }
    }
}

