namespace Vista
{
    partial class FormPago
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
            panel1 = new Panel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            panelDerecha = new Panel();
            HoraActual = new Label();
            label5 = new Label();
            TxtPrecio = new TextBox();
            label6 = new Label();
            txtdesc = new TextBox();
            label8 = new Label();
            TxtPrecioFinal = new TextBox();
            label7 = new Label();
            panelIzquierda = new Panel();
            lbPatente = new Label();
            label9 = new Label();
            txtTipo = new TextBox();
            label10 = new Label();
            TxtEstadia = new TextBox();
            label3 = new Label();
            TxtHoraLlegada = new TextBox();
            label4 = new Label();
            panelPago = new Panel();
            checkBox1 = new CheckBox();
            cbmMetodo = new ComboBox();
            label1 = new Label();
            btnPago = new Button();
            label2 = new Label();
            TimerHora = new System.Windows.Forms.Timer(components);
            ticketBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            panelDerecha.SuspendLayout();
            panelIzquierda.SuspendLayout();
            panelPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(panelHeader);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnPago);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1000, 650);
            panel1.TabIndex = 36;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(20, 20);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(960, 70);
            panelHeader.TabIndex = 55;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(234, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Procesar Pago";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(220, 53, 69);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(800, 580);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 50);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "✖ Cancelar";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(panelDerecha);
            groupBox1.Controls.Add(panelIzquierda);
            groupBox1.Controls.Add(panelPago);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(20, 110);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20);
            groupBox1.Size = new Size(960, 450);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del Ticket";
            // 
            // panelDerecha
            // 
            panelDerecha.Controls.Add(HoraActual);
            panelDerecha.Controls.Add(label5);
            panelDerecha.Controls.Add(TxtPrecio);
            panelDerecha.Controls.Add(label6);
            panelDerecha.Controls.Add(txtdesc);
            panelDerecha.Controls.Add(label8);
            panelDerecha.Controls.Add(TxtPrecioFinal);
            panelDerecha.Controls.Add(label7);
            panelDerecha.Dock = DockStyle.Right;
            panelDerecha.Location = new Point(500, 47);
            panelDerecha.Name = "panelDerecha";
            panelDerecha.Size = new Size(440, 273);
            panelDerecha.TabIndex = 56;
            // 
            // HoraActual
            // 
            HoraActual.AutoSize = true;
            HoraActual.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HoraActual.ForeColor = Color.FromArgb(0, 204, 153);
            HoraActual.Location = new Point(180, 10);
            HoraActual.Margin = new Padding(4, 0, 4, 0);
            HoraActual.Name = "HoraActual";
            HoraActual.Size = new Size(166, 48);
            HoraActual.TabIndex = 41;
            HoraActual.Text = "00:00:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 22);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 40;
            label5.Text = "🕐 Hora Actual";
            // 
            // TxtPrecio
            // 
            TxtPrecio.BackColor = Color.FromArgb(45, 45, 48);
            TxtPrecio.BorderStyle = BorderStyle.FixedSingle;
            TxtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPrecio.ForeColor = Color.White;
            TxtPrecio.Location = new Point(180, 80);
            TxtPrecio.Margin = new Padding(4, 3, 4, 3);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.ReadOnly = true;
            TxtPrecio.Size = new Size(240, 39);
            TxtPrecio.TabIndex = 42;
            TxtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 85);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 28);
            label6.TabIndex = 43;
            label6.Text = "💵 Subtotal";
            // 
            // txtdesc
            // 
            txtdesc.BackColor = Color.FromArgb(45, 45, 48);
            txtdesc.BorderStyle = BorderStyle.FixedSingle;
            txtdesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdesc.ForeColor = Color.FromArgb(40, 167, 69);
            txtdesc.Location = new Point(180, 145);
            txtdesc.Margin = new Padding(4, 3, 4, 3);
            txtdesc.Name = "txtdesc";
            txtdesc.ReadOnly = true;
            txtdesc.Size = new Size(240, 39);
            txtdesc.TabIndex = 47;
            txtdesc.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 150);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 46;
            label8.Text = "🏷️ Descuento";
            // 
            // TxtPrecioFinal
            // 
            TxtPrecioFinal.BackColor = Color.FromArgb(45, 45, 48);
            TxtPrecioFinal.BorderStyle = BorderStyle.FixedSingle;
            TxtPrecioFinal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPrecioFinal.ForeColor = Color.FromArgb(0, 204, 153);
            TxtPrecioFinal.Location = new Point(180, 215);
            TxtPrecioFinal.Margin = new Padding(4, 3, 4, 3);
            TxtPrecioFinal.Name = "TxtPrecioFinal";
            TxtPrecioFinal.ReadOnly = true;
            TxtPrecioFinal.Size = new Size(240, 45);
            TxtPrecioFinal.TabIndex = 44;
            TxtPrecioFinal.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 204, 153);
            label7.Location = new Point(20, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 32);
            label7.TabIndex = 45;
            label7.Text = "💰 TOTAL:";
            // 
            // panelIzquierda
            // 
            panelIzquierda.Controls.Add(lbPatente);
            panelIzquierda.Controls.Add(label9);
            panelIzquierda.Controls.Add(txtTipo);
            panelIzquierda.Controls.Add(label10);
            panelIzquierda.Controls.Add(TxtEstadia);
            panelIzquierda.Controls.Add(label3);
            panelIzquierda.Controls.Add(TxtHoraLlegada);
            panelIzquierda.Controls.Add(label4);
            panelIzquierda.Dock = DockStyle.Left;
            panelIzquierda.Location = new Point(20, 47);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(460, 273);
            panelIzquierda.TabIndex = 55;
            // 
            // lbPatente
            // 
            lbPatente.AutoSize = true;
            lbPatente.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbPatente.ForeColor = Color.FromArgb(0, 122, 204);
            lbPatente.Location = new Point(150, 10);
            lbPatente.Margin = new Padding(4, 0, 4, 0);
            lbPatente.Name = "lbPatente";
            lbPatente.Size = new Size(138, 45);
            lbPatente.TabIndex = 51;
            lbPatente.Text = "ABC123";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(20, 22);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(115, 28);
            label9.TabIndex = 36;
            label9.Text = "📋 Patente";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.FromArgb(45, 45, 48);
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.ForeColor = Color.White;
            txtTipo.Location = new Point(150, 80);
            txtTipo.Margin = new Padding(4, 3, 4, 3);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(280, 37);
            txtTipo.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(20, 85);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 53;
            label10.Text = "🚗 Vehículo";
            // 
            // TxtEstadia
            // 
            TxtEstadia.BackColor = Color.FromArgb(45, 45, 48);
            TxtEstadia.BorderStyle = BorderStyle.FixedSingle;
            TxtEstadia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEstadia.ForeColor = Color.White;
            TxtEstadia.Location = new Point(150, 145);
            TxtEstadia.Margin = new Padding(4, 3, 4, 3);
            TxtEstadia.Name = "TxtEstadia";
            TxtEstadia.ReadOnly = true;
            TxtEstadia.Size = new Size(280, 37);
            TxtEstadia.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 38;
            label3.Text = "⏱️ Estadía";
            // 
            // TxtHoraLlegada
            // 
            TxtHoraLlegada.BackColor = Color.FromArgb(45, 45, 48);
            TxtHoraLlegada.BorderStyle = BorderStyle.FixedSingle;
            TxtHoraLlegada.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtHoraLlegada.ForeColor = Color.White;
            TxtHoraLlegada.Location = new Point(150, 215);
            TxtHoraLlegada.Margin = new Padding(4, 3, 4, 3);
            TxtHoraLlegada.Name = "TxtHoraLlegada";
            TxtHoraLlegada.ReadOnly = true;
            TxtHoraLlegada.Size = new Size(280, 37);
            TxtHoraLlegada.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 39;
            label4.Text = "🕐 Entrada";
            // 
            // panelPago
            // 
            panelPago.Controls.Add(checkBox1);
            panelPago.Controls.Add(cbmMetodo);
            panelPago.Controls.Add(label1);
            panelPago.Dock = DockStyle.Bottom;
            panelPago.Location = new Point(20, 320);
            panelPago.Name = "panelPago";
            panelPago.Padding = new Padding(0, 20, 0, 0);
            panelPago.Size = new Size(920, 110);
            panelPago.TabIndex = 54;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(500, 50);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(272, 32);
            checkBox1.TabIndex = 54;
            checkBox1.Text = "🖨️ Imprimir Comprobante";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbmMetodo
            // 
            cbmMetodo.BackColor = Color.FromArgb(45, 45, 48);
            cbmMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmMetodo.FlatStyle = FlatStyle.Flat;
            cbmMetodo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbmMetodo.ForeColor = Color.White;
            cbmMetodo.FormattingEnabled = true;
            cbmMetodo.Location = new Point(20, 45);
            cbmMetodo.Margin = new Padding(4, 3, 4, 3);
            cbmMetodo.Name = "cbmMetodo";
            cbmMetodo.Size = new Size(450, 38);
            cbmMetodo.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 49;
            label1.Text = "💳 Método de Pago";
            // 
            // btnPago
            // 
            btnPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPago.BackColor = Color.FromArgb(40, 167, 69);
            btnPago.FlatAppearance.BorderSize = 0;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnPago.ForeColor = Color.White;
            btnPago.Location = new Point(20, 580);
            btnPago.Margin = new Padding(4, 3, 4, 3);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(180, 50);
            btnPago.TabIndex = 9;
            btnPago.Text = "✓ Confirmar Pago";
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnPago_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(593, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 35;
            // 
            // TimerHora
            // 
            TimerHora.Enabled = true;
            TimerHora.Tick += TimerHora_Tick;
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 650);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPago";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            panelDerecha.ResumeLayout(false);
            panelDerecha.PerformLayout();
            panelIzquierda.ResumeLayout(false);
            panelIzquierda.PerformLayout();
            panelPago.ResumeLayout(false);
            panelPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private GroupBox groupBox1;
        private Button btnPago;
        private Label label2;
        private BindingSource ticketBindingSource;
        private Label label9;
        private TextBox TxtHoraLlegada;
        private TextBox TxtEstadia;
        private Label label5;
        private Label label4;
        private Label label3;
        private System.Windows.Forms.Timer TimerHora;
        public Label HoraActual;
        private Label label7;
        private TextBox TxtPrecioFinal;
        private Label label6;
        private TextBox TxtPrecio;
        private Label label8;
        private TextBox txtdesc;
        private Label label1;
        private ComboBox cbmMetodo;
        private Label lbPatente;
        private Label label10;
        private TextBox txtTipo;
        private CheckBox checkBox1;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelIzquierda;
        private Panel panelDerecha;
        private Panel panelPago;
    }
}