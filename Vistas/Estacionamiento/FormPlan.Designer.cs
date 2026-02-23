namespace Vista
{
    partial class FormPlan
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
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBoxCliente = new GroupBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtdni = new TextBox();
            label7 = new Label();
            txttelefono = new TextBox();
            groupBoxPlan = new GroupBox();
            label1 = new Label();
            txttipoVehiculo = new ComboBox();
            label6 = new Label();
            txtPatente = new TextBox();
            checkDesc = new CheckBox();
            label11 = new Label();
            TxtDescuento = new ComboBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBoxEspacios = new GroupBox();
            LabelNoLugar = new Label();
            dataGridView1 = new DataGridView();
            btnaceptar = new Button();
            btncancelar = new Button();
            espacioBindingSource = new BindingSource(components);
            nombreEspacioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocupacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            disponibilidadDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            panelHeader.SuspendLayout();
            groupBoxCliente.SuspendLayout();
            groupBoxPlan.SuspendLayout();
            groupBoxEspacios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1350, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crear Plan Mensual";
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxCliente.Controls.Add(label5);
            groupBoxCliente.Controls.Add(txtNombre);
            groupBoxCliente.Controls.Add(label4);
            groupBoxCliente.Controls.Add(txtdni);
            groupBoxCliente.Controls.Add(label7);
            groupBoxCliente.Controls.Add(txttelefono);
            groupBoxCliente.FlatStyle = FlatStyle.Flat;
            groupBoxCliente.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxCliente.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxCliente.Location = new Point(30, 80);
            groupBoxCliente.Margin = new Padding(0);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Padding = new Padding(15);
            groupBoxCliente.Size = new Size(380, 380);
            groupBoxCliente.TabIndex = 1;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "👤 Datos del Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 40);
            label5.Name = "label5";
            label5.Size = new Size(168, 28);
            label5.TabIndex = 0;
            label5.Text = "Nombre Apellido";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(45, 45, 48);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(20, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre completo";
            txtNombre.Size = new Size(340, 37);
            txtNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 130);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 2;
            label4.Text = "DNI";
            // 
            // txtdni
            // 
            txtdni.BackColor = Color.FromArgb(45, 45, 48);
            txtdni.BorderStyle = BorderStyle.FixedSingle;
            txtdni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtdni.ForeColor = Color.White;
            txtdni.Location = new Point(20, 165);
            txtdni.Name = "txtdni";
            txtdni.PlaceholderText = "Número de documento";
            txtdni.Size = new Size(340, 37);
            txtdni.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 220);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 4;
            label7.Text = "Teléfono";
            // 
            // txttelefono
            // 
            txttelefono.BackColor = Color.FromArgb(45, 45, 48);
            txttelefono.BorderStyle = BorderStyle.FixedSingle;
            txttelefono.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefono.ForeColor = Color.White;
            txttelefono.Location = new Point(20, 255);
            txttelefono.Name = "txttelefono";
            txttelefono.PlaceholderText = "Número de contacto";
            txttelefono.Size = new Size(340, 37);
            txttelefono.TabIndex = 5;
            // 
            // groupBoxPlan
            // 
            groupBoxPlan.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxPlan.Controls.Add(label1);
            groupBoxPlan.Controls.Add(txttipoVehiculo);
            groupBoxPlan.Controls.Add(label6);
            groupBoxPlan.Controls.Add(txtPatente);
            groupBoxPlan.Controls.Add(checkDesc);
            groupBoxPlan.Controls.Add(label11);
            groupBoxPlan.Controls.Add(TxtDescuento);
            groupBoxPlan.FlatStyle = FlatStyle.Flat;
            groupBoxPlan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxPlan.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxPlan.Location = new Point(430, 80);
            groupBoxPlan.Margin = new Padding(0);
            groupBoxPlan.Name = "groupBoxPlan";
            groupBoxPlan.Padding = new Padding(15);
            groupBoxPlan.Size = new Size(380, 380);
            groupBoxPlan.TabIndex = 2;
            groupBoxPlan.TabStop = false;
            groupBoxPlan.Text = "📋 Datos del Plan";
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
            // txttipoVehiculo
            // 
            txttipoVehiculo.BackColor = Color.FromArgb(45, 45, 48);
            txttipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            txttipoVehiculo.FlatStyle = FlatStyle.Flat;
            txttipoVehiculo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txttipoVehiculo.ForeColor = Color.White;
            txttipoVehiculo.FormattingEnabled = true;
            txttipoVehiculo.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            txttipoVehiculo.Location = new Point(20, 75);
            txttipoVehiculo.Name = "txttipoVehiculo";
            txttipoVehiculo.Size = new Size(340, 38);
            txttipoVehiculo.TabIndex = 1;
            txttipoVehiculo.SelectedIndexChanged += txttipoVehiculo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 130);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 2;
            label6.Text = "Patente";
            // 
            // txtPatente
            // 
            txtPatente.BackColor = Color.FromArgb(45, 45, 48);
            txtPatente.BorderStyle = BorderStyle.FixedSingle;
            txtPatente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatente.ForeColor = Color.White;
            txtPatente.Location = new Point(20, 165);
            txtPatente.Name = "txtPatente";
            txtPatente.PlaceholderText = "Ej: ABC123";
            txtPatente.Size = new Size(340, 37);
            txtPatente.TabIndex = 3;
            // 
            // checkDesc
            // 
            checkDesc.AutoSize = true;
            checkDesc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkDesc.ForeColor = Color.White;
            checkDesc.Location = new Point(20, 220);
            checkDesc.Name = "checkDesc";
            checkDesc.Size = new Size(204, 32);
            checkDesc.TabIndex = 4;
            checkDesc.Text = "Agregar descuento";
            checkDesc.UseVisualStyleBackColor = true;
            checkDesc.CheckedChanged += checkDesc_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(20, 255);
            label11.Name = "label11";
            label11.Size = new Size(109, 28);
            label11.TabIndex = 5;
            label11.Text = "Descuento";
            // 
            // TxtDescuento
            // 
            TxtDescuento.BackColor = Color.FromArgb(45, 45, 48);
            TxtDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtDescuento.FlatStyle = FlatStyle.Flat;
            TxtDescuento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDescuento.ForeColor = Color.White;
            TxtDescuento.FormattingEnabled = true;
            TxtDescuento.Location = new Point(20, 290);
            TxtDescuento.Name = "TxtDescuento";
            TxtDescuento.Size = new Size(340, 38);
            TxtDescuento.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(799, 502);
            label10.Name = "label10";
            label10.Size = new Size(119, 28);
            label10.TabIndex = 7;
            label10.Text = "Fecha Inicio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(45, 45, 48);
            dateTimePicker1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(933, 493);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 37);
            dateTimePicker1.TabIndex = 8;
            // 
            // groupBoxEspacios
            // 
            groupBoxEspacios.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxEspacios.Controls.Add(LabelNoLugar);
            groupBoxEspacios.Controls.Add(dataGridView1);
            groupBoxEspacios.FlatStyle = FlatStyle.Flat;
            groupBoxEspacios.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEspacios.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxEspacios.Location = new Point(830, 80);
            groupBoxEspacios.Margin = new Padding(0);
            groupBoxEspacios.Name = "groupBoxEspacios";
            groupBoxEspacios.Padding = new Padding(15);
            groupBoxEspacios.Size = new Size(490, 380);
            groupBoxEspacios.TabIndex = 3;
            groupBoxEspacios.TabStop = false;
            groupBoxEspacios.Text = "🅿️ Espacios de Parqueo";
            // 
            // LabelNoLugar
            // 
            LabelNoLugar.AutoSize = true;
            LabelNoLugar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNoLugar.ForeColor = Color.FromArgb(220, 53, 69);
            LabelNoLugar.Location = new Point(246, 27);
            LabelNoLugar.Name = "LabelNoLugar";
            LabelNoLugar.Size = new Size(224, 30);
            LabelNoLugar.TabIndex = 1;
            LabelNoLugar.Text = "⚠ No hay espacios!";
            LabelNoLugar.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 48);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreEspacioDataGridViewTextBoxColumn, capacidadDataGridViewTextBoxColumn, ocupacionDataGridViewTextBoxColumn, disponibilidadDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = espacioBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(50, 50, 50);
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(450, 300);
            dataGridView1.TabIndex = 0;
            // 
            // btnaceptar
            // 
            btnaceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnaceptar.BackColor = Color.FromArgb(40, 167, 69);
            btnaceptar.FlatAppearance.BorderSize = 0;
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnaceptar.ForeColor = Color.White;
            btnaceptar.Location = new Point(30, 480);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(180, 50);
            btnaceptar.TabIndex = 4;
            btnaceptar.Text = "✓ Aceptar";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btncancelar.BackColor = Color.FromArgb(220, 53, 69);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(1140, 480);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(180, 50);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "✖ Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // espacioBindingSource
            // 
            espacioBindingSource.DataSource = typeof(MODELO.Espacio);
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
            // disponibilidadDataGridViewCheckBoxColumn
            // 
            disponibilidadDataGridViewCheckBoxColumn.DataPropertyName = "Disponibilidad";
            disponibilidadDataGridViewCheckBoxColumn.HeaderText = "Disponibilidad";
            disponibilidadDataGridViewCheckBoxColumn.MinimumWidth = 8;
            disponibilidadDataGridViewCheckBoxColumn.Name = "disponibilidadDataGridViewCheckBoxColumn";
            disponibilidadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FormPlan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1350, 550);
            ControlBox = false;
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Controls.Add(groupBoxEspacios);
            Controls.Add(groupBoxPlan);
            Controls.Add(groupBoxCliente);
            Controls.Add(panelHeader);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPlan";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            groupBoxPlan.ResumeLayout(false);
            groupBoxPlan.PerformLayout();
            groupBoxEspacios.ResumeLayout(false);
            groupBoxEspacios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)espacioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private GroupBox groupBoxCliente;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtdni;
        private Label label7;
        private TextBox txttelefono;
        private GroupBox groupBoxPlan;
        private Label label1;
        private ComboBox txttipoVehiculo;
        private Label label6;
        private TextBox txtPatente;
        private CheckBox checkDesc;
        private Label label11;
        private ComboBox TxtDescuento;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBoxEspacios;
        private Label LabelNoLugar;
        private DataGridView dataGridView1;
        private Button btnaceptar;
        private Button btncancelar;
        private DataGridViewTextBoxColumn nombreEspacioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ocupacionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn disponibilidadDataGridViewCheckBoxColumn;
        private BindingSource espacioBindingSource;
    }
}