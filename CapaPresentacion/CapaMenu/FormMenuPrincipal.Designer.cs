using CapaHerramientas;

namespace CapaPresentacion
{
    partial class FormMenuPrincipal
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
            panelCentral = new Panel();
            sideBar = new FlowLayoutPanel();
            panel3 = new Panel();
            btnMenu = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnPanelInicio = new Button();
            panel4 = new Panel();
            btnPanelUsuarios = new Button();
            panel5 = new Panel();
            btnPanelMaquinas = new Button();
            panel6 = new Panel();
            btnPanelReservas = new Button();
            panel7 = new Panel();
            btnPanelTarifas = new Button();
            panel8 = new Panel();
            BtnPanelBackUp = new Button();
            panel1 = new Panel();
            BtnPanelInformes = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            dropDownMenu1 = new DropDownMenu(components);
            sasToolStripMenuItem = new ToolStripMenuItem();
            saToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            sideBar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            dropDownMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.Transparent;
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(58, 0);
            panelCentral.Margin = new Padding(0);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1220, 674);
            panelCentral.TabIndex = 4;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.Transparent;
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel5);
            sideBar.Controls.Add(panel6);
            sideBar.Controls.Add(panel7);
            sideBar.Controls.Add(panel8);
            sideBar.Controls.Add(panel1);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Margin = new Padding(4, 3, 4, 3);
            sideBar.MaximumSize = new Size(204, 0);
            sideBar.MinimumSize = new Size(58, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(58, 674);
            sideBar.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMenu);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(4, 3);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 115);
            panel3.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.Location = new Point(6, 37);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(43, 37);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 37);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPanelInicio);
            panel2.Location = new Point(4, 124);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 46);
            panel2.TabIndex = 0;
            // 
            // btnPanelInicio
            // 
            btnPanelInicio.BackColor = Color.Transparent;
            btnPanelInicio.FlatAppearance.BorderSize = 0;
            btnPanelInicio.FlatStyle = FlatStyle.Flat;
            btnPanelInicio.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPanelInicio.ForeColor = Color.White;
            btnPanelInicio.Image = Properties.Resources.home;
            btnPanelInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanelInicio.Location = new Point(-27, -10);
            btnPanelInicio.Margin = new Padding(4, 3, 4, 3);
            btnPanelInicio.Name = "btnPanelInicio";
            btnPanelInicio.Padding = new Padding(29, 0, 0, 0);
            btnPanelInicio.Size = new Size(245, 67);
            btnPanelInicio.TabIndex = 3;
            btnPanelInicio.Text = "Inicio";
            btnPanelInicio.UseVisualStyleBackColor = false;
            btnPanelInicio.Click += btnPanelInicio_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnPanelUsuarios);
            panel4.Location = new Point(4, 176);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 46);
            panel4.TabIndex = 4;
            // 
            // btnPanelUsuarios
            // 
            btnPanelUsuarios.BackColor = Color.Transparent;
            btnPanelUsuarios.FlatAppearance.BorderSize = 0;
            btnPanelUsuarios.FlatStyle = FlatStyle.Flat;
            btnPanelUsuarios.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPanelUsuarios.ForeColor = Color.White;
            btnPanelUsuarios.Image = Properties.Resources.users;
            btnPanelUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanelUsuarios.Location = new Point(-27, -10);
            btnPanelUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnPanelUsuarios.Name = "btnPanelUsuarios";
            btnPanelUsuarios.Padding = new Padding(29, 0, 0, 0);
            btnPanelUsuarios.Size = new Size(245, 67);
            btnPanelUsuarios.TabIndex = 3;
            btnPanelUsuarios.Text = "Usuarios";
            btnPanelUsuarios.UseVisualStyleBackColor = false;
            btnPanelUsuarios.Click += btnPanelUsuarios_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPanelMaquinas);
            panel5.Location = new Point(4, 228);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 46);
            panel5.TabIndex = 4;
            // 
            // btnPanelMaquinas
            // 
            btnPanelMaquinas.BackColor = Color.Transparent;
            btnPanelMaquinas.FlatAppearance.BorderSize = 0;
            btnPanelMaquinas.FlatStyle = FlatStyle.Flat;
            btnPanelMaquinas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPanelMaquinas.ForeColor = Color.White;
            btnPanelMaquinas.Image = Properties.Resources.monitor;
            btnPanelMaquinas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanelMaquinas.Location = new Point(-27, -10);
            btnPanelMaquinas.Margin = new Padding(4, 3, 4, 3);
            btnPanelMaquinas.Name = "btnPanelMaquinas";
            btnPanelMaquinas.Padding = new Padding(29, 0, 0, 0);
            btnPanelMaquinas.Size = new Size(245, 67);
            btnPanelMaquinas.TabIndex = 3;
            btnPanelMaquinas.Text = "Maquinas";
            btnPanelMaquinas.UseVisualStyleBackColor = false;
            btnPanelMaquinas.Click += btnPanelMaquinas_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnPanelReservas);
            panel6.Location = new Point(4, 280);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(201, 46);
            panel6.TabIndex = 5;
            // 
            // btnPanelReservas
            // 
            btnPanelReservas.BackColor = Color.Transparent;
            btnPanelReservas.FlatAppearance.BorderSize = 0;
            btnPanelReservas.FlatStyle = FlatStyle.Flat;
            btnPanelReservas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPanelReservas.ForeColor = Color.White;
            btnPanelReservas.Image = Properties.Resources.calendar;
            btnPanelReservas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanelReservas.Location = new Point(-27, -10);
            btnPanelReservas.Margin = new Padding(4, 3, 4, 3);
            btnPanelReservas.Name = "btnPanelReservas";
            btnPanelReservas.Padding = new Padding(29, 0, 0, 0);
            btnPanelReservas.Size = new Size(245, 67);
            btnPanelReservas.TabIndex = 3;
            btnPanelReservas.Text = "Reservas";
            btnPanelReservas.UseVisualStyleBackColor = false;
            btnPanelReservas.Click += btnPanelReservas_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnPanelTarifas);
            panel7.Location = new Point(4, 332);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(201, 46);
            panel7.TabIndex = 6;
            // 
            // btnPanelTarifas
            // 
            btnPanelTarifas.BackColor = Color.Transparent;
            btnPanelTarifas.FlatAppearance.BorderSize = 0;
            btnPanelTarifas.FlatStyle = FlatStyle.Flat;
            btnPanelTarifas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPanelTarifas.ForeColor = Color.White;
            btnPanelTarifas.Image = Properties.Resources.dollar_sign;
            btnPanelTarifas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanelTarifas.Location = new Point(-27, -10);
            btnPanelTarifas.Margin = new Padding(4, 3, 4, 3);
            btnPanelTarifas.Name = "btnPanelTarifas";
            btnPanelTarifas.Padding = new Padding(29, 0, 0, 0);
            btnPanelTarifas.Size = new Size(245, 67);
            btnPanelTarifas.TabIndex = 3;
            btnPanelTarifas.Text = "Tarifas";
            btnPanelTarifas.UseVisualStyleBackColor = false;
            btnPanelTarifas.Click += btnPanelTarifas_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(BtnPanelBackUp);
            panel8.Location = new Point(4, 384);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(201, 46);
            panel8.TabIndex = 6;
            // 
            // BtnPanelBackUp
            // 
            BtnPanelBackUp.BackColor = Color.Transparent;
            BtnPanelBackUp.FlatAppearance.BorderSize = 0;
            BtnPanelBackUp.FlatStyle = FlatStyle.Flat;
            BtnPanelBackUp.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPanelBackUp.ForeColor = Color.White;
            BtnPanelBackUp.Image = Properties.Resources.shield;
            BtnPanelBackUp.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPanelBackUp.Location = new Point(-27, -10);
            BtnPanelBackUp.Margin = new Padding(4, 3, 4, 3);
            BtnPanelBackUp.Name = "BtnPanelBackUp";
            BtnPanelBackUp.Padding = new Padding(29, 0, 0, 0);
            BtnPanelBackUp.Size = new Size(245, 67);
            BtnPanelBackUp.TabIndex = 3;
            BtnPanelBackUp.Text = "Restricciones";
            BtnPanelBackUp.UseVisualStyleBackColor = false;
            BtnPanelBackUp.Click += BtnPanelBackUp_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnPanelInformes);
            panel1.Location = new Point(4, 436);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 46);
            panel1.TabIndex = 7;
            // 
            // BtnPanelInformes
            // 
            BtnPanelInformes.BackColor = Color.Transparent;
            BtnPanelInformes.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPanelInformes.FlatAppearance.BorderSize = 0;
            BtnPanelInformes.FlatStyle = FlatStyle.Flat;
            BtnPanelInformes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPanelInformes.ForeColor = Color.White;
            BtnPanelInformes.Image = Properties.Resources.informes;
            BtnPanelInformes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPanelInformes.Location = new Point(-27, -10);
            BtnPanelInformes.Margin = new Padding(4, 3, 4, 3);
            BtnPanelInformes.Name = "BtnPanelInformes";
            BtnPanelInformes.Padding = new Padding(29, 0, 0, 0);
            BtnPanelInformes.Size = new Size(245, 67);
            BtnPanelInformes.TabIndex = 3;
            BtnPanelInformes.Text = "Informes";
            BtnPanelInformes.UseVisualStyleBackColor = false;
            BtnPanelInformes.Click += BtnPanelInformes_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // dropDownMenu1
            // 
            dropDownMenu1.IsMainMenu = false;
            dropDownMenu1.Items.AddRange(new ToolStripItem[] { sasToolStripMenuItem, saToolStripMenuItem, toolStripMenuItem2 });
            dropDownMenu1.MenuItemHeaderSize = null;
            dropDownMenu1.MenuItemHeight = 25;
            dropDownMenu1.MenuItemTextColor = Color.DimGray;
            dropDownMenu1.Name = "dropDownMenu1";
            dropDownMenu1.PrimaryColor = Color.MediumSlateBlue;
            dropDownMenu1.Size = new Size(81, 70);
            // 
            // sasToolStripMenuItem
            // 
            sasToolStripMenuItem.Name = "sasToolStripMenuItem";
            sasToolStripMenuItem.Size = new Size(80, 22);
            sasToolStripMenuItem.Text = "1";
            // 
            // saToolStripMenuItem
            // 
            saToolStripMenuItem.Name = "saToolStripMenuItem";
            saToolStripMenuItem.Size = new Size(80, 22);
            saToolStripMenuItem.Text = "2";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(80, 22);
            toolStripMenuItem2.Text = "3";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(80, 22);
            toolStripMenuItem3.Text = "1";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 38, 44);
            ClientSize = new Size(1278, 674);
            Controls.Add(panelCentral);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            Load += FormMenuPrincipal_Load;
            ResizeEnd += FormMenuPrincipal_ResizeEnd;
            sideBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            dropDownMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCentral;
        private FlowLayoutPanel sideBar;
        private Panel panel3;
        private PictureBox btnMenu;
        private Label label1;
        private Panel panel2;
        private Button btnPanelInicio;
        private Panel panel4;
        private Button btnPanelUsuarios;
        private Panel panel5;
        private Button btnPanelMaquinas;
        private Panel panel6;
        private Button btnPanelReservas;
        private Panel panel7;
        private Button btnPanelTarifas;
        private Panel panel8;
        private Button BtnPanelBackUp;
        private System.Windows.Forms.Timer sideBarTimer;
        private DropDownMenu dropDownMenu1;
        private ToolStripMenuItem sasToolStripMenuItem;
        private ToolStripMenuItem saToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Panel panel1;
        private Button BtnPanelInformes;
    }
}