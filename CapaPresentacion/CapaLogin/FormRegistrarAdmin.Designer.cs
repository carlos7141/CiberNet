namespace CapaPresentacion
{
    partial class FormRegistrarAdmin
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
            label1 = new Label();
            txtNombre = new TextBox();
            labelConfPass = new Label();
            txtConfPass = new TextBox();
            labelPassword = new Label();
            labelUsuario = new Label();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            btnGuardar = new Button();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(278, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 26;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(365, 142);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 23);
            txtNombre.TabIndex = 27;
            // 
            // labelConfPass
            // 
            labelConfPass.AutoSize = true;
            labelConfPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfPass.ForeColor = Color.White;
            labelConfPass.ImeMode = ImeMode.NoControl;
            labelConfPass.Location = new Point(160, 247);
            labelConfPass.Margin = new Padding(4, 0, 4, 0);
            labelConfPass.Name = "labelConfPass";
            labelConfPass.Size = new Size(169, 20);
            labelConfPass.TabIndex = 24;
            labelConfPass.Text = "Confirmar Contraseña:";
            // 
            // txtConfPass
            // 
            txtConfPass.Location = new Point(364, 247);
            txtConfPass.Margin = new Padding(4, 3, 4, 3);
            txtConfPass.Name = "txtConfPass";
            txtConfPass.PasswordChar = '*';
            txtConfPass.Size = new Size(190, 23);
            txtConfPass.TabIndex = 25;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.ImeMode = ImeMode.NoControl;
            labelPassword.Location = new Point(245, 211);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(96, 20);
            labelPassword.TabIndex = 19;
            labelPassword.Text = "Contraseña:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.ImeMode = ImeMode.NoControl;
            labelUsuario.Location = new Point(278, 177);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(68, 20);
            labelUsuario.TabIndex = 18;
            labelUsuario.Text = "Usuario:";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImeMode = ImeMode.NoControl;
            btnCancelar.Location = new Point(402, 287);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 29);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(365, 176);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(190, 23);
            txtUsuario.TabIndex = 20;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImeMode = ImeMode.NoControl;
            btnGuardar.Location = new Point(264, 287);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 29);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(364, 211);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(190, 23);
            txtPassword.TabIndex = 21;
            // 
            // FormRegistrarAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 38, 44);
            ClientSize = new Size(714, 458);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(labelConfPass);
            Controls.Add(txtConfPass);
            Controls.Add(labelPassword);
            Controls.Add(labelUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(txtUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarAdmin";
            Text = "FormRegistrarAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label labelConfPass;
        private TextBox txtConfPass;
        private Label labelPassword;
        private Label labelUsuario;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private Button btnGuardar;
        private TextBox txtPassword;
    }
}