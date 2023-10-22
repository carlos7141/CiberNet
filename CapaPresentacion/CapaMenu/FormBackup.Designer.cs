namespace CapaPresentacion
{
    partial class FormBackup
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvDatos = new DataGridView();
            sqlCommand1 = new SqlCommand();
            BtnBackup = new Button();
            labelTitulo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnEliminar = new Button();
            BtnRestaurar = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            saveFileBackup = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToResizeColumns = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CausesValidation = false;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Right;
            dgvDatos.GridColor = Color.Black;
            dgvDatos.Location = new Point(655, 0);
            dgvDatos.Margin = new Padding(4, 3, 4, 3);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(565, 674);
            dgvDatos.TabIndex = 24;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // BtnBackup
            // 
            BtnBackup.BackColor = SystemColors.HotTrack;
            BtnBackup.FlatStyle = FlatStyle.Popup;
            BtnBackup.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBackup.ForeColor = Color.White;
            BtnBackup.Location = new Point(84, 3);
            BtnBackup.Name = "BtnBackup";
            BtnBackup.Size = new Size(75, 32);
            BtnBackup.TabIndex = 28;
            BtnBackup.Text = "Backup";
            BtnBackup.UseVisualStyleBackColor = false;
            BtnBackup.Click += BtnBackup_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(12, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(314, 45);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "Copia de Seguridad";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(BtnEliminar);
            flowLayoutPanel1.Controls.Add(BtnBackup);
            flowLayoutPanel1.Controls.Add(BtnRestaurar);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 634);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(655, 40);
            flowLayoutPanel1.TabIndex = 29;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = SystemColors.HotTrack;
            BtnEliminar.FlatStyle = FlatStyle.Popup;
            BtnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(3, 3);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 32);
            BtnEliminar.TabIndex = 29;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.BackColor = SystemColors.HotTrack;
            BtnRestaurar.FlatStyle = FlatStyle.Popup;
            BtnRestaurar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRestaurar.ForeColor = Color.White;
            BtnRestaurar.Location = new Point(165, 3);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(75, 32);
            BtnRestaurar.TabIndex = 30;
            BtnRestaurar.Text = "Restaurar";
            BtnRestaurar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 74);
            panel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.FromArgb(19, 21, 23);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CausesValidation = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(0, 74);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.WindowText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(655, 560);
            dataGridView1.TabIndex = 31;
            // 
            // FormBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(1220, 674);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgvDatos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBackup";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDatos;
        private SqlCommand sqlCommand1;
        private Button BtnBackup;
        private Label labelTitulo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnEliminar;
        private Button BtnRestaurar;
        private Panel panel1;
        private DataGridView dataGridView1;
        private SaveFileDialog saveFileBackup;
    }
}