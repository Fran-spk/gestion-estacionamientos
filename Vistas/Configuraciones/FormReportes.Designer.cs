namespace Vista
{
    partial class FormReportes
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
            vehiculoBindingSource = new BindingSource(components);
            label2 = new Label();
            Desde = new DateTimePicker();
            groupBox1 = new GroupBox();
            label3 = new Label();
            Hasta = new DateTimePicker();
            btnsalir = new Button();
            ticketBindingSource1 = new BindingSource(components);
            BtnFiltrar = new Button();
            colorDialog1 = new ColorDialog();
            ticketBindingSource = new BindingSource(components);
            repositorioTarifasBindingSource = new BindingSource(components);
            panelHeader = new Panel();
            lblTitulo = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositorioTarifasBindingSource).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 50);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 25;
            label2.Text = "📅 Fecha Desde";
            // 
            // Desde
            // 
            Desde.CalendarMonthBackground = Color.FromArgb(45, 45, 48);
            Desde.CalendarTitleBackColor = Color.FromArgb(0, 122, 204);
            Desde.CalendarTitleForeColor = Color.White;
            Desde.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Desde.Format = DateTimePickerFormat.Short;
            Desde.Location = new Point(193, 47);
            Desde.Margin = new Padding(6, 5, 6, 5);
            Desde.Name = "Desde";
            Desde.Size = new Size(280, 37);
            Desde.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Desde);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Hasta);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(30, 100);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(940, 140);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rango de Fechas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(485, 50);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 26;
            label3.Text = "📅 Fecha Hasta";
            // 
            // Hasta
            // 
            Hasta.CalendarMonthBackground = Color.FromArgb(45, 45, 48);
            Hasta.CalendarTitleBackColor = Color.FromArgb(0, 122, 204);
            Hasta.CalendarTitleForeColor = Color.White;
            Hasta.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Hasta.Format = DateTimePickerFormat.Short;
            Hasta.Location = new Point(652, 44);
            Hasta.Margin = new Padding(6, 5, 6, 5);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(280, 37);
            Hasta.TabIndex = 24;
            // 
            // btnsalir
            // 
            btnsalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnsalir.BackColor = Color.FromArgb(220, 53, 69);
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.ForeColor = Color.White;
            btnsalir.Location = new Point(770, 319);
            btnsalir.Margin = new Padding(6, 5, 6, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(200, 55);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "✖ Cancelar";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // ticketBindingSource1
            // 
            ticketBindingSource1.DataSource = typeof(MODELO.Ticket_Diario);
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnFiltrar.BackColor = Color.FromArgb(0, 122, 204);
            BtnFiltrar.FlatAppearance.BorderSize = 0;
            BtnFiltrar.FlatStyle = FlatStyle.Flat;
            BtnFiltrar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFiltrar.ForeColor = Color.White;
            BtnFiltrar.Location = new Point(30, 319);
            BtnFiltrar.Margin = new Padding(6, 5, 6, 5);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(341, 55);
            BtnFiltrar.TabIndex = 51;
            BtnFiltrar.Text = "📊 Reporte de Estacionamiento";
            BtnFiltrar.UseVisualStyleBackColor = false;
            BtnFiltrar.Click += BtnFiltrar_Click;
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(MODELO.Ticket_Diario);
            // 
            // repositorioTarifasBindingSource
            // 
            repositorioTarifasBindingSource.DataSource = typeof(Controladora.ControladoraTarifasEstacionamiento);
            // 
            // panelHeader
            // 
            panelHeader.AutoSize = true;
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 60);
            panelHeader.TabIndex = 52;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(282, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Generar Reportes";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(404, 319);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(276, 55);
            button1.TabIndex = 53;
            button1.Text = "📊 Reporte de Auditoria";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 405);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panelHeader);
            Controls.Add(BtnFiltrar);
            Controls.Add(btnsalir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormReportes";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositorioTarifasBindingSource).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource repositorioTarifasBindingSource;
        private BindingSource vehiculoBindingSource;
        private Label label2;
        public DateTimePicker Desde;
        private GroupBox groupBox1;
        private Label label3;
        public DateTimePicker Hasta;
        private Button btnsalir;
        private Button BtnFiltrar;
        private ColorDialog colorDialog1;
        private BindingSource ticketBindingSource;
        private BindingSource ticketBindingSource1;
        private Panel panelHeader;
        private Label lblTitulo;
        private Button button1;
    }
}