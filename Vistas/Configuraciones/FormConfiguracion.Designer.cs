namespace Vista
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            panel1 = new Panel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            picCochera = new PictureBox();
            btnVolver = new Button();
            TxtExplicacion = new RichTextBox();
            panelBotones = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnModificar = new Button();
            BtnDescuentos = new Button();
            BtnTarifas = new Button();
            BtnActividades = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCochera).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(panelHeader);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(TxtExplicacion);
            panel1.Controls.Add(panelBotones);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(picCochera);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(30, 30);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1860, 100);
            panelHeader.TabIndex = 36;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(140, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(526, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "⚙️ Panel de Configuración";
            // 
            // picCochera
            // 
            picCochera.Image = (Image)resources.GetObject("picCochera.Image");
            picCochera.Location = new Point(20, 10);
            picCochera.Margin = new Padding(6, 5, 6, 5);
            picCochera.Name = "picCochera";
            picCochera.Size = new Size(100, 80);
            picCochera.SizeMode = PictureBoxSizeMode.Zoom;
            picCochera.TabIndex = 27;
            picCochera.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolver.BackColor = Color.FromArgb(220, 53, 69);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1650, 990);
            btnVolver.Margin = new Padding(6, 5, 6, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(240, 60);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // TxtExplicacion
            // 
            TxtExplicacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtExplicacion.BackColor = Color.FromArgb(37, 37, 38);
            TxtExplicacion.BorderStyle = BorderStyle.None;
            TxtExplicacion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtExplicacion.ForeColor = Color.FromArgb(200, 200, 200);
            TxtExplicacion.Location = new Point(380, 870);
            TxtExplicacion.Margin = new Padding(6, 5, 6, 5);
            TxtExplicacion.Name = "TxtExplicacion";
            TxtExplicacion.ReadOnly = true;
            TxtExplicacion.Size = new Size(1510, 100);
            TxtExplicacion.TabIndex = 26;
            TxtExplicacion.Text = "💡 Seleccione una opción para ver más información";
            // 
            // panelBotones
            // 
            panelBotones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBotones.Controls.Add(button3);
            panelBotones.Controls.Add(button2);
            panelBotones.Controls.Add(btnModificar);
            panelBotones.Controls.Add(BtnDescuentos);
            panelBotones.Controls.Add(BtnTarifas);
            panelBotones.Controls.Add(BtnActividades);
            panelBotones.Controls.Add(button1);
            panelBotones.Location = new Point(380, 160);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1510, 690);
            panelBotones.TabIndex = 37;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 58, 64);
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 600);
            button3.Margin = new Padding(0, 0, 0, 15);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(1510, 102);
            button3.TabIndex = 37;
            button3.Text = "\U0001f9fc Gestionar Tipos de servicios";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseMove += button3_MouseMove;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 58, 64);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 500);
            button2.Margin = new Padding(0, 0, 0, 15);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(1510, 100);
            button2.TabIndex = 36;
            button2.Text = "💰 Gestionar Tarifas de servicio";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseMove += button2_MouseMove;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(52, 58, 64);
            btnModificar.Dock = DockStyle.Top;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(0, 400);
            btnModificar.Margin = new Padding(0, 0, 0, 15);
            btnModificar.Name = "btnModificar";
            btnModificar.Padding = new Padding(30, 0, 0, 0);
            btnModificar.Size = new Size(1510, 100);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "🅿️  Espacios de Parqueo";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            btnModificar.MouseMove += btnModificar_MouseMove;
            // 
            // BtnDescuentos
            // 
            BtnDescuentos.BackColor = Color.FromArgb(52, 58, 64);
            BtnDescuentos.Dock = DockStyle.Top;
            BtnDescuentos.FlatAppearance.BorderSize = 0;
            BtnDescuentos.FlatStyle = FlatStyle.Flat;
            BtnDescuentos.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDescuentos.ForeColor = Color.White;
            BtnDescuentos.Location = new Point(0, 300);
            BtnDescuentos.Margin = new Padding(0, 0, 0, 15);
            BtnDescuentos.Name = "BtnDescuentos";
            BtnDescuentos.Padding = new Padding(30, 0, 0, 0);
            BtnDescuentos.Size = new Size(1510, 100);
            BtnDescuentos.TabIndex = 19;
            BtnDescuentos.Text = "🏷️  Gestionar Descuentos";
            BtnDescuentos.TextAlign = ContentAlignment.MiddleLeft;
            BtnDescuentos.UseVisualStyleBackColor = false;
            BtnDescuentos.Click += BtnDescuentos_Click;
            BtnDescuentos.MouseMove += BtnEliminar_MouseMove;
            // 
            // BtnTarifas
            // 
            BtnTarifas.BackColor = Color.FromArgb(52, 58, 64);
            BtnTarifas.Dock = DockStyle.Top;
            BtnTarifas.FlatAppearance.BorderSize = 0;
            BtnTarifas.FlatStyle = FlatStyle.Flat;
            BtnTarifas.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTarifas.ForeColor = Color.White;
            BtnTarifas.Location = new Point(0, 200);
            BtnTarifas.Margin = new Padding(0, 0, 0, 15);
            BtnTarifas.Name = "BtnTarifas";
            BtnTarifas.Padding = new Padding(30, 0, 0, 0);
            BtnTarifas.Size = new Size(1510, 100);
            BtnTarifas.TabIndex = 34;
            BtnTarifas.Text = "💰  Gestionar Tarifas";
            BtnTarifas.TextAlign = ContentAlignment.MiddleLeft;
            BtnTarifas.UseVisualStyleBackColor = false;
            BtnTarifas.Click += BtnTarifas_Click;
            BtnTarifas.MouseMove += BtnTarifas_MouseMove;
            // 
            // BtnActividades
            // 
            BtnActividades.BackColor = Color.FromArgb(52, 58, 64);
            BtnActividades.Dock = DockStyle.Top;
            BtnActividades.FlatAppearance.BorderSize = 0;
            BtnActividades.FlatStyle = FlatStyle.Flat;
            BtnActividades.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            BtnActividades.ForeColor = Color.White;
            BtnActividades.Location = new Point(0, 100);
            BtnActividades.Margin = new Padding(0, 0, 0, 15);
            BtnActividades.Name = "BtnActividades";
            BtnActividades.Padding = new Padding(30, 0, 0, 0);
            BtnActividades.Size = new Size(1510, 100);
            BtnActividades.TabIndex = 25;
            BtnActividades.Text = "💳  Gestionar Métodos de Pago";
            BtnActividades.TextAlign = ContentAlignment.MiddleLeft;
            BtnActividades.UseVisualStyleBackColor = false;
            BtnActividades.Click += BtnActividades_Click;
            BtnActividades.MouseMove += BtnActividades_MouseMove;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 58, 64);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(1510, 100);
            button1.TabIndex = 35;
            button1.Text = "🚗  Gestionar Tipos de Vehículos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormConfiguracion
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración del Sistema";
            panel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCochera).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnDescuentos;
        private Button btnModificar;
        private RichTextBox TxtExplicacion;
        private Button BtnActividades;
        public PictureBox picCochera;
        private Button btnVolver;
        private Button BtnTarifas;
        private Button button1;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button button3;
        private Button button2;
    }
}