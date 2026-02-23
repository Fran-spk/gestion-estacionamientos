namespace Vista.Estacionamiento
{
    partial class FormTarifasServicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelSidebar = new Panel();
            btnVolver = new Button();
            groupBoxAcciones = new GroupBox();
            btnTotales = new Button();
            btnAgregar = new Button();
            BtnActuales = new Button();
            BtnAnular = new Button();
            groupBoxFiltro = new GroupBox();
            btnFiltrado = new Button();
            label3 = new Label();
            comboServicio = new ComboBox();
            label1 = new Label();
            comboVehiculo = new ComboBox();
            panelContent = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            servicioVehiculoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vigenteDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fechaHoraActualizacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarifaServicioBindingSource = new BindingSource(components);
            tarifaBindingSource = new BindingSource(components);
            ticketsBindingSource = new BindingSource(components);
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            groupBoxAcciones.SuspendLayout();
            groupBoxFiltro.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarifaServicioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1469, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💰 Gestión de Tarifas de Servicio";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(28, 28, 30);
            panelSidebar.Controls.Add(btnVolver);
            panelSidebar.Controls.Add(groupBoxAcciones);
            panelSidebar.Controls.Add(groupBoxFiltro);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15);
            panelSidebar.Size = new Size(280, 790);
            panelSidebar.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(108, 117, 125);
            btnVolver.Dock = DockStyle.Bottom;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(15, 725);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(250, 50);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "◄ Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // groupBoxAcciones
            // 
            groupBoxAcciones.Controls.Add(btnTotales);
            groupBoxAcciones.Controls.Add(btnAgregar);
            groupBoxAcciones.Controls.Add(BtnActuales);
            groupBoxAcciones.Controls.Add(BtnAnular);
            groupBoxAcciones.FlatStyle = FlatStyle.Flat;
            groupBoxAcciones.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxAcciones.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxAcciones.Location = new Point(15, 338);
            groupBoxAcciones.Name = "groupBoxAcciones";
            groupBoxAcciones.Padding = new Padding(15);
            groupBoxAcciones.Size = new Size(250, 370);
            groupBoxAcciones.TabIndex = 1;
            groupBoxAcciones.TabStop = false;
            groupBoxAcciones.Text = "⚙️ Acciones";
            // 
            // btnTotales
            // 
            btnTotales.BackColor = Color.FromArgb(0, 122, 204);
            btnTotales.FlatAppearance.BorderSize = 0;
            btnTotales.FlatStyle = FlatStyle.Flat;
            btnTotales.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotales.ForeColor = Color.White;
            btnTotales.Location = new Point(20, 200);
            btnTotales.Margin = new Padding(0, 0, 0, 10);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(210, 60);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "📋 Ver Todas";
            btnTotales.UseVisualStyleBackColor = false;
            btnTotales.Click += btnTotales_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(40, 167, 69);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(20, 40);
            btnAgregar.Margin = new Padding(0, 0, 0, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(210, 60);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "✏️ Actualizar Tarifa";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // BtnActuales
            // 
            BtnActuales.BackColor = Color.FromArgb(0, 122, 204);
            BtnActuales.FlatAppearance.BorderSize = 0;
            BtnActuales.FlatStyle = FlatStyle.Flat;
            BtnActuales.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnActuales.ForeColor = Color.White;
            BtnActuales.Location = new Point(20, 120);
            BtnActuales.Margin = new Padding(0, 0, 0, 10);
            BtnActuales.Name = "BtnActuales";
            BtnActuales.Size = new Size(210, 60);
            BtnActuales.TabIndex = 1;
            BtnActuales.Text = "🔍 Ver Actuales";
            BtnActuales.UseVisualStyleBackColor = false;
            // 
            // BtnAnular
            // 
            BtnAnular.BackColor = Color.FromArgb(220, 53, 69);
            BtnAnular.FlatAppearance.BorderSize = 0;
            BtnAnular.FlatStyle = FlatStyle.Flat;
            BtnAnular.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAnular.ForeColor = Color.White;
            BtnAnular.Location = new Point(20, 280);
            BtnAnular.Margin = new Padding(0);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(210, 60);
            BtnAnular.TabIndex = 2;
            BtnAnular.Text = "🗑️ Eliminar";
            BtnAnular.UseVisualStyleBackColor = false;
            // 
            // groupBoxFiltro
            // 
            groupBoxFiltro.Controls.Add(btnFiltrado);
            groupBoxFiltro.Controls.Add(label3);
            groupBoxFiltro.Controls.Add(comboServicio);
            groupBoxFiltro.Controls.Add(label1);
            groupBoxFiltro.Controls.Add(comboVehiculo);
            groupBoxFiltro.FlatStyle = FlatStyle.Flat;
            groupBoxFiltro.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFiltro.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxFiltro.Location = new Point(15, 15);
            groupBoxFiltro.Name = "groupBoxFiltro";
            groupBoxFiltro.Padding = new Padding(15);
            groupBoxFiltro.Size = new Size(250, 310);
            groupBoxFiltro.TabIndex = 0;
            groupBoxFiltro.TabStop = false;
            groupBoxFiltro.Text = "🔎 Filtros";
            // 
            // btnFiltrado
            // 
            btnFiltrado.BackColor = Color.FromArgb(0, 122, 204);
            btnFiltrado.FlatAppearance.BorderSize = 0;
            btnFiltrado.FlatStyle = FlatStyle.Flat;
            btnFiltrado.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrado.ForeColor = Color.White;
            btnFiltrado.Location = new Point(20, 225);
            btnFiltrado.Margin = new Padding(0);
            btnFiltrado.Name = "btnFiltrado";
            btnFiltrado.Size = new Size(210, 60);
            btnFiltrado.TabIndex = 4;
            btnFiltrado.Text = "✅ Aplicar Filtros";
            btnFiltrado.UseVisualStyleBackColor = false;
            btnFiltrado.Click += btnFiltrado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 130);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 2;
            label3.Text = "Tipo de Servicio";
            // 
            // comboServicio
            // 
            comboServicio.BackColor = Color.FromArgb(45, 45, 48);
            comboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboServicio.FlatStyle = FlatStyle.Flat;
            comboServicio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboServicio.ForeColor = Color.White;
            comboServicio.FormattingEnabled = true;
            comboServicio.Location = new Point(20, 165);
            comboServicio.Name = "comboServicio";
            comboServicio.Size = new Size(210, 36);
            comboServicio.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Vehículo";
            // 
            // comboVehiculo
            // 
            comboVehiculo.BackColor = Color.FromArgb(45, 45, 48);
            comboVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVehiculo.FlatStyle = FlatStyle.Flat;
            comboVehiculo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboVehiculo.ForeColor = Color.White;
            comboVehiculo.FormattingEnabled = true;
            comboVehiculo.Location = new Point(20, 75);
            comboVehiculo.Name = "comboVehiculo";
            comboVehiculo.Size = new Size(210, 36);
            comboVehiculo.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(30, 30, 30);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(dataGridView1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(280, 60);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(1189, 790);
            panelContent.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 122, 204);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(233, 30);
            label2.TabIndex = 0;
            label2.Text = "📊 Historial de Tarifas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 48);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { servicioVehiculoDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, vigenteDataGridViewCheckBoxColumn, fechaHoraActualizacionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tarifaServicioBindingSource;
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
            dataGridView1.Location = new Point(20, 60);
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
            dataGridView1.Size = new Size(1149, 710);
            dataGridView1.TabIndex = 1;
            // 
            // servicioVehiculoDataGridViewTextBoxColumn
            // 
            servicioVehiculoDataGridViewTextBoxColumn.DataPropertyName = "ServicioVehiculo";
            servicioVehiculoDataGridViewTextBoxColumn.HeaderText = "Servicio Vehículo";
            servicioVehiculoDataGridViewTextBoxColumn.MinimumWidth = 8;
            servicioVehiculoDataGridViewTextBoxColumn.Name = "servicioVehiculoDataGridViewTextBoxColumn";
            servicioVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.MinimumWidth = 8;
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vigenteDataGridViewCheckBoxColumn
            // 
            vigenteDataGridViewCheckBoxColumn.DataPropertyName = "Vigente";
            vigenteDataGridViewCheckBoxColumn.HeaderText = "Vigente";
            vigenteDataGridViewCheckBoxColumn.MinimumWidth = 8;
            vigenteDataGridViewCheckBoxColumn.Name = "vigenteDataGridViewCheckBoxColumn";
            vigenteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fechaHoraActualizacionDataGridViewTextBoxColumn
            // 
            fechaHoraActualizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraActualizacion";
            fechaHoraActualizacionDataGridViewTextBoxColumn.HeaderText = "Fecha Actualización";
            fechaHoraActualizacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaHoraActualizacionDataGridViewTextBoxColumn.Name = "fechaHoraActualizacionDataGridViewTextBoxColumn";
            fechaHoraActualizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifaServicioBindingSource
            // 
            tarifaServicioBindingSource.DataSource = typeof(MODELO.TarifaServicio);
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(MODELO.TarifaEstacionamiento);
            // 
            // ticketsBindingSource
            // 
            ticketsBindingSource.DataMember = "Tickets";
            ticketsBindingSource.DataSource = tarifaServicioBindingSource;
            // 
            // FormTarifasServicios
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1469, 850);
            ControlBox = false;
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Name = "FormTarifasServicios";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormTarifasServicios_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            groupBoxAcciones.ResumeLayout(false);
            groupBoxFiltro.ResumeLayout(false);
            groupBoxFiltro.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarifaServicioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource tarifaBindingSource;
        private GroupBox groupBoxFiltro;
        private Label label1;
        private ComboBox comboVehiculo;
        private GroupBox groupBoxAcciones;
        private Button btnAgregar;
        private Button BtnActuales;
        private Button BtnAnular;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnVolver;
        private Panel panelSidebar;
        private Label lblTitulo;
        private Panel panelContent;
        private Panel panelHeader;
        private DataGridViewTextBoxColumn servicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private BindingSource tarifaServicioBindingSource;
        private Button btnFiltrado;
        private Label label3;
        private ComboBox comboServicio;
        private Button btnTotales;
        private DataGridViewTextBoxColumn servicioVehiculoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn vigenteDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraActualizacionDataGridViewTextBoxColumn;
        private BindingSource ticketsBindingSource;
    }
}