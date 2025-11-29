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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            comboBox1.Location = new Point(301, 34);
            comboBox1.Margin = new Padding(6, 5, 6, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 36);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtpatente
            // 
            txtpatente.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpatente.Location = new Point(460, 205);
            txtpatente.Margin = new Padding(6, 5, 6, 5);
            txtpatente.Name = "txtpatente";
            txtpatente.Size = new Size(304, 36);
            txtpatente.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(30, 37);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 5;
            label1.Text = "Tipo de vehiculo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(37, 210);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 9;
            label5.Text = "Patente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HoraActual);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtManual);
            groupBox1.Controls.Add(CbxManual);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtpatente);
            groupBox1.Location = new Point(20, 70);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(803, 532);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // HoraActual
            // 
            HoraActual.AutoSize = true;
            HoraActual.Font = new Font("Microsoft Tai Le", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HoraActual.ForeColor = Color.Maroon;
            HoraActual.Location = new Point(264, 60);
            HoraActual.Margin = new Padding(6, 0, 6, 0);
            HoraActual.Name = "HoraActual";
            HoraActual.Size = new Size(0, 53);
            HoraActual.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(37, 77);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 42;
            label2.Text = "Hora Actual:";
            // 
            // txtManual
            // 
            txtManual.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtManual.Location = new Point(460, 443);
            txtManual.Margin = new Padding(6, 5, 6, 5);
            txtManual.Name = "txtManual";
            txtManual.Size = new Size(304, 36);
            txtManual.TabIndex = 22;
            txtManual.Visible = false;
            // 
            // CbxManual
            // 
            CbxManual.AutoSize = true;
            CbxManual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CbxManual.ForeColor = SystemColors.ButtonFace;
            CbxManual.Location = new Point(43, 447);
            CbxManual.Margin = new Padding(6, 5, 6, 5);
            CbxManual.Name = "CbxManual";
            CbxManual.Size = new Size(200, 33);
            CbxManual.TabIndex = 21;
            CbxManual.Text = "Carga Manual";
            CbxManual.UseVisualStyleBackColor = true;
            CbxManual.CheckedChanged += CbxManual_CheckedChanged;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(48, 30, 35);
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.ForeColor = SystemColors.ButtonFace;
            btncancelar.Location = new Point(1171, 612);
            btncancelar.Margin = new Padding(6, 5, 6, 5);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(210, 54);
            btncancelar.TabIndex = 12;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(25, 42, 75);
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaceptar.ForeColor = SystemColors.ButtonFace;
            btnaceptar.Location = new Point(19, 612);
            btnaceptar.Margin = new Padding(6, 5, 6, 5);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(210, 54);
            btnaceptar.TabIndex = 13;
            btnaceptar.Text = "Aceptar";
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
            LabelNoLugar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNoLugar.ForeColor = Color.Red;
            LabelNoLugar.Location = new Point(1171, 48);
            LabelNoLugar.Margin = new Padding(4, 0, 4, 0);
            LabelNoLugar.Name = "LabelNoLugar";
            LabelNoLugar.Size = new Size(184, 31);
            LabelNoLugar.TabIndex = 14;
            LabelNoLugar.Text = "No hay espacio!";
            LabelNoLugar.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(25, 42, 75);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreEspacioDataGridViewTextBoxColumn, capacidadDataGridViewTextBoxColumn, ocupacionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = espacioBindingSource;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(857, 85);
            dataGridView1.Margin = new Padding(6, 5, 6, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(524, 517);
            dataGridView1.TabIndex = 34;
            // 
            // nombreEspacioDataGridViewTextBoxColumn
            // 
            nombreEspacioDataGridViewTextBoxColumn.DataPropertyName = "NombreEspacio";
            nombreEspacioDataGridViewTextBoxColumn.HeaderText = "NombreEspacio";
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
            ocupacionDataGridViewTextBoxColumn.HeaderText = "Ocupacion";
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
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(857, 48);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(259, 28);
            label4.TabIndex = 35;
            label4.Text = "Espacio de parqueo:";
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1400, 682);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(LabelNoLugar);
            Controls.Add(btnaceptar);
            Controls.Add(btncancelar);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
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
    }
}