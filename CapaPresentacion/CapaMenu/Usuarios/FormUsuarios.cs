using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FormUsuarios : Form
    {
        readonly Class_SQL_Usuario execute = new();
        public FormUsuarios()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            txtFiltro.SelectedIndex = 0;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            execute.llenarTablasUser(dataGridViewUsuarios);
            columBtnEliminar();
        }
        bool FormAbierto;
        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is RegistrarUser)
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
                RegistrarUser form = new(dataGridViewUsuarios);
                form.Show();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            execute.buscarUser(txtBuscar.Text, txtFiltro.Text, dataGridViewUsuarios);
        }
        private void columBtnEliminar()
        {
            DataGridViewButtonColumn btnEditar = new()
            {
                Name = "Editar",
                FlatStyle = FlatStyle.Flat
            };
            dataGridViewUsuarios.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnEliminar = new()
            {
                Name = "Eliminar",
                FlatStyle = FlatStyle.Flat
            };
            dataGridViewUsuarios.Columns.Add(btnEliminar);
        }
        private void dataGridViewUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridViewUsuarios.Columns["Editar"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el icono deseado (por ejemplo, una imagen desde recursos del proyecto)
                Icon icono = new Icon(Environment.CurrentDirectory + @"\\edit.ico");
                // Dibujar el icono en el centro del botón
                int x = e.CellBounds.Left + (e.CellBounds.Width - icono.Width) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - icono.Height) / 2;
                e.Graphics.DrawIcon(icono, x, y);

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridViewUsuarios.Columns["Eliminar"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el icono deseado (por ejemplo, una imagen desde recursos del proyecto)
                Icon icono = new Icon(Environment.CurrentDirectory + @"\\error.ico");
                // Dibujar el icono en el centro del botón
                int x = e.CellBounds.Left + (e.CellBounds.Width - icono.Width) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - icono.Height) / 2;
                e.Graphics.DrawIcon(icono, x, y);
                e.Handled = true;
            }
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0 && dataGridViewUsuarios.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dataGridViewUsuarios.SelectedCells[0].RowIndex;

                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? Nombre = dataGridViewUsuarios.Rows[filaSeleccionada].Cells["Nombre"].Value?.ToString();
                    string? Correo = dataGridViewUsuarios.Rows[filaSeleccionada].Cells["Correo"].Value?.ToString();

                    if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Correo))
                    {
                        DialogResult Ok = MsgBox.Show("El usuario " + Nombre + " será eliminado completamente", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            execute.EliminarUser(Correo);
                            execute.llenarTablasUser(dataGridViewUsuarios);
                        }
                    }
                    else
                    {
                        // Los valores de Nombre o Correo son nulos o vacíos
                        MsgBox.Show("Error al obtener los datos del usuario seleccionado.");
                    }
                }
            }
            else if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0 && dataGridViewUsuarios.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dataGridViewUsuarios.SelectedCells[0].RowIndex;

                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? Nombre = dataGridViewUsuarios.Rows[filaSeleccionada].Cells["Nombre"].Value?.ToString();
                    string? Usuario = dataGridViewUsuarios.Rows[filaSeleccionada].Cells["Usuario"].Value?.ToString();
                    string? Correo = dataGridViewUsuarios.Rows[filaSeleccionada].Cells["Correo"].Value?.ToString();
                    string? FNac = dataGridViewUsuarios.Rows[filaSeleccionada].Cells["FNac"].Value?.ToString();

                    if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Correo))
                    {
                        DialogResult Ok = MsgBox.Show("¿Desea Editar los datos de " + Nombre + "?", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            foreach (Form form in Application.OpenForms)
                            {
                                if (form is UpdateUser)
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
                                UpdateUser form = new(dataGridViewUsuarios, Nombre, Usuario, Correo, FNac);
                                form.Show();
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
        }
    }
}
