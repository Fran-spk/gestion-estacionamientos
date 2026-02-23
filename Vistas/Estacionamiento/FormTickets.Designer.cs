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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            button2 = new Button();
            lblFiltro = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button1 = new Button();
            btnEliminar = new Button();
            BtnPago = new Button();
            BtnSalir = new Button();
            groupBoxFiltros = new GroupBox();
            checkBoxAnulados = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            Desde = new DateTimePicker();
            label2 = new Label();
            Hasta = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ticketDiarioBindingSource = new BindingSource(components);
            ticketBindingSource2 = new BindingSource(components);
            ticketBindingSource = new BindingSource(components);
            formTicketBindingSource = new BindingSource(components);
            ticketBindingSource1 = new BindingSource(components);
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tarifaEstacionamientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panelSidebar.SuspendLayout();
            groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketDiarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formTicketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(28, 28, 30);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(lblFiltro);
            panelSidebar.Controls.Add(comboBox1);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(btnEliminar);
            panelSidebar.Controls.Add(BtnPago);
            panelSidebar.Controls.Add(BtnSalir);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15);
            panelSidebar.Size = new Size(280, 887);
            panelSidebar.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(108, 117, 125);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(20, 436);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(240, 55);
            button2.TabIndex = 7;
            button2.Text = "Ver trazabilidad";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltro.ForeColor = Color.White;
            lblFiltro.Location = new Point(20, 30);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(231, 28);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Buscar por Tipo/Patente";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 36);
            comboBox1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(40, 167, 69);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(20, 125);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(240, 55);
            button3.TabIndex = 2;
            button3.Text = "🔍 Filtrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 210);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(240, 55);
            button1.TabIndex = 3;
            button1.Text = "📋 Buscar Todos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(20, 283);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(240, 55);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "✖ Anular Ticket";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // BtnPago
            // 
            BtnPago.BackColor = Color.FromArgb(255, 193, 7);
            BtnPago.FlatAppearance.BorderSize = 0;
            BtnPago.FlatStyle = FlatStyle.Flat;
            BtnPago.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPago.ForeColor = Color.White;
            BtnPago.Location = new Point(20, 358);
            BtnPago.Margin = new Padding(0);
            BtnPago.Name = "BtnPago";
            BtnPago.Size = new Size(240, 55);
            BtnPago.TabIndex = 5;
            BtnPago.Text = "💳 Ver Pago";
            BtnPago.UseVisualStyleBackColor = false;
            BtnPago.Click += BtnPago_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSalir.BackColor = Color.FromArgb(108, 117, 125);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(20, 802);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(240, 55);
            BtnSalir.TabIndex = 6;
            BtnSalir.Text = "◄ Volver";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // groupBoxFiltros
            // 
            groupBoxFiltros.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxFiltros.Controls.Add(checkBoxAnulados);
            groupBoxFiltros.Controls.Add(checkBox1);
            groupBoxFiltros.Controls.Add(label1);
            groupBoxFiltros.Controls.Add(Desde);
            groupBoxFiltros.Controls.Add(label2);
            groupBoxFiltros.Controls.Add(Hasta);
            groupBoxFiltros.FlatStyle = FlatStyle.Flat;
            groupBoxFiltros.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFiltros.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxFiltros.Location = new Point(295, 30);
            groupBoxFiltros.Margin = new Padding(0);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Padding = new Padding(15);
            groupBoxFiltros.Size = new Size(1101, 140);
            groupBoxFiltros.TabIndex = 1;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "🗓️ Filtros de Fecha y Estado";
            // 
            // checkBoxAnulados
            // 
            checkBoxAnulados.AutoSize = true;
            checkBoxAnulados.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAnulados.ForeColor = Color.White;
            checkBoxAnulados.Location = new Point(1200, 85);
            checkBoxAnulados.Name = "checkBoxAnulados";
            checkBoxAnulados.Size = new Size(150, 32);
            checkBoxAnulados.TabIndex = 5;
            checkBoxAnulados.Text = "Ver anulados";
            checkBoxAnulados.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(1200, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 32);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Solo con pagos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 0;
            label1.Text = "Desde";
            // 
            // Desde
            // 
            Desde.CalendarMonthBackground = Color.FromArgb(45, 45, 48);
            Desde.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Desde.Location = new Point(20, 80);
            Desde.Name = "Desde";
            Desde.Size = new Size(350, 37);
            Desde.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 45);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 2;
            label2.Text = "Hasta";
            // 
            // Hasta
            // 
            Hasta.CalendarMonthBackground = Color.FromArgb(45, 45, 48);
            Hasta.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Hasta.Location = new Point(400, 80);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(350, 37);
            Hasta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(295, 175);
            label3.Name = "label3";
            label3.Size = new Size(238, 30);
            label3.TabIndex = 2;
            label3.Text = "🎟️ Registro de Tickets";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 48);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, tarifaEstacionamientoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.DataSource = ticketDiarioBindingSource;
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
            dataGridView1.Location = new Point(295, 218);
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
            dataGridView1.Size = new Size(1101, 668);
            dataGridView1.TabIndex = 3;
            // 
            // ticketDiarioBindingSource
            // 
            ticketDiarioBindingSource.DataSource = typeof(MODELO.Ticket_Diario);
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FechaHoraEmision";
            dataGridViewTextBoxColumn2.HeaderText = "FechaHoraEmision";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Patente";
            dataGridViewTextBoxColumn3.HeaderText = "Patente";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tarifaEstacionamientoDataGridViewTextBoxColumn
            // 
            tarifaEstacionamientoDataGridViewTextBoxColumn.DataPropertyName = "TarifaEstacionamiento";
            tarifaEstacionamientoDataGridViewTextBoxColumn.HeaderText = "TarifaEstacionamiento";
            tarifaEstacionamientoDataGridViewTextBoxColumn.MinimumWidth = 8;
            tarifaEstacionamientoDataGridViewTextBoxColumn.Name = "tarifaEstacionamientoDataGridViewTextBoxColumn";
            tarifaEstacionamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Estadia";
            dataGridViewTextBoxColumn4.HeaderText = "Estadia";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn5.HeaderText = "Estado";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FormTickets
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1446, 887);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(groupBoxFiltros);
            Controls.Add(panelSidebar);
            ImeMode = ImeMode.Disable;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTickets";
            StartPosition = FormStartPosition.CenterScreen;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketDiarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)formTicketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Label lblFiltro;
        private ComboBox comboBox1;
        private Button button3;
        private Button button1;
        private Button btnEliminar;
        private Button BtnPago;
        private Button BtnSalir;
        private GroupBox groupBoxFiltros;
        private CheckBox checkBoxAnulados;
        private CheckBox checkBox1;
        private Label label1;
        public DateTimePicker Desde;
        private Label label2;
        public DateTimePicker Hasta;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fechaHoraEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource ticketBindingSource2;
        private BindingSource ticketBindingSource;
        private BindingSource formTicketBindingSource;
        private BindingSource ticketBindingSource1;
        private Button button2;
        private BindingSource ticketDiarioBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn tarifaEstacionamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}