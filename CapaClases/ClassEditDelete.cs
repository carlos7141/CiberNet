namespace CapaClases
{
    public class ClassEditDelete
    {
        public void columBtnEliminar(DataGridView dgv)
        {
            DataGridViewButtonColumn btnEditar = new()
            {
                Name = "Editar",
                FlatStyle = FlatStyle.Flat
            };
            dgv.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnEliminar = new()
            {
                Name = "Eliminar",
                FlatStyle = FlatStyle.Flat
            };
            dgv.Columns.Add(btnEliminar);
        }
        public void cellPainting(DataGridView dgv, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgv.Columns["Editar"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el icono deseado (por ejemplo, una imagen desde recursos del proyecto)
                Icon icono = new(Environment.CurrentDirectory + @"\\edit.ico");

                // Dibujar el icono en el centro del botón
                int x = e.CellBounds.Left + (e.CellBounds.Width - icono.Width) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - icono.Height) / 2;
                e.Graphics.DrawIcon(icono, x, y);

                e.Handled = true;
            }
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgv.Columns["Eliminar"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el icono deseado (por ejemplo, una imagen desde recursos del proyecto)
                Icon icono = new(Environment.CurrentDirectory + @"\\error.ico");

                // Dibujar el icono en el centro del botón
                int x = e.CellBounds.Left + (e.CellBounds.Width - icono.Width) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - icono.Height) / 2;
                e.Graphics.DrawIcon(icono, x, y);

                e.Handled = true;
            }
        }
    }
}
