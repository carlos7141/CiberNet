using System.Data;

namespace CapaSQL
{
    public class Class_SQL_Reporte
    {
        readonly SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void LlenarDGV(DataGridView Tabla)
        {
            cn.Open();
            string consulta = "SELECT * FROM REPORTE";
            SqlDataAdapter adaptador = new(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            Tabla.DataSource = dt;
            cn.Close();
        }
        public void Add(string Fecha, string LoginCliente, string Estado, string Descripcion, string Total, string idPC)
        {
            cn.Open();
            SqlCommand cmd = new("insertar_Reporte", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@LoginCliente", LoginCliente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@idPC", idPC);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Remove(string idReporte)
        {
            cn.Open();
            SqlCommand cmd = new("eliminar_Reporte", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idReporte", idReporte);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
