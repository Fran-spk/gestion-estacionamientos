namespace Vista
{
    partial class FormEspacio
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
            ChboxMensual = new CheckBox();
            TxtCapacidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TxtNombre = new TextBox();
            BtnVolver = new Button();
            BtnAceptar = new Button();
            label3 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ChboxMensual);
            groupBox2.Controls.Add(TxtCapacidad);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtNombre);
            groupBox2.Location = new Point(13, 31);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(378, 218);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            // 
            // ChboxMensual
            // 
            ChboxMensual.AutoSize = true;
            ChboxMensual.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChboxMensual.ForeColor = SystemColors.ButtonHighlight;
            ChboxMensual.Location = new Point(14, 166);
            ChboxMensual.Margin = new Padding(4, 3, 4, 3);
            ChboxMensual.Name = "ChboxMensual";
            ChboxMensual.Size = new Size(91, 23);
            ChboxMensual.TabIndex = 45;
            ChboxMensual.Text = "Menusal";
            ChboxMensual.UseVisualStyleBackColor = true;
            // 
            // TxtCapacidad
            // 
            TxtCapacidad.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCapacidad.Location = new Point(14, 108);
            TxtCapacidad.Margin = new Padding(4, 3, 4, 3);
            TxtCapacidad.Name = "TxtCapacidad";
            TxtCapacidad.Size = new Size(200, 26);
            TxtCapacidad.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(15, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 19);
            label2.TabIndex = 41;
            label2.Text = "Capacidad maxima:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(15, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 19);
            label1.TabIndex = 40;
            label1.Text = "Descripcion de espacio:";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.Location = new Point(14, 41);
            TxtNombre.Margin = new Padding(4, 3, 4, 3);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(200, 26);
            TxtNombre.TabIndex = 32;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.FromArgb(48, 30, 35);
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVolver.ForeColor = SystemColors.ButtonFace;
            BtnVolver.Location = new Point(281, 255);
            BtnVolver.Margin = new Padding(4, 3, 4, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(110, 33);
            BtnVolver.TabIndex = 47;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.FromArgb(32, 30, 45);
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAceptar.ForeColor = SystemColors.ButtonFace;
            BtnAceptar.Location = new Point(13, 255);
            BtnAceptar.Margin = new Padding(4, 3, 4, 3);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(110, 33);
            BtnAceptar.TabIndex = 44;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(10, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 19);
            label3.TabIndex = 46;
            label3.Text = "Espacio de parqueo:";
            // 
            // FormEspacio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(406, 298);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(BtnVolver);
            Controls.Add(BtnAceptar);
            Name = "FormEspacio";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox ChboxMensual;
        private TextBox TxtCapacidad;
        private Label label2;
        private Label label1;
        private TextBox TxtNombre;
        private Button BtnVolver;
        private Button BtnAceptar;
        private Label label3;
    }
}