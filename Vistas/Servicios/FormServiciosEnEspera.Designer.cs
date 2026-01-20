namespace Vista
{
    partial class FormServiciosEnEspera
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnVolver = new Button();
            tarifaBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            BtnActuales = new Button();
            cbmTipo = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Juice ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(1000, 2);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 34;
            label3.Text = "Tarifas:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(280, 266);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(649, 103);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(32, 30, 45);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(447, 50);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(194, 47);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(MODELO.TarifaEstacionamiento);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(280, 30);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Size = new Size(649, 230);
            dataGridView1.TabIndex = 31;
            // 
            // BtnActuales
            // 
            BtnActuales.BackColor = Color.FromArgb(35, 32, 39);
            BtnActuales.CausesValidation = false;
            BtnActuales.FlatStyle = FlatStyle.Flat;
            BtnActuales.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnActuales.ForeColor = SystemColors.ButtonFace;
            BtnActuales.Location = new Point(4, 125);
            BtnActuales.Margin = new Padding(4, 3, 4, 3);
            BtnActuales.Name = "BtnActuales";
            BtnActuales.Size = new Size(276, 60);
            BtnActuales.TabIndex = 20;
            BtnActuales.Text = "Anular";
            BtnActuales.UseVisualStyleBackColor = false;
            // 
            // cbmTipo
            // 
            cbmTipo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbmTipo.FormattingEnabled = true;
            cbmTipo.Location = new Point(48, 51);
            cbmTipo.Margin = new Padding(4, 3, 4, 3);
            cbmTipo.Name = "cbmTipo";
            cbmTipo.Size = new Size(180, 27);
            cbmTipo.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnActuales);
            panel1.Controls.Add(cbmTipo);
            panel1.Location = new Point(-8, -8);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 652);
            panel1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(62, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 26;
            label1.Text = "Tipo de servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Juice ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(785, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 31;
            label2.Text = "Vehiculos en espera:";
            // 
            // FormServiciosEnEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(956, 380);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormServiciosEnEspera";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Button btnVolver;
        private BindingSource tarifaBindingSource;
        private DataGridView dataGridView1;
        private Button BtnActuales;
        private ComboBox cbmTipo;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}