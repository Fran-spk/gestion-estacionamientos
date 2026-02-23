using Controladora;
using MODELO;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vista.Estacionamiento
{
    public partial class FormTarifasServicios : Form
    {
        public FormTarifasServicios()
        {
            InitializeComponent();
            ConfigurarEventos();
            CargarCombos();
            CargarTarifas();
        }

        private void ConfigurarEventos()
        {
            // Evento del ComboBox de filtro
            comboVehiculo.SelectedIndexChanged += CbmTipo_SelectedIndexChanged;

            // Evento del botón Ver Actuales
            BtnActuales.Click += BtnActuales_Click;

            // Evento del botón Eliminar
            BtnAnular.Click += BtnAnular_Click;

            // Evento del botón Volver
            btnVolver.Click += BtnVolver_Click;
        }

        private void CargarCombos()
        {
            try
            {
                // Obtener todos los tipos de servicio desde la controladora
                var tiposServicio = ControladoraTiposServicio.Instancia.getAllTiposServicio();
                var tiposVehiculos = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculoActivos();
                comboVehiculo.Items.Clear();
                comboServicio.Items.Clear();
                comboVehiculo.DataSource = tiposVehiculos;
                comboServicio.DataSource = tiposServicio;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de servicio: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTarifas()
        {
            try
            {
                // Obtener todas las tarifas
                var tarifas = ControladoraTarifasServicio.Instancia.getAllTarifas();

                // Actualizar el DataGridView
                ActualizarDataGridView(tarifas.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tarifas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbmTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnActuales_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener solo las tarifas vigentes
                var tarifasActuales = ControladoraTarifasServicio.Instancia.getAllTarifasActuales();

                if (tarifasActuales.Count > 0)
                {
                    ActualizarDataGridView(tarifasActuales.ToList());
                    MessageBox.Show($"Se encontraron {tarifasActuales.Count} tarifa(s) vigente(s).",
                        "Tarifas Actuales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ActualizarDataGridView(new List<TarifaServicio>());
                    MessageBox.Show("No se encontraron tarifas vigentes.",
                        "Tarifas Actuales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tarifas actuales: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una tarifa para eliminar.",
                        "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tarifaSeleccionada = dataGridView1.SelectedRows[0].DataBoundItem as TarifaServicio;

                if (tarifaSeleccionada == null)
                {
                    MessageBox.Show("Error al obtener la tarifa seleccionada.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string mensaje = $"¿Está seguro de eliminar la siguiente tarifa?\n\n" +
                                $"Servicio: {tarifaSeleccionada.ServicioVehiculo.Servicio.Descripcion}\n" +
                                $"Vehículo: {tarifaSeleccionada.ServicioVehiculo.Vehiculo.NombreVehiculo}\n" +
                                $"Precio: ${tarifaSeleccionada.Precio:N2}\n" +
                                $"Vigente: {(tarifaSeleccionada.Vigente ? "Sí" : "No")}";

                var confirmacion = MessageBox.Show(mensaje, "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Intentar eliminar la tarifa
                    string resultado = ControladoraTarifasServicio.Instancia
                        .EliminarTarifa(tarifaSeleccionada);

                    // Verificar si fue exitoso
                    if (resultado.Contains("exitosamente"))
                    {
                        MessageBox.Show(resultado, "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar la grilla
                        CargarTarifas();
                    }
                    else
                    {
                        MessageBox.Show(resultado, "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la tarifa: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
        }

        private void ActualizarDataGridView(List<TarifaServicio> tarifas)
        {
            // Limpiar la selección actual
            dataGridView1.DataSource = null;

            // Asignar la nueva fuente de datos
            tarifaBindingSource.DataSource = tarifas;
            dataGridView1.DataSource = tarifaBindingSource;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormTarifaServicio();
            form.ShowDialog();
        }

        private void btnFiltrado_Click(object sender, EventArgs e)
        {
            var tipoServicio = (TipoServicio)comboServicio.SelectedItem;
            var tipoVehiculo = (TipoVehiculo)comboVehiculo.SelectedItem;
            var tarifas = ControladoraTarifasServicio.Instancia.getAllTarifasByServicioVehiculo(tipoServicio, tipoVehiculo);

            ActualizarDataGridView(tarifas.ToList());
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            CargarTarifas();
        }

        private void FormTarifasServicios_Load(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar Tarifas"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
        }
    }
}