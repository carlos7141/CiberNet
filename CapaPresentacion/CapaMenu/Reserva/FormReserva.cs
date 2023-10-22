using System.Globalization;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReserva : Form
    {
        readonly Class_SQL_Reserva execute = new();
        ClassEditDelete dgvButton = new();
        public FormReserva()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        bool FormAbierto;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is RegistrarReserva)
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
                RegistrarReserva form = new(dgvReservas);
                form.Show();
            }
        }
        private void dgvReservas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dgvButton.cellPainting(dgvReservas, e);
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0 && dgvReservas.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dgvReservas.SelectedCells[0].RowIndex;

                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? idReserva = dgvReservas.Rows[filaSeleccionada].Cells["idReserva"].Value?.ToString();
                    string? Usuario = dgvReservas.Rows[filaSeleccionada].Cells["Usuario"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idReserva) && !string.IsNullOrEmpty(Usuario))
                    {
                        DialogResult Ok = MsgBox.Show("La Reserva de " + Usuario + " será eliminado completamente", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            execute.Remove(idReserva);
                            dgvReservas.DataSource = execute.LlenarReservaDGV();
                            dgvReservas.Columns["idReserva"].Visible = false;
                            dgvReservas.Columns["idPC"].Visible = false;
                            dgvReservas.Columns["idUser"].Visible = false;
                        }
                    }
                    else
                    {
                        // Los valores de Nombre o Correo son nulos o vacíos
                        MsgBox.Show("Error al obtener los datos de la Tarifa.");
                    }
                }
            }
            else if (dgvReservas.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0 && dgvReservas.SelectedCells.Count > 0)
                {
                    int filaSeleccionada = dgvReservas.SelectedCells[0].RowIndex;

                    // Obtener el valor de las columnas "Nombre" y "Correo" de la fila seleccionada
                    string? idReserva = dgvReservas.Rows[filaSeleccionada].Cells["idReserva"].Value?.ToString();
                    string? idUser = dgvReservas.Rows[filaSeleccionada].Cells["idUser"].Value?.ToString();
                    string? Usuario = dgvReservas.Rows[filaSeleccionada].Cells["Usuario"].Value?.ToString();
                    string? Correo = dgvReservas.Rows[filaSeleccionada].Cells["Correo"].Value?.ToString();
                    string? Fecha = dgvReservas.Rows[filaSeleccionada].Cells["Fecha"].Value?.ToString();
                    string? HoraInicio = dgvReservas.Rows[filaSeleccionada].Cells["HoraInicio"].Value?.ToString();
                    string? HoraFin = dgvReservas.Rows[filaSeleccionada].Cells["HoraFin"].Value?.ToString();
                    string? Pago = dgvReservas.Rows[filaSeleccionada].Cells["Pago"].Value?.ToString();
                    string? idPC = dgvReservas.Rows[filaSeleccionada].Cells["idPC"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idReserva))
                    {
                        DialogResult Ok = MsgBox.Show("¿Desea Editar los datos de la reserva de " + Usuario + "?", "Advertencia", MessageBoxButtons.OKCancel);
                        if (Ok == DialogResult.OK)
                        {
                            foreach (Form form in Application.OpenForms)
                            {
                                if (form is UpdateReserva)
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
                                UpdateReserva form = new(dgvReservas, idReserva, idUser, Usuario, Correo, Fecha, HoraInicio, HoraFin, Pago, idPC);
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
        private void FormReservas_Load(object sender, EventArgs e)
        {
            string parrafoExplicacion = "Para registrar una reserva debera proporcionar la siguiente información:" +
                "\n\nNombre: [Nombre de la tarifa]" +
                "\nPrecio: [Precio por Hora]" +
                "\n\nPresione el botón 'Agregar'";
            labelParrafo.Text = parrafoExplicacion;
            dgvReservas.DataSource = execute.LlenarReservaDGV();
            dgvReservas.Columns["idReserva"].Visible = false;
            dgvReservas.Columns["idPC"].Visible = false;
            dgvReservas.Columns["idUser"].Visible = false;
            dgvButton.columBtnEliminar(dgvReservas);
        }

        private void dgvReservas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvReservas.Columns["Pago"].Index)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    decimal valor = (decimal)e.Value;
                    e.Value = valor.ToString("N2") + " Bs.";
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == dgvReservas.Columns["HoraInicio"].Index || e.ColumnIndex == dgvReservas.Columns["HoraFin"].Index)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    TimeSpan hora = (TimeSpan)e.Value;
                    e.Value = hora.ToString(@"hh\:mm", CultureInfo.InvariantCulture);
                    e.FormattingApplied = true;
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Centra el contenido de todas las celdas
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
