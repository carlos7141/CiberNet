namespace CapaClases
{
    public class ClassChilde
    {
        private Form? formActual = null;
        public void abrir(Form formulario, Panel panelContenedor)
        {
            formActual?.Close();
            formActual = formulario;
            formulario.TopLevel = false;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }
        public void AbrirFormulario<MiForm>(Panel panel) where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panel.Controls.Add(formulario);
                panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        public void FormResize()
        {
            if (formActual != null)
            {
                formActual.WindowState = FormWindowState.Normal;
                formActual.WindowState = FormWindowState.Maximized;
            }
        }
    }
}