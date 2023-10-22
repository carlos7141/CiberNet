using CapaHerramientas;
namespace CapaPresentacion
{
    partial class UpdateReserva
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
            panelBarra = new Panel();
            btnClose = new PictureBox();
            labelRegistrar = new Label();
            panelBtn = new Panel();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtPago = new BoxText();
            label5 = new Label();
            txtHoraFin = new DateTimePicker();
            label3 = new Label();
            txtMaquina = new ComboBox();
            label2 = new Label();
            txtHoraInicio = new DateTimePicker();
            label1 = new Label();
            txtFecha = new DateTimePicker();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtCorreo = new BoxText();
            label6 = new Label();
            txtUsuario = new BoxText();
            dgvUsuario = new DataGridView();
            txtFiltro = new ComboBox();
            label4 = new Label();
            txtBuscar = new BoxText();
            panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelBtn.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(35, 38, 44);
            panelBarra.Controls.Add(btnClose);
            panelBarra.Controls.Add(labelRegistrar);
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(0, 0);
            panelBarra.Name = "panelBarra";
            panelBarra.Size = new Size(500, 51);
            panelBarra.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(463, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelRegistrar
            // 
            labelRegistrar.AutoSize = true;
            labelRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistrar.ForeColor = Color.White;
            labelRegistrar.Location = new Point(12, 15);
            labelRegistrar.Name = "labelRegistrar";
            labelRegistrar.Size = new Size(107, 20);
            labelRegistrar.TabIndex = 0;
            labelRegistrar.Text = "Editar Reserva";
            // 
            // panelBtn
            // 
            panelBtn.BackColor = Color.FromArgb(35, 38, 44);
            panelBtn.Controls.Add(btnRegistrar);
            panelBtn.Controls.Add(btnCancelar);
            panelBtn.Dock = DockStyle.Bottom;
            panelBtn.Location = new Point(0, 449);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(500, 51);
            panelBtn.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(343, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 27);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Actualizar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DimGray;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(12, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 27);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtPago);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtHoraFin);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtMaquina);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtHoraInicio);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtFecha);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 170);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = " Datos de Reserva";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(65, 131);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 26;
            label8.Text = "Pago Previo:";
            // 
            // txtPago
            // 
            txtPago.BackColor = Color.FromArgb(19, 21, 23);
            txtPago.BorderColor = SystemColors.HotTrack;
            txtPago.BorderFocusColor = Color.HotPink;
            txtPago.BorderSize = 2;
            txtPago.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPago.ForeColor = Color.White;
            txtPago.Location = new Point(144, 122);
            txtPago.MaxLength = 10;
            txtPago.Multiline = false;
            txtPago.Name = "txtPago";
            txtPago.Padding = new Padding(7);
            txtPago.PasswordChar = false;
            txtPago.PlaceholderText = "Ingresar la cantidad del pago";
            txtPago.Size = new Size(205, 31);
            txtPago.TabIndex = 25;
            txtPago.Texts = "";
            txtPago.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(240, 63);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 15;
            label5.Text = "a";
            // 
            // txtHoraFin
            // 
            txtHoraFin.CustomFormat = "HH:mm";
            txtHoraFin.Format = DateTimePickerFormat.Custom;
            txtHoraFin.Location = new Point(259, 57);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.ShowUpDown = true;
            txtHoraFin.Size = new Size(90, 23);
            txtHoraFin.TabIndex = 14;
            txtHoraFin.Value = new DateTime(2023, 10, 14, 12, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(28, 96);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 13;
            label3.Text = "Máquina a reservar:";
            // 
            // txtMaquina
            // 
            txtMaquina.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMaquina.FormattingEnabled = true;
            txtMaquina.Location = new Point(144, 93);
            txtMaquina.Name = "txtMaquina";
            txtMaquina.Size = new Size(90, 23);
            txtMaquina.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(100, 63);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Hora:";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(144, 57);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(90, 23);
            txtHoraInicio.TabIndex = 10;
            txtHoraInicio.Value = new DateTime(2023, 10, 14, 12, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 9;
            label1.Text = "Día de la reservación:";
            // 
            // txtFecha
            // 
            txtFecha.Format = DateTimePickerFormat.Short;
            txtFecha.Location = new Point(144, 22);
            txtFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(88, 23);
            txtFecha.TabIndex = 0;
            txtFecha.Value = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(dgvUsuario);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 197);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(12, 162);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 31;
            label7.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(19, 21, 23);
            txtCorreo.BorderColor = SystemColors.HotTrack;
            txtCorreo.BorderFocusColor = Color.HotPink;
            txtCorreo.BorderSize = 2;
            txtCorreo.Enabled = false;
            txtCorreo.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(60, 153);
            txtCorreo.MaxLength = 10;
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(7);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Size = new Size(276, 31);
            txtCorreo.TabIndex = 30;
            txtCorreo.Texts = "";
            txtCorreo.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(8, 114);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 29;
            label6.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(19, 21, 23);
            txtUsuario.BorderColor = SystemColors.HotTrack;
            txtUsuario.BorderFocusColor = Color.HotPink;
            txtUsuario.BorderSize = 2;
            txtUsuario.Enabled = false;
            txtUsuario.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(60, 106);
            txtUsuario.MaxLength = 10;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(7);
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderText = "";
            txtUsuario.Size = new Size(276, 31);
            txtUsuario.TabIndex = 28;
            txtUsuario.Texts = "";
            txtUsuario.UnderlinedStyle = true;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AllowUserToResizeColumns = false;
            dgvUsuario.AllowUserToResizeRows = false;
            dgvUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvUsuario.BackgroundColor = Color.White;
            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.CausesValidation = false;
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.ColumnHeadersVisible = false;
            dgvUsuario.GridColor = Color.Black;
            dgvUsuario.Location = new Point(7, 61);
            dgvUsuario.Margin = new Padding(4, 3, 4, 3);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(461, 39);
            dgvUsuario.TabIndex = 27;
            dgvUsuario.CellClick += dgvUsuario_CellClick;
            // 
            // txtFiltro
            // 
            txtFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFiltro.FormattingEnabled = true;
            txtFiltro.Items.AddRange(new object[] { "Correo", "Usuario" });
            txtFiltro.Location = new Point(260, 29);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(209, 23);
            txtFiltro.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(8, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 24;
            label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(19, 21, 23);
            txtBuscar.BorderColor = SystemColors.HotTrack;
            txtBuscar.BorderFocusColor = Color.HotPink;
            txtBuscar.BorderSize = 2;
            txtBuscar.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(60, 24);
            txtBuscar.MaxLength = 10;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(7);
            txtBuscar.PasswordChar = false;
            txtBuscar.PlaceholderText = "Ingresar Correo o Usuario";
            txtBuscar.Size = new Size(193, 31);
            txtBuscar.TabIndex = 7;
            txtBuscar.Texts = "";
            txtBuscar.UnderlinedStyle = true;
            // 
            // UpdateReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(500, 500);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelBtn);
            Controls.Add(panelBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateUser";
            Load += UpdateReserva_Load;
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelBtn.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarra;
        private PictureBox btnClose;
        private Label labelRegistrar;
        private Panel panelBtn;
        private Button btnRegistrar;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private Label label8;
        private BoxText txtPago;
        private Label label5;
        private DateTimePicker txtHoraFin;
        private Label label3;
        private ComboBox txtMaquina;
        private Label label2;
        private DateTimePicker txtHoraInicio;
        private Label label1;
        private DateTimePicker txtFecha;
        private GroupBox groupBox1;
        private Label label7;
        private BoxText txtCorreo;
        private Label label6;
        private BoxText txtUsuario;
        private DataGridView dgvUsuario;
        private ComboBox txtFiltro;
        private Label label4;
        private BoxText txtBuscar;
    }
}