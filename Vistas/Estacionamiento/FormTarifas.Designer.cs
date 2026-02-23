namespace Vista
{
    partial class FormTarifas
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
            groupBoxFiltro = new GroupBox();
            label1 = new Label();
            cbmTipo = new ComboBox();
            groupBoxAcciones = new GroupBox();
            btnAgregar = new Button();
            BtnActuales = new Button();
            BtnAnular = new Button();
            btnVolver = new Button();
            panelContent = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            tarifaBindingSource = new BindingSource(components);
            PrecioMediaHora = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            PrecioDia = new DataGridViewTextBoxColumn();
            Mes = new DataGridViewTextBoxColumn();
            vigenteDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            tipoVehiculoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraActualizacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            groupBoxFiltro.SuspendLayout();
            groupBoxAcciones.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1471, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💰 Gestión de Tarifas";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(28, 28, 30);
            panelSidebar.Controls.Add(groupBoxFiltro);
            panelSidebar.Controls.Add(groupBoxAcciones);
            panelSidebar.Controls.Add(btnVolver);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15);
            panelSidebar.Size = new Size(280, 790);
            panelSidebar.TabIndex = 1;
            // 
            // groupBoxFiltro
            // 
            groupBoxFiltro.Controls.Add(label1);
            groupBoxFiltro.Controls.Add(cbmTipo);
            groupBoxFiltro.FlatStyle = FlatStyle.Flat;
            groupBoxFiltro.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFiltro.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxFiltro.Location = new Point(15, 30);
            groupBoxFiltro.Name = "groupBoxFiltro";
            groupBoxFiltro.Padding = new Padding(15);
            groupBoxFiltro.Size = new Size(250, 140);
            groupBoxFiltro.TabIndex = 0;
            groupBoxFiltro.TabStop = false;
            groupBoxFiltro.Text = "Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo de vehículo";
            // 
            // cbmTipo
            // 
            cbmTipo.BackColor = Color.Gray;
            cbmTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmTipo.FlatStyle = FlatStyle.System;
            cbmTipo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbmTipo.ForeColor = Color.White;
            cbmTipo.FormattingEnabled = true;
            cbmTipo.Location = new Point(20, 75);
            cbmTipo.Name = "cbmTipo";
            cbmTipo.Size = new Size(210, 36);
            cbmTipo.TabIndex = 1;
            cbmTipo.SelectedIndexChanged += cmbTiempo_SelectedIndexChanged;
            // 
            // groupBoxAcciones
            // 
            groupBoxAcciones.Controls.Add(btnAgregar);
            groupBoxAcciones.Controls.Add(BtnActuales);
            groupBoxAcciones.Controls.Add(BtnAnular);
            groupBoxAcciones.FlatStyle = FlatStyle.Flat;
            groupBoxAcciones.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxAcciones.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxAcciones.Location = new Point(15, 190);
            groupBoxAcciones.Name = "groupBoxAcciones";
            groupBoxAcciones.Padding = new Padding(15);
            groupBoxAcciones.Size = new Size(250, 320);
            groupBoxAcciones.TabIndex = 1;
            groupBoxAcciones.TabStop = false;
            groupBoxAcciones.Text = "Acciones";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(40, 167, 69);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(20, 40);
            btnAgregar.Margin = new Padding(0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(210, 65);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "✓ Actualizar Tarifa";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // BtnActuales
            // 
            BtnActuales.BackColor = Color.FromArgb(0, 122, 204);
            BtnActuales.FlatAppearance.BorderSize = 0;
            BtnActuales.FlatStyle = FlatStyle.Flat;
            BtnActuales.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnActuales.ForeColor = Color.White;
            BtnActuales.Location = new Point(20, 125);
            BtnActuales.Margin = new Padding(0);
            BtnActuales.Name = "BtnActuales";
            BtnActuales.Size = new Size(210, 65);
            BtnActuales.TabIndex = 1;
            BtnActuales.Text = "📋 Ver Actuales";
            BtnActuales.UseVisualStyleBackColor = false;
            BtnActuales.Click += BtnActuales_Click;
            // 
            // BtnAnular
            // 
            BtnAnular.BackColor = Color.FromArgb(220, 53, 69);
            BtnAnular.FlatAppearance.BorderSize = 0;
            BtnAnular.FlatStyle = FlatStyle.Flat;
            BtnAnular.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAnular.ForeColor = Color.White;
            BtnAnular.Location = new Point(20, 210);
            BtnAnular.Margin = new Padding(0);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(210, 65);
            BtnAnular.TabIndex = 2;
            BtnAnular.Text = "🗑 Eliminar";
            BtnAnular.UseVisualStyleBackColor = false;
            BtnAnular.Click += BtnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVolver.BackColor = Color.FromArgb(108, 117, 125);
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
            btnVolver.Click += btnVolver_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(37, 37, 38);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(dataGridView1);
            panelContent.Location = new Point(295, 103);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(1167, 732);
            panelContent.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 122, 204);
            label2.Location = new Point(20, 10);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PrecioMediaHora, Hora, PrecioDia, Mes, vigenteDataGridViewCheckBoxColumn, tipoVehiculoDataGridViewTextBoxColumn, fechaHoraActualizacionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tarifaBindingSource;
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
            dataGridView1.Location = new Point(20, 50);
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
            dataGridView1.Size = new Size(1124, 690);
            dataGridView1.TabIndex = 1;
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(MODELO.TarifaEstacionamiento);
            // 
            // PrecioMediaHora
            // 
            PrecioMediaHora.DataPropertyName = "PrecioMediaHora";
            PrecioMediaHora.HeaderText = "Media Hora";
            PrecioMediaHora.MinimumWidth = 8;
            PrecioMediaHora.Name = "PrecioMediaHora";
            PrecioMediaHora.ReadOnly = true;
            // 
            // Hora
            // 
            Hora.DataPropertyName = "PrecioHora";
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 8;
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            // 
            // PrecioDia
            // 
            PrecioDia.DataPropertyName = "PrecioDia";
            PrecioDia.HeaderText = "Día";
            PrecioDia.MinimumWidth = 8;
            PrecioDia.Name = "PrecioDia";
            PrecioDia.ReadOnly = true;
            // 
            // Mes
            // 
            Mes.DataPropertyName = "PrecioMes";
            Mes.HeaderText = "Mes";
            Mes.MinimumWidth = 8;
            Mes.Name = "Mes";
            Mes.ReadOnly = true;
            // 
            // vigenteDataGridViewCheckBoxColumn
            // 
            vigenteDataGridViewCheckBoxColumn.DataPropertyName = "Vigente";
            vigenteDataGridViewCheckBoxColumn.HeaderText = "Vigente";
            vigenteDataGridViewCheckBoxColumn.MinimumWidth = 8;
            vigenteDataGridViewCheckBoxColumn.Name = "vigenteDataGridViewCheckBoxColumn";
            vigenteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoVehiculo";
            tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "TipoVehiculo";
            tipoVehiculoDataGridViewTextBoxColumn.MinimumWidth = 8;
            tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            tipoVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraActualizacionDataGridViewTextBoxColumn
            // 
            fechaHoraActualizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraActualizacion";
            fechaHoraActualizacionDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaHoraActualizacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaHoraActualizacionDataGridViewTextBoxColumn.Name = "fechaHoraActualizacionDataGridViewTextBoxColumn";
            fechaHoraActualizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTarifas
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1471, 850);
            ControlBox = false;
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Name = "FormTarifas";
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            groupBoxFiltro.ResumeLayout(false);
            groupBoxFiltro.PerformLayout();
            groupBoxAcciones.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelSidebar;
        private GroupBox groupBoxFiltro;
        private Label label1;
        private ComboBox cbmTipo;
        private Button btnVolver;
        private Panel panelContent;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private BindingSource tarifaBindingSource;
        private GroupBox groupBoxAcciones;
        private Button btnAgregar;
        private Button BtnActuales;
        private Button BtnAnular;
        private DataGridViewTextBoxColumn PrecioMediaHora;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn PrecioDia;
        private DataGridViewTextBoxColumn Mes;
        private DataGridViewCheckBoxColumn vigenteDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraActualizacionDataGridViewTextBoxColumn;
    }
}