namespace Vista
{
    partial class FormTickets
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
            dataGridView1 = new DataGridView();
            fechaHoraEmisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarifaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ticketBindingSource2 = new BindingSource(components);
            Desde = new DateTimePicker();
            Hasta = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            button3 = new Button();
            BtnPago = new Button();
            panel2 = new Panel();
            button1 = new Button();
            btnEliminar = new Button();
            comboBox1 = new ComboBox();
            BtnSalir = new Button();
            BtnBuscarTodo = new GroupBox();
            label3 = new Label();
            ticketBindingSource = new BindingSource(components);
            checkBox1 = new CheckBox();
            formTicketBindingSource = new BindingSource(components);
            ticketBindingSource1 = new BindingSource(components);
            checkBoxAnulados = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource2).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            BtnBuscarTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formTicketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaHoraEmisionDataGridViewTextBoxColumn, patenteDataGridViewTextBoxColumn, tarifaDataGridViewTextBoxColumn, estadiaDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = ticketBindingSource2;
            dataGridView1.Location = new Point(282, 128);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(799, 372);
            dataGridView1.TabIndex = 19;
            // 
            // fechaHoraEmisionDataGridViewTextBoxColumn
            // 
            fechaHoraEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraEmision";
            fechaHoraEmisionDataGridViewTextBoxColumn.HeaderText = "FechaHoraEmision";
            fechaHoraEmisionDataGridViewTextBoxColumn.Name = "fechaHoraEmisionDataGridViewTextBoxColumn";
            fechaHoraEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            patenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifaDataGridViewTextBoxColumn
            // 
            tarifaDataGridViewTextBoxColumn.DataPropertyName = "Tarifa";
            tarifaDataGridViewTextBoxColumn.HeaderText = "Tarifa";
            tarifaDataGridViewTextBoxColumn.Name = "tarifaDataGridViewTextBoxColumn";
            tarifaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadiaDataGridViewTextBoxColumn
            // 
            estadiaDataGridViewTextBoxColumn.DataPropertyName = "Estadia";
            estadiaDataGridViewTextBoxColumn.HeaderText = "Estadia";
            estadiaDataGridViewTextBoxColumn.Name = "estadiaDataGridViewTextBoxColumn";
            estadiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ticketBindingSource2
            // 
            ticketBindingSource2.DataSource = typeof(MODELO.Ticket);
            // 
            // Desde
            // 
            Desde.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Desde.Location = new Point(102, 23);
            Desde.Margin = new Padding(4, 3, 4, 3);
            Desde.Name = "Desde";
            Desde.Size = new Size(195, 26);
            Desde.TabIndex = 23;
            // 
            // Hasta
            // 
            Hasta.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hasta.Location = new Point(575, 22);
            Hasta.Margin = new Padding(4, 3, 4, 3);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(195, 26);
            Hasta.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(7, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 25;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(477, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 26;
            label2.Text = "Hasta:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Desde);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Hasta);
            groupBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(282, 25);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(799, 67);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(BtnPago);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(comboBox1);
            panel1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 653);
            panel1.TabIndex = 28;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(75, 10, 30);
            button3.CausesValidation = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(30, 99);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(216, 45);
            button3.TabIndex = 17;
            button3.Text = "Filtrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BtnPago
            // 
            BtnPago.BackColor = Color.FromArgb(35, 32, 39);
            BtnPago.FlatStyle = FlatStyle.Flat;
            BtnPago.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnPago.ForeColor = Color.Firebrick;
            BtnPago.ImageAlign = ContentAlignment.BottomLeft;
            BtnPago.Location = new Point(-5, 390);
            BtnPago.Margin = new Padding(4, 3, 4, 3);
            BtnPago.Name = "BtnPago";
            BtnPago.Size = new Size(276, 59);
            BtnPago.TabIndex = 16;
            BtnPago.Text = "Ver pago";
            BtnPago.UseVisualStyleBackColor = false;
            BtnPago.Click += BtnPago_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(15, 192);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 1);
            panel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 32, 39);
            button1.CausesValidation = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 258);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(274, 59);
            button1.TabIndex = 14;
            button1.Text = "Buscar todos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(35, 32, 39);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(-2, 324);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(276, 59);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Anular";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 43);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 27);
            comboBox1.TabIndex = 13;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(32, 30, 45);
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSalir.ForeColor = SystemColors.ButtonFace;
            BtnSalir.Location = new Point(598, 68);
            BtnSalir.Margin = new Padding(4, 3, 4, 3);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(194, 47);
            BtnSalir.TabIndex = 8;
            BtnSalir.Text = "Volver";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnBuscarTodo
            // 
            BtnBuscarTodo.Controls.Add(BtnSalir);
            BtnBuscarTodo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarTodo.Location = new Point(282, 507);
            BtnBuscarTodo.Margin = new Padding(4, 3, 4, 3);
            BtnBuscarTodo.Name = "BtnBuscarTodo";
            BtnBuscarTodo.Padding = new Padding(4, 3, 4, 3);
            BtnBuscarTodo.Size = new Size(799, 122);
            BtnBuscarTodo.TabIndex = 28;
            BtnBuscarTodo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Juice ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(1010, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 29;
            label3.Text = "Tickets:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(282, 99);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(172, 23);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Ver solo Pagados";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ticketBindingSource1
            // 
            ticketBindingSource1.DataSource = typeof(MODELO.Ticket);
            // 
            // checkBoxAnulados
            // 
            checkBoxAnulados.AutoSize = true;
            checkBoxAnulados.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxAnulados.ForeColor = SystemColors.ButtonHighlight;
            checkBoxAnulados.Location = new Point(481, 98);
            checkBoxAnulados.Margin = new Padding(4, 3, 4, 3);
            checkBoxAnulados.Name = "checkBoxAnulados";
            checkBoxAnulados.Size = new Size(136, 23);
            checkBoxAnulados.TabIndex = 30;
            checkBoxAnulados.Text = "Ver anulados";
            checkBoxAnulados.UseVisualStyleBackColor = true;
            // 
            // FormTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1093, 643);
            ControlBox = false;
            Controls.Add(checkBoxAnulados);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(BtnBuscarTodo);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormTickets";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            BtnBuscarTodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)formTicketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioFinalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horallegadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasalidaDataGridViewTextBoxColumn;
        private Panel panel1;
        private Button btnEliminar;
        private Button BtnSalir;
        private GroupBox BtnBuscarTodo;
        private ComboBox comboBox1;
        private Panel panel2;
        private Button button1;
        public DateTimePicker Desde;
        public DateTimePicker Hasta;
        private Label label3;
        private BindingSource ticketBindingSource;
        private Button button3;
        private Button BtnPago;
        private BindingSource formTicketBindingSource;
        private DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private BindingSource ticketBindingSource1;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn fechaHoraEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarifaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource ticketBindingSource2;
        private CheckBox checkBoxAnulados;
    }
}