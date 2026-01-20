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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btncancelar = new Button();
            label1 = new Label();
            cbxTipoVehiculo = new ComboBox();
            dataGridView1 = new DataGridView();
            nombreEspacioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocupacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            disponibilidadDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            espacioBindingSource = new BindingSource(components);
            label5 = new Label();
            btnAgregarEspacio = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            BtnQuitarVehi = new Button();
            BtnAgregarVehiculo = new Button();
            listBoxVehiculos = new ListBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btncancelar.BackColor = Color.FromArgb(220, 53, 69);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(1070, 675);
            btncancelar.Margin = new Padding(4, 3, 4, 3);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 45);
            btncancelar.TabIndex = 28;
            btncancelar.Text = "✖ Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(830, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 28);
            label1.TabIndex = 26;
            label1.Text = "🚗 Vehículos Permitidos";
            // 
            // cbxTipoVehiculo
            // 
            cbxTipoVehiculo.BackColor = Color.FromArgb(45, 45, 48);
            cbxTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoVehiculo.FlatStyle = FlatStyle.Flat;
            cbxTipoVehiculo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTipoVehiculo.ForeColor = Color.White;
            cbxTipoVehiculo.FormattingEnabled = true;
            cbxTipoVehiculo.Location = new Point(249, 511);
            cbxTipoVehiculo.Margin = new Padding(4, 3, 4, 3);
            cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            cbxTipoVehiculo.Size = new Size(280, 38);
            cbxTipoVehiculo.TabIndex = 25;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreEspacioDataGridViewTextBoxColumn, capacidadDataGridViewTextBoxColumn, ocupacionDataGridViewTextBoxColumn, disponibilidadDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = espacioBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(50, 50, 50);
            dataGridView1.Location = new Point(30, 75);
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
            dataGridView1.Size = new Size(760, 400);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // disponibilidadDataGridViewCheckBoxColumn
            // 
            disponibilidadDataGridViewCheckBoxColumn.DataPropertyName = "Disponibilidad";
            disponibilidadDataGridViewCheckBoxColumn.HeaderText = "Disponible";
            disponibilidadDataGridViewCheckBoxColumn.MinimumWidth = 8;
            disponibilidadDataGridViewCheckBoxColumn.Name = "disponibilidadDataGridViewCheckBoxColumn";
            disponibilidadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // espacioBindingSource
            // 
            espacioBindingSource.DataSource = typeof(MODELO.Espacio);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 40);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(232, 28);
            label5.TabIndex = 34;
            label5.Text = "🅿️ Espacios de Parqueo";
            // 
            // btnAgregarEspacio
            // 
            btnAgregarEspacio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarEspacio.BackColor = Color.FromArgb(40, 167, 69);
            btnAgregarEspacio.FlatAppearance.BorderSize = 0;
            btnAgregarEspacio.FlatStyle = FlatStyle.Flat;
            btnAgregarEspacio.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEspacio.ForeColor = Color.White;
            btnAgregarEspacio.Location = new Point(30, 675);
            btnAgregarEspacio.Margin = new Padding(4, 3, 4, 3);
            btnAgregarEspacio.Name = "btnAgregarEspacio";
            btnAgregarEspacio.Size = new Size(200, 45);
            btnAgregarEspacio.TabIndex = 33;
            btnAgregarEspacio.Text = "➕ Agregar Espacio";
            btnAgregarEspacio.UseVisualStyleBackColor = false;
            btnAgregarEspacio.Click += btnAgregarEspacio_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.BackColor = Color.FromArgb(0, 122, 204);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(520, 675);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 45);
            btnModificar.TabIndex = 38;
            btnModificar.Text = "✏️ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(270, 675);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 45);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnQuitarVehi);
            groupBox1.Controls.Add(BtnAgregarVehiculo);
            groupBox1.Controls.Add(listBoxVehiculos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbxTipoVehiculo);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(30, 90);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(1200, 565);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de Espacios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 515);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 43;
            label2.Text = "🚗 Agregar Vehículos";
            // 
            // BtnQuitarVehi
            // 
            BtnQuitarVehi.BackColor = Color.FromArgb(220, 53, 69);
            BtnQuitarVehi.FlatAppearance.BorderSize = 0;
            BtnQuitarVehi.FlatStyle = FlatStyle.Flat;
            BtnQuitarVehi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnQuitarVehi.ForeColor = Color.White;
            BtnQuitarVehi.Location = new Point(1020, 505);
            BtnQuitarVehi.Margin = new Padding(4, 3, 4, 3);
            BtnQuitarVehi.Name = "BtnQuitarVehi";
            BtnQuitarVehi.Size = new Size(150, 45);
            BtnQuitarVehi.TabIndex = 42;
            BtnQuitarVehi.Text = "➖ Quitar";
            BtnQuitarVehi.UseVisualStyleBackColor = false;
            BtnQuitarVehi.Click += BtnQuitarVehi_Click;
            // 
            // BtnAgregarVehiculo
            // 
            BtnAgregarVehiculo.BackColor = Color.FromArgb(40, 167, 69);
            BtnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            BtnAgregarVehiculo.FlatStyle = FlatStyle.Flat;
            BtnAgregarVehiculo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarVehiculo.ForeColor = Color.White;
            BtnAgregarVehiculo.Location = new Point(830, 505);
            BtnAgregarVehiculo.Margin = new Padding(4, 3, 4, 3);
            BtnAgregarVehiculo.Name = "BtnAgregarVehiculo";
            BtnAgregarVehiculo.Size = new Size(170, 45);
            BtnAgregarVehiculo.TabIndex = 41;
            BtnAgregarVehiculo.Text = "➕ Agregar →";
            BtnAgregarVehiculo.UseVisualStyleBackColor = false;
            BtnAgregarVehiculo.Click += BtnAgregarVehiculo_Click;
            // 
            // listBoxVehiculos
            // 
            listBoxVehiculos.BackColor = Color.FromArgb(45, 45, 48);
            listBoxVehiculos.BorderStyle = BorderStyle.FixedSingle;
            listBoxVehiculos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxVehiculos.ForeColor = Color.White;
            listBoxVehiculos.FormattingEnabled = true;
            listBoxVehiculos.ItemHeight = 30;
            listBoxVehiculos.Location = new Point(830, 75);
            listBoxVehiculos.Name = "listBoxVehiculos";
            listBoxVehiculos.Size = new Size(340, 392);
            listBoxVehiculos.TabIndex = 35;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1260, 70);
            panelHeader.TabIndex = 41;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(515, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🅿️ Gestión de Plazas de Parqueo";
            // 
            // FormPlazas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1260, 745);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregarEspacio);
            Controls.Add(btncancelar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPlazas";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
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
        private Panel panelHeader;
        private Label lblTitulo;
    }
}