using iTextSharp.text.pdf;
using ScottPlot.Hatches;
using ScottPlot.Palettes;

namespace Vista.Estacionamiento
{
    partial class FormAltaServicioPlan
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
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBoxServiciosDisponibles = new GroupBox();
            flowLayoutServiciosDisponibles = new FlowLayoutPanel();
            BtnAceptar = new Button();
            panelInfoVehiculo = new Panel();
            lbPatente = new Label();
            label9 = new Label();
            txtTipo = new TextBox();
            label10 = new Label();
            groupBoxServiciosAsignados = new GroupBox();
            flowLayoutServiciosAsignados = new FlowLayoutPanel();
            panelBotones = new Panel();
            panelHeader.SuspendLayout();
            groupBoxServiciosDisponibles.SuspendLayout();
            panelInfoVehiculo.SuspendLayout();
            groupBoxServiciosAsignados.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1040, 70);
            panelHeader.TabIndex = 48;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🅿️ Asignar servicio ";
            // 
            // groupBoxServiciosDisponibles
            // 
            groupBoxServiciosDisponibles.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxServiciosDisponibles.Controls.Add(flowLayoutServiciosDisponibles);
            groupBoxServiciosDisponibles.Dock = DockStyle.Top;
            groupBoxServiciosDisponibles.FlatStyle = FlatStyle.Flat;
            groupBoxServiciosDisponibles.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxServiciosDisponibles.ForeColor = Color.FromArgb(0, 122, 204);
            groupBoxServiciosDisponibles.Location = new Point(0, 147);
            groupBoxServiciosDisponibles.Margin = new Padding(6, 5, 6, 5);
            groupBoxServiciosDisponibles.Name = "groupBoxServiciosDisponibles";
            groupBoxServiciosDisponibles.Padding = new Padding(15);
            groupBoxServiciosDisponibles.Size = new Size(1040, 240);
            groupBoxServiciosDisponibles.TabIndex = 49;
            groupBoxServiciosDisponibles.TabStop = false;
            groupBoxServiciosDisponibles.Text = "✨ Servicios Disponibles";
            // 
            // flowLayoutServiciosDisponibles
            // 
            flowLayoutServiciosDisponibles.AutoScroll = true;
            flowLayoutServiciosDisponibles.BackColor = Color.FromArgb(37, 37, 38);
            flowLayoutServiciosDisponibles.Dock = DockStyle.Fill;
            flowLayoutServiciosDisponibles.Location = new Point(15, 42);
            flowLayoutServiciosDisponibles.Name = "flowLayoutServiciosDisponibles";
            flowLayoutServiciosDisponibles.Padding = new Padding(5);
            flowLayoutServiciosDisponibles.Size = new Size(1010, 183);
            flowLayoutServiciosDisponibles.TabIndex = 0;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Anchor = AnchorStyles.Left;
            BtnAceptar.BackColor = Color.FromArgb(40, 167, 69);
            BtnAceptar.FlatAppearance.BorderSize = 0;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAceptar.ForeColor = Color.White;
            BtnAceptar.Location = new Point(865, 3);
            BtnAceptar.Margin = new Padding(4, 3, 4, 3);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(160, 45);
            BtnAceptar.TabIndex = 44;
            BtnAceptar.Text = "✓ Guardar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // panelInfoVehiculo
            // 
            panelInfoVehiculo.BackColor = Color.FromArgb(37, 37, 38);
            panelInfoVehiculo.Controls.Add(lbPatente);
            panelInfoVehiculo.Controls.Add(label9);
            panelInfoVehiculo.Controls.Add(txtTipo);
            panelInfoVehiculo.Controls.Add(label10);
            panelInfoVehiculo.Dock = DockStyle.Top;
            panelInfoVehiculo.Location = new Point(0, 70);
            panelInfoVehiculo.Name = "panelInfoVehiculo";
            panelInfoVehiculo.Padding = new Padding(30, 15, 30, 15);
            panelInfoVehiculo.Size = new Size(1040, 77);
            panelInfoVehiculo.TabIndex = 56;
            // 
            // lbPatente
            // 
            lbPatente.AutoSize = true;
            lbPatente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbPatente.ForeColor = Color.FromArgb(0, 122, 204);
            lbPatente.Location = new Point(150, 25);
            lbPatente.Margin = new Padding(4, 0, 4, 0);
            lbPatente.Name = "lbPatente";
            lbPatente.Size = new Size(120, 38);
            lbPatente.TabIndex = 51;
            lbPatente.Text = "ABC123";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 30);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(115, 28);
            label9.TabIndex = 36;
            label9.Text = "📋 Patente";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.FromArgb(45, 45, 48);
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.ForeColor = Color.White;
            txtTipo.Location = new Point(590, 25);
            txtTipo.Margin = new Padding(4, 3, 4, 3);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(280, 37);
            txtTipo.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(460, 30);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 53;
            label10.Text = "🚗 Vehículo";
            // 
            // groupBoxServiciosAsignados
            // 
            groupBoxServiciosAsignados.BackColor = Color.FromArgb(37, 37, 38);
            groupBoxServiciosAsignados.Controls.Add(flowLayoutServiciosAsignados);
            groupBoxServiciosAsignados.Dock = DockStyle.Top;
            groupBoxServiciosAsignados.FlatStyle = FlatStyle.Flat;
            groupBoxServiciosAsignados.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxServiciosAsignados.ForeColor = Color.FromArgb(40, 167, 69);
            groupBoxServiciosAsignados.Location = new Point(0, 387);
            groupBoxServiciosAsignados.Margin = new Padding(6, 5, 6, 5);
            groupBoxServiciosAsignados.Name = "groupBoxServiciosAsignados";
            groupBoxServiciosAsignados.Padding = new Padding(15);
            groupBoxServiciosAsignados.Size = new Size(1040, 223);
            groupBoxServiciosAsignados.TabIndex = 57;
            groupBoxServiciosAsignados.TabStop = false;
            groupBoxServiciosAsignados.Text = "✓ Servicios Asignados";
            // 
            // flowLayoutServiciosAsignados
            // 
            flowLayoutServiciosAsignados.AutoScroll = true;
            flowLayoutServiciosAsignados.BackColor = Color.FromArgb(37, 37, 38);
            flowLayoutServiciosAsignados.Dock = DockStyle.Fill;
            flowLayoutServiciosAsignados.Location = new Point(15, 42);
            flowLayoutServiciosAsignados.Name = "flowLayoutServiciosAsignados";
            flowLayoutServiciosAsignados.Padding = new Padding(5);
            flowLayoutServiciosAsignados.Size = new Size(1010, 166);
            flowLayoutServiciosAsignados.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(30, 30, 30);
            panelBotones.Controls.Add(BtnAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 610);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1040, 65);
            panelBotones.TabIndex = 58;
            // 
            // FormAltaServicioPlan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1040, 675);
            ControlBox = false;
            Controls.Add(groupBoxServiciosAsignados);
            Controls.Add(groupBoxServiciosDisponibles);
            Controls.Add(panelInfoVehiculo);
            Controls.Add(panelHeader);
            Controls.Add(panelBotones);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAltaServicioPlan";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBoxServiciosDisponibles.ResumeLayout(false);
            panelInfoVehiculo.ResumeLayout(false);
            panelInfoVehiculo.PerformLayout();
            groupBoxServiciosAsignados.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label lblTitulo;
        private GroupBox groupBoxServiciosDisponibles;
        private FlowLayoutPanel flowLayoutServiciosDisponibles;
        private Button BtnAceptar;
        private Panel panelInfoVehiculo;
        private Label label9;
        private TextBox txtTipo;
        private Label label10;
        private Label lbPatente;
        private GroupBox groupBoxServiciosAsignados;
        private FlowLayoutPanel flowLayoutServiciosAsignados;
        private Panel panelBotones;
    }
}