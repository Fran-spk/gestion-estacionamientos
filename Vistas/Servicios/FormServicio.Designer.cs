namespace Vista
{
    partial class FormServicio
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
            comboBox1 = new ComboBox();
            txtpatente = new TextBox();
            label1 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cboxtiempo = new ComboBox();
            btnaceptar = new Button();
            btncancelar = new Button();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            comboBox1.Location = new Point(235, 12);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 27);
            comboBox1.TabIndex = 15;
            // 
            // txtpatente
            // 
            txtpatente.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpatente.Location = new Point(322, 40);
            txtpatente.Margin = new Padding(4, 3, 4, 3);
            txtpatente.Name = "txtpatente";
            txtpatente.Size = new Size(214, 26);
            txtpatente.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(13, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 16;
            label1.Text = "Tipo de servicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(27, 43);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 9;
            label5.Text = "Patente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboxtiempo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtpatente);
            groupBox1.Location = new Point(17, 47);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(562, 265);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // cboxtiempo
            // 
            cboxtiempo.BackColor = Color.Gray;
            cboxtiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxtiempo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxtiempo.FormattingEnabled = true;
            cboxtiempo.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            cboxtiempo.Location = new Point(322, 97);
            cboxtiempo.Margin = new Padding(4, 3, 4, 3);
            cboxtiempo.Name = "cboxtiempo";
            cboxtiempo.Size = new Size(214, 27);
            cboxtiempo.TabIndex = 14;
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(48, 30, 35);
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaceptar.ForeColor = SystemColors.ButtonFace;
            btnaceptar.Location = new Point(17, 318);
            btnaceptar.Margin = new Padding(4, 3, 4, 3);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(147, 44);
            btnaceptar.TabIndex = 19;
            btnaceptar.Text = "Aceptar";
            btnaceptar.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(32, 30, 45);
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.ForeColor = SystemColors.ButtonFace;
            btncancelar.Location = new Point(432, 318);
            btncancelar.Margin = new Padding(4, 3, 4, 3);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(147, 44);
            btncancelar.TabIndex = 18;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(27, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 19);
            label2.TabIndex = 20;
            label2.Text = "Tipo de vehiculo:";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Gray;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            comboBox2.Location = new Point(322, 212);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 27);
            comboBox2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(27, 220);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(207, 19);
            label3.TabIndex = 24;
            label3.Text = "Vehiculos en servicio:";
            // 
            // FormServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(598, 375);
            ControlBox = false;
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnaceptar);
            Controls.Add(btncancelar);
            Name = "FormServicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtpatente;
        private Label label1;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox cboxtiempo;
        private Button btnaceptar;
        private Button btncancelar;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
    }
}