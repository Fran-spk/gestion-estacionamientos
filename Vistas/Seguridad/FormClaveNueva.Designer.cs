namespace Vista.Seguridad
{
    partial class FormClaveNueva
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
            panel1 = new Panel();
            label2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label4 = new Label();
            txtClaveNueva = new TextBox();
            label5 = new Label();
            txtClaveActual = new TextBox();
            label1 = new Label();
            txtConfirmar = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 39);
            panel1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(366, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 31;
            label2.Text = "Cambiar clave";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(417, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 40);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(323, 206);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 40);
            btnAceptar.TabIndex = 35;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(26, 117);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 19);
            label4.TabIndex = 34;
            label4.Text = "Clave nueva:";
            // 
            // txtClaveNueva
            // 
            txtClaveNueva.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClaveNueva.Location = new Point(171, 110);
            txtClaveNueva.Margin = new Padding(4, 3, 4, 3);
            txtClaveNueva.Name = "txtClaveNueva";
            txtClaveNueva.PasswordChar = '*';
            txtClaveNueva.Size = new Size(284, 26);
            txtClaveNueva.TabIndex = 33;
            txtClaveNueva.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(26, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 19);
            label5.TabIndex = 32;
            label5.Text = "Clave actual:";
            // 
            // txtClaveActual
            // 
            txtClaveActual.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClaveActual.Location = new Point(171, 63);
            txtClaveActual.Margin = new Padding(4, 3, 4, 3);
            txtClaveActual.Name = "txtClaveActual";
            txtClaveActual.PasswordChar = '*';
            txtClaveActual.Size = new Size(284, 26);
            txtClaveActual.TabIndex = 31;
            txtClaveActual.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(26, 167);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 40;
            label1.Text = "Confirmar:";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmar.Location = new Point(171, 160);
            txtConfirmar.Margin = new Padding(4, 3, 4, 3);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PasswordChar = '*';
            txtConfirmar.Size = new Size(284, 26);
            txtConfirmar.TabIndex = 39;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // FormClaveNueva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 258);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(txtConfirmar);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(txtClaveNueva);
            Controls.Add(label5);
            Controls.Add(txtClaveActual);
            Name = "FormClaveNueva";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label4;
        private TextBox txtClaveNueva;
        private Label label5;
        private TextBox txtClaveActual;
        private Label label1;
        private TextBox txtConfirmar;
    }
}