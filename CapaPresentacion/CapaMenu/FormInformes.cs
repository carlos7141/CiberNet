namespace CapaPresentacion
{
    public partial class FormInformes : Form
    {
        readonly ClassInformePDF execute = new();
        readonly Class_SQL_Reporte exe = new();
        public FormInformes()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            execute.InformePDF(saveFileInformes, dgvInformes);
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            exe.LlenarDGV(dgvInformes);
        }
    }
}
