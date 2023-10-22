namespace CapaPresentacion
{
    public partial class RegistrarReserva : Form
    {
        readonly Class_SQL_Reserva execute = new();
        DataGridView dgvReservas;
        public RegistrarReserva(DataGridView dgvReservas)
        {
            InitializeComponent();
            this.dgvReservas = dgvReservas;
            txtFiltro.SelectedIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtFecha.MinDate = DateTime.Now;
            txtHoraInicio.Value = DateTime.Now;
            txtHoraFin.Value = DateTime.Now;
        }
        string? idUser = string.Empty;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {

                if (txtMaquina.SelectedItem is DataMaquina selectedMaquina)
                {
                    string idMaquinaSeleccionada = selectedMaquina.idPC.ToString();
                    execute.Add(txtFecha.Text, txtHoraInicio.Text, txtHoraFin.Text, txtPago.Texts, idUser, idMaquinaSeleccionada);
                }
                //execute.LlenarDGV(dgvTarifa);
                MsgBox.Show("El Usuario reserva a sido añadido a la lista correctamente.");
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
            else
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
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            execute.BuscarUsuario(txtBuscar.Texts, txtFiltro.Text, dgvUsuario);
        }

        private void RegistrarReserva_Load(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = execute.LlenarUsuariosDGV();
            dgvUsuario.Columns["idUser"].Visible = false;

            txtMaquina.DataSource = new Class_SQL_Reserva().ComboBox();
            txtMaquina.ValueMember = "idPC";
            txtMaquina.DisplayMember = "Nombre";
        }
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUser = dgvUsuario.CurrentRow.Cells["idUser"].Value.ToString();
            txtUsuario.Texts = dgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
            txtCorreo.Texts = dgvUsuario.CurrentRow.Cells["Correo"].Value.ToString();
        }
    }
}
