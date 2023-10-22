namespace CapaPresentacion
{
    public partial class FormLoading : Form
    {
        public PanelLogin login;
        public FormLoading(PanelLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void timerBarra_Tick(object sender, EventArgs e)
        {
            if (barraProgreso1.Value < barraProgreso1.Maximum)
                barraProgreso1.Value++;
            else
            {
                timerBarra.Stop();
                login.cambiarTamaño();
            }
        }
    }
}
