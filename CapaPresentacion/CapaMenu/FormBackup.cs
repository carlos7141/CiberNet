namespace CapaPresentacion
{
    public partial class FormBackup : Form
    {
        readonly Class_SQL_Backup execute = new();
        public FormBackup()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            saveFileBackup.Filter = "Archivos Backup SQL Server (*.bak)|*.bak";
            saveFileBackup.Title = "Copia de seguridad 1";

            if (saveFileBackup.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileBackup.FileName;

                // Verificar si el nombre del archivo tiene la extensión .bak
                if (!filePath.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                {
                    // Agregar la extensión .bak si no está presente
                    filePath += ".bak";
                }
                // Llamar al PROC de copia de seguridad de SQL Server
                execute.CrearBackup(filePath);

                MsgBox.Show("Copia de seguridad creada con éxito.");
            }
        }
    }
}
