using Controladora;
using MODELO;
using Modelo_Ids;
using Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Vista.Estacionamiento
{
    public partial class FormTarifaServicio : Form
    {
        private TarifaServicio tarifaActual;

        public FormTarifaServicio()
        {
            InitializeComponent();
            CargarCombos();
        }


        private void CargarCombos()
        {
            try
            {
                var vehiculos = ControladoraTiposVehiculo.Instancia.getAllTiposVehiculo();
                comboVehiculo.Items.Clear();
                comboVehiculo.DisplayMember = "Nombre";
                comboVehiculo.ValueMember = "TipoVehiculoId";

                foreach (var vehiculo in vehiculos)
                {
                    comboVehiculo.Items.Add(vehiculo);
                }

                var servicios = ControladoraTiposServicio.Instancia.getAllTiposServicioActivos();
                comboServicio.Items.Clear();
                comboServicio.DisplayMember = "Nombre";
                comboServicio.ValueMember = "TipoServicioId";

                foreach (var servicio in servicios)
                {
                    comboServicio.Items.Add(servicio);
                }

                // No seleccionar nada por defecto
                comboVehiculo.SelectedIndex = -1;
                comboServicio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVehiculo.SelectedIndex != -1 && comboServicio.SelectedIndex != -1)
            {
                CargarUltimaTarifa();
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void CargarServicioVehiculo(TarifaServicio tarifa)
        {
            chkVigente.Checked = tarifa.ServicioVehiculo.EsActivo;
            txtTiempoEstimado.Text = tarifa.ServicioVehiculo.TiempoEstimado.ToString();
        }

        private void CargarUltimaTarifa()
        {
            try
            {
                var vehiculoSeleccionado = (TipoVehiculo)comboVehiculo.SelectedItem;
                var servicioSeleccionado = (TipoServicio)comboServicio.SelectedItem;

                if (vehiculoSeleccionado == null || servicioSeleccionado == null)
                    return;

                var tarifasFiltradas = ControladoraTarifasServicio.Instancia.getAllTarifasByServicioVehiculo(servicioSeleccionado, vehiculoSeleccionado);
                var ultimaTarifa = tarifasFiltradas.FirstOrDefault(x=>x.Vigente);
                if (ultimaTarifa != null)
                {
                    CargarServicioVehiculo(ultimaTarifa);

                    if (ultimaTarifa != null)
                    {
                        txtPrecio.Text = ultimaTarifa.Precio.ToString("F2");
                    }
                    else
                    {
                        txtPrecio.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Configure el tiempo estimado para este servicio y vehículo.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.Text = "";
                    txtTiempoEstimado.Text = "";
                    tarifaActual = null;
                    chkVigente.Checked = true;
                }

                txtPrecio.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tarifa: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Gestionar Tarifas"))
            {
                MessageBox.Show("Necesita permisos");
                this.Close();
            }
            try
            {
                // Validaciones
                if (comboVehiculo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de vehículo.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboServicio.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de servicio.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a cero.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    return;
                }

                if (!double.TryParse(txtTiempoEstimado.Text, out double tiempoEstimado) || tiempoEstimado <= 0)
                {
                    MessageBox.Show("El tiempo estimado debe ser mayor a cero.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTiempoEstimado.Focus();
                    return;
                }

                // Verificar si el precio es igual al actual
                if (tarifaActual != null && tarifaActual.Precio == precio)
                {
                    MessageBox.Show("El precio ingresado es igual al actual. No se realizarán cambios.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirmación
                var confirmacion = MessageBox.Show(
                    "¿Desea guardar la tarifa?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion != DialogResult.Yes)
                    return;

                // Obtener datos del formulario
                var vehiculoSeleccionado = (TipoVehiculo)comboVehiculo.SelectedItem;
                var servicioSeleccionado = (TipoServicio)comboServicio.SelectedItem;

                // Buscar tarifas existentes para esta combinación
                var tarifasBysSerVehi = ControladoraTarifasServicio.Instancia
                    .getAllTarifasByServicioVehiculo(servicioSeleccionado, vehiculoSeleccionado);

                ServicioVehiculo servicioVehiculo;

                // Si existen tarifas, reutilizar y actualizar el ServicioVehiculo
                if (tarifasBysSerVehi != null && tarifasBysSerVehi.Any())
                {
                    servicioVehiculo = tarifasBysSerVehi.First().ServicioVehiculo;

                    // Actualizar las propiedades con los nuevos valores del formulario
                    servicioVehiculo.EsActivo = chkVigente.Checked;
                    servicioVehiculo.TiempoEstimado = tiempoEstimado;
                }
                else
                {
                    // Si no existe, crear uno nuevo
                    servicioVehiculo = new ServicioVehiculo
                    {
                        Vehiculo = vehiculoSeleccionado,
                        Servicio = servicioSeleccionado,
                        EsActivo = chkVigente.Checked,
                        TiempoEstimado = tiempoEstimado
                    };
                }

                // Crear y guardar nueva tarifa
                var nuevaTarifa = TarifaFactory.CrearTarifa(
                    servicioVehiculo: servicioVehiculo,
                    precio: precio
                );

                string resultado = ControladoraTarifasServicio.Instancia
                    .ActualizarTarifa(nuevaTarifa as TarifaServicio);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Está seguro de cancelar la operación?",
                "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtPrecio.Text = "";
            txtTiempoEstimado.Text = "";
            tarifaActual = null;
        }

        private void TxtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void comboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSeleccionado_SelectedIndexChanged(sender, e);
        }

        private void comboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSeleccionado_SelectedIndexChanged(sender, e);
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}