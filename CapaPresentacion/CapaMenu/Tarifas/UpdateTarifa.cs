namespace CapaPresentacion
{
    public partial class UpdateTarifa : Form
    {
        readonly Class_SQL_Tarifa execute = new();
        DataGridView dgvTarifa;
        string Nombre;
        string id;
        string PrecioxHora;
        public UpdateTarifa(DataGridView data, string idTarifa, string Nombre, string precio)
        {
            InitializeComponent();
            dgvTarifa = data;
            this.Nombre = Nombre;
            PrecioxHora = precio;
            id = idTarifa;
            txtNombre.Texts = Nombre;
            txtPrecio.Texts = precio;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                execute.Update(id, txtNombre.Texts, txtPrecio.Texts);
                MsgBox.Show("Los datos fueron actualizados correctamente.");
                //execute.UpdateUsuario(txtNombre.Texts, txtUsuario.Texts);
                execute.LlenarDGV(dgvTarifa);
                Close();
            }
        }
        private bool Verify()
        {
            bool ok = false;

            if (string.IsNullOrEmpty(txtNombre.Texts))
            {
                MsgBox.Show("Ingrese un Nombre");
            }
            else if (string.IsNullOrEmpty(txtPrecio.Texts))
            {
                MsgBox.Show("Ingrese el precio por hora");
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

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
