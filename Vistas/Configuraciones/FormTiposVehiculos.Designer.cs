namespace Vista
{
    partial class FormTiposVehiculos
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
            groupBox2 = new GroupBox();
            ChboxEstado = new CheckBox();
            TxtDesc = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TXTnombre = new TextBox();
            BtnAceptar = new Button();
            label8 = new Label();
            BtnVolver = new Button();
            cbxTiposVehiculos = new ComboBox();
            chboxNuevoVehiculo = new CheckBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox2.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(37, 37, 38);
            groupBox2.Controls.Add(ChboxEstado);
            groupBox2.Controls.Add(TxtDesc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TXTnombre);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox2.Location = new Point(30, 180);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15);
            groupBox2.Size = new Size(520, 280);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Vehículo";
            // 
            // ChboxEstado
            // 
            ChboxEstado.AutoSize = true;
            ChboxEstado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ChboxEstado.ForeColor = Color.White;
            ChboxEstado.Location = new Point(20, 230);
            ChboxEstado.Margin = new Padding(4, 3, 4, 3);
            ChboxEstado.Name = "ChboxEstado";
            ChboxEstado.Size = new Size(173, 32);
            ChboxEstado.TabIndex = 45;
            ChboxEstado.Text = "Vehículo Activo";
            ChboxEstado.UseVisualStyleBackColor = true;
            // 
            // TxtDesc
            // 
            TxtDesc.BackColor = Color.FromArgb(45, 45, 48);
            TxtDesc.BorderStyle = BorderStyle.FixedSingle;
            TxtDesc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDesc.ForeColor = Color.White;
            TxtDesc.Location = new Point(20, 170);
            TxtDesc.Margin = new Padding(4, 3, 4, 3);
            TxtDesc.Multiline = true;
            TxtDesc.Name = "TxtDesc";
            TxtDesc.PlaceholderText = "Ingrese descripción del vehículo";
            TxtDesc.Size = new Size(480, 45);
            TxtDesc.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 41;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 28);
            label1.TabIndex = 40;
            label1.Text = "Nombre de Vehículo";
            // 
            // TXTnombre
            // 
            TXTnombre.BackColor = Color.FromArgb(45, 45, 48);
            TXTnombre.BorderStyle = BorderStyle.FixedSingle;
            TXTnombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTnombre.ForeColor = Color.White;
            TXTnombre.Location = new Point(20, 75);
            TXTnombre.Margin = new Padding(4, 3, 4, 3);
            TXTnombre.Name = "TXTnombre";
            TXTnombre.PlaceholderText = "Ej: Auto, Moto, Camioneta";
            TXTnombre.Size = new Size(480, 37);
            TXTnombre.TabIndex = 32;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAceptar.BackColor = Color.FromArgb(40, 167, 69);
            BtnAceptar.FlatAppearance.BorderSize = 0;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAceptar.ForeColor = Color.White;
            BtnAceptar.Location = new Point(30, 472);
            BtnAceptar.Margin = new Padding(4, 3, 4, 3);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(160, 45);
            BtnAceptar.TabIndex = 29;
            BtnAceptar.Text = "✓ Guardar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 85);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(145, 28);
            label8.TabIndex = 38;
            label8.Text = "Tipo Existente:";
            // 
            // BtnVolver
            // 
            BtnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnVolver.BackColor = Color.FromArgb(220, 53, 69);
            BtnVolver.FlatAppearance.BorderSize = 0;
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVolver.ForeColor = Color.White;
            BtnVolver.Location = new Point(390, 472);
            BtnVolver.Margin = new Padding(4, 3, 4, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(160, 45);
            BtnVolver.TabIndex = 40;
            BtnVolver.Text = "✖ Cancelar";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // cbxTiposVehiculos
            // 
            cbxTiposVehiculos.BackColor = Color.FromArgb(45, 45, 48);
            cbxTiposVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTiposVehiculos.FlatStyle = FlatStyle.Flat;
            cbxTiposVehiculos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTiposVehiculos.ForeColor = Color.White;
            cbxTiposVehiculos.FormattingEnabled = true;
            cbxTiposVehiculos.Location = new Point(288, 81);
            cbxTiposVehiculos.Name = "cbxTiposVehiculos";
            cbxTiposVehiculos.Size = new Size(280, 38);
            cbxTiposVehiculos.TabIndex = 41;
            cbxTiposVehiculos.SelectedIndexChanged += cbxTiposVehiculos_SelectedIndexChanged;
            // 
            // chboxNuevoVehiculo
            // 
            chboxNuevoVehiculo.AutoSize = true;
            chboxNuevoVehiculo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chboxNuevoVehiculo.ForeColor = Color.White;
            chboxNuevoVehiculo.Location = new Point(30, 135);
            chboxNuevoVehiculo.Margin = new Padding(4, 3, 4, 3);
            chboxNuevoVehiculo.Name = "chboxNuevoVehiculo";
            chboxNuevoVehiculo.Size = new Size(223, 32);
            chboxNuevoVehiculo.TabIndex = 43;
            chboxNuevoVehiculo.Text = "➕ Crear Nuevo Tipo";
            chboxNuevoVehiculo.UseVisualStyleBackColor = true;
            chboxNuevoVehiculo.CheckedChanged += chboxNuevoVehiculo_CheckedChanged;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(580, 60);
            panelHeader.TabIndex = 44;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(259, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tipos de Vehículos";
            // 
            // FormTiposVehiculos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(580, 542);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(chboxNuevoVehiculo);
            Controls.Add(cbxTiposVehiculos);
            Controls.Add(BtnVolver);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(BtnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormTiposVehiculos";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label1;
        private Button BtnAceptar;
        private TextBox TXTnombre;
        private Label label8;
        private TextBox TxtDesc;
        private Label label2;
        private Button BtnVolver;
        private ComboBox cbxTiposVehiculos;
        private CheckBox chboxNuevoVehiculo;
        private CheckBox ChboxEstado;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}