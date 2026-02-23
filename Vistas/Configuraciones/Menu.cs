using Controladora;
using Microsoft.Extensions.Configuration;
using MODELO;
using MODELO.seguridad;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Configuraciones;
using Vista.Estacionamiento;
using Vista.Seguridad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            if (Sesion.Instancia.Perfil != null)
            {
                InitializeComponent();
                Actualizargrilla();
                Fecha_Usuario.Text = DateTime.UtcNow.ToLongDateString();
                Fecha_Usuario.Text += ":  " + Sesion.Instancia.Perfil.PER_NOMBRE;
                ControladoraSesiones.Instancia.OnSesionExpirada = ManejarSesionExpirada;
                ActualizarFechaBackup();
            }
            else
            {
                this.Close();
            }
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void ManejarSesionExpirada(string motivo)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(ManejarSesionExpirada), motivo);
                return;
            }

            MessageBox.Show(motivo, "Sesión Expirada",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Sesion.Instancia.Perfil = null;
            CerrarTodosLosFormsMenosLogin();
        }
        private void CerrarTodosLosFormsMenosLogin()
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(form is FormIniciarSesion))
                {
                    form.Close();
                }
            }
        }


        private void btnentrada_Click(object sender, EventArgs e)
        {
            var carga = new FormVehiculo();
            carga.ShowDialog();
            Actualizargrilla();

        }

        void Actualizargrilla()
        {
            ControladoraTicketsDiarios.Instancia.ActualizarTicketsVencidos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraTicketsDiarios.Instancia.getAllTicketsPendientes();
            CapacidadDiaria();
        }


        void CapacidadDiaria()
        {
            var espacios = Controladora.ControladoraEspacios.Instancia.getAllEspacios();
            int Capacidad = espacios.Sum(cap => cap.Capacidad);
            int Ocupacion = espacios.Sum(oc => oc.Ocupacion);
            if (Capacidad != 0)
            {
                var porcentaje = (double)Ocupacion * 100 / Capacidad;
                txtcapacidad.Text = Math.Round(porcentaje, 2).ToString() + " %";
            }
        }



        private void btnsalida_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                var vehiculo = (Ticket_Diario)dataGridView1.CurrentRow.DataBoundItem;

                var form = new FormPago(vehiculo);
                this.Hide();
                form.ShowDialog();
                this.Show();
                Actualizargrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehiculo");
            }
            Actualizargrilla();
        }


        private void txtconfiguracion_Click(object sender, EventArgs e)
        {
            var form = new formTarifa();
            form.ShowDialog();
            Actualizargrilla();
        }


        private void BtnTickets_Click(object sender, EventArgs e)
        {
            var form = new FormTickets();
            this.Hide();
            form.ShowDialog();
            this.Show();
            Actualizargrilla();
        }




        private void BtnAbonados_Click(object sender, EventArgs e)
        {
            var form = new FormPlanes();
            this.Hide();
            form.ShowDialog();
            this.Show();
            Actualizargrilla();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            var form = new FormConfiguracion();
            this.Hide();
            form.ShowDialog();
            this.Show();
            Actualizargrilla();
        }


        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Desea salir del sistema?", "Atencion", MessageBoxButtons.YesNo);

            if (resul == DialogResult.Yes)
            {
                ControladoraSesiones.Instancia.RegistrarLogout();
                Sesion.Instancia.Perfil = null;
                this.Close();
                Application.Exit();
            }
        }

        private void tiposDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTiposVehiculos();
            form.ShowDialog();
        }

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMetodosDepago();
            form.ShowDialog();
        }

        private void tarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTarifas();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new formDescuentos();
            form.ShowDialog();
        }

        private void espaciosDeParqueoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPlazas();
            form.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Guardar Registro") || !PermisoService.TienePermiso("Eliminar Registro"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }

            var form = new FormUsuarios();
            this.Hide();
            form.ShowDialog();
            this.Show();
            if (Sesion.Instancia.Perfil == null)
            {
                this.Close();
            }
        }


        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Desea cerrar sesión?", "Atencion", MessageBoxButtons.YesNo);

            if (resul == DialogResult.Yes)
            {
                ControladoraSesiones.Instancia.RegistrarLogout();
                Sesion.Instancia.Perfil = null;
                this.Close();
            }
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormClaveNueva();
            form.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUsuarios();
            form.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = new FormGrupos();
            form.ShowDialog();
        }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUsuario(Sesion.Instancia.Perfil);
            form.ShowDialog();
        }

        private void verReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportes = new FormReportes();
            reportes.ShowDialog();
        }


        private void tarifasDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTarifasServicios();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void tiposDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTiposServicio();
            form.ShowDialog();
        }

        private void btnTarifasServicios_Click(object sender, EventArgs e)
        {
            var formservicios = new FormTarifaServicio();
            formservicios.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var vehiculo = (Ticket_Diario)dataGridView1.CurrentRow.DataBoundItem;

                var form = new FormAltaServicioPlan(vehiculo);
                this.Hide();
                form.ShowDialog();
                this.Show();
                Actualizargrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehiculo");
            }
            Actualizargrilla();
        }

        private void btnSalidaByPatente_Click(object sender, EventArgs e)
        {
            var formSalidaPatente = new FormSalidaPorPatente();
            formSalidaPatente.ShowDialog();
        }

        private void generarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Resguardar datos"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            var confirm = MessageBox.Show(
            "Se sobreescribirá el backup anterior. ¿Continuar?",
            "Confirmar backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                var connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");
                BackupService.GenerarBackup(connectionString);
                ActualizarFechaBackup();
                MessageBox.Show("Backup generado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar backup: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarFechaBackup()
        {
            var fecha = BackupService.FechaUltimoBackup();
            backUpLbl.Text = fecha.HasValue
                ? $"Último backup: {fecha:dd/MM/yyyy HH:mm}"
                : "Sin backup previo";
        }


        private void reestaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermisoService.TienePermiso("Restaurar datos"))
            {
                MessageBox.Show("Necesita permisos");
                return;
            }
            if (!BackupService.ExisteBackup())
            {
                MessageBox.Show("No existe un backup previo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Se restaurará la base de datos al estado del último backup. " +
                "Todos los cambios posteriores se perderán. ¿Continuar?",
                "Confirmar restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                var connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");
                BackupService.RestaurarBackup(connectionString);
                MessageBox.Show("Base de datos restaurada correctamente. " +
                    "Reinicie la aplicación.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControladoraSesiones.Instancia.RegistrarLogout();
                this.Close();
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
