namespace Vista
{
    partial class FormPlazas
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
            btncancelar = new Button();
            label1 = new Label();
            cbxTipoVehiculo = new ComboBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnAgregarEspacio = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            BtnQuitarVehi = new Button();
            BtnAgregarVehiculo = new Button();
            listBoxVehiculos = new ListBox();
            espacioBindingSource = new BindingSource(components);
            nombreEspacioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocupacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            disponibilidadDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(32, 30, 45);
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.ForeColor = SystemColors.ButtonFace;
            btncancelar.Location = new Point(703, 401);
            btncancelar.Margin = new Padding(4, 3, 4, 3);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(124, 33);
            btncancelar.TabIndex = 28;
            btncancelar.Text = "Volver";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(607, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 19);
            label1.TabIndex = 26;
            label1.Text = "Vehiculos cargados:";
            // 
            // cbxTipoVehiculo
            // 
            cbxTipoVehiculo.AllowDrop = true;
            cbxTipoVehiculo.BackColor = Color.Gray;
            cbxTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoVehiculo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTipoVehiculo.FormattingEnabled = true;
            cbxTipoVehiculo.Location = new Point(195, 321);
            cbxTipoVehiculo.Margin = new Padding(4, 3, 4, 3);
            cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            cbxTipoVehiculo.Size = new Size(180, 27);
            cbxTipoVehiculo.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreEspacioDataGridViewTextBoxColumn, capacidadDataGridViewTextBoxColumn, ocupacionDataGridViewTextBoxColumn, disponibilidadDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = espacioBindingSource;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(25, 46);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Size = new Size(553, 254);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(25, 24);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(180, 19);
            label5.TabIndex = 34;
            label5.Text = "Espacios de Parqueo";
            // 
            // btnAgregarEspacio
            // 
            btnAgregarEspacio.BackColor = Color.FromArgb(32, 30, 45);
            btnAgregarEspacio.FlatStyle = FlatStyle.Flat;
            btnAgregarEspacio.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarEspacio.ForeColor = SystemColors.ButtonFace;
            btnAgregarEspacio.Location = new Point(13, 401);
            btnAgregarEspacio.Margin = new Padding(4, 3, 4, 3);
            btnAgregarEspacio.Name = "btnAgregarEspacio";
            btnAgregarEspacio.Size = new Size(155, 33);
            btnAgregarEspacio.TabIndex = 33;
            btnAgregarEspacio.Text = "Agregar espacio";
            btnAgregarEspacio.UseVisualStyleBackColor = false;
            btnAgregarEspacio.Click += btnAgregarEspacio_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(32, 30, 45);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(182, 401);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 33);
            btnModificar.TabIndex = 38;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(48, 30, 35);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(310, 401);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 33);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnQuitarVehi);
            groupBox1.Controls.Add(BtnAgregarVehiculo);
            groupBox1.Controls.Add(listBoxVehiculos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbxTipoVehiculo);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(814, 373);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(25, 321);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 19);
            label2.TabIndex = 43;
            label2.Text = "Cargar vehiculos:";
            // 
            // BtnQuitarVehi
            // 
            BtnQuitarVehi.BackColor = Color.FromArgb(32, 30, 45);
            BtnQuitarVehi.FlatStyle = FlatStyle.Flat;
            BtnQuitarVehi.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnQuitarVehi.ForeColor = SystemColors.ButtonFace;
            BtnQuitarVehi.Location = new Point(579, 317);
            BtnQuitarVehi.Margin = new Padding(4, 3, 4, 3);
            BtnQuitarVehi.Name = "BtnQuitarVehi";
            BtnQuitarVehi.Size = new Size(147, 33);
            BtnQuitarVehi.TabIndex = 42;
            BtnQuitarVehi.Text = "Quitar Vehiculo";
            BtnQuitarVehi.UseVisualStyleBackColor = false;
            BtnQuitarVehi.Click += BtnQuitarVehi_Click;
            // 
            // BtnAgregarVehiculo
            // 
            BtnAgregarVehiculo.BackColor = Color.FromArgb(32, 30, 45);
            BtnAgregarVehiculo.FlatStyle = FlatStyle.Flat;
            BtnAgregarVehiculo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarVehiculo.ForeColor = SystemColors.ButtonFace;
            BtnAgregarVehiculo.Location = new Point(406, 317);
            BtnAgregarVehiculo.Margin = new Padding(4, 3, 4, 3);
            BtnAgregarVehiculo.Name = "BtnAgregarVehiculo";
            BtnAgregarVehiculo.Size = new Size(147, 33);
            BtnAgregarVehiculo.TabIndex = 41;
            BtnAgregarVehiculo.Text = "Agregar Vehiculo";
            BtnAgregarVehiculo.UseVisualStyleBackColor = false;
            BtnAgregarVehiculo.Click += BtnAgregarVehiculo_Click;
            // 
            // listBoxVehiculos
            // 
            listBoxVehiculos.BackColor = SystemColors.ActiveBorder;
            listBoxVehiculos.BorderStyle = BorderStyle.FixedSingle;
            listBoxVehiculos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxVehiculos.ForeColor = Color.FromArgb(32, 30, 45);
            listBoxVehiculos.FormattingEnabled = true;
            listBoxVehiculos.ItemHeight = 21;
            listBoxVehiculos.Location = new Point(607, 46);
            listBoxVehiculos.Name = "listBoxVehiculos";
            listBoxVehiculos.Size = new Size(180, 254);
            listBoxVehiculos.TabIndex = 35;
            // 
            // espacioBindingSource
            // 
            espacioBindingSource.DataSource = typeof(MODELO.Espacio);
            // 
            // nombreEspacioDataGridViewTextBoxColumn
            // 
            nombreEspacioDataGridViewTextBoxColumn.DataPropertyName = "NombreEspacio";
            nombreEspacioDataGridViewTextBoxColumn.HeaderText = "Espacio";
            nombreEspacioDataGridViewTextBoxColumn.Name = "nombreEspacioDataGridViewTextBoxColumn";
            nombreEspacioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            capacidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocupacionDataGridViewTextBoxColumn
            // 
            ocupacionDataGridViewTextBoxColumn.DataPropertyName = "Ocupacion";
            ocupacionDataGridViewTextBoxColumn.HeaderText = "Ocupacion";
            ocupacionDataGridViewTextBoxColumn.Name = "ocupacionDataGridViewTextBoxColumn";
            ocupacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disponibilidadDataGridViewCheckBoxColumn
            // 
            disponibilidadDataGridViewCheckBoxColumn.DataPropertyName = "Disponibilidad";
            disponibilidadDataGridViewCheckBoxColumn.HeaderText = "Disponibilidad";
            disponibilidadDataGridViewCheckBoxColumn.Name = "disponibilidadDataGridViewCheckBoxColumn";
            disponibilidadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FormPlazas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(840, 446);
            ControlBox = false;
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregarEspacio);
            Controls.Add(btncancelar);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPlazas";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btncancelar;
        private Label label1;
        private ComboBox cbxTipoVehiculo;
        private DataGridView dataGridView1;
        private Label label5;
        private Button btnAgregarEspacio;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private Button BtnAgregarVehiculo;
        private ListBox listBoxVehiculos;
        private Button BtnQuitarVehi;
        private Label label2;
        private DataGridViewTextBoxColumn nombreEspacioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ocupacionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn disponibilidadDataGridViewCheckBoxColumn;
        private BindingSource espacioBindingSource;
    }
}