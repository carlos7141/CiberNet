namespace CapaPresentacion
{
    partial class FormReserva
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
            dgvReservas = new DataGridView();
            labelParrafo = new Label();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(30, 39);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(150, 45);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Reservas";
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.AllowUserToResizeColumns = false;
            dgvReservas.AllowUserToResizeRows = false;
            dgvReservas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvReservas.BackgroundColor = Color.White;
            dgvReservas.BorderStyle = BorderStyle.None;
            dgvReservas.CausesValidation = false;
            dgvReservas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvReservas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.GridColor = Color.Black;
            dgvReservas.Location = new Point(444, 62);
            dgvReservas.Margin = new Padding(4, 3, 4, 3);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReservas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dgvReservas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.Size = new Size(730, 550);
            dgvReservas.TabIndex = 28;
            dgvReservas.CellClick += dgvReservas_CellClick;
            dgvReservas.CellFormatting += dgvReservas_CellFormatting;
            dgvReservas.CellPainting += dgvReservas_CellPainting;
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
            // FormReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(1220, 674);
            Controls.Add(dgvReservas);
            Controls.Add(labelParrafo);
            Controls.Add(btnAgregar);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReserva";
            Text = "FormTarifas";
            Load += FormReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private DataGridView dgvReservas;
        private Label labelParrafo;
        private Button btnAgregar;
    }
}