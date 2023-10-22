namespace CapaPresentacion
{
    public partial class FormRegistrarAdmin : Form
    {
        public PanelLogin login;
        ClassChilde newform = new();
        public FormRegistrarAdmin(PanelLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormLoginAdmin form = new(login);
            newform.abrir(form, login.panelCentralLogin);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                Class_SQL_Usuario execute = new();
                execute.insertarAdmin(txtNombre.Text, txtUsuario.Text, txtPassword.Text);
                txtNombre.Clear();
                txtUsuario.Clear();
                txtPassword.Clear();
                txtConfPass.Clear();
                FormLoginAdmin form = new (login);
                newform.abrir(form,login.panelCentralLogin);
            }
        }
        private bool Verify()
        {
            bool ok = false;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un Usuario");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese una Contraseña");
            }
            else if (txtConfPass.Text == "")
            {
                MessageBox.Show("Confirme su Contraseña");
            }
            else if (txtConfPass.Text != txtPassword.Text)
            {
                MessageBox.Show("Las contraseña no coincide");
            }
            else
            {
                ok = true;
            }
            btnGuardar.Enabled = ok;
            return ok;
        }
    }
}
