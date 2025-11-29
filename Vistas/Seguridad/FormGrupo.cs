using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO.seguridad;
using Controladora;

namespace Vista.Seguridad
{
    public partial class FormGrupo : Form
    {
        List<Accion> acciones;
        Grupo grupo;
        public FormGrupo()
        {           
            acciones = new List<Accion>();
            InitializeComponent();
            LlenarAcciones();
            LlenarEstados();
            txtCodigo.Enabled = false;
        }

        public FormGrupo(Grupo Grupo)
        {         
            acciones = new List<Accion>();
            grupo = Grupo;
            InitializeComponent();
            LlenarAcciones();
            LlenarEstados();                   
            LlenarTxt();
            txtCodigo.Enabled = false;
        }

        void LlenarTxt()
        {
            txtCodigo.Text = grupo.GRU_ID.ToString();
            TxtNombre.Text = grupo.GRU_NOMBRE.ToString();
            txtDesc.Text = grupo.GRU_DESCRIPCION.ToString();
            cmbEstado.SelectedItem = grupo.Estado_Grupo;           
        }

        void LlenarEstados()
        {
            cmbEstado.DataSource = null;
            cmbEstado.DataSource = ControladoraGrupos.Instancia.getAllEstadosGrupo();
        }

        void LlenarAcciones()
        {
            var modulos = ControladoraGrupos.Instancia.getAllModulos();
            treeView1.Nodes.Clear();
            foreach (var modulo in modulos)
            {
                TreeNode nodoModulo = treeView1.Nodes.Add(modulo.MOD_NOMBRE);
                nodoModulo.Tag = modulo;
                var modulocheck = true;
                foreach (var formulario in modulo.Formularios)
                {
                    TreeNode nodoFormulario = nodoModulo.Nodes.Add(formulario.FOR_NOMBRE);
                    nodoFormulario.Tag = formulario;
                    var Formcheck = true;
                    foreach (var accion in formulario.Acciones)
                    {
                        TreeNode nodoAccion = nodoFormulario.Nodes.Add(accion.ACC_NOMBRE);
                        nodoAccion.Tag = accion;
                        if(grupo!=null && grupo.Acciones.Contains(accion))
                        {
                            nodoAccion.Checked = true;
                        }
                        else
                        {
                            Formcheck = false;
                        }                   
                    }
                    nodoFormulario.Checked = Formcheck;
                    if (!Formcheck) { modulocheck = false; }
                }
                nodoModulo.Checked = modulocheck;
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            var nodo = e.Node;
            if (nodo == null) return;
         
            if (nodo.Tag is Accion accion)
            {
                if (!e.Node.Checked)
                {
                    acciones.Remove(accion);
                }
                else
                {
                    acciones.Add(accion);
                }
            }
        }

        bool Validaciones()
        {
            var ok = true;
            if (new[] { TxtNombre.Text, txtDesc.Text, cmbEstado.SelectedItem.ToString()}.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }         
            if (!acciones.Any())
            {
                MessageBox.Show("Debe seleccionar al menos una acción");
                return false;
            }
            return ok;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!Validaciones())
            {
                return;
            }
            if(grupo != null)
            {
                grupo.GRU_NOMBRE = TxtNombre.Text;
                grupo.Estado_Grupo = cmbEstado.SelectedItem as Estado_Grupo;
                grupo.GRU_DESCRIPCION = txtDesc.Text;
                grupo.Acciones.Clear();
                foreach (var ac in acciones)
                {
                    grupo.AgregarAccion(ac);
                }
                if (!grupo.Acciones.Any())
                {
                    MessageBox.Show("Debe asignar al menos una accion al grupo");
                    return;
                }
                var msj = ControladoraGrupos.Instancia.ModificarGrupo(grupo);
                MessageBox.Show(msj);
            }
            else
            {
                grupo = new Grupo();
                grupo.GRU_NOMBRE = TxtNombre.Text;
                grupo.Estado_Grupo = cmbEstado.SelectedItem as Estado_Grupo;
                grupo.GRU_DESCRIPCION = txtDesc.Text;
                foreach (var ac in acciones)
                {
                    grupo.AgregarAccion(ac);
                }
                if (!grupo.Acciones.Any())
                {
                    MessageBox.Show("Debe asignar al menos una accion al grupo");
                    return;
                }
                var msj = ControladoraGrupos.Instancia.AgregarGrupo(grupo);
                MessageBox.Show(msj);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
