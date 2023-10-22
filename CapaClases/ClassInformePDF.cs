using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Data.SqlClient;
using System.Data;
using iText.Kernel.Pdf.Canvas.Draw;
using System.Diagnostics;
using CapaHerramientas;

namespace CapaClases
{
    public class ClassInformePDF
    {
        readonly SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void InformePDF(SaveFileDialog saveFileInformes, DataGridView DgvInformes)
        {
            saveFileInformes.Title = "Archivo PDF";
            saveFileInformes.Filter = "Archivo PDF Reporte CiberNet (*.pdf)|*.pdf"; ;
            saveFileInformes.FileName = "Reporte " + DateTime.Now.ToString("dd-MM-yyyy");
            if (saveFileInformes.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileInformes.FileName;
                if (!path.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    // Agregar la extensión .pdf si no está presente
                    path += ".pdf";
                }

                PdfWriter pdfwriter = new(path);
                PdfDocument pdf = new(pdfwriter);
                iText.Layout.Document documento = new(pdf, PageSize.LETTER);

                documento.SetMargins(10, 30, 55, 30);
                PdfFont columnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont contenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                string titulo = "Reporte de Pagos\nCIBERNET";
                string fecha = "Fecha: " + DateTime.Now.ToString("dd-MM-yyyy");
                LineSeparator linea = new(new SolidLine());
                
                documento.Add(new Paragraph(titulo).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                documento.Add(new Paragraph(fecha).SetTextAlignment(TextAlignment.RIGHT));
                documento.Add(linea);
                documento.Add(new Paragraph("\n"));
                // Crear una tabla con la misma cantidad de columnas que el DataGridView
                Table tabla = new(UnitValue.CreatePercentArray(DgvInformes.ColumnCount));

                // Agregar encabezados a la tabla
                foreach (DataGridViewColumn col in DgvInformes.Columns)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(col.HeaderText).SetFont(columnas).SetTextAlignment(TextAlignment.CENTER)));
                }

                // Agregar datos desde el DataGridView
                foreach (DataGridViewRow row in DgvInformes.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString()).SetFont(contenido).SetTextAlignment(TextAlignment.CENTER)));
                    }
                }
                // Configurar el ancho de la tabla
                tabla.SetWidth(UnitValue.CreatePercentValue(100));
                documento.Add(tabla);
                documento.Close();
                MsgBox.Show("Se exporto los datos correctamente");
            }
        }
    }
}
