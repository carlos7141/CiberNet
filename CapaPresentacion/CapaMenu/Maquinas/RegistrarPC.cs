namespace CapaPresentacion
{
    public partial class RegistrarPC : Form
    {
        Class_SQL_Pc exe = new();
        public RegistrarPC()
        {
            InitializeComponent();
            txtCategoria.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistrarPC_Load(object sender, EventArgs e)
        {
            labelRegistrar.Focus();
            txtCategoria.DataSource = new Class_SQL_Tarifa().ComboBox();
            txtCategoria.ValueMember = "idTarifa";
            txtCategoria.DisplayMember = "Nombre";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                if (txtCategoria.SelectedItem is DataTarifa selectedTarifa)
                {
                    string idTarifaSeleccionada = selectedTarifa.idTarifa.ToString();
                    exe.InsertarPC(txtNombre.Texts, txtIpAddress.Texts, idTarifaSeleccionada);
                    FormExe();
                }
                Close();
            }
        }

        public void FormExe()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FormMaquinas) // Reemplaza "MiFormulario" con el nombre de tu formulario
                {
                    FormMaquinas formulario = (FormMaquinas)openForm;
                    formulario.DgvLoad(); // Llamada al método en la instancia de formulario
                }
                if (openForm is FormInicio)
                {
                    FormInicio formulario = (FormInicio)openForm;
                    formulario.CrearPC();
                }
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
    }
}
