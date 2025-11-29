using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using MODELO.seguridad;
using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Vista.Seguridad
{
    public partial class FormUsuario : Form
    {

        List<Grupo> gruposSeleccionados;
        List<Accion> accionesSeleccionadas;
        Usuario usuario;

        public FormUsuario()
        {
            gruposSeleccionados = new List<Grupo>();
            accionesSeleccionadas = new List<Accion>();
            InitializeComponent();
            LlenarEstados();
            LlenarGrupos();
            LlenarAcciones();

        }

       
        public FormUsuario(Usuario Usuario)
        {
            gruposSeleccionados = new List<Grupo>();
            accionesSeleccionadas = new List<Accion>();
            usuario = Usuario;
            InitializeComponent();
            LlenarEstados();
            LlenarCombos();
            LlenarGrupos();
            LlenarAcciones();
        }

        void LlenarCombos()
        {
            accionesSeleccionadas = usuario.Acciones.ToList();
            gruposSeleccionados = usuario.Grupos.ToList();
            txtNomb.Text = usuario.PER_NOMBRE;
            txtUsuario.Text = usuario.USU_USUARIO.ToString();
            txtEmail.Text = usuario.USU_MAIL.ToString();
            cmxEstado.DataSource = ControladoraUsuarios.Instancia.getAllEstadosUsuario();
            cmxEstado.SelectedItem = usuario.Estado_Usuario;
            txtEmail.Enabled = false;
        }

        void LlenarEstados()
        {
            cmxEstado.DataSource = null;
            cmxEstado.DataSource = ControladoraUsuarios.Instancia.getAllEstadosUsuario();
        }

        void LlenarGrupos()
        {
            var grupos = ControladoraGrupos.Instancia.getAllGrupos();
            checkedListBox1.Items.Clear();
            foreach (var grupo in grupos)
            {
                int index = checkedListBox1.Items.Add(grupo);
                if (gruposSeleccionados.Any(g => g.GRU_ID == grupo.GRU_ID))
                {
                    checkedListBox1.SetItemChecked(index, true);
                }
            }
        }

        void LlenarAcciones()
        {

            var modulos = ControladoraGrupos.Instancia.getAllModulos();
            treeView1.Nodes.Clear();
            foreach (var modulo in modulos)
            {
                TreeNode nodoModulo = treeView1.Nodes.Add(modulo.MOD_NOMBRE);
                nodoModulo.Tag = modulo;
                bool modulocheck = true;
                foreach (var formulario in modulo.Formularios)
                {
                    TreeNode nodoFormulario = nodoModulo.Nodes.Add(formulario.FOR_NOMBRE);
                    nodoFormulario.Tag = formulario;

                    foreach (var accion in formulario.Acciones)
                    {
                        TreeNode nodoAccion = nodoFormulario.Nodes.Add(accion.ACC_NOMBRE);
                        nodoAccion.Tag = accion;
                        var Acciones = gruposSeleccionados.SelectMany(g => g.Acciones ).ToList();
                        if (Acciones.Contains(accion) || (usuario!=null && usuario.Acciones.Contains(accion)))
                        {
                            nodoAccion.Checked = true;
                        }
                    }
                    if (formulario.Acciones.All(a => gruposSeleccionados.SelectMany(g => g.Acciones).Contains(a)))
                    {
                        nodoFormulario.Checked = true;
                    }
                    else
                    {
                        modulocheck = false;
                    }
                }
                if (modulocheck)
                {
                    nodoModulo.Checked = true;
                }
            }
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Guardar Registro");
            if (Accion == null)
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            if (txtEmail.Enabled)
            {
                usuario = new Usuario();
                usuario.PER_NOMBRE = txtNomb.Text;
                usuario.USU_USUARIO = txtUsuario.Text;
                usuario.USU_MAIL = txtEmail.Text;
                usuario.Estado_Usuario = (Estado_Usuario)cmxEstado.SelectedItem;
                foreach (var accion in accionesSeleccionadas)
                {
                    usuario.AgregarAccion(accion);
                }
                foreach (var grupo in gruposSeleccionados)
                {
                    usuario.AgregarGrupo(grupo);
                }              

                usuario.USU_CLAVE = GenerarPasword();
                if (!Validaciones())
                {
                    return;
                }
                var mensaje = ControladoraUsuarios.Instancia.AgregarUsuario(usuario);
                MessageBox.Show(mensaje);
                VaciarTxt();
            }
            else
            {
                usuario.PER_NOMBRE = txtNomb.Text;
                usuario.USU_USUARIO = txtUsuario.Text;
                usuario.USU_MAIL = txtEmail.Text;
                usuario.Estado_Usuario = (Estado_Usuario)cmxEstado.SelectedItem;
                usuario.Acciones.Clear();
                usuario.Grupos.Clear();
                foreach (var accion in accionesSeleccionadas)
                {
                    usuario.AgregarAccion(accion);
                }
                foreach (var grupo in gruposSeleccionados)
                {
                    usuario.AgregarGrupo(grupo);
                }
                if (!Validaciones())
                {
                    return;
                }
                var ok = ControladoraUsuarios.Instancia.ModificarUsuario(usuario);
                if (ok)
                {
                    MessageBox.Show("Usuario modificado con exito");
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser modificado");
                }
            }
        }




        bool Validaciones()
        {
            var ok = true;
            if (new[] { usuario.PER_NOMBRE, usuario.USU_CLAVE, usuario.USU_MAIL, usuario.USU_USUARIO }.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(usuario.USU_MAIL, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                MessageBox.Show("El correo electrónico no es válido");
                return false;
            }
            if (!gruposSeleccionados.Any())
            {
                MessageBox.Show("Debe seleccionar al menos un grupo");
                return false;
            }
            return ok;
        }

        void VaciarTxt()
        {
            txtEmail.Text = "";
            txtNomb.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GenerarPasword()
        {
            Random random = new Random();
            string password = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                int eleccion = random.Next(0, 9);
                password += eleccion.ToString();
            }
            return password;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.Items[e.Index] is Grupo grupo)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (!gruposSeleccionados.Any(g => g.GRU_ID == grupo.GRU_ID))
                    {
                        gruposSeleccionados.Add(grupo);
                    }
                }
                else
                {
                    gruposSeleccionados.RemoveAll(g => g.GRU_ID == grupo.GRU_ID);
                }
            }
            LlenarAcciones();
        }


    


        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e) //Marcar las grupales si o si
        {
            var nodo = e.Node;
            if (nodo == null) return;

            if (nodo.Tag is Accion accion)
            {
                var accionesGrupos = gruposSeleccionados
                    .SelectMany(g => g.Acciones)
                    .Any(x => x.ACC_ID == accion.ACC_ID);
                if (!e.Node.Checked)
                {

                    if (accionesGrupos)
                    {
                        MessageBox.Show("No se puede eliminar una acción asociada al grupo seleccionado");
                        nodo.Checked = true;

                    }
                    else
                    {
                        accionesSeleccionadas.Remove(accion);
                    }
                }
                else
                {

                    if (!accionesGrupos && !usuario.Acciones.Contains(accion))
                    {
                        accionesSeleccionadas.Add(accion);
                    }
                }
            }

        }
    }
}
