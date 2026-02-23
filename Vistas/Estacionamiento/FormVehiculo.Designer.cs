namespace Vista
{
    partial class FormVehiculo
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
            comboVehiculo = new ComboBox();
            label1 = new Label();
            LabelNoLugar = new Label();
            groupBox1 = new GroupBox();
            HoraActual = new Label();
            label2 = new Label();
            txtManual = new TextBox();
            CbxManual = new CheckBox();
            label5 = new Label();
            txtpatente = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            nombreEspacioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocupacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            espacioBindingSource = new BindingSource(components);
            groupBoxServicios = new GroupBox();
            flowLayoutServicios = new FlowLayoutPanel();
            btnaceptar = new Button();
            btncancelar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).BeginInit();
            groupBoxServicios.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1280, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(371, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🚗 Entrada de Vehículo";
            // 
            // comboVehiculo
            // 
            comboVehiculo.BackColor = Color.FromArgb(45, 45, 48);
            comboVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVehiculo.FlatStyle = FlatStyle.Flat;
            comboVehiculo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboVehiculo.ForeColor = Color.White;
            comboVehiculo.FormattingEnabled = true;
            comboVehiculo.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            comboVehiculo.Location = new Point(30, 107);
            comboVehiculo.Margin = new Padding(0);
            comboVehiculo.Name = "comboVehiculo";
            comboVehiculo.Size = new Size(580, 38);
            comboVehiculo.TabIndex = 1;
            comboVehiculo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 72);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Vehículo";
            // 
            // LabelNoLugar
            // 
            LabelNoLugar.AutoSize = true;
            LabelNoLugar.BackColor = Color.FromArgb(220, 53, 69);
            LabelNoLugar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNoLugar.ForeColor = Color.White;
            LabelNoLugar.Location = new Point(660, 72);
            LabelNoLugar.Margin = new Padding(4, 0, 4, 0);
            LabelNoLugar.Name = "LabelNoLugar";
            LabelNoLugar.Padding = new Padding(15, 8, 15, 8);
            LabelNoLugar.Size = new Size(351, 46);
            LabelNoLugar.TabIndex = 3;
            LabelNoLugar.Text = "⚠️ No hay espacio disponible";
            LabelNoLugar.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(HoraActual);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtManual);
            groupBox1.Controls.Add(CbxManual);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtpatente);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(30, 157);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(600, 359);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "📋 Datos del Vehículo";
            // 
            // HoraActual
            // 
            HoraActual.AutoSize = true;
            HoraActual.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HoraActual.ForeColor = Color.FromArgb(0, 204, 153);
            HoraActual.Location = new Point(185, 155);
            HoraActual.Margin = new Padding(6, 0, 6, 0);
            HoraActual.Name = "HoraActual";
            HoraActual.Size = new Size(166, 48);
            HoraActual.TabIndex = 5;
            HoraActual.Text = "00:00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 165);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 6;
            label2.Text = "Hora Actual";
            // 
            // txtManual
            // 
            txtManual.BackColor = Color.FromArgb(45, 45, 48);
            txtManual.BorderStyle = BorderStyle.FixedSingle;
            txtManual.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtManual.ForeColor = Color.White;
            txtManual.Location = new Point(20, 290);
            txtManual.Margin = new Padding(6, 5, 6, 5);
            txtManual.Name = "txtManual";
            txtManual.PlaceholderText = "Ejemplo: 12:30";
            txtManual.Size = new Size(560, 37);
            txtManual.TabIndex = 7;
            txtManual.Visible = false;
            // 
            // CbxManual
            // 
            CbxManual.AutoSize = true;
            CbxManual.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CbxManual.ForeColor = Color.White;
            CbxManual.Location = new Point(20, 240);
            CbxManual.Margin = new Padding(6, 5, 6, 5);
            CbxManual.Name = "CbxManual";
            CbxManual.Size = new Size(372, 32);
            CbxManual.TabIndex = 8;
            CbxManual.Text = "Seleccionar horario de ingreso manual";
            CbxManual.UseVisualStyleBackColor = true;
            CbxManual.CheckedChanged += CbxManual_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 35);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 9;
            label5.Text = "Patente";
            // 
            // txtpatente
            // 
            txtpatente.BackColor = Color.FromArgb(45, 45, 48);
            txtpatente.BorderStyle = BorderStyle.FixedSingle;
            txtpatente.CharacterCasing = CharacterCasing.Upper;
            txtpatente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtpatente.ForeColor = Color.White;
            txtpatente.Location = new Point(20, 70);
            txtpatente.Margin = new Padding(6, 5, 6, 5);
            txtpatente.MaxLength = 10;
            txtpatente.Name = "txtpatente";
            txtpatente.PlaceholderText = "Ej: ABC123";
            txtpatente.Size = new Size(560, 45);
            txtpatente.TabIndex = 10;
            txtpatente.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(660, 127);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(217, 30);
            label4.TabIndex = 11;
            label4.Text = "Espacios Disponibles";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreEspacioDataGridViewTextBoxColumn, capacidadDataGridViewTextBoxColumn, ocupacionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = espacioBindingSource;
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
            dataGridView1.Location = new Point(660, 157);
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
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(590, 359);
            dataGridView1.TabIndex = 12;
            // 
            // nombreEspacioDataGridViewTextBoxColumn
            // 
            nombreEspacioDataGridViewTextBoxColumn.DataPropertyName = "NombreEspacio";
            nombreEspacioDataGridViewTextBoxColumn.HeaderText = "Espacio";
            nombreEspacioDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombreEspacioDataGridViewTextBoxColumn.Name = "nombreEspacioDataGridViewTextBoxColumn";
            nombreEspacioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            capacidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            capacidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocupacionDataGridViewTextBoxColumn
            // 
            ocupacionDataGridViewTextBoxColumn.DataPropertyName = "Ocupacion";
            ocupacionDataGridViewTextBoxColumn.HeaderText = "Ocupación";
            ocupacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            ocupacionDataGridViewTextBoxColumn.Name = "ocupacionDataGridViewTextBoxColumn";
            ocupacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // espacioBindingSource
            // 
            espacioBindingSource.DataSource = typeof(MODELO.Espacio);
            // 
            // groupBoxServicios
            // 
            groupBoxServicios.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxServicios.Controls.Add(flowLayoutServicios);
            groupBoxServicios.FlatStyle = FlatStyle.Flat;
            groupBoxServicios.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxServicios.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxServicios.Location = new Point(30, 526);
            groupBoxServicios.Margin = new Padding(6, 5, 6, 5);
            groupBoxServicios.Name = "groupBoxServicios";
            groupBoxServicios.Padding = new Padding(15);
            groupBoxServicios.Size = new Size(1220, 200);
            groupBoxServicios.TabIndex = 13;
            groupBoxServicios.TabStop = false;
            groupBoxServicios.Text = "✨ Servicios Adicionales";
            // 
            // flowLayoutServicios
            // 
            flowLayoutServicios.AutoScroll = true;
            flowLayoutServicios.BackColor = Color.FromArgb(37, 37, 38);
            flowLayoutServicios.Dock = DockStyle.Fill;
            flowLayoutServicios.Location = new Point(15, 42);
            flowLayoutServicios.Name = "flowLayoutServicios";
            flowLayoutServicios.Padding = new Padding(5);
            flowLayoutServicios.Size = new Size(1190, 143);
            flowLayoutServicios.TabIndex = 0;
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(40, 167, 69);
            btnaceptar.FlatAppearance.BorderSize = 0;
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnaceptar.ForeColor = Color.White;
            btnaceptar.Location = new Point(30, 736);
            btnaceptar.Margin = new Padding(6, 5, 6, 5);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(180, 50);
            btnaceptar.TabIndex = 14;
            btnaceptar.Text = "✓ Aceptar";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(220, 53, 69);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(1070, 736);
            btncancelar.Margin = new Padding(6, 5, 6, 5);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(180, 50);
            btncancelar.TabIndex = 15;
            btncancelar.Text = "✖ Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1280, 850);
            ControlBox = false;
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Controls.Add(groupBoxServicios);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(LabelNoLugar);
            Controls.Add(label1);
            Controls.Add(comboVehiculo);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVehiculo";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).EndInit();
            groupBoxServicios.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private ComboBox comboVehiculo;
        private Label label1;
        private Label LabelNoLugar;
        private GroupBox groupBox1;
        private Label HoraActual;
        private Label label2;
        private TextBox txtManual;
        private CheckBox CbxManual;
        private Label label5;
        private TextBox txtpatente;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreEspacioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ocupacionDataGridViewTextBoxColumn;
        private BindingSource espacioBindingSource;
        private GroupBox groupBoxServicios;
        private FlowLayoutPanel flowLayoutServicios;
        private Button btnaceptar;
        private Button btncancelar;
        private System.Windows.Forms.Timer timer1;
    }
}