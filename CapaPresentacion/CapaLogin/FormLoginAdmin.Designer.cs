using CapaHerramientas;
namespace CapaPresentacion
{
    partial class FormLoginAdmin
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
            txtPassword = new BoxText();
            txtUsuario = new BoxText();
            btnRegistrar = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(39, 38, 44);
            txtPassword.BorderColor = Color.FromArgb(128, 90, 255);
            txtPassword.BorderFocusColor = Color.FromArgb(128, 128, 255);
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(207, 199);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.MaxLength = 15;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(8);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(304, 32);
            txtPassword.TabIndex = 6;
            txtPassword.UnderlinedStyle = true;
            txtPassword.EnterKeyPressed += txtPassword_EnterKeyPressed;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(39, 38, 44);
            txtUsuario.BorderColor = Color.FromArgb(128, 90, 255);
            txtUsuario.BorderFocusColor = Color.FromArgb(128, 128, 255);
            txtUsuario.BorderSize = 2;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(207, 139);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.MaxLength = 20;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(8);
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderText = "Ingresar Usuario";
            txtUsuario.Size = new Size(304, 32);
            txtUsuario.TabIndex = 5;
            txtUsuario.UnderlinedStyle = true;
            txtUsuario.EnterKeyPressed += txtUsuario_EnterKeyPressed;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = true;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(204, 305);
            btnRegistrar.Margin = new Padding(4, 0, 4, 0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(64, 15);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(64, 68, 237);
            btnIngresar.FlatAppearance.BorderColor = Color.Black;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(207, 256);
            btnIngresar.Margin = new Padding(4, 3, 4, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(304, 29);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseMnemonic = false;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 38, 44);
            ClientSize = new Size(714, 458);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoginAdmin";
            Text = "FormLoginAdmin";
            Load += FormLoginAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BoxText txtPassword;
        private BoxText txtUsuario;
        private Label btnRegistrar;
        public Button btnIngresar;
    }
}