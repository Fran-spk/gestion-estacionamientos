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
            button1 = new Button();
            BtnTarifas = new Button();
            picCochera = new PictureBox();
            TxtExplicacion = new RichTextBox();
            BtnActividades = new Button();
            BtnDescuentos = new Button();
            btnModificar = new Button();
            panel2 = new Panel();
            btnVolver = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCochera).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnTarifas);
            panel1.Controls.Add(picCochera);
            panel1.Controls.Add(TxtExplicacion);
            panel1.Controls.Add(BtnActividades);
            panel1.Controls.Add(BtnDescuentos);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 560);
            panel1.TabIndex = 22;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 30, 35);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(239, 377);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(784, 63);
            button1.TabIndex = 35;
            button1.Text = "gestionar tipos de Vehiculos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnTarifas
            // 
            BtnTarifas.BackColor = Color.FromArgb(35, 32, 39);
            BtnTarifas.FlatStyle = FlatStyle.Flat;
            BtnTarifas.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTarifas.ForeColor = SystemColors.ButtonFace;
            BtnTarifas.Location = new Point(239, 217);
            BtnTarifas.Margin = new Padding(4, 3, 4, 3);
            BtnTarifas.Name = "BtnTarifas";
            BtnTarifas.Size = new Size(784, 63);
            BtnTarifas.TabIndex = 34;
            BtnTarifas.Text = "Gestionar tarifas";
            BtnTarifas.UseVisualStyleBackColor = false;
            BtnTarifas.Click += BtnTarifas_Click;
            BtnTarifas.MouseMove += BtnTarifas_MouseMove;
            // 
            // picCochera
            // 
            picCochera.Image = (Image)resources.GetObject("picCochera.Image");
            picCochera.Location = new Point(28, 35);
            picCochera.Margin = new Padding(4, 3, 4, 3);
            picCochera.Name = "picCochera";
            picCochera.Size = new Size(138, 122);
            picCochera.SizeMode = PictureBoxSizeMode.StretchImage;
            picCochera.TabIndex = 27;
            picCochera.TabStop = false;
            picCochera.UseWaitCursor = true;
            // 
            // TxtExplicacion
            // 
            TxtExplicacion.Location = new Point(573, 485);
            TxtExplicacion.Margin = new Padding(4, 3, 4, 3);
            TxtExplicacion.Name = "TxtExplicacion";
            TxtExplicacion.ReadOnly = true;
            TxtExplicacion.Size = new Size(474, 50);
            TxtExplicacion.TabIndex = 26;
            TxtExplicacion.Text = "";
            // 
            // BtnActividades
            // 
            BtnActividades.BackColor = Color.FromArgb(48, 30, 35);
            BtnActividades.FlatStyle = FlatStyle.Flat;
            BtnActividades.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnActividades.ForeColor = SystemColors.ButtonFace;
            BtnActividades.Location = new Point(239, 297);
            BtnActividades.Margin = new Padding(4, 3, 4, 3);
            BtnActividades.Name = "BtnActividades";
            BtnActividades.Size = new Size(784, 63);
            BtnActividades.TabIndex = 25;
            BtnActividades.Text = "gestionar metodos de pago";
            BtnActividades.UseVisualStyleBackColor = false;
            BtnActividades.Click += BtnActividades_Click;
            BtnActividades.MouseMove += BtnActividades_MouseMove;
            // 
            // BtnDescuentos
            // 
            BtnDescuentos.BackColor = Color.FromArgb(35, 32, 39);
            BtnDescuentos.FlatStyle = FlatStyle.Flat;
            BtnDescuentos.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDescuentos.ForeColor = SystemColors.ButtonFace;
            BtnDescuentos.Location = new Point(239, 139);
            BtnDescuentos.Margin = new Padding(4, 3, 4, 3);
            BtnDescuentos.Name = "BtnDescuentos";
            BtnDescuentos.Size = new Size(784, 63);
            BtnDescuentos.TabIndex = 19;
            BtnDescuentos.Text = "Modificar descuentos";
            BtnDescuentos.UseCompatibleTextRendering = true;
            BtnDescuentos.UseVisualStyleBackColor = false;
            BtnDescuentos.Click += BtnDescuentos_Click;
            BtnDescuentos.MouseMove += BtnEliminar_MouseMove;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(35, 32, 39);
            btnModificar.CausesValidation = false;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(239, 58);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(784, 63);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Espacios de parqueo";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            btnModificar.MouseMove += btnModificar_MouseMove;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(573, 460);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 2);
            panel2.TabIndex = 18;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(32, 30, 45);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(886, 582);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(194, 47);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Juice ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(952, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 35;
            label2.Text = "Configuracion:";
            // 
            // FormConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1093, 643);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCochera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BtnDescuentos;
        private Button btnModificar;
        private Panel panel2;
        private RichTextBox TxtExplicacion;
        private Button BtnActividades;
        public PictureBox picCochera;
        private Button btnVolver;
        private Button BtnTarifas;
        private Label label2;
        private Button button1;
    }
}