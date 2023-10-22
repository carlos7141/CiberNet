namespace CapaPresentacion
{
    public partial class FormTarifas : Form
    {
        readonly Class_SQL_Tarifa execute = new();
        ClassEditDelete dgvButton = new();
        public FormTarifas()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        bool FormAbierto;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is RegistrarTarifa)
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
                RegistrarTarifa form = new(dgvTarifas);
                form.Show();
            }
        }
        private void dgvTarifas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dgvButton.cellPainting(dgvTarifas, e);
        }

        private void dgvTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarifas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0 && dgvTarifas.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dgvTarifas.SelectedCells[0].RowIndex;

                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? idTarifa = dgvTarifas.Rows[filaSeleccionada].Cells["idTarifa"].Value?.ToString();
                    string? Nombre = dgvTarifas.Rows[filaSeleccionada].Cells["Nombre"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idTarifa) && !string.IsNullOrEmpty(Nombre))
                    {
                        DialogResult Ok = MsgBox.Show("La Tarifa " + Nombre + " será eliminado completamente", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            execute.Remove(idTarifa);
                            execute.LlenarDGV(dgvTarifas);
                        }
                    }
                    else
                    {
                        // Los valores de Nombre o Correo son nulos o vacíos
                        MsgBox.Show("Error al obtener los datos de la Tarifa.");
                    }
                }
            }
            else if (dgvTarifas.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0 && dgvTarifas.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dgvTarifas.SelectedCells[0].RowIndex;

                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? idTarifa = dgvTarifas.Rows[filaSeleccionada].Cells["idTarifa"].Value?.ToString();
                    string? Nombre = dgvTarifas.Rows[filaSeleccionada].Cells["Nombre"].Value?.ToString();
                    string? Precio = dgvTarifas.Rows[filaSeleccionada].Cells["PrecioPorHora"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idTarifa) && !string.IsNullOrEmpty(Nombre))
                    {
                        DialogResult Ok = MsgBox.Show("¿Desea Editar los datos de la tarifa " + Nombre + "?", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            foreach (Form form in Application.OpenForms)
                            {
                                if (form is UpdateTarifa)
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
                                UpdateTarifa form = new(dgvTarifas, idTarifa, Nombre, Precio);
                                form.Show();
                            }
                        }
                    }
                    else
                    {
                        // Los valores de Nombre o Correo son nulos o vacíos
                        MsgBox.Show("Error al obtener los datos de la tarifa seleccionada.");
                    }
                }
            }
        }

        private void FormTarifas_Load(object sender, EventArgs e)
        {
            string parrafoExplicacion = "Para registrar una Tarifa debera proporcionar la siguiente información." +
                "\n\nNombre: [Nombre de la tarifa]" +
                "\nPrecio: [Precio por Hora]" +
                "\n\nPresione el botón 'Agregar'";
            labelParrafo.Text = parrafoExplicacion;
            execute.LlenarDGV(dgvTarifas);
            dgvButton.columBtnEliminar(dgvTarifas);
        }
    }
}
