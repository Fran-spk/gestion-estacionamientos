using System.Windows.Forms;

namespace Vista
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            dataGridView1 = new DataGridView();
            TarifaEstacionamiento = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ticketDiarioBindingSource = new BindingSource(components);
            ticketBindingSource = new BindingSource(components);
            btnsalida = new Button();
            txtcapacidad = new TextBox();
            BtnTickets = new Button();
            txtconfiguracion = new Button();
            btnentrada = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            btnAsignarServicios = new Button();
            button1 = new Button();
            BtnAbonados = new Button();
            btnConfiguracion = new Button();
            picCochera = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            tarifaBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            tiposDeVehiculoToolStripMenuItem = new ToolStripMenuItem();
            metodoDePagoToolStripMenuItem = new ToolStripMenuItem();
            tarifasToolStripMenuItem = new ToolStripMenuItem();
            descuentosToolStripMenuItem = new ToolStripMenuItem();
            espaciosDeParqueoToolStripMenuItem = new ToolStripMenuItem();
            tarifasDeServiciosToolStripMenuItem = new ToolStripMenuItem();
            tiposDeServiciosDispToolStripMenuItem = new ToolStripMenuItem();
            backUpLbl = new ToolStripMenuItem();
            reestaurarToolStripMenuItem = new ToolStripMenuItem();
            generarBackUpToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            gruposToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            cambiarClaveToolStripMenuItem = new ToolStripMenuItem();
            misDatosToolStripMenuItem = new ToolStripMenuItem();
            verReportesToolStripMenuItem = new ToolStripMenuItem();
            Fecha_Usuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketDiarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCochera).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TarifaEstacionamiento, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.DataSource = ticketDiarioBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(50, 50, 50);
            dataGridView1.Location = new Point(295, 100);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1465, 950);
            dataGridView1.TabIndex = 0;
            // 
            // TarifaEstacionamiento
            // 
            TarifaEstacionamiento.DataPropertyName = "TarifaEstacionamiento";
            TarifaEstacionamiento.HeaderText = "Tipo de Vehículo";
            TarifaEstacionamiento.MinimumWidth = 8;
            TarifaEstacionamiento.Name = "TarifaEstacionamiento";
            TarifaEstacionamiento.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FechaHoraEmision";
            dataGridViewTextBoxColumn1.HeaderText = "Fecha hora ingreso";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Patente";
            dataGridViewTextBoxColumn2.HeaderText = "Patente";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Estadia";
            dataGridViewTextBoxColumn3.HeaderText = "Estadia";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ticketDiarioBindingSource
            // 
            ticketDiarioBindingSource.DataSource = typeof(MODELO.Ticket_Diario);
            // 
            // btnsalida
            // 
            btnsalida.BackColor = Color.FromArgb(220, 53, 69);
            btnsalida.FlatAppearance.BorderSize = 0;
            btnsalida.FlatStyle = FlatStyle.Flat;
            btnsalida.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalida.ForeColor = Color.White;
            btnsalida.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalida.Location = new Point(20, 320);
            btnsalida.Margin = new Padding(0);
            btnsalida.Name = "btnsalida";
            btnsalida.Padding = new Padding(15, 0, 0, 0);
            btnsalida.Size = new Size(240, 55);
            btnsalida.TabIndex = 2;
            btnsalida.Text = "       🚗 Salida";
            btnsalida.TextAlign = ContentAlignment.MiddleLeft;
            btnsalida.UseVisualStyleBackColor = false;
            btnsalida.Click += btnsalida_Click;
            // 
            // txtcapacidad
            // 
            txtcapacidad.BackColor = Color.FromArgb(37, 37, 38);
            txtcapacidad.BorderStyle = BorderStyle.None;
            txtcapacidad.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtcapacidad.ForeColor = Color.FromArgb(0, 204, 153);
            txtcapacidad.Location = new Point(160, 35);
            txtcapacidad.Margin = new Padding(6, 5, 6, 5);
            txtcapacidad.Name = "txtcapacidad";
            txtcapacidad.ReadOnly = true;
            txtcapacidad.Size = new Size(150, 38);
            txtcapacidad.TabIndex = 5;
            txtcapacidad.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnTickets
            // 
            BtnTickets.BackColor = Color.FromArgb(52, 58, 64);
            BtnTickets.FlatAppearance.BorderSize = 0;
            BtnTickets.FlatStyle = FlatStyle.Flat;
            BtnTickets.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTickets.ForeColor = Color.White;
            BtnTickets.Location = new Point(20, 773);
            BtnTickets.Margin = new Padding(0);
            BtnTickets.Name = "BtnTickets";
            BtnTickets.Size = new Size(240, 55);
            BtnTickets.TabIndex = 7;
            BtnTickets.Text = "🔍 Buscar Tickets";
            BtnTickets.TextAlign = ContentAlignment.MiddleLeft;
            BtnTickets.UseVisualStyleBackColor = false;
            BtnTickets.Click += BtnTickets_Click;
            // 
            // txtconfiguracion
            // 
            txtconfiguracion.BackColor = Color.FromArgb(52, 58, 64);
            txtconfiguracion.FlatAppearance.BorderSize = 0;
            txtconfiguracion.FlatStyle = FlatStyle.Flat;
            txtconfiguracion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtconfiguracion.ForeColor = Color.White;
            txtconfiguracion.Location = new Point(20, 470);
            txtconfiguracion.Margin = new Padding(0);
            txtconfiguracion.Name = "txtconfiguracion";
            txtconfiguracion.Size = new Size(240, 55);
            txtconfiguracion.TabIndex = 8;
            txtconfiguracion.Text = "💰 Actualizar Tarifas";
            txtconfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            txtconfiguracion.UseVisualStyleBackColor = false;
            txtconfiguracion.Click += txtconfiguracion_Click;
            // 
            // btnentrada
            // 
            btnentrada.BackColor = Color.FromArgb(40, 167, 69);
            btnentrada.CausesValidation = false;
            btnentrada.FlatAppearance.BorderSize = 0;
            btnentrada.FlatStyle = FlatStyle.Flat;
            btnentrada.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnentrada.ForeColor = Color.White;
            btnentrada.Location = new Point(20, 245);
            btnentrada.Margin = new Padding(0);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(240, 55);
            btnentrada.TabIndex = 9;
            btnentrada.Text = "✓ Entrada Rápida";
            btnentrada.TextAlign = ContentAlignment.MiddleLeft;
            btnentrada.UseVisualStyleBackColor = false;
            btnentrada.Click += btnentrada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 38);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 11;
            label1.Text = "Capacidad:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 30);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAsignarServicios);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnAbonados);
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(picCochera);
            panel1.Controls.Add(btnentrada);
            panel1.Controls.Add(btnsalida);
            panel1.Controls.Add(BtnTickets);
            panel1.Controls.Add(txtconfiguracion);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 1080);
            panel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 53, 69);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(20, 849);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(240, 55);
            button2.TabIndex = 21;
            button2.Text = "Salida por patente";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSalidaByPatente_Click;
            // 
            // btnAsignarServicios
            // 
            btnAsignarServicios.BackColor = Color.FromArgb(52, 58, 64);
            btnAsignarServicios.FlatAppearance.BorderSize = 0;
            btnAsignarServicios.FlatStyle = FlatStyle.Flat;
            btnAsignarServicios.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignarServicios.ForeColor = Color.White;
            btnAsignarServicios.Location = new Point(20, 396);
            btnAsignarServicios.Margin = new Padding(0);
            btnAsignarServicios.Name = "btnAsignarServicios";
            btnAsignarServicios.Size = new Size(240, 55);
            btnAsignarServicios.TabIndex = 20;
            btnAsignarServicios.Text = " 🔧 Asignar servicios";
            btnAsignarServicios.TextAlign = ContentAlignment.MiddleLeft;
            btnAsignarServicios.UseVisualStyleBackColor = false;
            btnAsignarServicios.Click += btnServicios_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 58, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 547);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(240, 55);
            button1.TabIndex = 19;
            button1.Text = "💰  Tarifas servicios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnTarifasServicios_Click;
            // 
            // BtnAbonados
            // 
            BtnAbonados.BackColor = Color.FromArgb(52, 58, 64);
            BtnAbonados.FlatAppearance.BorderSize = 0;
            BtnAbonados.FlatStyle = FlatStyle.Flat;
            BtnAbonados.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAbonados.ForeColor = Color.White;
            BtnAbonados.Location = new Point(20, 695);
            BtnAbonados.Margin = new Padding(0);
            BtnAbonados.Name = "BtnAbonados";
            BtnAbonados.Size = new Size(240, 55);
            BtnAbonados.TabIndex = 18;
            BtnAbonados.Text = "📅 Planes Mensuales";
            BtnAbonados.TextAlign = ContentAlignment.MiddleLeft;
            BtnAbonados.UseVisualStyleBackColor = false;
            BtnAbonados.Click += BtnAbonados_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.FromArgb(52, 58, 64);
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.Location = new Point(20, 620);
            btnConfiguracion.Margin = new Padding(0);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(240, 55);
            btnConfiguracion.TabIndex = 17;
            btnConfiguracion.Text = "⚙️ Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // picCochera
            // 
            picCochera.Image = (Image)resources.GetObject("picCochera.Image");
            picCochera.Location = new Point(65, 30);
            picCochera.Margin = new Padding(6, 5, 6, 5);
            picCochera.Name = "picCochera";
            picCochera.Size = new Size(150, 140);
            picCochera.SizeMode = PictureBoxSizeMode.Zoom;
            picCochera.TabIndex = 15;
            picCochera.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(txtcapacidad);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(1237, 5);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(450, 90);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado del Estacionamiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(300, 30);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(271, 45);
            label3.TabIndex = 17;
            label3.Text = "Panel de Control ";
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(MODELO.TarifaEstacionamiento);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(28, 28, 30);
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, herramientasToolStripMenuItem, ayudaToolStripMenuItem, verReportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 1050);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1920, 38);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiposDeVehiculoToolStripMenuItem, metodoDePagoToolStripMenuItem, tarifasToolStripMenuItem, descuentosToolStripMenuItem, espaciosDeParqueoToolStripMenuItem, tarifasDeServiciosToolStripMenuItem, tiposDeServiciosDispToolStripMenuItem, backUpLbl });
            archivoToolStripMenuItem.ForeColor = Color.White;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(183, 32);
            archivoToolStripMenuItem.Text = "⚙️ Configuración";
            // 
            // tiposDeVehiculoToolStripMenuItem
            // 
            tiposDeVehiculoToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            tiposDeVehiculoToolStripMenuItem.ForeColor = Color.White;
            tiposDeVehiculoToolStripMenuItem.Name = "tiposDeVehiculoToolStripMenuItem";
            tiposDeVehiculoToolStripMenuItem.Size = new Size(312, 36);
            tiposDeVehiculoToolStripMenuItem.Text = "Tipos de Vehículo";
            tiposDeVehiculoToolStripMenuItem.Click += tiposDeVehiculoToolStripMenuItem_Click;
            // 
            // metodoDePagoToolStripMenuItem
            // 
            metodoDePagoToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            metodoDePagoToolStripMenuItem.ForeColor = Color.White;
            metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            metodoDePagoToolStripMenuItem.Size = new Size(312, 36);
            metodoDePagoToolStripMenuItem.Text = "Métodos de Pago";
            metodoDePagoToolStripMenuItem.Click += metodoDePagoToolStripMenuItem_Click;
            // 
            // tarifasToolStripMenuItem
            // 
            tarifasToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            tarifasToolStripMenuItem.ForeColor = Color.White;
            tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            tarifasToolStripMenuItem.Size = new Size(312, 36);
            tarifasToolStripMenuItem.Text = "Tarifas";
            tarifasToolStripMenuItem.Click += tarifasToolStripMenuItem_Click;
            // 
            // descuentosToolStripMenuItem
            // 
            descuentosToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            descuentosToolStripMenuItem.ForeColor = Color.White;
            descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            descuentosToolStripMenuItem.Size = new Size(312, 36);
            descuentosToolStripMenuItem.Text = "Descuentos";
            descuentosToolStripMenuItem.Click += descuentosToolStripMenuItem_Click;
            // 
            // espaciosDeParqueoToolStripMenuItem
            // 
            espaciosDeParqueoToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            espaciosDeParqueoToolStripMenuItem.ForeColor = Color.White;
            espaciosDeParqueoToolStripMenuItem.Name = "espaciosDeParqueoToolStripMenuItem";
            espaciosDeParqueoToolStripMenuItem.Size = new Size(312, 36);
            espaciosDeParqueoToolStripMenuItem.Text = "Espacios de Parqueo";
            espaciosDeParqueoToolStripMenuItem.Click += espaciosDeParqueoToolStripMenuItem_Click;
            // 
            // tarifasDeServiciosToolStripMenuItem
            // 
            tarifasDeServiciosToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            tarifasDeServiciosToolStripMenuItem.ForeColor = Color.White;
            tarifasDeServiciosToolStripMenuItem.Name = "tarifasDeServiciosToolStripMenuItem";
            tarifasDeServiciosToolStripMenuItem.Size = new Size(312, 36);
            tarifasDeServiciosToolStripMenuItem.Text = "Tarifas de servicios";
            tarifasDeServiciosToolStripMenuItem.Click += tarifasDeServiciosToolStripMenuItem_Click;
            // 
            // tiposDeServiciosDispToolStripMenuItem
            // 
            tiposDeServiciosDispToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            tiposDeServiciosDispToolStripMenuItem.ForeColor = Color.White;
            tiposDeServiciosDispToolStripMenuItem.Name = "tiposDeServiciosDispToolStripMenuItem";
            tiposDeServiciosDispToolStripMenuItem.Size = new Size(312, 36);
            tiposDeServiciosDispToolStripMenuItem.Text = "Tipos de Servicios disp";
            tiposDeServiciosDispToolStripMenuItem.Click += tiposDeServiciosToolStripMenuItem_Click;
            // 
            // backUpLbl
            // 
            backUpLbl.BackColor = Color.FromArgb(45, 45, 48);
            backUpLbl.DropDownItems.AddRange(new ToolStripItem[] { reestaurarToolStripMenuItem, generarBackUpToolStripMenuItem });
            backUpLbl.ForeColor = Color.White;
            backUpLbl.Name = "backUpLbl";
            backUpLbl.Size = new Size(312, 36);
            backUpLbl.Text = "Back up";
            // 
            // reestaurarToolStripMenuItem
            // 
            reestaurarToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            reestaurarToolStripMenuItem.ForeColor = Color.White;
            reestaurarToolStripMenuItem.Name = "reestaurarToolStripMenuItem";
            reestaurarToolStripMenuItem.Size = new Size(270, 36);
            reestaurarToolStripMenuItem.Text = "Reestaurar";
            reestaurarToolStripMenuItem.Click += reestaurarToolStripMenuItem_Click;
            // 
            // generarBackUpToolStripMenuItem
            // 
            generarBackUpToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            generarBackUpToolStripMenuItem.ForeColor = Color.White;
            generarBackUpToolStripMenuItem.Name = "generarBackUpToolStripMenuItem";
            generarBackUpToolStripMenuItem.Size = new Size(270, 36);
            generarBackUpToolStripMenuItem.Text = "Generar Back up";
            generarBackUpToolStripMenuItem.Click += generarBackUpToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gruposToolStripMenuItem, usuariosToolStripMenuItem });
            editarToolStripMenuItem.ForeColor = Color.White;
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(150, 32);
            editarToolStripMenuItem.Text = "🔒 Seguridad";
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            gruposToolStripMenuItem.ForeColor = Color.White;
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(189, 36);
            gruposToolStripMenuItem.Text = "Grupos";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            usuariosToolStripMenuItem.ForeColor = Color.White;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(189, 36);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.ForeColor = Color.FromArgb(220, 53, 69);
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(139, 32);
            herramientasToolStripMenuItem.Text = "Salir Sistema";
            herramientasToolStripMenuItem.Click += herramientasToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, cambiarClaveToolStripMenuItem, misDatosToolStripMenuItem });
            ayudaToolStripMenuItem.ForeColor = Color.White;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(131, 32);
            ayudaToolStripMenuItem.Text = "👤 Mi Perfil";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            cerrarSesionToolStripMenuItem.ForeColor = Color.White;
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(239, 36);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // cambiarClaveToolStripMenuItem
            // 
            cambiarClaveToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            cambiarClaveToolStripMenuItem.ForeColor = Color.White;
            cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            cambiarClaveToolStripMenuItem.Size = new Size(239, 36);
            cambiarClaveToolStripMenuItem.Text = "Cambiar Clave";
            cambiarClaveToolStripMenuItem.Click += cambiarClaveToolStripMenuItem_Click;
            // 
            // misDatosToolStripMenuItem
            // 
            misDatosToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 48);
            misDatosToolStripMenuItem.ForeColor = Color.White;
            misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            misDatosToolStripMenuItem.Size = new Size(239, 36);
            misDatosToolStripMenuItem.Text = "Mis Datos";
            misDatosToolStripMenuItem.Click += misDatosToolStripMenuItem_Click;
            // 
            // verReportesToolStripMenuItem
            // 
            verReportesToolStripMenuItem.ForeColor = Color.White;
            verReportesToolStripMenuItem.Name = "verReportesToolStripMenuItem";
            verReportesToolStripMenuItem.Size = new Size(137, 32);
            verReportesToolStripMenuItem.Text = "📊 Reportes";
            verReportesToolStripMenuItem.Click += verReportesToolStripMenuItem_Click;
            // 
            // Fecha_Usuario
            // 
            Fecha_Usuario.AutoSize = true;
            Fecha_Usuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Fecha_Usuario.ForeColor = Color.FromArgb(200, 200, 200);
            Fecha_Usuario.Location = new Point(650, 40);
            Fecha_Usuario.Margin = new Padding(4, 0, 4, 0);
            Fecha_Usuario.Name = "Fecha_Usuario";
            Fecha_Usuario.Size = new Size(151, 28);
            Fecha_Usuario.TabIndex = 12;
            Fecha_Usuario.Text = "Fecha y usuario ";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1920, 1088);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Controls.Add(Fecha_Usuario);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Estacionamiento";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketDiarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCochera).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridView dataGridView1;
        private Button btnsalida;
        private TextBox txtcapacidad;
        private Button BtnTickets;
        private Button txtconfiguracion;
        private Button btnentrada;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnConfiguracion;
        private Button BtnAbonados;
        public PictureBox picCochera;
        private Label label3;
        private DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private BindingSource ticketBindingSource;
        private DataGridViewTextBoxColumn tarifaDataGridViewTextBoxColumn;
        private BindingSource tarifaBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem tiposDeVehiculoToolStripMenuItem;
        private ToolStripMenuItem metodoDePagoToolStripMenuItem;
        private ToolStripMenuItem tarifasToolStripMenuItem;
        private ToolStripMenuItem descuentosToolStripMenuItem;
        private ToolStripMenuItem espaciosDeParqueoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private ToolStripMenuItem misDatosToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem verReportesToolStripMenuItem;
        private Label Fecha_Usuario;
        private DataGridViewTextBoxColumn fechaHoraEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private Button btnAsignarServicios;
        private Button button1;
        private ToolStripMenuItem tarifasDeServiciosToolStripMenuItem;
        private ToolStripMenuItem tiposDeServiciosDispToolStripMenuItem;
        private Button button2;
        private DataGridViewTextBoxColumn TarifaEstacionamiento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource ticketDiarioBindingSource;
        private ToolStripMenuItem backUpLbl;
        private ToolStripMenuItem reestaurarToolStripMenuItem;
        private ToolStripMenuItem generarBackUpToolStripMenuItem;
    }
}