namespace Vista.Configuraciones
{
    partial class FormSalidaPorPatente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            pnlBody = new Panel();
            lblSubtitulo = new Label();
            pnlFooter = new Panel();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblHint = new Label();
            pnlInputWrapper = new Panel();
            txtPatente = new TextBox();
            lblLabelPatente = new Label();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlMain.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlInputWrapper.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(18, 21, 32);
            pnlMain.Controls.Add(pnlBody);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(400, 450);
            pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(30, 30, 34);
            pnlBody.Controls.Add(lblSubtitulo);
            pnlBody.Controls.Add(pnlFooter);
            pnlBody.Controls.Add(lblHint);
            pnlBody.Controls.Add(pnlInputWrapper);
            pnlBody.Controls.Add(lblLabelPatente);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 70);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(24, 18, 24, 0);
            pnlBody.Size = new Size(400, 380);
            pnlBody.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(24, 18);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 18);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Búsqueda de ticket por patente";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Transparent;
            pnlFooter.Controls.Add(btnAceptar);
            pnlFooter.Controls.Add(btnCancelar);
            pnlFooter.Location = new Point(24, 268);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(332, 44);
            pnlFooter.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(52, 58, 64);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(116, 0);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(216, 40);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "REGISTRAR SALIDA";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(220, 53, 69);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(30, 38, 60);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(2, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblHint
            // 
            lblHint.BackColor = Color.Transparent;
            lblHint.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblHint.ForeColor = Color.White;
            lblHint.Location = new Point(24, 163);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(332, 16);
            lblHint.TabIndex = 2;
            lblHint.Text = "Presioná ENTER para buscar el ticket";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInputWrapper
            // 
            pnlInputWrapper.BackColor = Color.FromArgb(22, 27, 40);
            pnlInputWrapper.Controls.Add(txtPatente);
            pnlInputWrapper.Location = new Point(24, 107);
            pnlInputWrapper.Name = "pnlInputWrapper";
            pnlInputWrapper.Padding = new Padding(2);
            pnlInputWrapper.Size = new Size(332, 52);
            pnlInputWrapper.TabIndex = 3;
            // 
            // txtPatente
            // 
            txtPatente.BackColor = Color.FromArgb(22, 27, 40);
            txtPatente.BorderStyle = BorderStyle.None;
            txtPatente.CharacterCasing = CharacterCasing.Upper;
            txtPatente.Dock = DockStyle.Fill;
            txtPatente.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtPatente.ForeColor = Color.FromArgb(232, 234, 240);
            txtPatente.Location = new Point(2, 2);
            txtPatente.Margin = new Padding(8, 0, 8, 0);
            txtPatente.MaxLength = 8;
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(328, 41);
            txtPatente.TabIndex = 0;
            txtPatente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblLabelPatente
            // 
            lblLabelPatente.BackColor = Color.Transparent;
            lblLabelPatente.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblLabelPatente.ForeColor = Color.White;
            lblLabelPatente.Location = new Point(24, 88);
            lblLabelPatente.Name = "lblLabelPatente";
            lblLabelPatente.Size = new Size(200, 16);
            lblLabelPatente.TabIndex = 4;
            lblLabelPatente.Text = "PATENTE";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 122, 204);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(16, 0, 0, 0);
            pnlHeader.Size = new Size(400, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(54, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 36);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "SALIDA VEHICULAR";
            // 
            // FormSalidaPorPatente
            // 
            BackColor = Color.FromArgb(18, 21, 32);
            ClientSize = new Size(400, 450);
            ControlBox = false;
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSalidaPorPatente";
            StartPosition = FormStartPosition.CenterScreen;
            pnlMain.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlInputWrapper.ResumeLayout(false);
            pnlInputWrapper.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ── Controles ─────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblLabelPatente;
        private System.Windows.Forms.Panel pnlInputWrapper;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}