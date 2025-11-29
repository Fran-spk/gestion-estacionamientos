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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            BtnAnular = new Button();
            panel2 = new Panel();
            BtnActuales = new Button();
            cbmTipo = new ComboBox();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            TipoVehiculo = new DataGridViewTextBoxColumn();
            PrecioMediaHora = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            PrecioDia = new DataGridViewTextBoxColumn();
            Mes = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarifaBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            btnVolver = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(BtnAnular);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BtnActuales);
            panel1.Controls.Add(cbmTipo);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 652);
            panel1.TabIndex = 24;
            // 
            // BtnAnular
            // 
            BtnAnular.BackColor = Color.FromArgb(35, 32, 39);
            BtnAnular.CausesValidation = false;
            BtnAnular.FlatStyle = FlatStyle.Flat;
            BtnAnular.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnular.ForeColor = SystemColors.ButtonFace;
            BtnAnular.Location = new Point(0, 333);
            BtnAnular.Margin = new Padding(4, 3, 4, 3);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(276, 60);
            BtnAnular.TabIndex = 22;
            BtnAnular.Text = "Eliminar";
            BtnAnular.UseVisualStyleBackColor = false;
            BtnAnular.Click += BtnEliminar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(16, 130);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 1);
            panel2.TabIndex = 21;
            // 
            // BtnActuales
            // 
            BtnActuales.BackColor = Color.FromArgb(35, 32, 39);
            BtnActuales.CausesValidation = false;
            BtnActuales.FlatStyle = FlatStyle.Flat;
            BtnActuales.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnActuales.ForeColor = SystemColors.ButtonFace;
            BtnActuales.Location = new Point(0, 200);
            BtnActuales.Margin = new Padding(4, 3, 4, 3);
            BtnActuales.Name = "BtnActuales";
            BtnActuales.Size = new Size(276, 60);
            BtnActuales.TabIndex = 20;
            BtnActuales.Text = "Seleccionar actuales";
            BtnActuales.UseVisualStyleBackColor = false;
            BtnActuales.Click += BtnActuales_Click;
            // 
            // cbmTipo
            // 
            cbmTipo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmTipo.FormattingEnabled = true;
            cbmTipo.Location = new Point(47, 63);
            cbmTipo.Margin = new Padding(4, 3, 4, 3);
            cbmTipo.Name = "cbmTipo";
            cbmTipo.Size = new Size(180, 27);
            cbmTipo.TabIndex = 19;
            cbmTipo.SelectedIndexChanged += cmbTiempo_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(75, 10, 30);
            btnAgregar.CausesValidation = false;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(0, 267);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(276, 60);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Actualizar Tarifa";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TipoVehiculo, PrecioMediaHora, Hora, PrecioDia, Mes, fechaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tarifaBindingSource;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(286, 38);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Size = new Size(793, 402);
            dataGridView1.TabIndex = 23;
            // 
            // TipoVehiculo
            // 
            TipoVehiculo.DataPropertyName = "TipoVehiculo";
            TipoVehiculo.HeaderText = "TipoVehiculo";
            TipoVehiculo.Name = "TipoVehiculo";
            TipoVehiculo.ReadOnly = true;
            // 
            // PrecioMediaHora
            // 
            PrecioMediaHora.DataPropertyName = "PrecioMediaHora";
            PrecioMediaHora.HeaderText = "Media Hora";
            PrecioMediaHora.Name = "PrecioMediaHora";
            PrecioMediaHora.ReadOnly = true;
            // 
            // Hora
            // 
            Hora.DataPropertyName = "PrecioHora";
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            // 
            // PrecioDia
            // 
            PrecioDia.DataPropertyName = "PrecioDia";
            PrecioDia.HeaderText = "Dia";
            PrecioDia.Name = "PrecioDia";
            PrecioDia.ReadOnly = true;
            // 
            // Mes
            // 
            Mes.DataPropertyName = "PrecioMes";
            Mes.HeaderText = "Mes";
            Mes.Name = "Mes";
            Mes.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(MODELO.Tarifa);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(286, 447);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(793, 182);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(32, 30, 45);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(593, 128);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(194, 47);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Juice ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(1006, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 30;
            label3.Text = "Tarifas:";
            // 
            // FormTarifas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1093, 643);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormTarifas";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnVolver;
        private DataGridViewTextBoxColumn mediahoraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private BindingSource tarifaBindingSource;
        private ComboBox cbmTipo;
        private Button BtnActuales;
        private Label label3;
        private DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private Panel panel2;
        private DataGridViewTextBoxColumn TipoVehiculo;
        private DataGridViewTextBoxColumn PrecioMediaHora;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn PrecioDia;
        private DataGridViewTextBoxColumn Mes;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private Button BtnAnular;
    }
}