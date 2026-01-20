namespace Vista
{
    partial class formDescuentos
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            LbDni = new Label();
            label2 = new Label();
            TxtDesc = new TextBox();
            label1 = new Label();
            btnaceptar = new Button();
            BtnVolver = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 37, 38);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(LbDni);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtDesc);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox1.Location = new Point(30, 100);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(740, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Descuento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 45);
            label4.Name = "label4";
            label4.Size = new Size(224, 28);
            label4.TabIndex = 40;
            label4.Text = "Nombre del Descuento";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(45, 45, 48);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(20, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Descuento Empleados";
            txtNombre.Size = new Size(320, 37);
            txtNombre.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 225);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 38;
            label3.Text = "✓ Descuento Activo";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(210, 228);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 37;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(45, 45, 48);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(380, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 38);
            comboBox1.TabIndex = 36;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LbDni
            // 
            LbDni.AutoSize = true;
            LbDni.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbDni.ForeColor = Color.White;
            LbDni.Location = new Point(380, 45);
            LbDni.Name = "LbDni";
            LbDni.Size = new Size(221, 28);
            LbDni.TabIndex = 23;
            LbDni.Text = " Descuentos Existentes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 204, 153);
            label2.Location = new Point(310, 170);
            label2.Name = "label2";
            label2.Size = new Size(35, 32);
            label2.TabIndex = 27;
            label2.Text = "%";
            // 
            // TxtDesc
            // 
            TxtDesc.BackColor = Color.FromArgb(45, 45, 48);
            TxtDesc.BorderStyle = BorderStyle.FixedSingle;
            TxtDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDesc.ForeColor = Color.White;
            TxtDesc.Location = new Point(20, 165);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.PlaceholderText = "0";
            TxtDesc.Size = new Size(280, 39);
            TxtDesc.TabIndex = 26;
            TxtDesc.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 130);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 25;
            label1.Text = "Porcentaje de Desc.";
            // 
            // btnaceptar
            // 
            btnaceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnaceptar.BackColor = Color.FromArgb(40, 167, 69);
            btnaceptar.FlatAppearance.BorderSize = 0;
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnaceptar.ForeColor = Color.White;
            btnaceptar.Location = new Point(30, 405);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(160, 45);
            btnaceptar.TabIndex = 14;
            btnaceptar.Text = "➕ Agregar";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnVolver.BackColor = Color.FromArgb(220, 53, 69);
            BtnVolver.FlatAppearance.BorderSize = 0;
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVolver.ForeColor = Color.White;
            BtnVolver.Location = new Point(610, 405);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(160, 45);
            BtnVolver.TabIndex = 15;
            BtnVolver.Text = "✖ Cancelar";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(415, 405);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 45);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.BackColor = Color.FromArgb(0, 122, 204);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(220, 405);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 45);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "✏️ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 70);
            panelHeader.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(344, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestionar Descuentos";
            // 
            // formDescuentos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 475);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(BtnVolver);
            Controls.Add(btnaceptar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formDescuentos";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbDni;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
    }
}