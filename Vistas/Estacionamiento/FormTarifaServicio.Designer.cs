namespace Vista.Estacionamiento
{
    partial class FormTarifaServicio
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
            chkVigente = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            comboServicio = new ComboBox();
            label1 = new Label();
            comboVehiculo = new ComboBox();
            label2 = new Label();
            txtTiempoEstimado = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
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
            panelHeader.Size = new Size(574, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(389, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💰 Actualizar Tarifa Servicio";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(chkVigente);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboServicio);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboVehiculo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTiempoEstimado);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(30, 80);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(520, 520);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuración de Tarifa";
            // 
            // chkVigente
            // 
            chkVigente.AutoSize = true;
            chkVigente.FlatStyle = FlatStyle.Flat;
            chkVigente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkVigente.ForeColor = Color.White;
            chkVigente.Location = new Point(20, 475);
            chkVigente.Name = "chkVigente";
            chkVigente.Size = new Size(419, 32);
            chkVigente.TabIndex = 13;
            chkVigente.Text = "Servicio vigente para este tipo de vehiculos?";
            chkVigente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 430);
            label7.Name = "label7";
            label7.Size = new Size(176, 28);
            label7.TabIndex = 12;
            label7.Text = "Estado de servicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 130);
            label6.Name = "label6";
            label6.Size = new Size(158, 28);
            label6.TabIndex = 10;
            label6.Text = "Tipo de Servicio";
            // 
            // comboServicio
            // 
            comboServicio.BackColor = Color.FromArgb(45, 45, 48);
            comboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboServicio.FlatStyle = FlatStyle.Flat;
            comboServicio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboServicio.ForeColor = Color.White;
            comboServicio.FormattingEnabled = true;
            comboServicio.Location = new Point(20, 165);
            comboServicio.Name = "comboServicio";
            comboServicio.Size = new Size(480, 38);
            comboServicio.TabIndex = 11;
            comboServicio.SelectedIndexChanged += CmbSeleccionado_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Vehículo";
            // 
            // comboVehiculo
            // 
            comboVehiculo.BackColor = Color.FromArgb(45, 45, 48);
            comboVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVehiculo.FlatStyle = FlatStyle.Flat;
            comboVehiculo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboVehiculo.ForeColor = Color.White;
            comboVehiculo.FormattingEnabled = true;
            comboVehiculo.Location = new Point(20, 75);
            comboVehiculo.Name = "comboVehiculo";
            comboVehiculo.Size = new Size(480, 38);
            comboVehiculo.TabIndex = 1;
            comboVehiculo.SelectedIndexChanged += CmbSeleccionado_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 320);
            label2.Name = "label2";
            label2.Size = new Size(265, 28);
            label2.TabIndex = 8;
            label2.Text = "Tiempo Estimado (minutos)";
            // 
            // txtTiempoEstimado
            // 
            txtTiempoEstimado.BackColor = Color.FromArgb(45, 45, 48);
            txtTiempoEstimado.BorderStyle = BorderStyle.FixedSingle;
            txtTiempoEstimado.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTiempoEstimado.ForeColor = Color.White;
            txtTiempoEstimado.Location = new Point(20, 355);
            txtTiempoEstimado.Name = "txtTiempoEstimado";
            txtTiempoEstimado.PlaceholderText = "Ejemplo: 30, 45, 60";
            txtTiempoEstimado.Size = new Size(480, 37);
            txtTiempoEstimado.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 220);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 2;
            label5.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(45, 45, 48);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(20, 255);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Ingrese el precio del servicio";
            txtPrecio.Size = new Size(480, 37);
            txtPrecio.TabIndex = 3;
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(40, 167, 69);
            btnaceptar.FlatAppearance.BorderSize = 0;
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnaceptar.ForeColor = Color.White;
            btnaceptar.Location = new Point(30, 620);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(160, 45);
            btnaceptar.TabIndex = 2;
            btnaceptar.Text = "✓ Actualizar";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += BtnAceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(220, 53, 69);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(390, 620);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 45);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "✖ Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click_1;
            // 
            // FormTarifaServicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(574, 685);
            ControlBox = false;
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Controls.Add(groupBox1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTarifaServicio";
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
        private ComboBox comboVehiculo;
        private Label label5;
        private TextBox txtPrecio;
        private Button btncancelar;
        private Button btnaceptar;
        private Label label6;
        private ComboBox comboServicio;
        private Label label2;
        private TextBox txtTiempoEstimado;
        private Label label7;
        private CheckBox chkVigente;
    }
}