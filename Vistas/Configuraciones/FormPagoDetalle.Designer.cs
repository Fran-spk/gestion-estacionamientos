namespace Vista
{
    partial class FormPagoDetalle
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
            TxtMontoFinal = new Label();
            TxtFecha = new Label();
            TxtDescuento = new Label();
            TxtMonto = new Label();
            TxtEstadia = new Label();
            Txtpatente = new Label();
            BtnSalir = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            vehiculoBindingSource = new BindingSource(components);
            vehiculoBindingSource1 = new BindingSource(components);
            label1 = new Label();
            lbMetodo = new Label();
            label9 = new Label();
            BtnImprimir = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBoxDatos = new GroupBox();
            panelSeparador = new Panel();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource1).BeginInit();
            panelHeader.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            SuspendLayout();
            // 
            // TxtMontoFinal
            // 
            TxtMontoFinal.AutoSize = true;
            TxtMontoFinal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMontoFinal.ForeColor = Color.FromArgb(0, 204, 153);
            TxtMontoFinal.Location = new Point(280, 253);
            TxtMontoFinal.Margin = new Padding(4, 0, 4, 0);
            TxtMontoFinal.Name = "TxtMontoFinal";
            TxtMontoFinal.Size = new Size(89, 38);
            TxtMontoFinal.TabIndex = 67;
            TxtMontoFinal.Text = "$0.00";
            // 
            // TxtFecha
            // 
            TxtFecha.AutoSize = true;
            TxtFecha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtFecha.ForeColor = Color.White;
            TxtFecha.Location = new Point(280, 313);
            TxtFecha.Margin = new Padding(4, 0, 4, 0);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(186, 30);
            TxtFecha.TabIndex = 66;
            TxtFecha.Text = "01/01/2026 12:00";
            // 
            // TxtDescuento
            // 
            TxtDescuento.AutoSize = true;
            TxtDescuento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDescuento.ForeColor = Color.FromArgb(40, 167, 69);
            TxtDescuento.Location = new Point(280, 203);
            TxtDescuento.Margin = new Padding(4, 0, 4, 0);
            TxtDescuento.Name = "TxtDescuento";
            TxtDescuento.Size = new Size(66, 30);
            TxtDescuento.TabIndex = 65;
            TxtDescuento.Text = "$0.00";
            // 
            // TxtMonto
            // 
            TxtMonto.AutoSize = true;
            TxtMonto.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMonto.ForeColor = Color.White;
            TxtMonto.Location = new Point(280, 153);
            TxtMonto.Margin = new Padding(4, 0, 4, 0);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(66, 30);
            TxtMonto.TabIndex = 64;
            TxtMonto.Text = "$0.00";
            // 
            // TxtEstadia
            // 
            TxtEstadia.AutoSize = true;
            TxtEstadia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEstadia.ForeColor = Color.White;
            TxtEstadia.Location = new Point(280, 103);
            TxtEstadia.Margin = new Padding(4, 0, 4, 0);
            TxtEstadia.Name = "TxtEstadia";
            TxtEstadia.Size = new Size(125, 30);
            TxtEstadia.TabIndex = 63;
            TxtEstadia.Text = "02:30 horas";
            // 
            // Txtpatente
            // 
            Txtpatente.AutoSize = true;
            Txtpatente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txtpatente.ForeColor = Color.FromArgb(0, 122, 204);
            Txtpatente.Location = new Point(280, 53);
            Txtpatente.Margin = new Padding(4, 0, 4, 0);
            Txtpatente.Name = "Txtpatente";
            Txtpatente.Size = new Size(103, 32);
            Txtpatente.TabIndex = 62;
            Txtpatente.Text = "ABC123";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.BackColor = Color.FromArgb(220, 53, 69);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(430, 505);
            BtnSalir.Margin = new Padding(4, 3, 4, 3);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(180, 50);
            BtnSalir.TabIndex = 61;
            BtnSalir.Text = "✖ Cerrar";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 313);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(197, 28);
            label8.TabIndex = 60;
            label8.Text = "🕐 Fecha Operación";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 203);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 28);
            label7.TabIndex = 59;
            label7.Text = "🏷️ Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 204, 153);
            label6.Location = new Point(30, 258);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 32);
            label6.TabIndex = 58;
            label6.Text = "💰 TOTAL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 56;
            label4.Text = "⏱️ Estadía";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 55;
            label2.Text = "📋 Patente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 153);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 57;
            label5.Text = "💵 Subtotal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(280, 420);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 68;
            // 
            // lbMetodo
            // 
            lbMetodo.AutoSize = true;
            lbMetodo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbMetodo.ForeColor = Color.White;
            lbMetodo.Location = new Point(280, 376);
            lbMetodo.Margin = new Padding(4, 0, 4, 0);
            lbMetodo.Name = "lbMetodo";
            lbMetodo.Size = new Size(89, 30);
            lbMetodo.TabIndex = 70;
            lbMetodo.Text = "Efectivo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 376);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(198, 28);
            label9.TabIndex = 69;
            label9.Text = "💳 Método de Pago";
            // 
            // BtnImprimir
            // 
            BtnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnImprimir.BackColor = Color.FromArgb(0, 122, 204);
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatStyle = FlatStyle.Flat;
            BtnImprimir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnImprimir.ForeColor = Color.White;
            BtnImprimir.Location = new Point(30, 505);
            BtnImprimir.Margin = new Padding(4, 3, 4, 3);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(180, 50);
            BtnImprimir.TabIndex = 71;
            BtnImprimir.Text = "🖨️ Imprimir";
            BtnImprimir.UseVisualStyleBackColor = false;
            BtnImprimir.Click += BtnImprimir_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(640, 70);
            panelHeader.TabIndex = 72;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Comprobante de Pago";
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxDatos.Controls.Add(panelSeparador);
            groupBoxDatos.Controls.Add(label2);
            groupBoxDatos.Controls.Add(Txtpatente);
            groupBoxDatos.Controls.Add(label4);
            groupBoxDatos.Controls.Add(TxtEstadia);
            groupBoxDatos.Controls.Add(label5);
            groupBoxDatos.Controls.Add(TxtMonto);
            groupBoxDatos.Controls.Add(label7);
            groupBoxDatos.Controls.Add(TxtDescuento);
            groupBoxDatos.Controls.Add(label6);
            groupBoxDatos.Controls.Add(TxtMontoFinal);
            groupBoxDatos.Controls.Add(label8);
            groupBoxDatos.Controls.Add(TxtFecha);
            groupBoxDatos.Controls.Add(label9);
            groupBoxDatos.Controls.Add(lbMetodo);
            groupBoxDatos.FlatStyle = FlatStyle.Flat;
            groupBoxDatos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDatos.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxDatos.Location = new Point(30, 90);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(15);
            groupBoxDatos.Size = new Size(580, 409);
            groupBoxDatos.TabIndex = 73;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Detalles de la Transacción";
            // 
            // panelSeparador
            // 
            panelSeparador.BackColor = Color.FromArgb(0, 122, 204);
            panelSeparador.Location = new Point(30, 248);
            panelSeparador.Name = "panelSeparador";
            panelSeparador.Size = new Size(520, 2);
            panelSeparador.TabIndex = 71;
            // 
            // FormPagoDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(640, 565);
            ControlBox = false;
            Controls.Add(groupBoxDatos);
            Controls.Add(panelHeader);
            Controls.Add(BtnImprimir);
            Controls.Add(label1);
            Controls.Add(BtnSalir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPagoDetalle";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label TxtMontoFinal;
        private System.Windows.Forms.Label TxtFecha;
        private System.Windows.Forms.Label TxtDescuento;
        private System.Windows.Forms.Label TxtMonto;
        private System.Windows.Forms.Label TxtEstadia;
        private System.Windows.Forms.Label Txtpatente;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private System.Windows.Forms.BindingSource vehiculoBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMetodo;
        private System.Windows.Forms.Label label9;
        private Button BtnImprimir;
        private Panel panelHeader;
        private Label lblTitulo;
        private GroupBox groupBoxDatos;
        private Panel panelSeparador;
    }
}