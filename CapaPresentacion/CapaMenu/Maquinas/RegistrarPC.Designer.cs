using CapaHerramientas;
namespace CapaPresentacion
{
    partial class RegistrarPC
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
            panelBarra = new Panel();
            btnClose = new PictureBox();
            labelRegistrar = new Label();
            panelBtn = new Panel();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            txtCategoria = new ComboBox();
            txtIpAddress = new BoxText();
            txtNombre = new BoxText();
            panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelBtn.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(35, 38, 44);
            panelBarra.Controls.Add(btnClose);
            panelBarra.Controls.Add(labelRegistrar);
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(0, 0);
            panelBarra.Name = "panelBarra";
            panelBarra.Size = new Size(350, 51);
            panelBarra.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(313, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelRegistrar
            // 
            labelRegistrar.AutoSize = true;
            labelRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistrar.ForeColor = Color.White;
            labelRegistrar.Location = new Point(12, 15);
            labelRegistrar.Name = "labelRegistrar";
            labelRegistrar.Size = new Size(135, 20);
            labelRegistrar.TabIndex = 0;
            labelRegistrar.Text = "Registrar Maquina";
            // 
            // panelBtn
            // 
            panelBtn.BackColor = Color.FromArgb(35, 38, 44);
            panelBtn.Controls.Add(btnRegistrar);
            panelBtn.Controls.Add(btnCancelar);
            panelBtn.Dock = DockStyle.Bottom;
            panelBtn.Location = new Point(0, 399);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(350, 51);
            panelBtn.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(267, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 27);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DimGray;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(186, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 27);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Items.AddRange(new object[] { "Ninguno" });
            txtCategoria.Location = new Point(50, 306);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(250, 23);
            txtCategoria.TabIndex = 5;
            // 
            // txtIpAddress
            // 
            txtIpAddress.BackColor = Color.FromArgb(19, 21, 23);
            txtIpAddress.BorderColor = SystemColors.HotTrack;
            txtIpAddress.BorderFocusColor = Color.HotPink;
            txtIpAddress.BorderSize = 2;
            txtIpAddress.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIpAddress.ForeColor = Color.White;
            txtIpAddress.Location = new Point(50, 212);
            txtIpAddress.MaxLength = 15;
            txtIpAddress.Multiline = false;
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Padding = new Padding(7);
            txtIpAddress.PasswordChar = false;
            txtIpAddress.PlaceholderText = "Ingresar dirección Ip";
            txtIpAddress.Size = new Size(250, 35);
            txtIpAddress.TabIndex = 4;
            txtIpAddress.Texts = "";
            txtIpAddress.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(19, 21, 23);
            txtNombre.BorderColor = SystemColors.HotTrack;
            txtNombre.BorderFocusColor = Color.HotPink;
            txtNombre.BorderSize = 2;
            txtNombre.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(50, 121);
            txtNombre.MaxLength = 10;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderText = "Ingresar nombre";
            txtNombre.Size = new Size(250, 35);
            txtNombre.TabIndex = 3;
            txtNombre.Texts = "";
            txtNombre.UnderlinedStyle = true;
            // 
            // RegistrarPC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(350, 450);
            Controls.Add(txtCategoria);
            Controls.Add(txtIpAddress);
            Controls.Add(txtNombre);
            Controls.Add(panelBtn);
            Controls.Add(panelBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarPC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarPC";
            Load += RegistrarPC_Load;
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarra;
        private PictureBox btnClose;
        private Label labelRegistrar;
        private Panel panelBtn;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ComboBox txtCategoria;
        private BoxText txtIpAddress;
        private BoxText txtNombre;
    }
}