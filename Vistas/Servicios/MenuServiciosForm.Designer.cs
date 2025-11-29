namespace Vista
{
    partial class MenuServiciosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuServiciosForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tarifaBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            btnsalir = new Button();
            picCochera = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            btnentrada = new Button();
            btnsalida = new Button();
            BtnTickets = new Button();
            txtconfiguracion = new Button();
            ticketBindingSource = new BindingSource(components);
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txtcapacidad = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCochera).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(MODELO.Tarifa);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsalir);
            groupBox1.Location = new Point(288, 534);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(792, 106);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(32, 30, 45);
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalir.ForeColor = SystemColors.ButtonFace;
            btnsalir.Location = new Point(590, 53);
            btnsalir.Margin = new Padding(4, 3, 4, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(194, 47);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = false;
            // 
            // picCochera
            // 
            picCochera.Image = (Image)resources.GetObject("picCochera.Image");
            picCochera.Location = new Point(90, 14);
            picCochera.Margin = new Padding(4, 3, 4, 3);
            picCochera.Name = "picCochera";
            picCochera.Size = new Size(105, 84);
            picCochera.SizeMode = PictureBoxSizeMode.StretchImage;
            picCochera.TabIndex = 15;
            picCochera.TabStop = false;
            picCochera.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(picCochera);
            panel1.Controls.Add(btnentrada);
            panel1.Controls.Add(btnsalida);
            panel1.Controls.Add(BtnTickets);
            panel1.Controls.Add(txtconfiguracion);
            panel1.Location = new Point(-5, -2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 653);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 32, 39);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1, 280);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(271, 59);
            button1.TabIndex = 16;
            button1.Text = "Ver pendientes";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnentrada
            // 
            btnentrada.BackColor = Color.FromArgb(20, 38, 44);
            btnentrada.CausesValidation = false;
            btnentrada.FlatStyle = FlatStyle.Flat;
            btnentrada.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnentrada.ForeColor = SystemColors.ButtonFace;
            btnentrada.Location = new Point(4, 119);
            btnentrada.Margin = new Padding(4, 3, 4, 3);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(271, 59);
            btnentrada.TabIndex = 9;
            btnentrada.Text = "Agregar servicio";
            btnentrada.UseVisualStyleBackColor = false;
            // 
            // btnsalida
            // 
            btnsalida.BackColor = Color.FromArgb(75, 10, 30);
            btnsalida.FlatStyle = FlatStyle.Flat;
            btnsalida.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalida.ForeColor = SystemColors.ButtonFace;
            btnsalida.Location = new Point(4, 185);
            btnsalida.Margin = new Padding(4, 3, 4, 3);
            btnsalida.Name = "btnsalida";
            btnsalida.Size = new Size(271, 59);
            btnsalida.TabIndex = 2;
            btnsalida.Text = "Pagar";
            btnsalida.UseVisualStyleBackColor = false;
            // 
            // BtnTickets
            // 
            BtnTickets.BackColor = Color.FromArgb(35, 32, 39);
            BtnTickets.FlatStyle = FlatStyle.Flat;
            BtnTickets.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTickets.ForeColor = SystemColors.ButtonFace;
            BtnTickets.Location = new Point(4, 345);
            BtnTickets.Margin = new Padding(4, 3, 4, 3);
            BtnTickets.Name = "BtnTickets";
            BtnTickets.Size = new Size(271, 59);
            BtnTickets.TabIndex = 7;
            BtnTickets.Text = "Busqueda Tickets";
            BtnTickets.UseVisualStyleBackColor = false;
            // 
            // txtconfiguracion
            // 
            txtconfiguracion.BackColor = Color.FromArgb(35, 32, 39);
            txtconfiguracion.FlatStyle = FlatStyle.Flat;
            txtconfiguracion.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtconfiguracion.ForeColor = Color.Snow;
            txtconfiguracion.Location = new Point(0, 411);
            txtconfiguracion.Margin = new Padding(4, 3, 4, 3);
            txtconfiguracion.Name = "txtconfiguracion";
            txtconfiguracion.Size = new Size(274, 59);
            txtconfiguracion.TabIndex = 8;
            txtconfiguracion.Text = "Actualizar tarifas";
            txtconfiguracion.UseVisualStyleBackColor = false;
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(MODELO.Ticket);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Juice ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(1011, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 21;
            label3.Text = "Servicios";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(288, 82);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.Size = new Size(792, 446);
            dataGridView1.TabIndex = 18;
            // 
            // txtcapacidad
            // 
            txtcapacidad.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcapacidad.Location = new Point(446, 38);
            txtcapacidad.Margin = new Padding(4, 3, 4, 3);
            txtcapacidad.Name = "txtcapacidad";
            txtcapacidad.ReadOnly = true;
            txtcapacidad.Size = new Size(190, 26);
            txtcapacidad.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(285, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 23;
            label1.Text = "Ingrese Patente:";
            // 
            // MenuServiciosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(1093, 643);
            ControlBox = false;
            Controls.Add(txtcapacidad);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "MenuServiciosForm";
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCochera).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource tarifaBindingSource;
        private GroupBox groupBox1;
        private Button btnsalir;
        public PictureBox picCochera;
        private Panel panel1;
        private Button btnentrada;
        private Button btnsalida;
        private Button BtnTickets;
        private Button txtconfiguracion;
        private BindingSource ticketBindingSource;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtcapacidad;
        private Label label1;
    }
}