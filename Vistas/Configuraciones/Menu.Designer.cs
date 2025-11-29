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
            fechaHoraEmisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarifaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ticketBindingSource = new BindingSource(components);
            btnsalida = new Button();
            txtcapacidad = new TextBox();
            BtnTickets = new Button();
            txtconfiguracion = new Button();
            btnentrada = new Button();
            label1 = new Label();
            panel1 = new Panel();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.FromArgb(25, 42, 75);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaHoraEmisionDataGridViewTextBoxColumn, patenteDataGridViewTextBoxColumn, tarifaDataGridViewTextBoxColumn, estadiaDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ticketBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(460, 56);
            dataGridView1.Margin = new Padding(6, 5, 6, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(1300, 866);
            dataGridView1.TabIndex = 0;
            // 
            // fechaHoraEmisionDataGridViewTextBoxColumn
            // 
            fechaHoraEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraEmision";
            fechaHoraEmisionDataGridViewTextBoxColumn.HeaderText = "FechaHoraEmision";
            fechaHoraEmisionDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaHoraEmisionDataGridViewTextBoxColumn.Name = "fechaHoraEmisionDataGridViewTextBoxColumn";
            fechaHoraEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            patenteDataGridViewTextBoxColumn.MinimumWidth = 8;
            patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            patenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifaDataGridViewTextBoxColumn
            // 
            tarifaDataGridViewTextBoxColumn.DataPropertyName = "Tarifa";
            tarifaDataGridViewTextBoxColumn.HeaderText = "Tarifa";
            tarifaDataGridViewTextBoxColumn.MinimumWidth = 8;
            tarifaDataGridViewTextBoxColumn.Name = "tarifaDataGridViewTextBoxColumn";
            tarifaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadiaDataGridViewTextBoxColumn
            // 
            estadiaDataGridViewTextBoxColumn.DataPropertyName = "Estadia";
            estadiaDataGridViewTextBoxColumn.HeaderText = "Estadia";
            estadiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            estadiaDataGridViewTextBoxColumn.Name = "estadiaDataGridViewTextBoxColumn";
            estadiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(MODELO.Ticket);
            // 
            // btnsalida
            // 
            btnsalida.BackColor = Color.FromArgb(75, 10, 30);
            btnsalida.FlatStyle = FlatStyle.Flat;
            btnsalida.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalida.ForeColor = SystemColors.ButtonFace;
            btnsalida.Location = new Point(6, 306);
            btnsalida.Margin = new Padding(6, 5, 6, 5);
            btnsalida.Name = "btnsalida";
            btnsalida.Size = new Size(436, 113);
            btnsalida.TabIndex = 2;
            btnsalida.Text = "Salida";
            btnsalida.UseVisualStyleBackColor = false;
            btnsalida.Click += btnsalida_Click;
            // 
            // txtcapacidad
            // 
            txtcapacidad.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtcapacidad.ForeColor = Color.Maroon;
            txtcapacidad.Location = new Point(194, 30);
            txtcapacidad.Margin = new Padding(6, 5, 6, 5);
            txtcapacidad.Name = "txtcapacidad";
            txtcapacidad.ReadOnly = true;
            txtcapacidad.Size = new Size(270, 36);
            txtcapacidad.TabIndex = 5;
            // 
            // BtnTickets
            // 
            BtnTickets.BackColor = Color.FromArgb(35, 32, 39);
            BtnTickets.FlatStyle = FlatStyle.Flat;
            BtnTickets.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTickets.ForeColor = SystemColors.ButtonFace;
            BtnTickets.Location = new Point(6, 540);
            BtnTickets.Margin = new Padding(6, 5, 6, 5);
            BtnTickets.Name = "BtnTickets";
            BtnTickets.Size = new Size(436, 113);
            BtnTickets.TabIndex = 7;
            BtnTickets.Text = "Busqueda Tickets";
            BtnTickets.UseVisualStyleBackColor = false;
            BtnTickets.Click += BtnTickets_Click;
            // 
            // txtconfiguracion
            // 
            txtconfiguracion.BackColor = Color.FromArgb(35, 32, 39);
            txtconfiguracion.FlatStyle = FlatStyle.Flat;
            txtconfiguracion.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtconfiguracion.ForeColor = Color.Snow;
            txtconfiguracion.Location = new Point(0, 663);
            txtconfiguracion.Margin = new Padding(6, 5, 6, 5);
            txtconfiguracion.Name = "txtconfiguracion";
            txtconfiguracion.Size = new Size(442, 113);
            txtconfiguracion.TabIndex = 8;
            txtconfiguracion.Text = "Actualizar tarifas";
            txtconfiguracion.UseVisualStyleBackColor = false;
            txtconfiguracion.Click += txtconfiguracion_Click;
            // 
            // btnentrada
            // 
            btnentrada.BackColor = Color.FromArgb(20, 38, 44);
            btnentrada.CausesValidation = false;
            btnentrada.FlatStyle = FlatStyle.Flat;
            btnentrada.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnentrada.ForeColor = SystemColors.ButtonFace;
            btnentrada.Location = new Point(6, 183);
            btnentrada.Margin = new Padding(6, 5, 6, 5);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(436, 113);
            btnentrada.TabIndex = 9;
            btnentrada.Text = "Entrada rapida";
            btnentrada.UseVisualStyleBackColor = false;
            btnentrada.Click += btnentrada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(6, 37);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 11;
            label1.Text = "Capacidad :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 75);
            panel1.Controls.Add(BtnAbonados);
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(picCochera);
            panel1.Controls.Add(btnentrada);
            panel1.Controls.Add(btnsalida);
            panel1.Controls.Add(BtnTickets);
            panel1.Controls.Add(txtconfiguracion);
            panel1.ForeColor = Color.Aquamarine;
            panel1.Location = new Point(-9, -3);
            panel1.Margin = new Padding(6, 5, 6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 1300);
            panel1.TabIndex = 12;
            // 
            // BtnAbonados
            // 
            BtnAbonados.BackColor = Color.FromArgb(35, 32, 39);
            BtnAbonados.FlatStyle = FlatStyle.Flat;
            BtnAbonados.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAbonados.ForeColor = Color.Snow;
            BtnAbonados.Location = new Point(-1, 786);
            BtnAbonados.Margin = new Padding(6, 5, 6, 5);
            BtnAbonados.Name = "BtnAbonados";
            BtnAbonados.Size = new Size(443, 113);
            BtnAbonados.TabIndex = 18;
            BtnAbonados.Text = "Planes mensuales";
            BtnAbonados.UseVisualStyleBackColor = false;
            BtnAbonados.Click += BtnAbonados_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.FromArgb(48, 30, 35);
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracion.ForeColor = Color.Snow;
            btnConfiguracion.Location = new Point(6, 909);
            btnConfiguracion.Margin = new Padding(6, 5, 6, 5);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(436, 113);
            btnConfiguracion.TabIndex = 17;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // picCochera
            // 
            picCochera.Image = (Image)resources.GetObject("picCochera.Image");
            picCochera.Location = new Point(145, 17);
            picCochera.Margin = new Padding(6, 5, 6, 5);
            picCochera.Name = "picCochera";
            picCochera.Size = new Size(150, 140);
            picCochera.SizeMode = PictureBoxSizeMode.StretchImage;
            picCochera.TabIndex = 15;
            picCochera.TabStop = false;
            picCochera.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtcapacidad);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(460, 932);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(1303, 243);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(1663, 19);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 33);
            label3.TabIndex = 17;
            label3.Text = "Menu:";
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(MODELO.Tarifa);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(48, 30, 35);
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, herramientasToolStripMenuItem, ayudaToolStripMenuItem, verReportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 1162);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1778, 42);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.CheckOnClick = true;
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiposDeVehiculoToolStripMenuItem, metodoDePagoToolStripMenuItem, tarifasToolStripMenuItem, descuentosToolStripMenuItem, espaciosDeParqueoToolStripMenuItem });
            archivoToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(203, 36);
            archivoToolStripMenuItem.Text = "&Configuraciones";
            // 
            // tiposDeVehiculoToolStripMenuItem
            // 
            tiposDeVehiculoToolStripMenuItem.BackColor = SystemColors.HighlightText;
            tiposDeVehiculoToolStripMenuItem.Name = "tiposDeVehiculoToolStripMenuItem";
            tiposDeVehiculoToolStripMenuItem.Size = new Size(337, 40);
            tiposDeVehiculoToolStripMenuItem.Text = "Tipos de vehiculo";
            tiposDeVehiculoToolStripMenuItem.Click += tiposDeVehiculoToolStripMenuItem_Click;
            // 
            // metodoDePagoToolStripMenuItem
            // 
            metodoDePagoToolStripMenuItem.BackColor = SystemColors.HighlightText;
            metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            metodoDePagoToolStripMenuItem.Size = new Size(337, 40);
            metodoDePagoToolStripMenuItem.Text = "Metodos de pago";
            metodoDePagoToolStripMenuItem.Click += metodoDePagoToolStripMenuItem_Click;
            // 
            // tarifasToolStripMenuItem
            // 
            tarifasToolStripMenuItem.BackColor = SystemColors.HighlightText;
            tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            tarifasToolStripMenuItem.Size = new Size(337, 40);
            tarifasToolStripMenuItem.Text = "Tarifas";
            tarifasToolStripMenuItem.Click += tarifasToolStripMenuItem_Click;
            // 
            // descuentosToolStripMenuItem
            // 
            descuentosToolStripMenuItem.BackColor = SystemColors.HighlightText;
            descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            descuentosToolStripMenuItem.Size = new Size(337, 40);
            descuentosToolStripMenuItem.Text = "Descuentos";
            descuentosToolStripMenuItem.Click += descuentosToolStripMenuItem_Click;
            // 
            // espaciosDeParqueoToolStripMenuItem
            // 
            espaciosDeParqueoToolStripMenuItem.BackColor = SystemColors.HighlightText;
            espaciosDeParqueoToolStripMenuItem.Name = "espaciosDeParqueoToolStripMenuItem";
            espaciosDeParqueoToolStripMenuItem.Size = new Size(337, 40);
            espaciosDeParqueoToolStripMenuItem.Text = "Espacios de parqueo";
            espaciosDeParqueoToolStripMenuItem.Click += espaciosDeParqueoToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.CheckOnClick = true;
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gruposToolStripMenuItem, usuariosToolStripMenuItem });
            editarToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(138, 36);
            editarToolStripMenuItem.Text = "Seguridad";
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(208, 40);
            gruposToolStripMenuItem.Text = "Grupos";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(208, 40);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.CheckOnClick = true;
            herramientasToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.ShowShortcutKeys = false;
            herramientasToolStripMenuItem.Size = new Size(202, 36);
            herramientasToolStripMenuItem.Text = "&Salir del sistema";
            herramientasToolStripMenuItem.Click += herramientasToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.CheckOnClick = true;
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, cambiarClaveToolStripMenuItem, misDatosToolStripMenuItem });
            ayudaToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(120, 36);
            ayudaToolStripMenuItem.Text = "Mi perfil";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(267, 40);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesión";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // cambiarClaveToolStripMenuItem
            // 
            cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            cambiarClaveToolStripMenuItem.Size = new Size(267, 40);
            cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            cambiarClaveToolStripMenuItem.Click += cambiarClaveToolStripMenuItem_Click;
            // 
            // misDatosToolStripMenuItem
            // 
            misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            misDatosToolStripMenuItem.Size = new Size(267, 40);
            misDatosToolStripMenuItem.Text = "Mis datos";
            misDatosToolStripMenuItem.Click += misDatosToolStripMenuItem_Click;
            // 
            // verReportesToolStripMenuItem
            // 
            verReportesToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            verReportesToolStripMenuItem.Name = "verReportesToolStripMenuItem";
            verReportesToolStripMenuItem.Size = new Size(159, 36);
            verReportesToolStripMenuItem.Text = "Ver reportes";
            verReportesToolStripMenuItem.Click += verReportesToolStripMenuItem_Click;
            // 
            // Fecha_Usuario
            // 
            Fecha_Usuario.AutoSize = true;
            Fecha_Usuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Fecha_Usuario.ForeColor = SystemColors.Control;
            Fecha_Usuario.Location = new Point(460, 23);
            Fecha_Usuario.Margin = new Padding(4, 0, 4, 0);
            Fecha_Usuario.Name = "Fecha_Usuario";
            Fecha_Usuario.Size = new Size(146, 28);
            Fecha_Usuario.TabIndex = 12;
            Fecha_Usuario.Text = "Fecha y usuario";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1778, 1204);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Controls.Add(Fecha_Usuario);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn fechaHoraEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarifaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
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
    }
}

