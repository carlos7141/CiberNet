namespace CapaPresentacion
{
    partial class FormMaquinas
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
            btnAgregar = new Button();
            labelParrafo = new Label();
            dataMaquinas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataMaquinas).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(33, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(166, 45);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Máquinas";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.HotTrack;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(33, 290);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 32);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // labelParrafo
            // 
            labelParrafo.AutoSize = true;
            labelParrafo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelParrafo.ForeColor = Color.White;
            labelParrafo.Location = new Point(33, 140);
            labelParrafo.Name = "labelParrafo";
            labelParrafo.Size = new Size(0, 17);
            labelParrafo.TabIndex = 3;
            // 
            // dataMaquinas
            // 
            dataMaquinas.AllowUserToAddRows = false;
            dataMaquinas.AllowUserToDeleteRows = false;
            dataMaquinas.AllowUserToResizeColumns = false;
            dataMaquinas.AllowUserToResizeRows = false;
            dataMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataMaquinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMaquinas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataMaquinas.BackgroundColor = Color.White;
            dataMaquinas.BorderStyle = BorderStyle.None;
            dataMaquinas.CausesValidation = false;
            dataMaquinas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataMaquinas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataMaquinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataMaquinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMaquinas.GridColor = Color.Black;
            dataMaquinas.Location = new Point(572, 57);
            dataMaquinas.Margin = new Padding(4, 3, 4, 3);
            dataMaquinas.Name = "dataMaquinas";
            dataMaquinas.ReadOnly = true;
            dataMaquinas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataMaquinas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataMaquinas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataMaquinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMaquinas.Size = new Size(588, 550);
            dataMaquinas.TabIndex = 25;
            dataMaquinas.CellClick += dataMaquinas_CellClick;
            dataMaquinas.CellPainting += dataMaquinas_CellPainting;
            // 
            // FormMaquinas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(1220, 674);
            Controls.Add(dataMaquinas);
            Controls.Add(labelParrafo);
            Controls.Add(btnAgregar);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMaquinas";
            Text = "FormMaquinas";
            Load += FormMaquinas_Load;
            ((System.ComponentModel.ISupportInitialize)dataMaquinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button btnAgregar;
        private Label labelParrafo;
        private DataGridView dataMaquinas;
    }
}