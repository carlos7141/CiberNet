namespace CapaPresentacion
{
    public partial class UpdateReserva : Form
    {
        readonly Class_SQL_Reserva execute = new();
        DataGridView dgvReservas;
        string idReserva;
        string idUser;
        string idPC;
        public UpdateReserva(DataGridView data, string idReserva, string idUser, string Usuario, string Correo, string Fecha, string HoraInicio, string HoraFin, string Pago, string idPC)
        {
            InitializeComponent();
            dgvReservas = data;
            this.idReserva = idReserva;
            this.idUser = idUser;
            txtUsuario.Texts = Usuario;
            txtCorreo.Texts = Correo;
            txtFecha.Value = DateTime.Parse(Fecha);
            txtHoraInicio.Value = DateTime.Parse(HoraInicio);
            txtHoraFin.Value = DateTime.Parse(HoraFin);
            txtPago.Texts = Pago;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtFecha.MinDate = DateTime.Now;
            this.idPC = idPC;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                if (txtMaquina.SelectedItem is DataMaquina selectedMaquina)
                {
                    string idMaquinaSeleccionada = selectedMaquina.idPC.ToString();
                    execute.Update(idReserva, txtFecha.Text, txtHoraInicio.Text, txtHoraFin.Text, txtPago.Texts, idUser, idMaquinaSeleccionada);
                }
                MsgBox.Show("Los datos fueron actualizados correctamente.");
                dgvReservas.DataSource = execute.LlenarReservaDGV();
                dgvReservas.Columns["idReserva"].Visible = false;
                dgvReservas.Columns["idUser"].Visible = false;
                dgvReservas.Columns["idPC"].Visible = false;
                Close();
            }
        }
        private bool Verify()
        {
            bool ok = false;

            if (string.IsNullOrEmpty(idUser))
            {
                MsgBox.Show("Por favor selecciona a un usuario de la lista.");
            }
            else if (string.IsNullOrEmpty(txtUsuario.Texts))
            {
                MsgBox.Show("Por favor selecciona a un usuario de la lista.");
            }
            else if (string.IsNullOrEmpty(txtCorreo.Texts))
            {
                MsgBox.Show("Por favor selecciona a un usuario de la lista.");
            }
            {
                ok = true;
            }
            return ok;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateReserva_Load(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = execute.LlenarUsuariosDGV();
            dgvUsuario.Columns["idUser"].Visible = false;

            txtMaquina.DataSource = new Class_SQL_Reserva().ComboBox();
            txtMaquina.ValueMember = "idPC";
            txtMaquina.DisplayMember = "Nombre";
            txtMaquina.SelectedValue = int.Parse(idPC);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            execute.BuscarUsuario(txtBuscar.Texts, txtFiltro.Text, dgvUsuario);
        }
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUser = dgvUsuario.CurrentRow.Cells["idUser"].Value.ToString();
            txtUsuario.Texts = dgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
            txtCorreo.Texts = dgvUsuario.CurrentRow.Cells["Correo"].Value.ToString();
        }
    }
}
