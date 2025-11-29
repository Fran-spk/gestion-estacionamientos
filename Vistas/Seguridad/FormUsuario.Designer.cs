namespace Vista.Seguridad
{
    partial class FormUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Apellido = new Label();
            cmxEstado = new ComboBox();
            txtEmail = new TextBox();
            txtNomb = new TextBox();
            txtUsuario = new TextBox();
            tabPage2 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            tabPage3 = new TabPage();
            treeView1 = new TreeView();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(14, 40);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(770, 222);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Apellido);
            tabPage1.Controls.Add(cmxEstado);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtNomb);
            tabPage1.Controls.Add(txtUsuario);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(762, 189);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mis datos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(19, 48);
            Apellido.Margin = new Padding(4, 0, 4, 0);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(64, 20);
            Apellido.TabIndex = 4;
            Apellido.Text = "Usuario";
            // 
            // cmxEstado
            // 
            cmxEstado.FormattingEnabled = true;
            cmxEstado.Location = new Point(99, 144);
            cmxEstado.Margin = new Padding(4, 3, 4, 3);
            cmxEstado.Name = "cmxEstado";
            cmxEstado.Size = new Size(221, 28);
            cmxEstado.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 92);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtNomb
            // 
            txtNomb.Location = new Point(466, 40);
            txtNomb.Margin = new Padding(4, 3, 4, 3);
            txtNomb.Name = "txtNomb";
            txtNomb.Size = new Size(221, 26);
            txtNomb.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(99, 40);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 26);
            txtUsuario.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkedListBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(762, 189);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Grupos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(30, 29);
            checkedListBox1.Margin = new Padding(4, 3, 4, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(696, 142);
            checkedListBox1.TabIndex = 9;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(treeView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 3, 4, 3);
            tabPage3.Size = new Size(762, 189);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Acciones";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.BorderStyle = BorderStyle.FixedSingle;
            treeView1.CheckBoxes = true;
            treeView1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.ItemHeight = 22;
            treeView1.Location = new Point(30, 29);
            treeView1.Margin = new Padding(4, 3, 4, 3);
            treeView1.Name = "treeView1";
            treeView1.RightToLeft = RightToLeft.No;
            treeView1.Size = new Size(680, 145);
            treeView1.TabIndex = 2;
            treeView1.AfterCheck += treeView1_AfterCheck;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(676, 264);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 45);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(556, 264);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 45);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 37);
            panel1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(717, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 31;
            label4.Text = "Usuario";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 315);
            ControlBox = false;
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormUsuario";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.ComboBox cmxEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private Panel panel1;
        private Label label4;
    }
}

