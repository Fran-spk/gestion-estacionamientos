namespace Vista
{
    partial class FormPlan
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txttipoVehiculo = new ComboBox();
            groupBox1 = new GroupBox();
            checkDesc = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            TxtDescuento = new ComboBox();
            label11 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            txttelefono = new TextBox();
            label6 = new Label();
            txtPatente = new TextBox();
            label4 = new Label();
            txtdni = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            btnaceptar = new Button();
            btncancelar = new Button();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            LabelNoLugar = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txttipoVehiculo
            // 
            txttipoVehiculo.BackColor = Color.Gray;
            txttipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            txttipoVehiculo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttipoVehiculo.FormattingEnabled = true;
            txttipoVehiculo.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            txttipoVehiculo.Location = new Point(443, 52);
            txttipoVehiculo.Margin = new Padding(4, 3, 4, 3);
            txttipoVehiculo.Name = "txttipoVehiculo";
            txttipoVehiculo.Size = new Size(248, 27);
            txttipoVehiculo.TabIndex = 14;
            txttipoVehiculo.SelectedIndexChanged += txttipoVehiculo_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkDesc);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(TxtDescuento);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txttelefono);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtdni);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txttipoVehiculo);
            groupBox1.Location = new Point(14, 36);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(728, 418);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // checkDesc
            // 
            checkDesc.AutoSize = true;
            checkDesc.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkDesc.ForeColor = SystemColors.ButtonFace;
            checkDesc.Location = new Point(443, 192);
            checkDesc.Margin = new Padding(4, 3, 4, 3);
            checkDesc.Name = "checkDesc";
            checkDesc.Size = new Size(181, 23);
            checkDesc.TabIndex = 34;
            checkDesc.Text = "Agregar descuento";
            checkDesc.UseVisualStyleBackColor = true;
            checkDesc.CheckedChanged += checkDesc_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(331, 348);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 28);
            dateTimePicker1.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(42, 355);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(153, 19);
            label10.TabIndex = 30;
            label10.Text = "Fecha de Inicio:";
            // 
            // TxtDescuento
            // 
            TxtDescuento.BackColor = Color.Gray;
            TxtDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtDescuento.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDescuento.FormattingEnabled = true;
            TxtDescuento.Items.AddRange(new object[] { "Auto", "Moto", "Camion" });
            TxtDescuento.Location = new Point(443, 261);
            TxtDescuento.Margin = new Padding(4, 3, 4, 3);
            TxtDescuento.Name = "TxtDescuento";
            TxtDescuento.Size = new Size(248, 27);
            TxtDescuento.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(439, 235);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 19);
            label11.TabIndex = 31;
            label11.Text = "Descuento:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(372, 22);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 270);
            panel2.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(42, 163);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 26;
            label7.Text = "Telefono:";
            // 
            // txttelefono
            // 
            txttelefono.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefono.Location = new Point(47, 188);
            txttelefono.Margin = new Padding(4, 3, 4, 3);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(248, 26);
            txttelefono.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(439, 95);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 24;
            label6.Text = "Patente:";
            // 
            // txtPatente
            // 
            txtPatente.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatente.Location = new Point(443, 127);
            txtPatente.Margin = new Padding(4, 3, 4, 3);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(248, 26);
            txtPatente.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(42, 96);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 22;
            label4.Text = "DNI:";
            // 
            // txtdni
            // 
            txtdni.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdni.Location = new Point(47, 121);
            txtdni.Margin = new Padding(4, 3, 4, 3);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(248, 26);
            txtdni.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(42, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 9;
            label5.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(439, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 15;
            label1.Text = "Tipo de vehiculo:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(47, 53);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 26);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(562, -25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 20;
            label3.Text = "Datos del plan:";
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(48, 30, 35);
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaceptar.ForeColor = SystemColors.ButtonFace;
            btnaceptar.Location = new Point(14, 460);
            btnaceptar.Margin = new Padding(4, 3, 4, 3);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(147, 44);
            btnaceptar.TabIndex = 18;
            btnaceptar.Text = "Aceptar";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(32, 30, 45);
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.ForeColor = SystemColors.ButtonFace;
            btncancelar.Location = new Point(595, 460);
            btncancelar.Margin = new Padding(4, 3, 4, 3);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(147, 44);
            btncancelar.TabIndex = 17;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(9, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 19);
            label2.TabIndex = 19;
            label2.Text = "Datos del cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(382, 10);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(135, 19);
            label9.TabIndex = 20;
            label9.Text = "Datos del plan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(750, 24);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(180, 19);
            label8.TabIndex = 38;
            label8.Text = "Espacio de parqueo:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(750, 46);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Size = new Size(484, 408);
            dataGridView1.TabIndex = 37;
            // 
            // LabelNoLugar
            // 
            LabelNoLugar.AutoSize = true;
            LabelNoLugar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNoLugar.ForeColor = Color.Red;
            LabelNoLugar.Location = new Point(937, 24);
            LabelNoLugar.Name = "LabelNoLugar";
            LabelNoLugar.Size = new Size(120, 20);
            LabelNoLugar.TabIndex = 36;
            LabelNoLugar.Text = "No hay espacio!";
            LabelNoLugar.Visible = false;
            // 
            // FormPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1247, 522);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(LabelNoLugar);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(btnaceptar);
            Controls.Add(btncancelar);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormPlan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txttipoVehiculo;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtNombre;
        private Label label1;
        private Button btnaceptar;
        private Button btncancelar;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txtPatente;
        private Label label4;
        private TextBox txtdni;
        private Label label7;
        private TextBox txttelefono;
        private Panel panel2;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox TxtDescuento;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkDesc;
        private Label label8;
        private DataGridView dataGridView1;
        private Label LabelNoLugar;
    }
}