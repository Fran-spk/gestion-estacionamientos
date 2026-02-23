using Controladora;
using MODELO;
using Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Vista.Estacionamiento
{
    public partial class FormTiposServicio : Form
    {
        private TipoServicio servicioActual;

        public FormTiposServicio()
        {
            InitializeComponent();
            ConfigurarEventos();
            CargarServicios();
            ConfigurarEstadoInicial();
        }

        private void ConfigurarEventos()
        {
            cbxTiposServicios.SelectedIndexChanged += CbxTiposServicios_SelectedIndexChanged;
            chboxNuevoServicio.CheckedChanged += ChboxNuevoServicio_CheckedChanged;
            BtnAceptar.Click += BtnAceptar_Click;
            BtnVolver.Click += (s, e) => this.Close();
        }

        private void ConfigurarEstadoInicial()
        {
            chboxNuevoServicio.Checked = false;
            HabilitarEdicion(false);
        }

        private void CargarServicios()
        {
            cbxTiposServicios.Items.Clear();
            cbxTiposServicios.DisplayMember = "Descripcion";
            cbxTiposServicios.ValueMember = "TipoServicioId";

            var servicios = ControladoraTiposServicio.Instancia.getAllTiposServicio();

            foreach (var servicio in servicios)
            {
                cbxTiposServicios.Items.Add(servicio);
            }

            cbxTiposServicios.SelectedIndex = -1;
        }

        private void CbxTiposServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTiposServicios.SelectedIndex == -1)
                return;

            servicioActual = (TipoServicio)cbxTiposServicios.SelectedItem;
            chboxNuevoServicio.Checked = false;

            TXTDescripcion.Text = servicioActual.Descripcion;
            ChboxEstado.Checked = servicioActual.Estado;

            HabilitarEdicion(true);
        }

        private void ChboxNuevoServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxNuevoServicio.Checked)
            {
                cbxTiposServicios.SelectedIndex = -1;
                servicioActual = null;
                LimpiarCampos();
                HabilitarEdicion(true);
                ChboxEstado.Checked = true;
            }
            else
            {
                LimpiarCampos();
                HabilitarEdicion(false);
            }
        }

        private void HabilitarEdicion(bool habilitar)
        {
            TXTDescripcion.Enabled = habilitar;
            ChboxEstado.Enabled = habilitar && !chboxNuevoServicio.Checked;
        }

        private void LimpiarCampos()
        {
            TXTDescripcion.Text = "";
            ChboxEstado.Checked = false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(TXTDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }



            if (chboxNuevoServicio.Checked)
            {
                var nuevoServicio = new TipoServicio
                {
                    Descripcion = TXTDescripcion.Text.Trim(),
                    Estado = true
                };

                bool ok = ControladoraTiposServicio.Instancia.Agregar(nuevoServicio);

                if (ok)
                {
                    MessageBox.Show("Servicio agregado correctamente.");
                    CargarServicios();
                    ConfigurarEstadoInicial();
                }
                else
                {
                    MessageBox.Show("Ya existe un servicio con esa descripción.");
                }

                return;
            }

            if (servicioActual == null)
            {
                MessageBox.Show("Debe seleccionar un servicio.");
                return;
            }

            servicioActual.Descripcion = TXTDescripcion.Text.Trim();
            servicioActual.Estado = ChboxEstado.Checked;
            ControladoraTiposServicio.Instancia.Modificar(servicioActual);
            MessageBox.Show("Servicio modificado correctamente.");

            CargarServicios();
            ConfigurarEstadoInicial();
        }

        private void FormTiposServicio_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar tipos de servicios"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }
    }
}
