using Controladora;
using MODELO.seguridad;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vista.Seguridad
{
    public partial class FormUsuario : Form
    {
        private List<Grupo> gruposSeleccionados;
        private List<Accion> accionesSeleccionadas;
        private Usuario usuario;
        private bool _actualizandoNodos = false;

        // ─── Constructores ───────────────────────────────────────

        public FormUsuario()
        {
            gruposSeleccionados = new List<Grupo>();
            accionesSeleccionadas = new List<Accion>();
            InitializeComponent();
            LlenarEstados();
            LlenarGrupos();
            LlenarAcciones();
        }

        public FormUsuario(Usuario usuario)
        {
            gruposSeleccionados = new List<Grupo>();
            accionesSeleccionadas = new List<Accion>();
            this.usuario = usuario;
            InitializeComponent();
            LlenarEstados();
            LlenarCombos();
            LlenarGrupos();
            LlenarAcciones();
        }

        // ─── Carga de datos ──────────────────────────────────────

        void LlenarEstados()
        {
            cmxEstado.DataSource = null;
            cmxEstado.DataSource = ControladoraUsuarios.Instancia.getAllEstadosUsuario();
        }

        void LlenarCombos()
        {
            accionesSeleccionadas = usuario.Acciones.ToList();
            gruposSeleccionados = usuario.Grupos.ToList();
            txtNomb.Text = usuario.PER_NOMBRE;
            txtUsuario.Text = usuario.USU_USUARIO;
            txtEmail.Text = usuario.USU_MAIL;
            cmxEstado.DataSource = ControladoraUsuarios.Instancia.getAllEstadosUsuario();
            cmxEstado.SelectedItem = usuario.Estado_Usuario;
            txtEmail.Enabled = false;
        }

        void LlenarGrupos()
        {
            var grupos = ControladoraGrupos.Instancia.getAllGrupos();
            checkedListBox1.Items.Clear();

            foreach (var grupo in grupos)
            {
                int index = checkedListBox1.Items.Add(grupo);
                if (gruposSeleccionados.Any(g => g.GRU_ID == grupo.GRU_ID))
                    checkedListBox1.SetItemChecked(index, true);
            }
        }

        void LlenarAcciones()
        {
            var modulos = ControladoraGrupos.Instancia.getAllModulos();
            treeView1.Nodes.Clear();

            var accionesDeGrupos = gruposSeleccionados
                .SelectMany(g => g.Acciones)
                .ToList();

            foreach (var modulo in modulos)
            {
                TreeNode nodoModulo = treeView1.Nodes.Add(modulo.MOD_NOMBRE);
                nodoModulo.Tag = modulo;
                bool moduloCompleto = true;

                foreach (var formulario in modulo.Formularios)
                {
                    TreeNode nodoFormulario = nodoModulo.Nodes.Add(formulario.FOR_NOMBRE);
                    nodoFormulario.Tag = formulario;
                    bool formularioCompleto = true;

                    foreach (var accion in formulario.Acciones)
                    {
                        TreeNode nodoAccion = nodoFormulario.Nodes.Add(accion.ACC_NOMBRE);
                        nodoAccion.Tag = accion;

                        bool tienePermiso = accionesDeGrupos.Contains(accion)
                            || (usuario != null && usuario.Acciones.Contains(accion));

                        nodoAccion.Checked = tienePermiso;

                        if (!tienePermiso)
                            formularioCompleto = false;
                    }

                    nodoFormulario.Checked = formularioCompleto;

                    if (!formularioCompleto)
                        moduloCompleto = false;
                }

                nodoModulo.Checked = moduloCompleto;
            }
        }

        // ─── Eventos ─────────────────────────────────────────────

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.Items[e.Index] is not Grupo grupo) return;

            if (e.NewValue == CheckState.Checked)
            {
                if (!gruposSeleccionados.Any(g => g.GRU_ID == grupo.GRU_ID))
                    gruposSeleccionados.Add(grupo);
            }
            else
            {
                gruposSeleccionados.RemoveAll(g => g.GRU_ID == grupo.GRU_ID);
            }

            LlenarAcciones();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (_actualizandoNodos) return;
            _actualizandoNodos = true;

            try
            {
                var nodo = e.Node;
                if (nodo == null) return;

                if (nodo.Nodes.Count > 0)
                    MarcarHijos(nodo, nodo.Checked);

                if (nodo.Tag is Accion accion)
                    GestionarAccion(nodo, accion);

                ActualizarPadre(nodo.Parent);
            }
            finally
            {
                _actualizandoNodos = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Guardar Registro"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }

            if (!Validaciones()) return;

            if (EsModoAlta())
                GuardarAlta();
            else
                GuardarModificacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        // ─── Lógica de guardado ──────────────────────────────────

        private bool EsModoAlta() => txtEmail.Enabled;

        private void GuardarAlta()
        {
            usuario = new Usuario
            {
                PER_NOMBRE = txtNomb.Text,
                USU_USUARIO = txtUsuario.Text,
                USU_MAIL = txtEmail.Text,
                Estado_Usuario = (Estado_Usuario)cmxEstado.SelectedItem,
                USU_CLAVE = ServiciosUsuario.GenerarPassword()
            };

            AplicarAccionesYGrupos();

            var mensaje = ControladoraUsuarios.Instancia.AgregarUsuario(usuario);
            MessageBox.Show(mensaje);
            VaciarTxt();
        }

        private void GuardarModificacion()
        {
            usuario.PER_NOMBRE = txtNomb.Text;
            usuario.USU_USUARIO = txtUsuario.Text;
            usuario.USU_MAIL = txtEmail.Text;
            usuario.Estado_Usuario = (Estado_Usuario)cmxEstado.SelectedItem;

            usuario.Acciones.Clear();
            usuario.Grupos.Clear();

            AplicarAccionesYGrupos();

            var ok = ControladoraUsuarios.Instancia.ModificarUsuario(usuario);
            MessageBox.Show(ok ? "Usuario modificado con éxito" : "El usuario no pudo ser modificado");
        }

        private void AplicarAccionesYGrupos()
        {
            foreach (var accion in accionesSeleccionadas)
                usuario.AgregarAccion(accion);

            foreach (var grupo in gruposSeleccionados)
                usuario.AgregarGrupo(grupo);
        }

        // ─── Lógica del TreeView ─────────────────────────────────

        private void GestionarAccion(TreeNode nodo, Accion accion)
        {
            bool esDeGrupo = gruposSeleccionados
                .SelectMany(g => g.Acciones)
                .Any(x => x.ACC_ID == accion.ACC_ID);

            if (!nodo.Checked)
            {
                if (esDeGrupo)
                {
                    MessageBox.Show("No se puede eliminar una acción asociada al grupo seleccionado.");
                    nodo.Checked = true;
                }
                else
                {
                    accionesSeleccionadas.Remove(accion);
                }
            }
            else
            {
                bool yaAgregada = esDeGrupo
                    || (usuario != null && usuario.Acciones.Contains(accion))
                    || accionesSeleccionadas.Contains(accion);

                if (!yaAgregada)
                    accionesSeleccionadas.Add(accion);
            }
        }

        private void MarcarHijos(TreeNode nodo, bool marcado)
        {
            foreach (TreeNode hijo in nodo.Nodes)
            {
                if (hijo.Tag is Accion accion)
                {
                    bool esDeGrupo = gruposSeleccionados
                        .SelectMany(g => g.Acciones)
                        .Any(x => x.ACC_ID == accion.ACC_ID);

                    if (!marcado && esDeGrupo)
                    {
                        hijo.Checked = true;
                        continue;
                    }

                    if (!marcado)
                        accionesSeleccionadas.Remove(accion);
                    else if (!esDeGrupo && (usuario == null || !usuario.Acciones.Contains(accion)))
                        accionesSeleccionadas.Add(accion);
                }

                hijo.Checked = marcado;

                if (hijo.Nodes.Count > 0)
                    MarcarHijos(hijo, marcado);
            }
        }

        private void ActualizarPadre(TreeNode padre)
        {
            if (padre == null) return;

            padre.Checked = padre.Nodes
                .Cast<TreeNode>()
                .All(n => n.Checked);

            ActualizarPadre(padre.Parent);
        }

        // ─── Validaciones ────────────────────────────────────────

        private bool Validaciones()
        {
            string nombre = txtNomb.Text;
            string usuario = txtUsuario.Text;
            string email = txtEmail.Text;

            if (new[] { nombre, usuario, email }.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return false;
            }

            bool emailValido = System.Text.RegularExpressions.Regex
                .IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!emailValido)
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return false;
            }

            if (!gruposSeleccionados.Any())
            {
                MessageBox.Show("Debe seleccionar al menos un grupo.");
                return false;
            }

            return true;
        }

        // ─── Utilidades ──────────────────────────────────────────

        private void VaciarTxt()
        {
            txtNomb.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

       
    }
}