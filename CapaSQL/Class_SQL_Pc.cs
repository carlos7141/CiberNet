using System.Data;

namespace CapaSQL
{
    public class Class_SQL_Pc
    {
        readonly SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void InsertarPC(string Nombre, string IpAddress, string idTarifa)
        {
            cn.Open();
            SqlCommand cmd = new("insertar_Maquina", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@ipAddress", IpAddress);
            cmd.Parameters.AddWithValue("@idTarifa", idTarifa);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("La maquina " + Nombre + " a sido añadido correctamente");
        }
        public void EliminarPC(string ipAddress)
        {
            cn.Open();
            SqlCommand cmd = new("eliminar_Maquina", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ipAddress", ipAddress);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(string idPC, string Nombre, string ipAddress, string idTarifa)
        {
            cn.Open();
            SqlCommand cmd = new("update_Maquina", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idPC", idPC);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@ipAddress", ipAddress);
            cmd.Parameters.AddWithValue("@idTarifa", idTarifa);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public string BuscarMaquinaTarifa(string idTarifa)
        {
            string ?Nombre = string.Empty;
            cn.Open();
            SqlCommand cmd = new("buscar_Maquina_Tarifa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idTarifa", idTarifa);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 Nombre = reader["Nombre"].ToString();
            }
            cn.Close();
            return Nombre;
        }

        public void LlenarTablaPC(DataGridView Tabla)
        {
            cn.Open();
            SqlCommand cmd = new("LlenarTablaPC", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new(cmd);
            DataTable dt = new();
            adaptador.Fill(dt);
            Tabla.DataSource = dt;
            Tabla.Columns["idPC"].Visible = false;
            Tabla.Columns["idTarifa"].Visible = false;
            cn.Close();
        }
    }
}
