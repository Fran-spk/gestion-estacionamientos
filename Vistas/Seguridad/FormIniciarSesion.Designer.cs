namespace Vista.Seguridad
{
    partial class FormIniciarSesion
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
            label4 = new Label();
            txtClave = new TextBox();
            label5 = new Label();
            txtUsuario = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lbRecuperarClave = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(37, 97);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 26;
            label4.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(37, 119);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(248, 26);
            txtClave.TabIndex = 25;
            txtClave.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(37, 33);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 24;
            label5.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(37, 55);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(248, 26);
            txtUsuario.TabIndex = 23;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(257, 170);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 40);
            btnAceptar.TabIndex = 27;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(363, 170);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 40);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lbRecuperarClave
            // 
            lbRecuperarClave.AutoSize = true;
            lbRecuperarClave.Cursor = Cursors.Hand;
            lbRecuperarClave.Font = new Font("Consolas", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            lbRecuperarClave.ForeColor = Color.DarkBlue;
            lbRecuperarClave.Location = new Point(37, 149);
            lbRecuperarClave.Margin = new Padding(4, 0, 4, 0);
            lbRecuperarClave.Name = "lbRecuperarClave";
            lbRecuperarClave.Size = new Size(147, 15);
            lbRecuperarClave.TabIndex = 29;
            lbRecuperarClave.Text = "Olvide mi contraseña";
            lbRecuperarClave.Click += lbRecuperarClave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-8, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 37);
            panel1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(349, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 31;
            label2.Text = "Iniciar sesión";
            // 
            // FormIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 213);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(lbRecuperarClave);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(txtClave);
            Controls.Add(label5);
            Controls.Add(txtUsuario);
            Name = "FormIniciarSesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtClave;
        private Label label5;
        private TextBox txtUsuario;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lbRecuperarClave;
        private Panel panel1;
        private Label label2;
    }
}