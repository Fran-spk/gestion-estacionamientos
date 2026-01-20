namespace Vista
{
    partial class formTarifa
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
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtMedHora = new TextBox();
            label2 = new Label();
            txtHora = new TextBox();
            label4 = new Label();
            txtDia = new TextBox();
            label3 = new Label();
            textMes = new TextBox();
            btnaceptar = new Button();
            btncancelar = new Button();
            panelHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(580, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(267, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Actualizar Tarifas";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMedHora);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHora);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textMes);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(30, 80);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(520, 400);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuración de Tarifas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo de vehículo";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(45, 45, 48);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(480, 38);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 130);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 2;
            label5.Text = "Media hora";
            // 
            // txtMedHora
            // 
            txtMedHora.BackColor = Color.FromArgb(45, 45, 48);
            txtMedHora.BorderStyle = BorderStyle.FixedSingle;
            txtMedHora.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedHora.ForeColor = Color.White;
            txtMedHora.Location = new Point(20, 165);
            txtMedHora.Name = "txtMedHora";
            txtMedHora.PlaceholderText = "Precio por media hora";
            txtMedHora.Size = new Size(220, 37);
            txtMedHora.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(280, 130);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 4;
            label2.Text = "Hora";
            // 
            // txtHora
            // 
            txtHora.BackColor = Color.FromArgb(45, 45, 48);
            txtHora.BorderStyle = BorderStyle.FixedSingle;
            txtHora.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtHora.ForeColor = Color.White;
            txtHora.Location = new Point(280, 165);
            txtHora.Name = "txtHora";
            txtHora.PlaceholderText = "Precio por hora";
            txtHora.Size = new Size(220, 37);
            txtHora.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 220);
            label4.Name = "label4";
            label4.Size = new Size(41, 28);
            label4.TabIndex = 6;
            label4.Text = "Día";
            // 
            // txtDia
            // 
            txtDia.BackColor = Color.FromArgb(45, 45, 48);
            txtDia.BorderStyle = BorderStyle.FixedSingle;
            txtDia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDia.ForeColor = Color.White;
            txtDia.Location = new Point(20, 255);
            txtDia.Name = "txtDia";
            txtDia.PlaceholderText = "Precio por día";
            txtDia.Size = new Size(220, 37);
            txtDia.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(280, 220);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 8;
            label3.Text = "Mes";
            // 
            // textMes
            // 
            textMes.BackColor = Color.FromArgb(45, 45, 48);
            textMes.BorderStyle = BorderStyle.FixedSingle;
            textMes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textMes.ForeColor = Color.White;
            textMes.Location = new Point(280, 255);
            textMes.Name = "textMes";
            textMes.PlaceholderText = "Precio por mes";
            textMes.Size = new Size(220, 37);
            textMes.TabIndex = 9;
            // 
            // btnaceptar
            // 
            btnaceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnaceptar.BackColor = Color.FromArgb(40, 167, 69);
            btnaceptar.FlatAppearance.BorderSize = 0;
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnaceptar.ForeColor = Color.White;
            btnaceptar.Location = new Point(30, 492);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(160, 45);
            btnaceptar.TabIndex = 2;
            btnaceptar.Text = "✓ Actualizar";
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
            btncancelar.Location = new Point(390, 492);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 45);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "✖ Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // formTarifa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(580, 560);
            ControlBox = false;
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Controls.Add(groupBox1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formTarifa";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtMedHora;
        private Label label2;
        private TextBox txtHora;
        private Label label4;
        private TextBox txtDia;
        private Label label3;
        private TextBox textMes;
        private Button btnaceptar;
        private Button btncancelar;
    }
}