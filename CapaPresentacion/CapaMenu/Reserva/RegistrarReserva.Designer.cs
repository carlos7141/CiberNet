using CapaHerramientas;
namespace CapaPresentacion
{
    partial class RegistrarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarReserva));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelBarra = new Panel();
            btnClose = new PictureBox();
            labelRegistrar = new Label();
            txtBuscar = new BoxText();
            panelBtn = new Panel();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtCorreo = new BoxText();
            label6 = new Label();
            txtUsuario = new BoxText();
            dgvUsuario = new DataGridView();
            txtFiltro = new ComboBox();
            label4 = new Label();
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
            panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelBtn.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(35, 38, 44);
            panelBarra.Controls.Add(btnClose);
            panelBarra.Controls.Add(labelRegistrar);
            resources.ApplyResources(panelBarra, "panelBarra");
            panelBarra.Name = "panelBarra";
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.x;
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Name = "btnClose";
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelRegistrar
            // 
            resources.ApplyResources(labelRegistrar, "labelRegistrar");
            labelRegistrar.ForeColor = Color.White;
            labelRegistrar.Name = "labelRegistrar";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(19, 21, 23);
            txtBuscar.BorderColor = SystemColors.HotTrack;
            txtBuscar.BorderFocusColor = Color.HotPink;
            txtBuscar.BorderSize = 2;
            resources.ApplyResources(txtBuscar, "txtBuscar");
            txtBuscar.ForeColor = Color.White;
            txtBuscar.MaxLength = 10;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PasswordChar = false;
            txtBuscar.PlaceholderText = "Ingresar Correo o Usuario";
            txtBuscar.Texts = "";
            txtBuscar.UnderlinedStyle = true;
            // 
            // panelBtn
            // 
            panelBtn.BackColor = Color.FromArgb(35, 38, 44);
            panelBtn.Controls.Add(btnRegistrar);
            panelBtn.Controls.Add(btnCancelar);
            resources.ApplyResources(panelBtn, "panelBtn");
            panelBtn.Name = "panelBtn";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            resources.ApplyResources(btnRegistrar, "btnRegistrar");
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DimGray;
            resources.ApplyResources(btnCancelar, "btnCancelar");
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = Color.White;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.White;
            label7.Name = "label7";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(19, 21, 23);
            txtCorreo.BorderColor = SystemColors.HotTrack;
            txtCorreo.BorderFocusColor = Color.HotPink;
            txtCorreo.BorderSize = 2;
            resources.ApplyResources(txtCorreo, "txtCorreo");
            txtCorreo.ForeColor = Color.White;
            txtCorreo.MaxLength = 10;
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Texts = "";
            txtCorreo.UnderlinedStyle = true;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(19, 21, 23);
            txtUsuario.BorderColor = SystemColors.HotTrack;
            txtUsuario.BorderFocusColor = Color.HotPink;
            txtUsuario.BorderSize = 2;
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.ForeColor = Color.White;
            txtUsuario.MaxLength = 10;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderText = "";
            txtUsuario.Texts = "";
            txtUsuario.UnderlinedStyle = true;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AllowUserToResizeColumns = false;
            dgvUsuario.AllowUserToResizeRows = false;
            resources.ApplyResources(dgvUsuario, "dgvUsuario");
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
            dgvUsuario.CellClick += dgvUsuario_CellClick;
            // 
            // txtFiltro
            // 
            txtFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFiltro.FormattingEnabled = true;
            txtFiltro.Items.AddRange(new object[] { resources.GetString("txtFiltro.Items"), resources.GetString("txtFiltro.Items1") });
            resources.ApplyResources(txtFiltro, "txtFiltro");
            txtFiltro.Name = "txtFiltro";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.White;
            label4.Name = "label4";
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
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.ForeColor = Color.White;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.White;
            label8.Name = "label8";
            // 
            // txtPago
            // 
            txtPago.BackColor = Color.FromArgb(19, 21, 23);
            txtPago.BorderColor = SystemColors.HotTrack;
            txtPago.BorderFocusColor = Color.HotPink;
            txtPago.BorderSize = 2;
            resources.ApplyResources(txtPago, "txtPago");
            txtPago.ForeColor = Color.White;
            txtPago.MaxLength = 10;
            txtPago.Multiline = false;
            txtPago.Name = "txtPago";
            txtPago.PasswordChar = false;
            txtPago.PlaceholderText = "Ingresar la cantidad del pago";
            txtPago.Texts = "";
            txtPago.UnderlinedStyle = true;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.White;
            label5.Name = "label5";
            // 
            // txtHoraFin
            // 
            resources.ApplyResources(txtHoraFin, "txtHoraFin");
            txtHoraFin.Format = DateTimePickerFormat.Custom;
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.ShowUpDown = true;
            txtHoraFin.Value = new DateTime(2023, 10, 14, 12, 0, 0, 0);
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // txtMaquina
            // 
            txtMaquina.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMaquina.FormattingEnabled = true;
            resources.ApplyResources(txtMaquina, "txtMaquina");
            txtMaquina.Name = "txtMaquina";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // txtHoraInicio
            // 
            resources.ApplyResources(txtHoraInicio, "txtHoraInicio");
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Value = new DateTime(2023, 10, 14, 12, 0, 0, 0);
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // txtFecha
            // 
            txtFecha.Format = DateTimePickerFormat.Short;
            resources.ApplyResources(txtFecha, "txtFecha");
            txtFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            txtFecha.Name = "txtFecha";
            txtFecha.Value = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // RegistrarReserva
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelBtn);
            Controls.Add(panelBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarReserva";
            Load += RegistrarReserva_Load;
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelBtn.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarra;
        private PictureBox btnClose;
        private Label labelRegistrar;
        private BoxText txtBuscar;
        private Panel panelBtn;
        private Button btnRegistrar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private DateTimePicker txtFecha;
        private Label label2;
        private DateTimePicker txtHoraInicio;
        private Label label3;
        private ComboBox txtMaquina;
        private ComboBox txtFiltro;
        private Label label4;
        private DataGridView dgvUsuario;
        private Label label5;
        private DateTimePicker txtHoraFin;
        private Label label7;
        private BoxText txtCorreo;
        private Label label6;
        private BoxText txtUsuario;
        private Label label8;
        private BoxText txtPago;
    }
}