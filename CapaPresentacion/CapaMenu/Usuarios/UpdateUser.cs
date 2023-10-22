using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
namespace CapaPresentacion
{
    public partial class UpdateUser : Form
    {
        DataGridView datausers;
        string Nombre, Usuario, Correo, Fnac;
        public UpdateUser(DataGridView data, string n, string u, string c, string fn)
        {
            InitializeComponent();
            datausers = data;
            Nombre = n;
            Usuario = u;
            Correo = c;
            Fnac = fn;
            var parse = DateTime.Parse(Fnac);
            txtNombre.Texts = Nombre;
            txtUsuario.Texts = Usuario;
            txtCorreo.Texts = Correo;
            txtFNac.Value = parse;
            txtCorreo.Enabled = false;
        }

        readonly Class_SQL_Usuario execute = new();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                SMG();
            }
        }

        private void SMG()
        {
            string correoRemitente = "narutovi789456@gmail.com";
            string contraseñaRemitente = "gmwihtxrpeffmxbj";
            // Dirección de correo electrónico del destinatario
            string correoDestinatario = txtCorreo.Texts;

            // Configuración del cliente SMTP para Gmail
            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(correoRemitente, contraseñaRemitente),
                EnableSsl = true
            };

            // Crear el mensaje de correo
            var mensaje = new MailMessage(correoRemitente, correoDestinatario, "Modificacion de Datos", $"Los datos de cuenta fueron Modificados");

            try
            {
                smtpClient.Send(mensaje);
                MsgBox.Show("Los datos fueron actualizados correctamente.");
                execute.UpdateUsuario(txtNombre.Texts, txtUsuario.Texts, txtCorreo.Texts, txtFNac.Text);
                execute.llenarTablasUser(datausers);
                Close();
            }
            catch
            {
                MsgBox.Show($"Error al intentar actualizar los datos, intente nuevamente", "Error", MessageBoxButtons.OK);
            }
        }
        private bool Verify()
        {
            bool ok = false;

            if (string.IsNullOrEmpty(txtNombre.Texts))
            {
                MsgBox.Show("Ingrese un Nombre");
            }
            else if (string.IsNullOrEmpty(txtUsuario.Texts))
            {
                MsgBox.Show("Ingrese un Usuario");
            }
            else if (string.IsNullOrEmpty(txtCorreo.Texts))
            {
                MsgBox.Show("Ingrese un Correo");
            }
            else if (!ValidarFechaNacimiento())
            {
                // La validación de la fecha de nacimiento falló, no es necesario mostrar un mensaje aquí
            }
            else
            {
                ok = true;
            }

            return ok;
        }

        private bool ValidarFechaNacimiento()
        {
            DateTime fechaNacimiento = txtFNac.Value;
            DateTime fechaActual = DateTime.Today;

            if (fechaNacimiento > fechaActual)
            {
                MsgBox.Show("La fecha de nacimiento no puede ser una fecha futura.");
                return false;
            }

            return true;
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
