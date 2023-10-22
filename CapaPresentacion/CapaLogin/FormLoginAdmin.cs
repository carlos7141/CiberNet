using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLoginAdmin : Form
    {
        SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public PanelLogin login;
        ClassChilde newform = new();
        public FormLoginAdmin(PanelLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarAdmin form = new(login);
            newform.abrir(form, login.panelCentralLogin);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new("verify_loginAdmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Texts);
            cmd.Parameters.AddWithValue("@Contraseña", txtPassword.Texts);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FormLoading form = new(login);
                newform.abrir(form, login.panelCentralLogin);
                form.barraProgreso1.Value = 0;
                form.timerBarra.Start();
            }
            else
            {
                MsgBox.Show("Datos incorrectos, intente nuevamente", "Sistema", MessageBoxButtons.OK);
            }
            cn.Close();
        }

        private void txtUsuario_EnterKeyPressed(object sender, EventArgs e)
        {
            btnIngresar.PerformClick();
        }

        private void txtPassword_EnterKeyPressed(object sender, EventArgs e)
        {
            btnIngresar.PerformClick();
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {
            btnRegistrar.Select();
        }
    }
}
