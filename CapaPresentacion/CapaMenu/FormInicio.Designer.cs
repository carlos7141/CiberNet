namespace CapaPresentacion
{
    partial class FormInicio
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
            RelojTiempoReal = new System.Windows.Forms.Timer(components);
            panelPC = new FlowLayoutPanel();
            txtInfo = new TextBox();
            btnTimeFree = new Button();
            BtnTiempoLibre = new Button();
            btnAddTime = new Button();
            btnRemoveTime = new Button();
            txtTarifa = new TextBox();
            labelReloj = new Label();
            panel1 = new Panel();
            DatosPC = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // RelojTiempoReal
            // 
            RelojTiempoReal.Enabled = true;
            RelojTiempoReal.Tick += RelojTiempoReal_Tick;
            // 
            // panelPC
            // 
            panelPC.Dock = DockStyle.Bottom;
            panelPC.Location = new Point(0, 178);
            panelPC.Name = "panelPC";
            panelPC.Size = new Size(1220, 496);
            panelPC.TabIndex = 20;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(3, 3);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(241, 175);
            txtInfo.TabIndex = 34;
            // 
            // btnTimeFree
            // 
            btnTimeFree.BackColor = Color.Transparent;
            btnTimeFree.FlatStyle = FlatStyle.Flat;
            btnTimeFree.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimeFree.ForeColor = Color.White;
            btnTimeFree.Location = new Point(258, 3);
            btnTimeFree.Name = "btnTimeFree";
            btnTimeFree.Size = new Size(59, 34);
            btnTimeFree.TabIndex = 35;
            btnTimeFree.Text = "Time";
            btnTimeFree.UseVisualStyleBackColor = false;
            // 
            // BtnTiempoLibre
            // 
            BtnTiempoLibre.BackColor = Color.Transparent;
            BtnTiempoLibre.BackgroundImageLayout = ImageLayout.Zoom;
            BtnTiempoLibre.FlatStyle = FlatStyle.Flat;
            BtnTiempoLibre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTiempoLibre.ForeColor = Color.White;
            BtnTiempoLibre.Image = Properties.Resources.play;
            BtnTiempoLibre.Location = new Point(432, 3);
            BtnTiempoLibre.Name = "BtnTiempoLibre";
            BtnTiempoLibre.Size = new Size(37, 34);
            BtnTiempoLibre.TabIndex = 36;
            BtnTiempoLibre.UseVisualStyleBackColor = false;
            BtnTiempoLibre.Click += BtnTiempoLibre_Click;
            // 
            // btnAddTime
            // 
            btnAddTime.BackColor = Color.Transparent;
            btnAddTime.FlatStyle = FlatStyle.Flat;
            btnAddTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddTime.ForeColor = Color.White;
            btnAddTime.Location = new Point(475, 3);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new Size(80, 34);
            btnAddTime.TabIndex = 37;
            btnAddTime.Text = "AddTime";
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            // 
            // btnRemoveTime
            // 
            btnRemoveTime.BackColor = Color.Transparent;
            btnRemoveTime.FlatStyle = FlatStyle.Flat;
            btnRemoveTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveTime.ForeColor = Color.White;
            btnRemoveTime.Location = new Point(323, 3);
            btnRemoveTime.Name = "btnRemoveTime";
            btnRemoveTime.Size = new Size(103, 34);
            btnRemoveTime.TabIndex = 39;
            btnRemoveTime.Text = "RemovTime";
            btnRemoveTime.UseVisualStyleBackColor = false;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(561, 3);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(100, 23);
            txtTarifa.TabIndex = 40;
            txtTarifa.KeyPress += txtTarifa_KeyPress;
            // 
            // labelReloj
            // 
            labelReloj.AutoSize = true;
            labelReloj.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelReloj.ForeColor = Color.White;
            labelReloj.Location = new Point(251, 0);
            labelReloj.Margin = new Padding(4, 0, 4, 0);
            labelReloj.Name = "labelReloj";
            labelReloj.Size = new Size(0, 25);
            labelReloj.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(DatosPC);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(892, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 178);
            panel1.TabIndex = 41;
            // 
            // DatosPC
            // 
            DatosPC.AutoSize = true;
            DatosPC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DatosPC.ForeColor = Color.White;
            DatosPC.Location = new Point(3, 10);
            DatosPC.Name = "DatosPC";
            DatosPC.Size = new Size(0, 19);
            DatosPC.TabIndex = 0;
            DatosPC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtInfo);
            flowLayoutPanel1.Controls.Add(labelReloj);
            flowLayoutPanel1.Controls.Add(btnTimeFree);
            flowLayoutPanel1.Controls.Add(btnRemoveTime);
            flowLayoutPanel1.Controls.Add(BtnTiempoLibre);
            flowLayoutPanel1.Controls.Add(btnAddTime);
            flowLayoutPanel1.Controls.Add(txtTarifa);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(889, 178);
            flowLayoutPanel1.TabIndex = 42;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 38, 44);
            ClientSize = new Size(1220, 674);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panelPC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInicio";
            Load += FormInicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer RelojTiempoReal;
        public FlowLayoutPanel panelPC;
        public TextBox txtInfo;
        private Button btnTimeFree;
        private Button BtnTiempoLibre;
        private Button btnAddTime;
        private Button btnRemoveTime;
        private TextBox txtTarifa;
        private Label labelReloj;
        private Panel panel1;
        private Label DatosPC;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}