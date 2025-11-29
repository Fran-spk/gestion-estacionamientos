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
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ChboxEstado);
            groupBox2.Controls.Add(TxtDesc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TXTnombre);
            groupBox2.Location = new Point(12, 77);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(378, 211);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // ChboxEstado
            // 
            ChboxEstado.AutoSize = true;
            ChboxEstado.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChboxEstado.ForeColor = SystemColors.ButtonHighlight;
            ChboxEstado.Location = new Point(14, 158);
            ChboxEstado.Margin = new Padding(4, 3, 4, 3);
            ChboxEstado.Name = "ChboxEstado";
            ChboxEstado.Size = new Size(163, 23);
            ChboxEstado.TabIndex = 45;
            ChboxEstado.Text = "Vehiculo activo";
            ChboxEstado.UseVisualStyleBackColor = true;
            // 
            // TxtDesc
            // 
            TxtDesc.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDesc.Location = new Point(14, 108);
            TxtDesc.Margin = new Padding(4, 3, 4, 3);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.Size = new Size(200, 26);
            TxtDesc.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(14, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 41;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(14, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 19);
            label1.TabIndex = 40;
            label1.Text = "Nombre de vehiculo";
            // 
            // TXTnombre
            // 
            TXTnombre.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TXTnombre.Location = new Point(14, 41);
            TXTnombre.Margin = new Padding(4, 3, 4, 3);
            TXTnombre.Name = "TXTnombre";
            TXTnombre.Size = new Size(200, 26);
            TXTnombre.TabIndex = 32;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.FromArgb(32, 30, 45);
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAceptar.ForeColor = SystemColors.ButtonFace;
            BtnAceptar.Location = new Point(13, 294);
            BtnAceptar.Margin = new Padding(4, 3, 4, 3);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(110, 33);
            BtnAceptar.TabIndex = 29;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(12, 16);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(153, 19);
            label8.TabIndex = 38;
            label8.Text = "Tipo de vehiculo";
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(48, 30, 35);
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVolver.ForeColor = SystemColors.ButtonFace;
            BtnVolver.Location = new Point(280, 294);
            BtnVolver.Margin = new Padding(4, 3, 4, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(110, 33);
            BtnVolver.TabIndex = 40;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // cbxTiposVehiculos
            // 
            cbxTiposVehiculos.FormattingEnabled = true;
            cbxTiposVehiculos.Location = new Point(183, 12);
            cbxTiposVehiculos.Name = "cbxTiposVehiculos";
            cbxTiposVehiculos.Size = new Size(205, 23);
            cbxTiposVehiculos.TabIndex = 41;
            cbxTiposVehiculos.SelectedIndexChanged += cbxTiposVehiculos_SelectedIndexChanged;
            // 
            // chboxNuevoVehiculo
            // 
            chboxNuevoVehiculo.AutoSize = true;
            chboxNuevoVehiculo.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chboxNuevoVehiculo.ForeColor = SystemColors.ButtonHighlight;
            chboxNuevoVehiculo.Location = new Point(16, 48);
            chboxNuevoVehiculo.Margin = new Padding(4, 3, 4, 3);
            chboxNuevoVehiculo.Name = "chboxNuevoVehiculo";
            chboxNuevoVehiculo.Size = new Size(118, 23);
            chboxNuevoVehiculo.TabIndex = 43;
            chboxNuevoVehiculo.Text = "Nuevo tipo";
            chboxNuevoVehiculo.UseVisualStyleBackColor = true;
            chboxNuevoVehiculo.CheckedChanged += chboxNuevoVehiculo_CheckedChanged;
            // 
            // FormTiposVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(400, 339);
            ControlBox = false;
            Controls.Add(chboxNuevoVehiculo);
            Controls.Add(cbxTiposVehiculos);
            Controls.Add(BtnVolver);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(BtnAceptar);
            Name = "FormTiposVehiculos";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}