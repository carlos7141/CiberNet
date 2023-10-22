namespace CapaPresentacion
{
    public partial class UpdatePC : Form
    {
        readonly string idPC, Nombre, ipAddress, idTarifa;
        DataGridView dataMaquinas;
        readonly Class_SQL_Pc execute = new();
        readonly FormInicio form = new();
        public UpdatePC(DataGridView dataM, string idPC, string Nombre, string ipAddress, string idTarifa)
        {
            InitializeComponent();
            txtCategoria.SelectedIndex = 0;
            dataMaquinas = dataM;
            this.idPC = idPC;
            this.Nombre = Nombre;
            this.ipAddress = ipAddress;
            this.idTarifa = idTarifa;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                if (txtCategoria.SelectedItem is DataTarifa selectedTarifa)
                {
                    string idTarifaSeleccionada = selectedTarifa.idTarifa.ToString();
                    execute.Update(idPC, txtNombre.Texts, txtIpAddress.Texts, idTarifaSeleccionada);
                }
                MsgBox.Show("Se actualizo los datos correctamente");
                execute.LlenarTablaPC(dataMaquinas);
                form.CrearPC();
                Close();
            }
        }

        private bool Verify()
        {
            bool ok = false;
            if (string.IsNullOrEmpty(txtNombre.Texts))
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else if (string.IsNullOrEmpty(txtIpAddress.Texts))
            {
                MessageBox.Show("Ingrese una Ip válida");
            }
            else
            {
                ok = true;
            }
            return ok;
        }

        private void UpdatePC_Load(object sender, EventArgs e)
        {
            labelRegistrar.Focus();
            txtNombre.Texts = Nombre;
            txtIpAddress.Texts = ipAddress;
            txtNombre.ForeColor = Color.White;
            txtIpAddress.ForeColor = Color.White;
            txtCategoria.DataSource = new Class_SQL_Tarifa().ComboBox();
            txtCategoria.ValueMember = "idTarifa";
            txtCategoria.DisplayMember = "Nombre";
            txtCategoria.SelectedItem = execute.BuscarMaquinaTarifa(idTarifa);
        }
    }
}
