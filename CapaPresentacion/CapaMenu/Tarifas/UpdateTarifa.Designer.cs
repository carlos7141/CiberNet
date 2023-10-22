using CapaHerramientas;
namespace CapaPresentacion
{
    partial class UpdateTarifa
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
            txtPrecio = new BoxText();
            txtNombre = new BoxText();
            panelBtn = new Panel();
            btnRegistrar = new Button();
            btnCancelar = new Button();
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
            labelRegistrar.Size = new Size(128, 20);
            labelRegistrar.TabIndex = 0;
            labelRegistrar.Text = "Registro de Tarifa";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(19, 21, 23);
            txtPrecio.BorderColor = SystemColors.HotTrack;
            txtPrecio.BorderFocusColor = Color.HotPink;
            txtPrecio.BorderSize = 2;
            txtPrecio.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(132, 199);
            txtPrecio.MaxLength = 15;
            txtPrecio.Multiline = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Padding = new Padding(7);
            txtPrecio.PasswordChar = false;
            txtPrecio.PlaceholderText = "Ingresar precio por hora";
            txtPrecio.Size = new Size(250, 35);
            txtPrecio.TabIndex = 8;
            txtPrecio.Texts = "";
            txtPrecio.UnderlinedStyle = true;
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
            btnRegistrar.Text = "Actualizar";
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
            // UpdateTarifa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(500, 500);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(panelBtn);
            Controls.Add(panelBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateTarifa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateUser";
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
        private BoxText txtPrecio;
        private BoxText txtNombre;
        private Panel panelBtn;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}