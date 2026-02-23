namespace Vista.Configuraciones
{
    partial class FormTrazabilidadTicket
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
            BtnSalir = new Button();
            lblAuditoria = new Label();
            dataGridView1 = new DataGridView();
            operacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            campoModificadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorAnteriorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorNuevoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            auditoriaTicketBindingSource = new BindingSource(components);
            ticketBindingSource2 = new BindingSource(components);
            ticketBindingSource = new BindingSource(components);
            formTicketBindingSource = new BindingSource(components);
            ticketBindingSource1 = new BindingSource(components);
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)auditoriaTicketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formTicketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(28, 28, 30);
            panelSidebar.Controls.Add(BtnSalir);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15);
            panelSidebar.Size = new Size(280, 887);
            panelSidebar.TabIndex = 0;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSalir.BackColor = Color.FromArgb(108, 117, 125);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(20, 802);
            BtnSalir.Margin = new Padding(0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(240, 55);
            BtnSalir.TabIndex = 6;
            BtnSalir.Text = "◄ Volver";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // lblAuditoria
            // 
            lblAuditoria.AutoSize = true;
            lblAuditoria.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuditoria.ForeColor = Color.White;
            lblAuditoria.Location = new Point(295, 39);
            lblAuditoria.Name = "lblAuditoria";
            lblAuditoria.Size = new Size(388, 30);
            lblAuditoria.TabIndex = 2;
            lblAuditoria.Text = "🎟️ Registro de estados del ticket nro:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 48);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { operacionDataGridViewTextBoxColumn, campoModificadoDataGridViewTextBoxColumn, valorAnteriorDataGridViewTextBoxColumn, valorNuevoDataGridViewTextBoxColumn, fechaHoraDataGridViewTextBoxColumn, usuarioDataGridViewTextBoxColumn });
            dataGridView1.DataSource = auditoriaTicketBindingSource;
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
            dataGridView1.Location = new Point(295, 72);
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
            dataGridView1.Size = new Size(1101, 814);
            dataGridView1.TabIndex = 3;
            // 
            // operacionDataGridViewTextBoxColumn
            // 
            operacionDataGridViewTextBoxColumn.DataPropertyName = "Operacion";
            operacionDataGridViewTextBoxColumn.HeaderText = "Operacion";
            operacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            operacionDataGridViewTextBoxColumn.Name = "operacionDataGridViewTextBoxColumn";
            operacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // campoModificadoDataGridViewTextBoxColumn
            // 
            campoModificadoDataGridViewTextBoxColumn.DataPropertyName = "CampoModificado";
            campoModificadoDataGridViewTextBoxColumn.HeaderText = "Campo";
            campoModificadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            campoModificadoDataGridViewTextBoxColumn.Name = "campoModificadoDataGridViewTextBoxColumn";
            campoModificadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorAnteriorDataGridViewTextBoxColumn
            // 
            valorAnteriorDataGridViewTextBoxColumn.DataPropertyName = "ValorAnterior";
            valorAnteriorDataGridViewTextBoxColumn.HeaderText = "ValorAnterior";
            valorAnteriorDataGridViewTextBoxColumn.MinimumWidth = 8;
            valorAnteriorDataGridViewTextBoxColumn.Name = "valorAnteriorDataGridViewTextBoxColumn";
            valorAnteriorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorNuevoDataGridViewTextBoxColumn
            // 
            valorNuevoDataGridViewTextBoxColumn.DataPropertyName = "ValorNuevo";
            valorNuevoDataGridViewTextBoxColumn.HeaderText = "ValorNuevo";
            valorNuevoDataGridViewTextBoxColumn.MinimumWidth = 8;
            valorNuevoDataGridViewTextBoxColumn.Name = "valorNuevoDataGridViewTextBoxColumn";
            valorNuevoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraDataGridViewTextBoxColumn
            // 
            fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "FechaHora";
            fechaHoraDataGridViewTextBoxColumn.HeaderText = "FechaHora";
            fechaHoraDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            fechaHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            usuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auditoriaTicketBindingSource
            // 
            auditoriaTicketBindingSource.DataSource = typeof(MODELO.AuditoriaTicket);
            // 
            // FormTrazabilidadTicket
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1446, 887);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(lblAuditoria);
            Controls.Add(panelSidebar);
            ImeMode = ImeMode.Disable;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTrazabilidadTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormTrazabilidadTicket_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)auditoriaTicketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)formTicketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Button BtnSalir;
        private Label lblAuditoria;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fechaHoraEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TarifaEstacionamiento;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource ticketBindingSource2;
        private BindingSource ticketBindingSource;
        private BindingSource formTicketBindingSource;
        private BindingSource ticketBindingSource1;
        private BindingSource auditoriaTicketBindingSource;
        private DataGridViewTextBoxColumn operacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn campoModificadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorAnteriorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorNuevoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}