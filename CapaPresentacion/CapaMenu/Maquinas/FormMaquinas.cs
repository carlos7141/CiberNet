using System.CodeDom.Compiler;

namespace CapaPresentacion
{
    public partial class FormMaquinas : Form
    {
        readonly Class_SQL_Pc execute = new();
        readonly ClassEditDelete dgvButton = new();
        public FormMaquinas()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        private void FormRegistrarPC_MaquinaAgregada(object sender, EventArgs e)
        {
            execute.LlenarTablaPC(dataMaquinas);
        }
        private void FormMaquinas_Load(object sender, EventArgs e)
        {
            string parrafoExplicacion = "Para registrar una máquina debera proporcionar la siguiente información." +
                "\n\nNombre: [Nombre de la máquina]" +
                "\nDirección IP: [Dirección IP de la máquina]" +
                "\nCategoría: [Categoría seleccionada]" +
                "\n\nPresione el botón 'Agregar'";
            labelParrafo.Text = parrafoExplicacion;
            DgvLoad();
            dgvButton.columBtnEliminar(dataMaquinas);
        }
        bool FormAbierto;
        public void DgvLoad()
        {
            execute.LlenarTablaPC(dataMaquinas);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is RegistrarPC)
                {
                    FormAbierto = true;
                    form.Focus(); // Enfocar el formulario existente
                    break;
                }
                else
                {
                    FormAbierto = false;
                }
            }

            // Si el formulario UpdateUser no está abierto, abrirlo
            if (!FormAbierto)
            {
                RegistrarPC form = new();
                form.Show();
            }
        }

        private void dataMaquinas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dgvButton.cellPainting(dataMaquinas, e);
        }

        private void dataMaquinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMaquinas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0 && dataMaquinas.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dataMaquinas.SelectedCells[0].RowIndex;

                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? Nombre = dataMaquinas.Rows[filaSeleccionada].Cells["Nombre"].Value?.ToString();
                    string? ip = dataMaquinas.Rows[filaSeleccionada].Cells["ipAddress"].Value?.ToString();

                    if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(ip))
                    {
                        DialogResult Ok = MsgBox.Show("La máquina " + Nombre + " será eliminado completamente", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            execute.EliminarPC(ip);
                            execute.LlenarTablaPC(dataMaquinas);
                            foreach (Form openForm in Application.OpenForms)
                            {
                                if (openForm is FormInicio formulario) // Reemplaza "MiFormulario" con el nombre de tu formulario
                                {
                                    formulario.CrearPC(); // Llamada al método en la instancia de formulario
                                }
                            }
                        }
                    }
                    else
                    {
                        // Los valores de Nombre o Correo son nulos o vacíos
                        MsgBox.Show("Error al obtener los datos del usuario seleccionado.");
                    }
                }
            }
            else if (dataMaquinas.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0 && dataMaquinas.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dataMaquinas.SelectedCells[0].RowIndex;
                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? idPC = dataMaquinas.Rows[filaSeleccionada].Cells["idPC"].Value?.ToString();
                    string? Nombre = dataMaquinas.Rows[filaSeleccionada].Cells["Nombre"].Value?.ToString();
                    string? ipAddress = dataMaquinas.Rows[filaSeleccionada].Cells["ipAddress"].Value?.ToString();
                    string? idTarifa = dataMaquinas.Rows[filaSeleccionada].Cells["idTarifa"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idPC))
                    {
                        DialogResult Ok = MsgBox.Show("¿Desea Editar los datos de " + Nombre + "?", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            UpdatePC form = new(dataMaquinas, idPC, Nombre, ipAddress, idTarifa);
                            form.Show();
                        }
                    }
                    else
                    {
                        // Los valores de Nombre o Correo son nulos o vacíos
                        MsgBox.Show("Error al obtener los datos del usuario seleccionado.");
                    }
                }
            }
        }
    }
}
