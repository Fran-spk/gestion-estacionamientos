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
            BtnBuscarTodo = new GroupBox();
            BtnSalir = new Button();
            BtnCobrar = new Button();
            btnBaja = new Button();
            dataGridView1 = new DataGridView();
            fechaHoraEmisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Actual = new DataGridViewCheckBoxColumn();
            Estadia = new DataGridViewTextBoxColumn();
            patenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            FechaHoraVencimiento = new DataGridViewTextBoxColumn();
            cuotaBindingSource = new BindingSource(components);
            ticketAbonadoBindingSource = new BindingSource(components);
            panel1 = new Panel();
            CbxEstado = new CheckBox();
            BtnVerPago = new Button();
            BtnCrear = new Button();
            label5 = new Label();
            cbxPatente = new ComboBox();
            btnModificar = new Button();
            TxtTipo = new TextBox();
            TxtNombre = new TextBox();
            panel3 = new Panel();
            label8 = new Label();
            txtDate = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtDesc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            ticketBindingSource = new BindingSource(components);
            ticketAbonadoBindingSource1 = new BindingSource(components);
            BtnBuscarTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscarTodo
            // 
            BtnBuscarTodo.Controls.Add(BtnSalir);
            BtnBuscarTodo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarTodo.Location = new Point(410, 853);
            BtnBuscarTodo.Margin = new Padding(6, 5, 6, 5);
            BtnBuscarTodo.Name = "BtnBuscarTodo";
            BtnBuscarTodo.Padding = new Padding(6, 5, 6, 5);
            BtnBuscarTodo.Size = new Size(1130, 212);
            BtnBuscarTodo.TabIndex = 31;
            BtnBuscarTodo.TabStop = false;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(32, 30, 45);
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSalir.ForeColor = SystemColors.ButtonFace;
            BtnSalir.Location = new Point(843, 122);
            BtnSalir.Margin = new Padding(6, 5, 6, 5);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(277, 78);
            BtnSalir.TabIndex = 8;
            BtnSalir.Text = "Volver";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnCobrar
            // 
            BtnCobrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCobrar.BackColor = Color.FromArgb(75, 10, 30);
            BtnCobrar.CausesValidation = false;
            BtnCobrar.FlatStyle = FlatStyle.Flat;
            BtnCobrar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCobrar.ForeColor = SystemColors.ButtonFace;
            BtnCobrar.Location = new Point(7, 333);
            BtnCobrar.Margin = new Padding(6, 5, 6, 5);
            BtnCobrar.Name = "BtnCobrar";
            BtnCobrar.Size = new Size(387, 98);
            BtnCobrar.TabIndex = 14;
            BtnCobrar.Text = "Cobrar cuota";
            BtnCobrar.UseVisualStyleBackColor = false;
            BtnCobrar.Click += BtnCobrar_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(35, 32, 39);
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaja.ForeColor = SystemColors.ButtonFace;
            btnBaja.Location = new Point(7, 702);
            btnBaja.Margin = new Padding(6, 5, 6, 5);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(387, 98);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Dar de baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaHoraEmisionDataGridViewTextBoxColumn, Actual, Estadia, patenteDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn4, FechaHoraVencimiento });
            dataGridView1.DataSource = cuotaBindingSource;
            dataGridView1.Location = new Point(410, 292);
            dataGridView1.Margin = new Padding(6, 5, 6, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1131, 550);
            dataGridView1.TabIndex = 29;
            // 
            // fechaHoraEmisionDataGridViewTextBoxColumn
            // 
            fechaHoraEmisionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaHoraEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraEmision";
            fechaHoraEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha Emision";
            fechaHoraEmisionDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaHoraEmisionDataGridViewTextBoxColumn.Name = "fechaHoraEmisionDataGridViewTextBoxColumn";
            fechaHoraEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Actual
            // 
            Actual.DataPropertyName = "Actual";
            Actual.HeaderText = "Actual";
            Actual.MinimumWidth = 8;
            Actual.Name = "Actual";
            Actual.ReadOnly = true;
            Actual.Width = 67;
            // 
            // Estadia
            // 
            Estadia.DataPropertyName = "Estadia";
            Estadia.HeaderText = "Estadia";
            Estadia.MinimumWidth = 8;
            Estadia.Name = "Estadia";
            Estadia.ReadOnly = true;
            Estadia.Width = 104;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            patenteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            patenteDataGridViewTextBoxColumn.MinimumWidth = 8;
            patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            patenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDataGridViewTextBoxColumn.Width = 107;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 102;
            // 
            // FechaHoraVencimiento
            // 
            FechaHoraVencimiento.DataPropertyName = "FechaHoraVencimiento";
            FechaHoraVencimiento.HeaderText = "Fecha Vencimiento";
            FechaHoraVencimiento.MinimumWidth = 8;
            FechaHoraVencimiento.Name = "FechaHoraVencimiento";
            FechaHoraVencimiento.ReadOnly = true;
            FechaHoraVencimiento.Width = 179;
            // 
            // cuotaBindingSource
            // 
            cuotaBindingSource.DataSource = typeof(MODELO.Cuota);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(CbxEstado);
            panel1.Controls.Add(BtnVerPago);
            panel1.Controls.Add(BtnCrear);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbxPatente);
            panel1.Controls.Add(BtnCobrar);
            panel1.Controls.Add(btnBaja);
            panel1.Controls.Add(btnModificar);
            panel1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(-7, -3);
            panel1.Margin = new Padding(6, 5, 6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 1088);
            panel1.TabIndex = 32;
            // 
            // CbxEstado
            // 
            CbxEstado.AutoSize = true;
            CbxEstado.Checked = true;
            CbxEstado.CheckState = CheckState.Checked;
            CbxEstado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CbxEstado.ForeColor = SystemColors.ButtonFace;
            CbxEstado.Location = new Point(41, 183);
            CbxEstado.Margin = new Padding(6, 5, 6, 5);
            CbxEstado.Name = "CbxEstado";
            CbxEstado.Size = new Size(309, 33);
            CbxEstado.TabIndex = 48;
            CbxEstado.Text = "Ver solo planes activos";
            CbxEstado.UseVisualStyleBackColor = true;
            CbxEstado.Click += CbxEstado_Click;
            // 
            // BtnVerPago
            // 
            BtnVerPago.BackColor = Color.FromArgb(35, 32, 39);
            BtnVerPago.FlatStyle = FlatStyle.Flat;
            BtnVerPago.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVerPago.ForeColor = SystemColors.ButtonFace;
            BtnVerPago.Location = new Point(6, 443);
            BtnVerPago.Margin = new Padding(6, 5, 6, 5);
            BtnVerPago.Name = "BtnVerPago";
            BtnVerPago.Size = new Size(389, 98);
            BtnVerPago.TabIndex = 47;
            BtnVerPago.Text = "Ver pago";
            BtnVerPago.UseVisualStyleBackColor = false;
            BtnVerPago.Click += BtnVerPago_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.BackColor = Color.FromArgb(48, 30, 35);
            BtnCrear.FlatStyle = FlatStyle.Flat;
            BtnCrear.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCrear.ForeColor = SystemColors.ButtonFace;
            BtnCrear.Location = new Point(6, 812);
            BtnCrear.Margin = new Padding(6, 5, 6, 5);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(389, 98);
            BtnCrear.TabIndex = 46;
            BtnCrear.Text = "Crear plan";
            BtnCrear.UseVisualStyleBackColor = false;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(57, 50);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(259, 28);
            label5.TabIndex = 45;
            label5.Text = "Buscar por Patente:";
            // 
            // cbxPatente
            // 
            cbxPatente.BackColor = Color.Gray;
            cbxPatente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPatente.FlatStyle = FlatStyle.System;
            cbxPatente.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPatente.FormattingEnabled = true;
            cbxPatente.Location = new Point(63, 108);
            cbxPatente.Margin = new Padding(6, 5, 6, 5);
            cbxPatente.Name = "cbxPatente";
            cbxPatente.Size = new Size(267, 36);
            cbxPatente.TabIndex = 34;
            cbxPatente.SelectedIndexChanged += cbxPatente_SelectedIndexChanged;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(35, 32, 39);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(6, 593);
            btnModificar.Margin = new Padding(6, 5, 6, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(389, 98);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // TxtTipo
            // 
            TxtTipo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTipo.Location = new Point(31, 98);
            TxtTipo.Margin = new Padding(6, 5, 6, 5);
            TxtTipo.Name = "TxtTipo";
            TxtTipo.ReadOnly = true;
            TxtTipo.Size = new Size(214, 36);
            TxtTipo.TabIndex = 39;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.Location = new Point(280, 97);
            TxtNombre.Margin = new Padding(6, 5, 6, 5);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.ReadOnly = true;
            TxtNombre.Size = new Size(214, 36);
            TxtNombre.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 30, 45);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TxtDesc);
            panel3.Controls.Add(TxtTipo);
            panel3.Controls.Add(TxtNombre);
            panel3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(411, 62);
            panel3.Margin = new Padding(6, 5, 6, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1130, 175);
            panel3.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(797, 53);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(272, 28);
            label8.TabIndex = 46;
            label8.Text = "Fecha inicio de plan";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(803, 97);
            txtDate.Margin = new Padding(6, 5, 6, 5);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(227, 36);
            txtDate.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(527, 53);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 44;
            label3.Text = "Descuento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(273, 53);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 43;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(26, 53);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 39;
            label1.Text = "Tipo Vehiculo";
            // 
            // TxtDesc
            // 
            TxtDesc.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDesc.Location = new Point(533, 97);
            TxtDesc.Margin = new Padding(6, 5, 6, 5);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.ReadOnly = true;
            TxtDesc.Size = new Size(227, 36);
            TxtDesc.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Juice ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.RosyBrown;
            label6.Location = new Point(1449, 17);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 32);
            label6.TabIndex = 37;
            label6.Text = "Planes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(406, 20);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 28);
            label7.TabIndex = 45;
            label7.Text = "Datos del Plan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(406, 250);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 28);
            label9.TabIndex = 46;
            label9.Text = "Cuotas";
            // 
            // FormPlanes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1561, 1077);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(BtnBuscarTodo);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormPlanes";
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            Load += FormPlanes_Load_1;
            BtnBuscarTodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource ticketBindingSource;
        private GroupBox BtnBuscarTodo;
        private Button BtnSalir;
        private Button BtnCobrar;
        private Button btnBaja;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnModificar;
        private ComboBox cbxPatente;
        private TextBox TxtTipo;
        private TextBox TxtNombre;
        private Panel panel3;
        private TextBox TxtDesc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private Label label6;
        private BindingSource ticketAbonadoBindingSource;
        private BindingSource ticketAbonadoBindingSource1;
        private DataGridViewTextBoxColumn numeroPlanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCobroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDescuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarifaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioFinalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaCobroDataGridViewTextBoxColumn;
        private Label label7;
        private Button BtnCrear;
        private Button BtnVerPago;
        private Label label8;
        private TextBox txtDate;
        private Label label9;
        private BindingSource cuotaBindingSource;
        private CheckBox CbxEstado;
        private DataGridViewTextBoxColumn fechaHoraEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn FechaHoraVencimiento;
        private DataGridViewCheckBoxColumn Actual;
        private DataGridViewTextBoxColumn Estadia;
    }
}