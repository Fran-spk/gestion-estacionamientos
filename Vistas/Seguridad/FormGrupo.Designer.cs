namespace Vista.Seguridad
{
    partial class FormGrupo
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Apellido = new Label();
            cmbEstado = new ComboBox();
            TxtNombre = new TextBox();
            txtDesc = new TextBox();
            txtCodigo = new TextBox();
            tabPage3 = new TabPage();
            treeView1 = new TreeView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(717, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 31;
            label4.Text = "Grupo";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(559, 300);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 45);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(676, 300);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 45);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 37);
            panel1.TabIndex = 35;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(18, 46);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(770, 248);
            tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Apellido);
            tabPage1.Controls.Add(cmbEstado);
            tabPage1.Controls.Add(TxtNombre);
            tabPage1.Controls.Add(txtDesc);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(762, 215);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 184);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 11;
            label8.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 99);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 10;
            label7.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 56);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 9;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 24);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 8;
            label5.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(23, 51);
            Apellido.Margin = new Padding(4, 0, 4, 0);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(0, 20);
            Apellido.TabIndex = 4;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(99, 181);
            cmbEstado.Margin = new Padding(4, 3, 4, 3);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(221, 28);
            cmbEstado.TabIndex = 3;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(99, 53);
            TxtNombre.Margin = new Padding(4, 3, 4, 3);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(221, 26);
            TxtNombre.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(99, 85);
            txtDesc.Margin = new Padding(4, 3, 4, 3);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ScrollBars = ScrollBars.Horizontal;
            txtDesc.Size = new Size(644, 73);
            txtDesc.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(99, 21);
            txtCodigo.Margin = new Padding(4, 3, 4, 3);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(221, 26);
            txtCodigo.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(treeView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 3, 4, 3);
            tabPage3.Size = new Size(762, 215);
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
            // FormGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 348);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Name = "FormGrupo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Button btnGuardar;
        private Button btnCancelar;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Apellido;
        private ComboBox cmbEstado;
        private TextBox TxtNombre;
        private TextBox txtDesc;
        private TextBox txtCodigo;
        private TabPage tabPage3;
        private TreeView treeView1;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}