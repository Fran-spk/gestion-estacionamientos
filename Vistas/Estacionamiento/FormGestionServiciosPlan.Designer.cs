namespace Vista.Estacionamiento
{
    partial class FormGestionServiciosPlan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            btnCobrarUna = new Button();
            BtnVerPago = new Button();
            BtnCobrar = new Button();
            BtnSalir = new Button();
            BtnCrear = new Button();
            panel3 = new Panel();
            label8 = new Label();
            txtDate = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TxtTipo = new TextBox();
            TxtNombre = new TextBox();
            label7 = new Label();
            cuotaBindingSource = new BindingSource(components);
            label9 = new Label();
            ticketAbonadoBindingSource = new BindingSource(components);
            ticketBindingSource = new BindingSource(components);
            ticketAbonadoBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            servicioConsumidoBindingSource = new BindingSource(components);
            lbSeriviciosPendientes = new Label();
            cbmEstadoServicios = new ComboBox();
            panelSidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicioConsumidoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(28, 28, 30);
            panelSidebar.Controls.Add(btnCobrarUna);
            panelSidebar.Controls.Add(BtnVerPago);
            panelSidebar.Controls.Add(BtnCobrar);
            panelSidebar.Controls.Add(BtnSalir);
            panelSidebar.Controls.Add(BtnCrear);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15);
            panelSidebar.Size = new Size(280, 1088);
            panelSidebar.TabIndex = 0;
            // 
            // btnCobrarUna
            // 
            btnCobrarUna.BackColor = Color.FromArgb(52, 58, 64);
            btnCobrarUna.FlatAppearance.BorderSize = 0;
            btnCobrarUna.FlatStyle = FlatStyle.Flat;
            btnCobrarUna.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrarUna.ForeColor = Color.White;
            btnCobrarUna.Location = new Point(15, 383);
            btnCobrarUna.Margin = new Padding(0);
            btnCobrarUna.Name = "btnCobrarUna";
            btnCobrarUna.Size = new Size(240, 50);
            btnCobrarUna.TabIndex = 21;
            btnCobrarUna.Text = "💵 Liquidar";
            btnCobrarUna.UseVisualStyleBackColor = false;
            btnCobrarUna.Click += btnCobrarUna_Click;
            // 
            // BtnVerPago
            // 
            BtnVerPago.BackColor = Color.FromArgb(52, 58, 64);
            BtnVerPago.FlatAppearance.BorderSize = 0;
            BtnVerPago.FlatStyle = FlatStyle.Flat;
            BtnVerPago.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerPago.ForeColor = Color.White;
            BtnVerPago.Location = new Point(15, 454);
            BtnVerPago.Margin = new Padding(0);
            BtnVerPago.Name = "BtnVerPago";
            BtnVerPago.Size = new Size(240, 50);
            BtnVerPago.TabIndex = 1;
            BtnVerPago.Text = "💰 Ver pago";
            BtnVerPago.UseVisualStyleBackColor = false;
            BtnVerPago.Click += BtnVerPago_Click;
            // 
            // BtnCobrar
            // 
            BtnCobrar.BackColor = Color.FromArgb(40, 167, 69);
            BtnCobrar.FlatAppearance.BorderSize = 0;
            BtnCobrar.FlatStyle = FlatStyle.Flat;
            BtnCobrar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCobrar.ForeColor = Color.White;
            BtnCobrar.Location = new Point(15, 247);
            BtnCobrar.Margin = new Padding(0);
            BtnCobrar.Name = "BtnCobrar";
            BtnCobrar.Size = new Size(240, 50);
            BtnCobrar.TabIndex = 0;
            BtnCobrar.Text = "💵 Liquidar todos";
            BtnCobrar.UseVisualStyleBackColor = false;
            BtnCobrar.Click += BtnCobrar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSalir.BackColor = Color.FromArgb(32, 30, 45);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(15, 1018);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(240, 55);
            BtnSalir.TabIndex = 2;
            BtnSalir.Text = "Volver";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.BackColor = Color.FromArgb(52, 58, 64);
            BtnCrear.FlatAppearance.BorderSize = 0;
            BtnCrear.FlatStyle = FlatStyle.Flat;
            BtnCrear.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCrear.ForeColor = Color.White;
            BtnCrear.Location = new Point(15, 312);
            BtnCrear.Margin = new Padding(0);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(240, 55);
            BtnCrear.TabIndex = 4;
            BtnCrear.Text = "Gestionar servicios";
            BtnCrear.UseVisualStyleBackColor = false;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(28, 28, 30);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TxtTipo);
            panel3.Controls.Add(TxtNombre);
            panel3.Location = new Point(292, 41);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(1148, 130);
            panel3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(755, 30);
            label8.Name = "label8";
            label8.Size = new Size(192, 28);
            label8.TabIndex = 6;
            label8.Text = "Fecha inicio de plan";
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Gray;
            txtDate.BorderStyle = BorderStyle.FixedSingle;
            txtDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(755, 65);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(250, 37);
            txtDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(384, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo Vehiculo";
            // 
            // TxtTipo
            // 
            TxtTipo.BackColor = Color.Gray;
            TxtTipo.BorderStyle = BorderStyle.FixedSingle;
            TxtTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTipo.ForeColor = Color.White;
            TxtTipo.Location = new Point(30, 65);
            TxtTipo.Name = "TxtTipo";
            TxtTipo.ReadOnly = true;
            TxtTipo.Size = new Size(250, 37);
            TxtTipo.TabIndex = 1;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.Gray;
            TxtNombre.BorderStyle = BorderStyle.FixedSingle;
            TxtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.ForeColor = Color.White;
            TxtNombre.Location = new Point(384, 65);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.ReadOnly = true;
            TxtNombre.Size = new Size(250, 37);
            TxtNombre.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 204, 153);
            label7.Location = new Point(292, 9);
            label7.Name = "label7";
            label7.Size = new Size(156, 30);
            label7.TabIndex = 2;
            label7.Text = "Datos del Plan";
            // 
            // cuotaBindingSource
            // 
            cuotaBindingSource.DataSource = typeof(MODELO.Cuota);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 204, 153);
            label9.Location = new Point(290, 192);
            label9.Name = "label9";
            label9.Size = new Size(210, 30);
            label9.TabIndex = 3;
            label9.Text = "Seleccione servicios";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(50, 50, 50);
            dataGridView1.Location = new Point(290, 247);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1150, 826);
            dataGridView1.TabIndex = 4;
            // 
            // servicioConsumidoBindingSource
            // 
            servicioConsumidoBindingSource.DataSource = typeof(Modelo_Ids.ServicioConsumido);
            // 
            // lbSeriviciosPendientes
            // 
            lbSeriviciosPendientes.AutoSize = true;
            lbSeriviciosPendientes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSeriviciosPendientes.ForeColor = Color.FromArgb(192, 0, 0);
            lbSeriviciosPendientes.Location = new Point(1408, 185);
            lbSeriviciosPendientes.Name = "lbSeriviciosPendientes";
            lbSeriviciosPendientes.Size = new Size(0, 29);
            lbSeriviciosPendientes.TabIndex = 5;
            // 
            // cbmEstadoServicios
            // 
            cbmEstadoServicios.BackColor = Color.FromArgb(45, 45, 48);
            cbmEstadoServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmEstadoServicios.FlatStyle = FlatStyle.Flat;
            cbmEstadoServicios.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbmEstadoServicios.ForeColor = Color.White;
            cbmEstadoServicios.FormattingEnabled = true;
            cbmEstadoServicios.Location = new Point(507, 189);
            cbmEstadoServicios.Margin = new Padding(4, 3, 4, 3);
            cbmEstadoServicios.Name = "cbmEstadoServicios";
            cbmEstadoServicios.Size = new Size(450, 38);
            cbmEstadoServicios.TabIndex = 49;
            cbmEstadoServicios.SelectedIndexChanged += cbmEstadoServicios_SelectedIndexChanged;
            // 
            // FormGestionServiciosPlan
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1472, 1088);
            ControlBox = false;
            Controls.Add(cbmEstadoServicios);
            Controls.Add(lbSeriviciosPendientes);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panelSidebar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGestionServiciosPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planes";
            panelSidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketAbonadoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicioConsumidoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Button BtnCobrar;
        private Button BtnVerPago;
        private Button BtnCrear;
        private Button BtnSalir;
        private Panel panel3;
        private Label label8;
        private TextBox txtDate;
        private Label label2;
        private Label label1;
        private TextBox TxtTipo;
        private TextBox TxtNombre;
        private Label label7;
        private Label label9;
        private BindingSource cuotaBindingSource;
        private BindingSource ticketAbonadoBindingSource;
        private BindingSource ticketBindingSource;
        private BindingSource ticketAbonadoBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TarifaEstacionamiento;
        private DataGridViewTextBoxColumn planIdDataGridViewTextBoxColumn;
        private Label lbSeriviciosPendientes;
        private Button btnCobrarUna;
        private BindingSource servicioConsumidoBindingSource;
        private ComboBox cbmEstadoServicios;
        private DataGridViewTextBoxColumn fechaHoraAsignadoDataGridViewTextBoxColumn;
    }
}