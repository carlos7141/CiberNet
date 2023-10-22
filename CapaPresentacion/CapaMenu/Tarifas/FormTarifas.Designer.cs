namespace CapaPresentacion
{
    partial class FormTarifas
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
            labelTitulo = new Label();
            dgvTarifas = new DataGridView();
            labelParrafo = new Label();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTarifas).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(30, 39);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(118, 45);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Tarifas";
            // 
            // dgvTarifas
            // 
            dgvTarifas.AllowUserToAddRows = false;
            dgvTarifas.AllowUserToDeleteRows = false;
            dgvTarifas.AllowUserToResizeColumns = false;
            dgvTarifas.AllowUserToResizeRows = false;
            dgvTarifas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTarifas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTarifas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvTarifas.BackgroundColor = Color.White;
            dgvTarifas.BorderStyle = BorderStyle.None;
            dgvTarifas.CausesValidation = false;
            dgvTarifas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTarifas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTarifas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarifas.GridColor = Color.Black;
            dgvTarifas.Location = new Point(586, 62);
            dgvTarifas.Margin = new Padding(4, 3, 4, 3);
            dgvTarifas.Name = "dgvTarifas";
            dgvTarifas.ReadOnly = true;
            dgvTarifas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTarifas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dgvTarifas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvTarifas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarifas.Size = new Size(588, 550);
            dgvTarifas.TabIndex = 28;
            dgvTarifas.CellClick += dgvTarifas_CellClick;
            dgvTarifas.CellPainting += dgvTarifas_CellPainting;
            // 
            // labelParrafo
            // 
            labelParrafo.AutoSize = true;
            labelParrafo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelParrafo.ForeColor = Color.White;
            labelParrafo.Location = new Point(47, 145);
            labelParrafo.Name = "labelParrafo";
            labelParrafo.Size = new Size(0, 17);
            labelParrafo.TabIndex = 27;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.HotTrack;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(47, 295);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 32);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormTarifas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(1220, 674);
            Controls.Add(dgvTarifas);
            Controls.Add(labelParrafo);
            Controls.Add(btnAgregar);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTarifas";
            Text = "FormTarifas";
            Load += FormTarifas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTarifas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private DataGridView dgvTarifas;
        private Label labelParrafo;
        private Button btnAgregar;
    }
}