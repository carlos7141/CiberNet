namespace CapaPresentacion
{
    public partial class RegistrarTarifa : Form
    {
        readonly Class_SQL_Tarifa execute = new();
        readonly DataGridView dgvTarifa;
        public RegistrarTarifa(DataGridView data)
        {
            InitializeComponent();
            dgvTarifa = data;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                execute.Add(txtNombre.Texts, txtPrecio.Texts);
                MsgBox.Show($"Se registro correctamente la tarifa {txtNombre.Texts}.");
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
    }
}
