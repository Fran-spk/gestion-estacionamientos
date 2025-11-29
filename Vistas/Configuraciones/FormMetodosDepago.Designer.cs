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
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = Color.FromArgb(48, 30, 35);
            btnaceptar.FlatStyle = FlatStyle.Flat;
            btnaceptar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaceptar.ForeColor = SystemColors.ButtonFace;
            btnaceptar.Location = new Point(153, 173);
            btnaceptar.Margin = new Padding(4, 3, 4, 3);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(147, 33);
            btnaceptar.TabIndex = 37;
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
            btncancelar.Location = new Point(14, 254);
            btncancelar.Margin = new Padding(4, 3, 4, 3);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(147, 33);
            btncancelar.TabIndex = 36;
            btncancelar.Text = "Volver";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // cbxMetd
            // 
            cbxMetd.AllowDrop = true;
            cbxMetd.BackColor = Color.Gray;
            cbxMetd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMetd.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxMetd.FormattingEnabled = true;
            cbxMetd.Location = new Point(19, 43);
            cbxMetd.Margin = new Padding(4, 3, 4, 3);
            cbxMetd.Name = "cbxMetd";
            cbxMetd.Size = new Size(210, 27);
            cbxMetd.TabIndex = 33;
            cbxMetd.SelectedIndexChanged += cbxMetd_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnaceptar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(432, 33);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(310, 213);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(24, 43);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 26);
            txtNombre.TabIndex = 40;
            // 
            // lbnombre
            // 
            lbnombre.AutoSize = true;
            lbnombre.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbnombre.ForeColor = SystemColors.ButtonFace;
            lbnombre.Location = new Point(427, 14);
            lbnombre.Margin = new Padding(4, 0, 4, 0);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(261, 19);
            lbnombre.TabIndex = 39;
            lbnombre.Text = "Cargar Nuevo metodo de pago:";
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(32, 30, 45);
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaja.ForeColor = SystemColors.ButtonFace;
            btnBaja.Location = new Point(245, 81);
            btnBaja.Margin = new Padding(4, 3, 4, 3);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(147, 33);
            btnBaja.TabIndex = 37;
            btnBaja.Text = "Dar de baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnActivar);
            groupBox2.Controls.Add(checkActivo);
            groupBox2.Controls.Add(btnBaja);
            groupBox2.Controls.Add(cbxMetd);
            groupBox2.Location = new Point(14, 33);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(411, 213);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // btnActivar
            // 
            btnActivar.BackColor = Color.FromArgb(32, 30, 45);
            btnActivar.FlatStyle = FlatStyle.Flat;
            btnActivar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActivar.ForeColor = SystemColors.ButtonFace;
            btnActivar.Location = new Point(245, 22);
            btnActivar.Margin = new Padding(4, 3, 4, 3);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(147, 33);
            btnActivar.TabIndex = 43;
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = false;
            btnActivar.Click += btnActivar_Click;
            // 
            // checkActivo
            // 
            checkActivo.AutoSize = true;
            checkActivo.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkActivo.ForeColor = SystemColors.ButtonFace;
            checkActivo.Location = new Point(19, 81);
            checkActivo.Margin = new Padding(4, 3, 4, 3);
            checkActivo.Name = "checkActivo";
            checkActivo.Size = new Size(75, 22);
            checkActivo.TabIndex = 42;
            checkActivo.Text = "Activo";
            checkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(14, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 41;
            label1.Text = "Metodos de pago:";
            // 
            // FormMetodosDepago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(754, 293);
            ControlBox = false;
            Controls.Add(lbnombre);
            Controls.Add(label1);
            Controls.Add(btncancelar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMetodosDepago";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}