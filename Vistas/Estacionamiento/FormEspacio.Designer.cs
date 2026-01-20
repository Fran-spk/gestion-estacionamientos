namespace Vista
{
    partial class FormEspacio
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
            ChboxMensual = new CheckBox();
            TxtCapacidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TxtNombre = new TextBox();
            BtnVolver = new Button();
            BtnAceptar = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox2.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(37, 37, 38);
            groupBox2.Controls.Add(ChboxMensual);
            groupBox2.Controls.Add(TxtCapacidad);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtNombre);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 122, 204);
            groupBox2.Location = new Point(30, 100);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15);
            groupBox2.Size = new Size(520, 280);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Espacio";
            // 
            // ChboxMensual
            // 
            ChboxMensual.AutoSize = true;
            ChboxMensual.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ChboxMensual.ForeColor = Color.White;
            ChboxMensual.Location = new Point(20, 225);
            ChboxMensual.Margin = new Padding(4, 3, 4, 3);
            ChboxMensual.Name = "ChboxMensual";
            ChboxMensual.Size = new Size(249, 32);
            ChboxMensual.TabIndex = 45;
            ChboxMensual.Text = " Espacio para Mensuales";
            ChboxMensual.UseVisualStyleBackColor = true;
            // 
            // TxtCapacidad
            // 
            TxtCapacidad.BackColor = Color.FromArgb(45, 45, 48);
            TxtCapacidad.BorderStyle = BorderStyle.FixedSingle;
            TxtCapacidad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCapacidad.ForeColor = Color.White;
            TxtCapacidad.Location = new Point(20, 165);
            TxtCapacidad.Margin = new Padding(4, 3, 4, 3);
            TxtCapacidad.Name = "TxtCapacidad";
            TxtCapacidad.PlaceholderText = "Ej: 50";
            TxtCapacidad.Size = new Size(480, 37);
            TxtCapacidad.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 41;
            label2.Text = " Capacidad Máxima";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 40;
            label1.Text = "Descripción del Espacio";
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.FromArgb(45, 45, 48);
            TxtNombre.BorderStyle = BorderStyle.FixedSingle;
            TxtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.ForeColor = Color.White;
            TxtNombre.Location = new Point(20, 75);
            TxtNombre.Margin = new Padding(4, 3, 4, 3);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.PlaceholderText = "Ej: Planta Baja - Sector A";
            TxtNombre.Size = new Size(480, 37);
            TxtNombre.TabIndex = 32;
            // 
            // BtnVolver
            // 
            BtnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnVolver.BackColor = Color.FromArgb(220, 53, 69);
            BtnVolver.FlatAppearance.BorderSize = 0;
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVolver.ForeColor = Color.White;
            BtnVolver.Location = new Point(390, 405);
            BtnVolver.Margin = new Padding(4, 3, 4, 3);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(160, 45);
            BtnVolver.TabIndex = 47;
            BtnVolver.Text = "✖ Cancelar";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAceptar.BackColor = Color.FromArgb(40, 167, 69);
            BtnAceptar.FlatAppearance.BorderSize = 0;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAceptar.ForeColor = Color.White;
            BtnAceptar.Location = new Point(30, 405);
            BtnAceptar.Margin = new Padding(4, 3, 4, 3);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(160, 45);
            BtnAceptar.TabIndex = 44;
            BtnAceptar.Text = "✓ Guardar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(580, 70);
            panelHeader.TabIndex = 48;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🅿️ Gestionar Espacios";
            // 
            // FormEspacio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(580, 475);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(groupBox2);
            Controls.Add(BtnVolver);
            Controls.Add(BtnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormEspacio";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox ChboxMensual;
        private TextBox TxtCapacidad;
        private Label label2;
        private Label label1;
        private TextBox TxtNombre;
        private Button BtnVolver;
        private Button BtnAceptar;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}