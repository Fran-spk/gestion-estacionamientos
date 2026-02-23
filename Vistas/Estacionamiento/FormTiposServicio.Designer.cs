namespace Vista.Estacionamiento
{
    partial class FormTiposServicio
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
            groupBox2 = new GroupBox();
            ChboxEstado = new CheckBox();
            label1 = new Label();
            TXTDescripcion = new TextBox();
            BtnAceptar = new Button();
            labelServicio = new Label();
            BtnVolver = new Button();
            cbxTiposServicios = new ComboBox();
            chboxNuevoServicio = new CheckBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox2.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(37, 37, 38);
            groupBox2.Controls.Add(ChboxEstado);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TXTDescripcion);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox2.Location = new Point(30, 180);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15);
            groupBox2.Size = new Size(520, 280);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Servicio";
            // 
            // ChboxEstado
            // 
            ChboxEstado.AutoSize = true;
            ChboxEstado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ChboxEstado.ForeColor = Color.White;
            ChboxEstado.Location = new Point(20, 230);
            ChboxEstado.Margin = new Padding(4, 3, 4, 3);
            ChboxEstado.Name = "ChboxEstado";
            ChboxEstado.Size = new Size(173, 32);
            ChboxEstado.TabIndex = 45;
            ChboxEstado.Text = "Vehículo Activo";
            ChboxEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 40;
            label1.Text = "Nombre de Servicio";
            // 
            // TXTDescripcion
            // 
            TXTDescripcion.BackColor = Color.FromArgb(45, 45, 48);
            TXTDescripcion.BorderStyle = BorderStyle.FixedSingle;
            TXTDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTDescripcion.ForeColor = Color.White;
            TXTDescripcion.Location = new Point(20, 75);
            TXTDescripcion.Margin = new Padding(4, 3, 4, 3);
            TXTDescripcion.Name = "TXTDescripcion";
            TXTDescripcion.PlaceholderText = "Ej: Lavado";
            TXTDescripcion.Size = new Size(480, 37);
            TXTDescripcion.TabIndex = 32;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAceptar.BackColor = Color.FromArgb(40, 167, 69);
            BtnAceptar.FlatAppearance.BorderSize = 0;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAceptar.ForeColor = Color.White;
            BtnAceptar.Location = new Point(30, 472);
            BtnAceptar.Margin = new Padding(4, 3, 4, 3);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(160, 45);
            BtnAceptar.TabIndex = 29;
            BtnAceptar.Text = "✓ Guardar";
            BtnAceptar.UseVisualStyleBackColor = false;
            // 
            // labelServicio
            // 
            labelServicio.AutoSize = true;
            labelServicio.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelServicio.ForeColor = Color.White;
            labelServicio.Location = new Point(30, 85);
            labelServicio.Margin = new Padding(4, 0, 4, 0);
            labelServicio.Name = "labelServicio";
            labelServicio.Size = new Size(176, 28);
            labelServicio.TabIndex = 38;
            labelServicio.Text = "Servicio Existente:";
            // 
            // BtnVolver
            // 
            BtnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnVolver.BackColor = Color.FromArgb(220, 53, 69);
            BtnVolver.FlatAppearance.BorderSize = 0;
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVolver.ForeColor = Color.White;
            BtnVolver.Location = new Point(390, 472);
            BtnVolver.Margin = new Padding(4, 3, 4, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(160, 45);
            BtnVolver.TabIndex = 40;
            BtnVolver.Text = "✖ Cancelar";
            BtnVolver.UseVisualStyleBackColor = false;
            // 
            // cbxTiposServicios
            // 
            cbxTiposServicios.BackColor = Color.FromArgb(45, 45, 48);
            cbxTiposServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTiposServicios.FlatStyle = FlatStyle.Flat;
            cbxTiposServicios.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTiposServicios.ForeColor = Color.White;
            cbxTiposServicios.FormattingEnabled = true;
            cbxTiposServicios.Location = new Point(288, 81);
            cbxTiposServicios.Name = "cbxTiposServicios";
            cbxTiposServicios.Size = new Size(280, 38);
            cbxTiposServicios.TabIndex = 41;
            // 
            // chboxNuevoServicio
            // 
            chboxNuevoServicio.AutoSize = true;
            chboxNuevoServicio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chboxNuevoServicio.ForeColor = Color.White;
            chboxNuevoServicio.Location = new Point(30, 135);
            chboxNuevoServicio.Margin = new Padding(4, 3, 4, 3);
            chboxNuevoServicio.Name = "chboxNuevoServicio";
            chboxNuevoServicio.Size = new Size(253, 32);
            chboxNuevoServicio.TabIndex = 43;
            chboxNuevoServicio.Text = "➕ Crear Nuevo Servicio";
            chboxNuevoServicio.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(580, 60);
            panelHeader.TabIndex = 44;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tipos de Servicios";
            // 
            // FormTiposServicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(580, 542);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(chboxNuevoServicio);
            Controls.Add(cbxTiposServicios);
            Controls.Add(BtnVolver);
            Controls.Add(groupBox2);
            Controls.Add(labelServicio);
            Controls.Add(BtnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormTiposServicio";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormTiposServicio_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox ChboxEstado;
        private Label label1;
        private TextBox TXTDescripcion;
        private Panel panelHeader;
        private Label lblTitulo;
        private CheckBox chboxNuevoServicio;
        private ComboBox cbxTiposServicios;
        private Button BtnVolver;
        private Label labelServicio;
        private Button BtnAceptar;
    }
}