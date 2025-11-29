namespace Vista.Seguridad
{
    partial class FormGrupos
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
            btmVolver = new Button();
            panel1 = new Panel();
            label4 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            LbelNom = new Label();
            CBestados = new ComboBox();
            txtnombre = new TextBox();
            btnFiltrar = new Button();
            usuarioBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            gRUNOMBREDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gRUDESCRIPCIONDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoGrupoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            grupoBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grupoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btmVolver
            // 
            btmVolver.BackColor = SystemColors.ActiveCaption;
            btmVolver.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btmVolver.Location = new Point(804, 433);
            btmVolver.Margin = new Padding(4, 3, 4, 3);
            btmVolver.Name = "btmVolver";
            btmVolver.Size = new Size(114, 36);
            btmVolver.TabIndex = 41;
            btmVolver.Text = "Volver";
            btmVolver.UseVisualStyleBackColor = false;
            btmVolver.Click += btmVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 37);
            panel1.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(841, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 31;
            label4.Text = "Grupos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(257, 433);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 36);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(135, 433);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 36);
            btnModificar.TabIndex = 37;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(13, 433);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 36);
            btnAgregar.TabIndex = 36;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(518, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 7;
            label2.Text = "Estado";
            // 
            // LbelNom
            // 
            LbelNom.AutoSize = true;
            LbelNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LbelNom.Location = new Point(8, 33);
            LbelNom.Margin = new Padding(4, 0, 4, 0);
            LbelNom.Name = "LbelNom";
            LbelNom.Size = new Size(56, 16);
            LbelNom.TabIndex = 5;
            LbelNom.Text = "Nombre";
            // 
            // CBestados
            // 
            CBestados.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBestados.FormattingEnabled = true;
            CBestados.Location = new Point(582, 27);
            CBestados.Margin = new Padding(4, 3, 4, 3);
            CBestados.Name = "CBestados";
            CBestados.Size = new Size(159, 28);
            CBestados.TabIndex = 3;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(79, 29);
            txtnombre.Margin = new Padding(4, 3, 4, 3);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(431, 26);
            txtnombre.TabIndex = 1;
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
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(MODELO.seguridad.Usuario);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LbelNom);
            groupBox1.Controls.Add(CBestados);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 41);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(904, 78);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gRUNOMBREDataGridViewTextBoxColumn, gRUDESCRIPCIONDataGridViewTextBoxColumn, estadoGrupoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = grupoBindingSource;
            dataGridView1.Location = new Point(14, 125);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(903, 302);
            dataGridView1.TabIndex = 34;
            // 
            // gRUNOMBREDataGridViewTextBoxColumn
            // 
            gRUNOMBREDataGridViewTextBoxColumn.DataPropertyName = "GRU_NOMBRE";
            gRUNOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre";
            gRUNOMBREDataGridViewTextBoxColumn.Name = "gRUNOMBREDataGridViewTextBoxColumn";
            // 
            // gRUDESCRIPCIONDataGridViewTextBoxColumn
            // 
            gRUDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "GRU_DESCRIPCION";
            gRUDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            gRUDESCRIPCIONDataGridViewTextBoxColumn.Name = "gRUDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // estadoGrupoDataGridViewTextBoxColumn
            // 
            estadoGrupoDataGridViewTextBoxColumn.DataPropertyName = "Estado_Grupo";
            estadoGrupoDataGridViewTextBoxColumn.HeaderText = "Estado Grupo";
            estadoGrupoDataGridViewTextBoxColumn.Name = "estadoGrupoDataGridViewTextBoxColumn";
            // 
            // grupoBindingSource
            // 
            grupoBindingSource.DataSource = typeof(MODELO.seguridad.Grupo);
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 480);
            ControlBox = false;
            Controls.Add(btmVolver);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "FormGrupos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grupoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btmVolver;
        private Panel panel1;
        private Label label4;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label2;
        private Label LbelNom;
        private ComboBox CBestados;
        private TextBox txtnombre;
        private Button btnFiltrar;
        private BindingSource usuarioBindingSource;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn gRUNOMBREDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gRUDESCRIPCIONDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoGrupoDataGridViewTextBoxColumn;
        private BindingSource grupoBindingSource;
    }
}