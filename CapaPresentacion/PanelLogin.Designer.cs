namespace CapaPresentacion
{
    partial class PanelLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCentralLogin = new Panel();
            panelBarra = new Panel();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            labelTitulo = new Label();
            panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panelCentralLogin
            // 
            panelCentralLogin.BackColor = Color.FromArgb(39, 38, 44);
            panelCentralLogin.Dock = DockStyle.Fill;
            panelCentralLogin.Location = new Point(0, 44);
            panelCentralLogin.Margin = new Padding(0);
            panelCentralLogin.Name = "panelCentralLogin";
            panelCentralLogin.Size = new Size(700, 418);
            panelCentralLogin.TabIndex = 10;
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(39, 38, 44);
            panelBarra.Controls.Add(pictureBox1);
            panelBarra.Controls.Add(btnClose);
            panelBarra.Controls.Add(labelTitulo);
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(0, 0);
            panelBarra.Margin = new Padding(0);
            panelBarra.Name = "panelBarra";
            panelBarra.Size = new Size(700, 44);
            panelBarra.TabIndex = 9;
            panelBarra.MouseDown += panelBarra_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x;
            pictureBox1.Location = new Point(651, 5);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(1152, 3);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 36);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Nirmala UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(281, 0);
            labelTitulo.Margin = new Padding(0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(109, 30);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "CIBERNET";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            labelTitulo.MouseDown += labelTitulo_MouseDown;
            // 
            // PanelLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 38, 44);
            ClientSize = new Size(700, 462);
            Controls.Add(panelCentralLogin);
            Controls.Add(panelBarra);
            Name = "PanelLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PanelLogin_Load;
            ResizeEnd += PanelLogin_ResizeEnd;
            Resize += PanelLogin_Resize;
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelCentralLogin;
        private Panel panelBarra;
        private PictureBox btnClose;
        private Label labelTitulo;
        private PictureBox pictureBox1;
    }
}