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
            btnaceptar = new Button();
            btncancelar = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtHora = new TextBox();
            txtMedHora = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            textMes = new TextBox();
            txtDia = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(48, 30, 35);
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaceptar.ForeColor = SystemColors.ButtonFace;
            btnaceptar.Location = new Point(15, 275);
            btnaceptar.Margin = new Padding(4, 3, 4, 3);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(147, 33);
            btnaceptar.TabIndex = 24;
            btnaceptar.Text = "Actualizar";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(32, 30, 45);
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.ForeColor = SystemColors.ButtonFace;
            btncancelar.Location = new Point(393, 275);
            btncancelar.Margin = new Padding(4, 3, 4, 3);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(147, 33);
            btncancelar.TabIndex = 23;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(18, 25);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 19);
            label5.TabIndex = 20;
            label5.Text = "Media hora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(18, 127);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 19;
            label4.Text = "Dia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(18, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 18;
            label2.Text = "Hora:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(9, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 17;
            label1.Text = "Tipo de vehiculo:";
            // 
            // txtHora
            // 
            txtHora.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHora.Location = new Point(279, 70);
            txtHora.Margin = new Padding(4, 3, 4, 3);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(222, 26);
            txtHora.TabIndex = 16;
            // 
            // txtMedHora
            // 
            txtMedHora.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedHora.Location = new Point(279, 22);
            txtMedHora.Margin = new Padding(4, 3, 4, 3);
            txtMedHora.Name = "txtMedHora";
            txtMedHora.Size = new Size(222, 26);
            txtMedHora.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(205, 10);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 27);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textMes);
            groupBox1.Controls.Add(txtDia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHora);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMedHora);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 45);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(525, 223);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // textMes
            // 
            textMes.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMes.Location = new Point(279, 171);
            textMes.Margin = new Padding(4, 3, 4, 3);
            textMes.Name = "textMes";
            textMes.Size = new Size(222, 26);
            textMes.TabIndex = 25;
            // 
            // txtDia
            // 
            txtDia.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDia.Location = new Point(279, 119);
            txtDia.Margin = new Padding(4, 3, 4, 3);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(222, 26);
            txtDia.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(18, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 25;
            label3.Text = "Mes:";
            // 
            // formTarifa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(554, 318);
            ControlBox = false;
            Controls.Add(btnaceptar);
            Controls.Add(btncancelar);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formTarifa";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaceptar;
        private Button btncancelar;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtHora;
        private TextBox txtMedHora;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox textMes;
        private TextBox txtDia;
        private Label label3;
    }
}