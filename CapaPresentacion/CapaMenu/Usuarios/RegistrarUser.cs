using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
namespace CapaPresentacion
{
    public partial class RegistrarUser : Form
    {
        DataGridView datausers;
        public RegistrarUser(DataGridView data)
        {
            InitializeComponent();
            datausers = data;
        }
        readonly Class_SQL_Usuario execute = new();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                SMG();
            }
        }
        private string GenerarCodigoAcceso()
        {
            // Crear una instancia de la clase Random
            Random random = new Random();

            // Generar un número aleatorio entre 1000 y 9999
            int codigoAleatorio = random.Next(1000, 100000);

            // Convertir el número aleatorio en una cadena de texto
            string codigoAcceso = codigoAleatorio.ToString();

            return codigoAcceso;
        }

        private void SMG()
        {
            string correoRemitente = "narutovi789456@gmail.com";
            string contraseñaRemitente = "gmwihtxrpeffmxbj";
            string codigoAcceso = GenerarCodigoAcceso();
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
            var mensaje = new MailMessage(correoRemitente, correoDestinatario, "Codigo de Acceso CIBERNET", $"Tu codigo es: {codigoAcceso}");

            try
            {
                if (execute.UserRepeat("Correo", txtCorreo.Texts))
                {
                    MsgBox.Show("Este correo ya esta registrado.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    //smtpClient.Send(mensaje);
                    execute.insertarUser(txtNombre.Texts, txtUsuario.Texts, txtCorreo.Texts, txtFNac.Text);
                    MsgBox.Show("Correo enviado exitosamente, porfavor revisa el correo para completar el registro.");
                    execute.UpdateUsuarioPassword(codigoAcceso, txtCorreo.Texts);
                    execute.llenarTablasUser(datausers);
                    Close();
                }

            }
            catch (Exception ex)
            {
                MsgBox.Show($"Error al enviar el correo: {ex.Message}, intente nuevamente");
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
            else if (!EsCorreoValido(txtCorreo.Texts))
            {
                MsgBox.Show("Ingrese un Correo electrónico válido de Gmail");
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
        private static bool EsCorreoValido(string correo)
        {
            // Expresión regular para validar el formato de un correo electrónico de Gmail
            string patron = @"^[a-zA-Z0-9._%+-]+@gmail.com$";
            return Regex.IsMatch(correo, patron);
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
