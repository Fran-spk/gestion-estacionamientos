namespace Vista
{
    partial class FormPagoServicio
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
            ticketBindingSource = new BindingSource(components);
            btnPago = new Button();
            label10 = new Label();
            txtTipo = new TextBox();
            lbPatente = new Label();
            panel2 = new Panel();
            label1 = new Label();
            cbmMetodo = new ComboBox();
            txtdesc = new TextBox();
            label8 = new Label();
            label7 = new Label();
            TxtPrecioFinal = new TextBox();
            label6 = new Label();
            TxtPrecio = new TextBox();
            HoraActual = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            TxtHoraLlegada = new TextBox();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            TimerHora = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.FromArgb(75, 10, 30);
            btnPago.CausesValidation = false;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPago.ForeColor = SystemColors.ButtonFace;
            btnPago.Location = new Point(20, 406);
            btnPago.Margin = new Padding(4, 3, 4, 3);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(147, 44);
            btnPago.TabIndex = 9;
            btnPago.Text = "Pagar";
            btnPago.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(25, 211);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(81, 19);
            label10.TabIndex = 53;
            label10.Text = "Patente:";
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(178, 203);
            txtTipo.Margin = new Padding(4, 3, 4, 3);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(207, 26);
            txtTipo.TabIndex = 52;
            // 
            // lbPatente
            // 
            lbPatente.AutoSize = true;
            lbPatente.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbPatente.ForeColor = Color.Maroon;
            lbPatente.Location = new Point(175, 43);
            lbPatente.Margin = new Padding(4, 0, 4, 0);
            lbPatente.Name = "lbPatente";
            lbPatente.Size = new Size(94, 24);
            lbPatente.TabIndex = 51;
            lbPatente.Text = "Patente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(21, 111);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 2);
            panel2.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(25, 339);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 49;
            label1.Text = "Metodo de pago:";
            // 
            // cbmMetodo
            // 
            cbmMetodo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmMetodo.FormattingEnabled = true;
            cbmMetodo.Location = new Point(178, 330);
            cbmMetodo.Margin = new Padding(4, 3, 4, 3);
            cbmMetodo.Name = "cbmMetodo";
            cbmMetodo.Size = new Size(208, 27);
            cbmMetodo.TabIndex = 48;
            // 
            // txtdesc
            // 
            txtdesc.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdesc.Location = new Point(586, 203);
            txtdesc.Margin = new Padding(4, 3, 4, 3);
            txtdesc.Name = "txtdesc";
            txtdesc.ReadOnly = true;
            txtdesc.Size = new Size(207, 26);
            txtdesc.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(425, 211);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 19);
            label8.TabIndex = 46;
            label8.Text = "Descuento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(433, 333);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 45;
            label7.Text = "Precio total:";
            // 
            // TxtPrecioFinal
            // 
            TxtPrecioFinal.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPrecioFinal.Location = new Point(586, 330);
            TxtPrecioFinal.Margin = new Padding(4, 3, 4, 3);
            TxtPrecioFinal.Name = "TxtPrecioFinal";
            TxtPrecioFinal.ReadOnly = true;
            TxtPrecioFinal.Size = new Size(207, 26);
            TxtPrecioFinal.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(425, 152);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 19);
            label6.TabIndex = 43;
            label6.Text = "Precio unitario:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPrecio.Location = new Point(586, 145);
            TxtPrecio.Margin = new Padding(4, 3, 4, 3);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.ReadOnly = true;
            TxtPrecio.Size = new Size(207, 26);
            TxtPrecio.TabIndex = 42;
            // 
            // HoraActual
            // 
            HoraActual.AutoSize = true;
            HoraActual.Font = new Font("Microsoft Tai Le", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HoraActual.ForeColor = Color.Maroon;
            HoraActual.Location = new Point(598, 36);
            HoraActual.Margin = new Padding(4, 0, 4, 0);
            HoraActual.Name = "HoraActual";
            HoraActual.Size = new Size(0, 34);
            HoraActual.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(433, 47);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 19);
            label5.TabIndex = 40;
            label5.Text = "Hora Actual:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(25, 265);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 39;
            label4.Text = "Hora Llegada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(25, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 38;
            label3.Text = "Servicio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(25, 47);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 19);
            label9.TabIndex = 36;
            label9.Text = "Patente:";
            // 
            // TxtHoraLlegada
            // 
            TxtHoraLlegada.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtHoraLlegada.Location = new Point(178, 262);
            TxtHoraLlegada.Margin = new Padding(4, 3, 4, 3);
            TxtHoraLlegada.Name = "TxtHoraLlegada";
            TxtHoraLlegada.ReadOnly = true;
            TxtHoraLlegada.Size = new Size(207, 26);
            TxtHoraLlegada.TabIndex = 30;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(32, 30, 45);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(681, 406);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(147, 44);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtTipo);
            groupBox1.Controls.Add(lbPatente);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbmMetodo);
            groupBox1.Controls.Add(txtdesc);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtPrecioFinal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtPrecio);
            groupBox1.Controls.Add(HoraActual);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TxtHoraLlegada);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(20, 17);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(808, 382);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 149);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 27);
            comboBox1.TabIndex = 54;
            // 
            // TimerHora
            // 
            TimerHora.Enabled = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 32, 39);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnPago);
            panel1.Location = new Point(-8, -8);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 469);
            panel1.TabIndex = 38;
            // 
            // FormPagoServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 453);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "FormPagoServicio";
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private BindingSource ticketBindingSource;
        private Button btnPago;
        private Label label10;
        private TextBox txtTipo;
        private Label lbPatente;
        private Panel panel2;
        private Label label1;
        private ComboBox cbmMetodo;
        private TextBox txtdesc;
        private Label label8;
        private Label label7;
        private TextBox TxtPrecioFinal;
        private Label label6;
        private TextBox TxtPrecio;
        public Label HoraActual;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private TextBox TxtHoraLlegada;
        private Button btnSalir;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer TimerHora;
        private Panel panel1;
        private ComboBox comboBox1;
    }
}