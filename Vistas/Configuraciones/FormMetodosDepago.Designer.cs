namespace Vista
{
    partial class FormMetodosDepago
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
            actividadBindingSource = new BindingSource(components);
            btnaceptar = new Button();
            btncancelar = new Button();
            cbxMetd = new ComboBox();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            lbnombre = new Label();
            btnBaja = new Button();
            groupBox2 = new GroupBox();
            btnActivar = new Button();
            checkActivo = new CheckBox();
            label1 = new Label();
            panelHeader = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(40, 167, 69);
            btnaceptar.FlatAppearance.BorderSize = 0;
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnaceptar.ForeColor = Color.White;
            btnaceptar.Location = new Point(20, 170);
            btnaceptar.Margin = new Padding(4, 3, 4, 3);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(360, 45);
            btnaceptar.TabIndex = 37;
            btnaceptar.Text = "✓ Guardar Método";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btncancelar.BackColor = Color.FromArgb(220, 53, 69);
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(728, 343);
            btncancelar.Margin = new Padding(4, 3, 4, 3);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 45);
            btncancelar.TabIndex = 36;
            btncancelar.Text = "✖ Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // cbxMetd
            // 
            cbxMetd.BackColor = Color.FromArgb(45, 45, 48);
            cbxMetd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMetd.FlatStyle = FlatStyle.Flat;
            cbxMetd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbxMetd.ForeColor = Color.White;
            cbxMetd.FormattingEnabled = true;
            cbxMetd.Location = new Point(20, 60);
            cbxMetd.Margin = new Padding(4, 3, 4, 3);
            cbxMetd.Name = "cbxMetd";
            cbxMetd.Size = new Size(360, 38);
            cbxMetd.TabIndex = 33;
            cbxMetd.SelectedIndexChanged += cbxMetd_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lbnombre);
            groupBox1.Controls.Add(btnaceptar);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(488, 100);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(400, 240);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Método de Pago";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(45, 45, 48);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(20, 100);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Tarjeta de Crédito, PayPal";
            txtNombre.Size = new Size(360, 37);
            txtNombre.TabIndex = 40;
            // 
            // lbnombre
            // 
            lbnombre.AutoSize = true;
            lbnombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbnombre.ForeColor = Color.White;
            lbnombre.Location = new Point(20, 60);
            lbnombre.Margin = new Padding(4, 0, 4, 0);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(233, 28);
            lbnombre.TabIndex = 39;
            lbnombre.Text = "💳 Nombre del Método";
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(220, 53, 69);
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.ForeColor = Color.White;
            btnBaja.Location = new Point(200, 170);
            btnBaja.Margin = new Padding(4, 3, 4, 3);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(180, 45);
            btnBaja.TabIndex = 37;
            btnBaja.Text = "🗑️ Dar de Baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(37, 37, 38);
            groupBox2.Controls.Add(btnActivar);
            groupBox2.Controls.Add(checkActivo);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnBaja);
            groupBox2.Controls.Add(cbxMetd);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox2.Location = new Point(30, 100);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15);
            groupBox2.Size = new Size(445, 240);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestionar Métodos Existentes";
            // 
            // btnActivar
            // 
            btnActivar.BackColor = Color.FromArgb(40, 167, 69);
            btnActivar.FlatAppearance.BorderSize = 0;
            btnActivar.FlatStyle = FlatStyle.Flat;
            btnActivar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnActivar.ForeColor = Color.White;
            btnActivar.Location = new Point(20, 170);
            btnActivar.Margin = new Padding(4, 3, 4, 3);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(160, 45);
            btnActivar.TabIndex = 43;
            btnActivar.Text = "✓ Activar";
            btnActivar.UseVisualStyleBackColor = false;
            btnActivar.Click += btnActivar_Click;
            // 
            // checkActivo
            // 
            checkActivo.AutoSize = true;
            checkActivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkActivo.ForeColor = Color.White;
            checkActivo.Location = new Point(20, 120);
            checkActivo.Margin = new Padding(4, 3, 4, 3);
            checkActivo.Name = "checkActivo";
            checkActivo.Size = new Size(190, 32);
            checkActivo.TabIndex = 42;
            checkActivo.Text = "✓ Método Activo";
            checkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 28);
            label1.TabIndex = 41;
            label1.Text = "📋 Seleccionar Método";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(918, 70);
            panelHeader.TabIndex = 44;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(339, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💳 Métodos de Pago";
            // 
            // FormMetodosDepago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(918, 393);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(btncancelar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMetodosDepago";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource actividadBindingSource;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
        private Button btnaceptar;
        private Button btncancelar;
        private ComboBox cbxMetd;
        private GroupBox groupBox1;
        private Label lbnombre;
        private TextBox txtNombre;
        private Button btnBaja;
        private GroupBox groupBox2;
        private Label label1;
        private CheckBox checkActivo;
        private Button btnActivar;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}