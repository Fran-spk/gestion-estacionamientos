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
            comboBox1 = new ComboBox();
            txtpatente = new TextBox();
            label1 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            HoraActual = new Label();
            label2 = new Label();
            txtManual = new TextBox();
            CbxManual = new CheckBox();
            btncancelar = new Button();
            btnaceptar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            LabelNoLugar = new Label();
            dataGridView1 = new DataGridView();
            nombreEspacioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocupacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            espacioBindingSource = new BindingSource(components);
            label4 = new Label();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(45, 45, 48);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            comboBox1.Location = new Point(30, 120);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(580, 38);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            txtpatente.TabIndex = 3;
            txtpatente.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 85);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Vehículo";
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
            groupBox1.Location = new Point(30, 210);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(600, 359);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Vehículo";
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
            HoraActual.TabIndex = 43;
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
            label2.TabIndex = 42;
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
            txtManual.TabIndex = 22;
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
            CbxManual.Size = new Size(365, 32);
            CbxManual.TabIndex = 21;
            CbxManual.Text = "Selecciona horario de ingreso manual";
            CbxManual.UseVisualStyleBackColor = true;
            CbxManual.CheckedChanged += CbxManual_CheckedChanged;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btncancelar.BackColor = Color.FromArgb(220, 53, 69);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(1050, 589);
            btncancelar.Margin = new Padding(6, 5, 6, 5);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(180, 50);
            btncancelar.TabIndex = 12;
            btncancelar.Text = "✖ Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnaceptar
            // 
            btnaceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnaceptar.BackColor = Color.FromArgb(40, 167, 69);
            btnaceptar.FlatAppearance.BorderSize = 0;
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnaceptar.ForeColor = Color.White;
            btnaceptar.Location = new Point(30, 589);
            btnaceptar.Margin = new Padding(6, 5, 6, 5);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(180, 50);
            btnaceptar.TabIndex = 13;
            btnaceptar.Text = "✓ Aceptar";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // LabelNoLugar
            // 
            LabelNoLugar.AutoSize = true;
            LabelNoLugar.BackColor = Color.FromArgb(220, 53, 69);
            LabelNoLugar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNoLugar.ForeColor = Color.White;
            LabelNoLugar.Location = new Point(660, 120);
            LabelNoLugar.Margin = new Padding(4, 0, 4, 0);
            LabelNoLugar.Name = "LabelNoLugar";
            LabelNoLugar.Padding = new Padding(15, 8, 15, 8);
            LabelNoLugar.Size = new Size(351, 46);
            LabelNoLugar.TabIndex = 14;
            LabelNoLugar.Text = "⚠️ No hay espacio disponible";
            LabelNoLugar.Visible = false;
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
            dataGridView1.Location = new Point(660, 210);
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
            dataGridView1.Size = new Size(570, 359);
            dataGridView1.TabIndex = 34;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(660, 175);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(217, 30);
            label4.TabIndex = 35;
            label4.Text = "Espacios Disponibles";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1260, 60);
            panelHeader.TabIndex = 36;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(326, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = " Entrada de Vehículo";
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1260, 653);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(LabelNoLugar);
            Controls.Add(btnaceptar);
            Controls.Add(btncancelar);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVehiculo";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtpatente;
        private Label label1;
        private Label label5;
        private GroupBox groupBox1;
        private Button btncancelar;
        private Button btnaceptar;
        private TextBox txtManual;
        private CheckBox CbxManual;
        public Label HoraActual;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label LabelNoLugar;
        private DataGridView dataGridView1;
        private Label label4;
        private DataGridViewTextBoxColumn nombreEspacioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ocupacionDataGridViewTextBoxColumn;
        private BindingSource espacioBindingSource;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}