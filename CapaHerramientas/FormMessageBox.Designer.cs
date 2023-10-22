namespace CapaHerramientas
{
    partial class FormMessageBox
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
            panelTitleBar = new Panel();
            labelCaption = new Label();
            btnClose = new Button();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panelButtons = new Panel();
            panelTitleBar.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.CornflowerBlue;
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelTitleBar.Location = new Point(2, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(346, 35);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaption.ForeColor = Color.White;
            labelCaption.Location = new Point(9, 8);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(86, 17);
            labelCaption.TabIndex = 0;
            labelCaption.Text = "labelCaption";
            labelCaption.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.CornflowerBlue;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 79, 95);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 79, 95);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(306, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.WhiteSmoke;
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(2, 37);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(10, 10, 0, 0);
            panelBody.Size = new Size(346, 51);
            panelBody.TabIndex = 1;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.Location = new Point(50, 10);
            labelMessage.MaximumSize = new Size(600, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(5, 5, 10, 15);
            labelMessage.Size = new Size(110, 37);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "labelMessage";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Left;
            pictureBoxIcon.Image = Properties.Resources.chat;
            pictureBoxIcon.Location = new Point(10, 10);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(40, 41);
            pictureBoxIcon.TabIndex = 1;
            pictureBoxIcon.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(125, 12);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(231, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(235, 235, 235);
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(2, 88);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(346, 60);
            panelButtons.TabIndex = 2;
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 150);
            Controls.Add(panelBody);
            Controls.Add(panelButtons);
            Controls.Add(panelTitleBar);
            MinimumSize = new Size(350, 150);
            Name = "FormMessageBox";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMessageBox";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Label labelCaption;
        private Panel panelBody;
        private PictureBox pictureBoxIcon;
        private Label labelMessage;
        private Button btnClose;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panelButtons;
    }
}