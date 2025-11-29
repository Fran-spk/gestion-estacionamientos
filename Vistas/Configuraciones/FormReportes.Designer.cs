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
            label12 = new Label();
            btnsalir = new Button();
            ticketBindingSource1 = new BindingSource(components);
            BtnFiltrar = new Button();
            colorDialog1 = new ColorDialog();
            ticketBindingSource = new BindingSource(components);
            repositorioTarifasBindingSource = new BindingSource(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositorioTarifasBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(10, 52);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 25;
            label2.Text = "Desde:";
            // 
            // Desde
            // 
            Desde.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Desde.Location = new Point(112, 50);
            Desde.Margin = new Padding(6, 5, 6, 5);
            Desde.Name = "Desde";
            Desde.Size = new Size(277, 36);
            Desde.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Desde);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Hasta);
            groupBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 77);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(997, 112);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(541, 50);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 26;
            label3.Text = "Hasta:";
            // 
            // Hasta
            // 
            Hasta.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hasta.Location = new Point(657, 50);
            Hasta.Margin = new Padding(6, 5, 6, 5);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(277, 36);
            Hasta.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(453, 24);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(116, 28);
            label12.TabIndex = 47;
            label12.Text = "Reportes";
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(25, 42, 75);
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalir.ForeColor = SystemColors.ButtonFace;
            btnsalir.Location = new Point(339, 332);
            btnsalir.Margin = new Padding(6, 5, 6, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(377, 60);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // ticketBindingSource1
            // 
            ticketBindingSource1.DataSource = typeof(MODELO.Ticket);
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.BackColor = Color.FromArgb(25, 42, 75);
            BtnFiltrar.FlatStyle = FlatStyle.Flat;
            BtnFiltrar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFiltrar.ForeColor = SystemColors.ButtonFace;
            BtnFiltrar.Location = new Point(339, 248);
            BtnFiltrar.Margin = new Padding(6, 5, 6, 5);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(377, 60);
            BtnFiltrar.TabIndex = 51;
            BtnFiltrar.Text = "Generar reporte";
            BtnFiltrar.UseVisualStyleBackColor = false;
            BtnFiltrar.Click += BtnFiltrar_Click;
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(MODELO.Ticket);
            // 
            // repositorioTarifasBindingSource
            // 
            repositorioTarifasBindingSource.DataSource = typeof(Controladora.ControladoraTarifas);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 75);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(-10, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 73);
            panel1.TabIndex = 52;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1039, 441);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(BtnFiltrar);
            Controls.Add(btnsalir);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositorioTarifasBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource repositorioTarifasBindingSource;
        private BindingSource vehiculoBindingSource;
        private Label label2;
        public DateTimePicker Desde;
        private GroupBox groupBox1;
        private Label label3;
        public DateTimePicker Hasta;
        private Label label12;
        private Button btnsalir;
        private Button BtnFiltrar;
        private ColorDialog colorDialog1;
        private BindingSource ticketBindingSource;
        private BindingSource ticketBindingSource1;
        private Panel panel1;
    }
}