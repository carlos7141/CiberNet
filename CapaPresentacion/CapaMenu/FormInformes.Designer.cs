namespace CapaPresentacion
{
    partial class FormInformes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelTitulo = new Label();
            PanelButtons = new FlowLayoutPanel();
            BtnExportar = new Button();
            PanelLabel = new Panel();
            saveFileInformes = new SaveFileDialog();
            dgvInformes = new DataGridView();
            PanelButtons.SuspendLayout();
            PanelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformes).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(12, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(154, 45);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "Informes";
            // 
            // PanelButtons
            // 
            PanelButtons.Controls.Add(BtnExportar);
            PanelButtons.Dock = DockStyle.Bottom;
            PanelButtons.Location = new Point(0, 636);
            PanelButtons.Name = "PanelButtons";
            PanelButtons.Size = new Size(1220, 38);
            PanelButtons.TabIndex = 32;
            // 
            // BtnExportar
            // 
            BtnExportar.BackColor = SystemColors.HotTrack;
            BtnExportar.FlatStyle = FlatStyle.Popup;
            BtnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExportar.ForeColor = Color.White;
            BtnExportar.Location = new Point(3, 3);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(219, 32);
            BtnExportar.TabIndex = 30;
            BtnExportar.Text = "Exportar";
            BtnExportar.UseVisualStyleBackColor = false;
            BtnExportar.Click += BtnExportar_Click;
            // 
            // PanelLabel
            // 
            PanelLabel.Controls.Add(labelTitulo);
            PanelLabel.Dock = DockStyle.Top;
            PanelLabel.Location = new Point(0, 0);
            PanelLabel.Name = "PanelLabel";
            PanelLabel.Size = new Size(1220, 74);
            PanelLabel.TabIndex = 30;
            // 
            // dgvInformes
            // 
            dgvInformes.AllowUserToAddRows = false;
            dgvInformes.AllowUserToDeleteRows = false;
            dgvInformes.AllowUserToResizeColumns = false;
            dgvInformes.AllowUserToResizeRows = false;
            dgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvInformes.BackgroundColor = Color.FromArgb(19, 21, 23);
            dgvInformes.BorderStyle = BorderStyle.None;
            dgvInformes.CausesValidation = false;
            dgvInformes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInformes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInformes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInformes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(19, 21, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(19, 21, 23);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInformes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInformes.Dock = DockStyle.Fill;
            dgvInformes.GridColor = Color.Black;
            dgvInformes.Location = new Point(0, 74);
            dgvInformes.Margin = new Padding(4, 3, 4, 3);
            dgvInformes.Name = "dgvInformes";
            dgvInformes.ReadOnly = true;
            dgvInformes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(19, 21, 23);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInformes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInformes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(19, 21, 23);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvInformes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvInformes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInformes.Size = new Size(1220, 562);
            dgvInformes.TabIndex = 31;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(1220, 674);
            Controls.Add(dgvInformes);
            Controls.Add(PanelLabel);
            Controls.Add(PanelButtons);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInformes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarios";
            Load += FormInformes_Load;
            PanelButtons.ResumeLayout(false);
            PanelLabel.ResumeLayout(false);
            PanelLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelTitulo;
        private FlowLayoutPanel PanelButtons;
        private Button BtnExportar;
        private Panel PanelLabel;
        private SaveFileDialog saveFileInformes;
        private DataGridView dgvInformes;
    }
}