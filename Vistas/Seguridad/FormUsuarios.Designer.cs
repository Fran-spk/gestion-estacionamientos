using MODELO.seguridad;
namespace Vista.Seguridad
{
    partial class FormUsuarios
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
            dataGridView1 = new DataGridView();
            uSUUSUARIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uSUMAILDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pERNOMBREDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            LbelNom = new Label();
            cmbEstados = new ComboBox();
            cmbGrupos = new ComboBox();
            txtNombre = new TextBox();
            btnFiltrar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnResetear = new Button();
            panel1 = new Panel();
            label4 = new Label();
            btmVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { uSUUSUARIODataGridViewTextBoxColumn, uSUMAILDataGridViewTextBoxColumn, pERNOMBREDataGridViewTextBoxColumn, estadoUsuarioDataGridViewTextBoxColumn });
            dataGridView1.DataSource = usuarioBindingSource;
            dataGridView1.Location = new Point(14, 128);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(903, 302);
            dataGridView1.TabIndex = 0;
            // 
            // uSUUSUARIODataGridViewTextBoxColumn
            // 
            uSUUSUARIODataGridViewTextBoxColumn.DataPropertyName = "USU_USUARIO";
            uSUUSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            uSUUSUARIODataGridViewTextBoxColumn.Name = "uSUUSUARIODataGridViewTextBoxColumn";
            // 
            // uSUMAILDataGridViewTextBoxColumn
            // 
            uSUMAILDataGridViewTextBoxColumn.DataPropertyName = "USU_MAIL";
            uSUMAILDataGridViewTextBoxColumn.HeaderText = "E_MAIL";
            uSUMAILDataGridViewTextBoxColumn.Name = "uSUMAILDataGridViewTextBoxColumn";
            // 
            // pERNOMBREDataGridViewTextBoxColumn
            // 
            pERNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PER_NOMBRE";
            pERNOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            pERNOMBREDataGridViewTextBoxColumn.Name = "pERNOMBREDataGridViewTextBoxColumn";
            // 
            // estadoUsuarioDataGridViewTextBoxColumn
            // 
            estadoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Estado_Usuario";
            estadoUsuarioDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            estadoUsuarioDataGridViewTextBoxColumn.Name = "estadoUsuarioDataGridViewTextBoxColumn";
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Usuario);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LbelNom);
            groupBox1.Controls.Add(cmbEstados);
            groupBox1.Controls.Add(cmbGrupos);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 44);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(904, 78);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(517, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 7;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(279, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 6;
            label1.Text = "Grupo";
            // 
            // LbelNom
            // 
            LbelNom.AutoSize = true;
            LbelNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LbelNom.Location = new Point(7, 33);
            LbelNom.Margin = new Padding(4, 0, 4, 0);
            LbelNom.Name = "LbelNom";
            LbelNom.Size = new Size(56, 16);
            LbelNom.TabIndex = 5;
            LbelNom.Text = "Nombre";
            // 
            // cmbEstados
            // 
            cmbEstados.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstados.FormattingEnabled = true;
            cmbEstados.Location = new Point(582, 27);
            cmbEstados.Margin = new Padding(4, 3, 4, 3);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.Size = new Size(159, 28);
            cmbEstados.TabIndex = 3;
            // 
            // cmbGrupos
            // 
            cmbGrupos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGrupos.FormattingEnabled = true;
            cmbGrupos.Location = new Point(337, 29);
            cmbGrupos.Margin = new Padding(4, 3, 4, 3);
            cmbGrupos.Name = "cmbGrupos";
            cmbGrupos.Size = new Size(159, 28);
            cmbGrupos.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(79, 29);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 26);
            txtNombre.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(791, 24);
            btnFiltrar.Margin = new Padding(4, 3, 4, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(105, 35);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Buscar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(13, 436);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 36);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(135, 436);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 36);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(257, 436);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 36);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnResetear
            // 
            btnResetear.BackColor = SystemColors.ActiveCaption;
            btnResetear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetear.Location = new Point(379, 436);
            btnResetear.Margin = new Padding(4, 3, 4, 3);
            btnResetear.Name = "btnResetear";
            btnResetear.Size = new Size(114, 36);
            btnResetear.TabIndex = 5;
            btnResetear.Text = "Resetear";
            btnResetear.UseVisualStyleBackColor = false;
            btnResetear.Click += btnResetear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 37);
            panel1.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(841, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 31;
            label4.Text = "Usuarios";
            // 
            // btmVolver
            // 
            btmVolver.BackColor = SystemColors.ActiveCaption;
            btmVolver.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btmVolver.Location = new Point(804, 436);
            btmVolver.Margin = new Padding(4, 3, 4, 3);
            btmVolver.Name = "btmVolver";
            btmVolver.Size = new Size(114, 36);
            btmVolver.TabIndex = 33;
            btmVolver.Text = "Volver";
            btmVolver.UseVisualStyleBackColor = false;
            btmVolver.Click += btmVolver_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 475);
            ControlBox = false;
            Controls.Add(btmVolver);
            Controls.Add(panel1);
            Controls.Add(btnResetear);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.Label LbelNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Panel panel1;
        private Label label4;
        private DataGridViewTextBoxColumn uSUUSUARIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uSUMAILDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pERNOMBREDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoUsuarioDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
        private Button btmVolver;
    }
}