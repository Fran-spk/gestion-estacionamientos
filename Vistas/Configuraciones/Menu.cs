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
            }
            else
            {
                this.Close();
            }
            this.Size = new Size(1280, 720); 
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void btnentrada_Click(object sender, EventArgs e)
        {
            var carga = new FormVehiculo();
            carga.ShowDialog();
            Actualizargrilla();

        }

        void Actualizargrilla()
        {
            dataGridView1.DataSource = null;
            ActualizarPendientes();
            dataGridView1.DataSource = ControladoraTicketsBase.Instancia.getAllTicketsPendientes();
            CapacidadDiaria();
        }

        void ActualizarPendientes()
        {
            var tickets = ControladoraTicketsBase.Instancia.getAllTicketsPendientes();
            foreach (var ticket in tickets)
            {
                if (ticket.Estadia is Estadia_Vencida && ticket.Estado.Nombre == "Pendiente")
                {
                    var estado = ControladoraTicketsBase.Instancia.getAllEstados().FirstOrDefault(x => x.Nombre == "Cancelado");
                    if (estado != null)
                    {
                        ticket.Estado = estado;
                        ControladoraTicketsBase.Instancia.ModificarTicket(ticket);
                    }
                }
            }
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
                var vehiculo = (Ticket)dataGridView1.CurrentRow.DataBoundItem;

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
            var Accion = Sesion.Instancia.Acciones.FirstOrDefault(x => x.ACC_NOMBRE == "Guardar Registro" || x.ACC_NOMBRE == "Eliminar Registro");
            if (Accion == null)
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

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }

}
