namespace Vista.Seguridad
{
    partial class FormRecuperarClave
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
            txtEmail = new TextBox();
            label5 = new Label();
            txtUsuario = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 37);
            panel1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(346, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 19);
            label2.TabIndex = 31;
            label2.Text = "Recuperar clave";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(371, 179);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 40);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(265, 179);
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
            label4.Location = new Point(45, 106);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 34;
            label4.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(45, 128);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 26);
            txtEmail.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(45, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 32;
            label5.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(45, 64);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(248, 26);
            txtUsuario.TabIndex = 31;
            // 
            // FormRecuperarClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 225);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtUsuario);
            Name = "FormRecuperarClave";
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
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtUsuario;
    }
}