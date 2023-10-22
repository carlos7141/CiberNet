namespace CapaPresentacion
{
    partial class FormUsuarios
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
            txtFiltro = new ComboBox();
            dataGridViewUsuarios = new DataGridView();
            btnAñadirUsuario = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFiltro.FormattingEnabled = true;
            txtFiltro.Items.AddRange(new object[] { "Nombre", "Usuario" });
            txtFiltro.Location = new Point(309, 178);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(148, 23);
            txtFiltro.TabIndex = 23;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AllowUserToResizeColumns = false;
            dataGridViewUsuarios.AllowUserToResizeRows = false;
            dataGridViewUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewUsuarios.BackgroundColor = Color.White;
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.CausesValidation = false;
            dataGridViewUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.GridColor = Color.Black;
            dataGridViewUsuarios.Location = new Point(51, 220);
            dataGridViewUsuarios.Margin = new Padding(4, 3, 4, 3);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(1100, 439);
            dataGridViewUsuarios.TabIndex = 24;
            dataGridViewUsuarios.CellClick += dataGridViewUsuarios_CellClick;
            dataGridViewUsuarios.CellPainting += dataGridViewUsuarios_CellPainting;
            // 
            // btnAñadirUsuario
            // 
            btnAñadirUsuario.Anchor = AnchorStyles.Top;
            btnAñadirUsuario.FlatAppearance.BorderColor = Color.White;
            btnAñadirUsuario.FlatAppearance.BorderSize = 2;
            btnAñadirUsuario.FlatStyle = FlatStyle.Flat;
            btnAñadirUsuario.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAñadirUsuario.ForeColor = Color.White;
            btnAñadirUsuario.Location = new Point(552, 116);
            btnAñadirUsuario.Margin = new Padding(4, 3, 4, 3);
            btnAñadirUsuario.Name = "btnAñadirUsuario";
            btnAñadirUsuario.Size = new Size(88, 37);
            btnAñadirUsuario.TabIndex = 21;
            btnAñadirUsuario.Text = "Añadir";
            btnAñadirUsuario.UseVisualStyleBackColor = true;
            btnAñadirUsuario.Click += btnAñadirUsuario_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(127, 179);
            txtBuscar.Margin = new Padding(4, 3, 4, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(148, 23);
            txtBuscar.TabIndex = 22;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 16;
            label2.Text = "Buscar:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(551, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 17;
            label1.Text = "Usuarios";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 38, 44);
            ClientSize = new Size(1220, 674);
            Controls.Add(txtFiltro);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(btnAñadirUsuario);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsuarios";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtFiltro;
        private DataGridView dataGridViewUsuarios;
        private Button btnAñadirUsuario;
        private TextBox txtBuscar;
        private Label label2;
        private Label label1;
    }
}