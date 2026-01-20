namespace Vista
{
    partial class FormPlanes
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
            panelSidebar = new Panel();
            BtnVerPago = new Button();
            BtnCobrar = new Button();
            groupBoxFiltros = new GroupBox();
            CbxEstado = new CheckBox();
            label5 = new Label();
            cbxPatente = new ComboBox();
            btnModificar = new Button();
            BtnSalir = new Button();
            btnBaja = new Button();
            BtnCrear = new Button();
            panel3 = new Panel();
            label8 = new Label();
            txtDate = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtDesc = new TextBox();
            TxtTipo = new TextBox();
            TxtNombre = new TextBox();
            label7 = new Label();
            cuotaBindingSource = new BindingSource(components);
            label9 = new Label();
            ticketAbonadoBindingSource = new BindingSource(components);
            ticketBindingSource = new BindingSource(components);
            ticketAbonadoBindingSource1 = new BindingSource(components);
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraEmisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraVencimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actualDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridView1 = new DataGridView();
            panelSidebar.SuspendLayout();
            groupBoxFiltros.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(28, 28, 30);
            panelSidebar.Controls.Add(BtnVerPago);
            panelSidebar.Controls.Add(BtnCobrar);
            panelSidebar.Controls.Add(groupBoxFiltros);
            panelSidebar.Controls.Add(btnModificar);
            panelSidebar.Controls.Add(BtnSalir);
            panelSidebar.Controls.Add(btnBaja);
            panelSidebar.Controls.Add(BtnCrear);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15);
            panelSidebar.Size = new Size(280, 1088);
            panelSidebar.TabIndex = 0;
            // 
            // BtnVerPago
            // 
            BtnVerPago.BackColor = Color.FromArgb(35, 32, 39);
            BtnVerPago.FlatAppearance.BorderSize = 0;
            BtnVerPago.FlatStyle = FlatStyle.Flat;
            BtnVerPago.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerPago.ForeColor = Color.White;
            BtnVerPago.Location = new Point(15, 461);
            BtnVerPago.Margin = new Padding(0);
            BtnVerPago.Name = "BtnVerPago";
            BtnVerPago.Size = new Size(240, 50);
            BtnVerPago.TabIndex = 1;
            BtnVerPago.Text = "💰 Ver pago";
            BtnVerPago.UseVisualStyleBackColor = false;
            BtnVerPago.Click += BtnVerPago_Click;
            // 
            // BtnCobrar
            // 
            BtnCobrar.BackColor = Color.FromArgb(40, 167, 69);
            BtnCobrar.FlatAppearance.BorderSize = 0;
            BtnCobrar.FlatStyle = FlatStyle.Flat;
            BtnCobrar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCobrar.ForeColor = Color.White;
            BtnCobrar.Location = new Point(15, 387);
            BtnCobrar.Margin = new Padding(0);
            BtnCobrar.Name = "BtnCobrar";
            BtnCobrar.Size = new Size(240, 50);
            BtnCobrar.TabIndex = 0;
            BtnCobrar.Text = "💵 Cobrar cuota";
            BtnCobrar.UseVisualStyleBackColor = false;
            BtnCobrar.Click += BtnCobrar_Click;
            // 
            // groupBoxFiltros
            // 
            groupBoxFiltros.Controls.Add(CbxEstado);
            groupBoxFiltros.Controls.Add(label5);
            groupBoxFiltros.Controls.Add(cbxPatente);
            groupBoxFiltros.FlatStyle = FlatStyle.Flat;
            groupBoxFiltros.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFiltros.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxFiltros.Location = new Point(15, 30);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Padding = new Padding(15);
            groupBoxFiltros.Size = new Size(250, 200);
            groupBoxFiltros.TabIndex = 0;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "Filtros";
            // 
            // CbxEstado
            // 
            CbxEstado.AutoSize = true;
            CbxEstado.Checked = true;
            CbxEstado.CheckState = CheckState.Checked;
            CbxEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CbxEstado.ForeColor = Color.White;
            CbxEstado.Location = new Point(20, 155);
            CbxEstado.Name = "CbxEstado";
            CbxEstado.Size = new Size(190, 29);
            CbxEstado.TabIndex = 2;
            CbxEstado.Text = "Solo planes activos";
            CbxEstado.UseVisualStyleBackColor = true;
            CbxEstado.Click += CbxEstado_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 40);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 0;
            label5.Text = "Buscar por Patente";
            // 
            // cbxPatente
            // 
            cbxPatente.BackColor = Color.Gray;
            cbxPatente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPatente.FlatStyle = FlatStyle.System;
            cbxPatente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPatente.ForeColor = Color.White;
            cbxPatente.FormattingEnabled = true;
            cbxPatente.Location = new Point(20, 75);
            cbxPatente.Name = "cbxPatente";
            cbxPatente.Size = new Size(210, 36);
            cbxPatente.TabIndex = 1;
            cbxPatente.SelectedIndexChanged += cbxPatente_SelectedIndexChanged;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(0, 122, 204);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(15, 530);
            btnModificar.Margin = new Padding(0);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(240, 50);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "✏️ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSalir.BackColor = Color.FromArgb(32, 30, 45);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(15, 1018);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(240, 55);
            BtnSalir.TabIndex = 2;
            BtnSalir.Text = "Volver";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(220, 53, 69);
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.ForeColor = Color.White;
            btnBaja.Location = new Point(15, 601);
            btnBaja.Margin = new Padding(0);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(240, 50);
            btnBaja.TabIndex = 3;
            btnBaja.Text = "🗑️ Dar de baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.BackColor = Color.FromArgb(48, 30, 35);
            BtnCrear.FlatAppearance.BorderSize = 0;
            BtnCrear.FlatStyle = FlatStyle.Flat;
            BtnCrear.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCrear.ForeColor = Color.White;
            BtnCrear.Location = new Point(15, 672);
            BtnCrear.Margin = new Padding(0);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(240, 50);
            BtnCrear.TabIndex = 4;
            BtnCrear.Text = "✓ Crear plan";
            BtnCrear.UseVisualStyleBackColor = false;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(28, 28, 30);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TxtDesc);
            panel3.Controls.Add(TxtTipo);
            panel3.Controls.Add(TxtNombre);
            panel3.Location = new Point(292, 41);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(1515, 130);
            panel3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1109, 28);
            label8.Name = "label8";
            label8.Size = new Size(192, 28);
            label8.TabIndex = 6;
            label8.Text = "Fecha inicio de plan";
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Gray;
            txtDate.BorderStyle = BorderStyle.FixedSingle;
            txtDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(1109, 63);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(250, 37);
            txtDate.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(750, 28);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 4;
            label3.Text = "Descuento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(384, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo Vehiculo";
            // 
            // TxtDesc
            // 
            TxtDesc.BackColor = Color.Gray;
            TxtDesc.BorderStyle = BorderStyle.FixedSingle;
            TxtDesc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDesc.ForeColor = Color.White;
            TxtDesc.Location = new Point(750, 63);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.ReadOnly = true;
            TxtDesc.Size = new Size(230, 37);
            TxtDesc.TabIndex = 5;
            // 
            // TxtTipo
            // 
            TxtTipo.BackColor = Color.Gray;
            TxtTipo.BorderStyle = BorderStyle.FixedSingle;
            TxtTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTipo.ForeColor = Color.White;
            TxtTipo.Location = new Point(30, 65);
            TxtTipo.Name = "TxtTipo";
            TxtTipo.ReadOnly = true;
            TxtTipo.Size = new Size(250, 37);
            TxtTipo.TabIndex = 1;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.Gray;
            TxtNombre.BorderStyle = BorderStyle.FixedSingle;
            TxtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.ForeColor = Color.White;
            TxtNombre.Location = new Point(384, 65);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.ReadOnly = true;
            TxtNombre.Size = new Size(250, 37);
            TxtNombre.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 204, 153);
            label7.Location = new Point(292, 9);
            label7.Name = "label7";
            label7.Size = new Size(156, 30);
            label7.TabIndex = 2;
            label7.Text = "Datos del Plan";
            // 
            // cuotaBindingSource
            // 
            cuotaBindingSource.DataSource = typeof(MODELO.Cuota);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(290, 192);
            label9.Name = "label9";
            label9.Size = new Size(81, 30);
            label9.TabIndex = 3;
            label9.Text = "Cuotas";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraEmisionDataGridViewTextBoxColumn
            // 
            fechaHoraEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraEmision";
            fechaHoraEmisionDataGridViewTextBoxColumn.HeaderText = "Emision";
            fechaHoraEmisionDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaHoraEmisionDataGridViewTextBoxColumn.Name = "fechaHoraEmisionDataGridViewTextBoxColumn";
            fechaHoraEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraVencimientoDataGridViewTextBoxColumn
            // 
            fechaHoraVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraVencimiento";
            fechaHoraVencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            fechaHoraVencimientoDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaHoraVencimientoDataGridViewTextBoxColumn.Name = "fechaHoraVencimientoDataGridViewTextBoxColumn";
            fechaHoraVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualDataGridViewCheckBoxColumn
            // 
            actualDataGridViewCheckBoxColumn.DataPropertyName = "Actual";
            actualDataGridViewCheckBoxColumn.HeaderText = "Actual";
            actualDataGridViewCheckBoxColumn.MinimumWidth = 8;
            actualDataGridViewCheckBoxColumn.Name = "actualDataGridViewCheckBoxColumn";
            actualDataGridViewCheckBoxColumn.ReadOnly = true;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { actualDataGridViewCheckBoxColumn, fechaHoraVencimientoDataGridViewTextBoxColumn, fechaHoraEmisionDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cuotaBindingSource;
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
            dataGridView1.Location = new Point(292, 231);
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
            dataGridView1.Size = new Size(1515, 832);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormPlanes
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1920, 1088);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panelSidebar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPlanes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planes";
            Load += FormPlanes_Load_1;
            panelSidebar.ResumeLayout(false);
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private GroupBox groupBoxFiltros;
        private CheckBox CbxEstado;
        private Label label5;
        private ComboBox cbxPatente;
        private Button BtnCobrar;
        private Button BtnVerPago;
        private Button btnModificar;
        private Button btnBaja;
        private Button BtnCrear;
        private Button BtnSalir;
        private Panel panel3;
        private Label label8;
        private TextBox txtDate;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtDesc;
        private TextBox TxtTipo;
        private TextBox TxtNombre;
        private Label label7;
        private Label label9;
        private BindingSource cuotaBindingSource;
        private BindingSource ticketAbonadoBindingSource;
        private BindingSource ticketBindingSource;
        private BindingSource ticketAbonadoBindingSource1;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraVencimientoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn actualDataGridViewCheckBoxColumn;
        private DataGridView dataGridView1;
    }
}