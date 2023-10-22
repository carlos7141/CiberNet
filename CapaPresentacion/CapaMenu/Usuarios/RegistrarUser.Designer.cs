using CapaHerramientas;
namespace CapaPresentacion
{
    partial class RegistrarUser
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
            txtUsuario = new BoxText();
            txtNombre = new BoxText();
            panelBtn = new Panel();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            txtCorreo = new BoxText();
            txtFNac = new DateTimePicker();
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
            panelBarra.Size = new Size(500, 51);
            panelBarra.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(463, 12);
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
            labelRegistrar.Size = new Size(143, 20);
            labelRegistrar.TabIndex = 0;
            labelRegistrar.Text = "Registro de Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(19, 21, 23);
            txtUsuario.BorderColor = SystemColors.HotTrack;
            txtUsuario.BorderFocusColor = Color.HotPink;
            txtUsuario.BorderSize = 2;
            txtUsuario.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(132, 162);
            txtUsuario.MaxLength = 15;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(7);
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderText = "Ingresar Usuario";
            txtUsuario.Size = new Size(250, 35);
            txtUsuario.TabIndex = 8;
            txtUsuario.Texts = "";
            txtUsuario.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(19, 21, 23);
            txtNombre.BorderColor = SystemColors.HotTrack;
            txtNombre.BorderFocusColor = Color.HotPink;
            txtNombre.BorderSize = 2;
            txtNombre.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(132, 95);
            txtNombre.MaxLength = 10;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderText = "Ingresar Nombre";
            txtNombre.Size = new Size(250, 35);
            txtNombre.TabIndex = 7;
            txtNombre.Texts = "";
            txtNombre.UnderlinedStyle = true;
            // 
            // panelBtn
            // 
            panelBtn.BackColor = Color.FromArgb(35, 38, 44);
            panelBtn.Controls.Add(btnRegistrar);
            panelBtn.Controls.Add(btnCancelar);
            panelBtn.Dock = DockStyle.Bottom;
            panelBtn.Location = new Point(0, 449);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(500, 51);
            panelBtn.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(343, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 27);
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
            btnCancelar.Location = new Point(12, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 27);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(19, 21, 23);
            txtCorreo.BorderColor = SystemColors.HotTrack;
            txtCorreo.BorderFocusColor = Color.HotPink;
            txtCorreo.BorderSize = 2;
            txtCorreo.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(132, 225);
            txtCorreo.MaxLength = 40;
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(7);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderText = "Ingresar correo electrónico";
            txtCorreo.Size = new Size(250, 35);
            txtCorreo.TabIndex = 9;
            txtCorreo.Texts = "";
            txtCorreo.UnderlinedStyle = true;
            // 
            // txtFNac
            // 
            txtFNac.Format = DateTimePickerFormat.Short;
            txtFNac.Location = new Point(132, 304);
            txtFNac.Name = "txtFNac";
            txtFNac.Size = new Size(250, 23);
            txtFNac.TabIndex = 10;
            // 
            // RegistrarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(500, 500);
            Controls.Add(txtFNac);
            Controls.Add(txtCorreo);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(panelBtn);
            Controls.Add(panelBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarUser";
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
        private BoxText txtUsuario;
        private BoxText txtNombre;
        private Panel panelBtn;
        private Button btnRegistrar;
        private Button btnCancelar;
        private BoxText txtCorreo;
        private DateTimePicker txtFNac;
    }
}