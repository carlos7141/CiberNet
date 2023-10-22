using System.Data;

namespace CapaSQL
{
    public class Class_SQL_Tarifa
    {
        readonly SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void LlenarDGV(DataGridView Tabla)
        {
            cn.Open();
            string consulta = "SELECT * FROM TARIFA";
            SqlDataAdapter adaptador = new(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            Tabla.DataSource = dt;
            cn.Close();
        }
        public void Add(string Nombre, string Precio)
        {
            cn.Open();
            SqlCommand cmd = new("insertar_Tarifa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@PrecioPorHora", Precio);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Remove(string idTarifa)
        {
            cn.Open();
            SqlCommand cmd = new("eliminar_Tarifa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idTarifa", idTarifa);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(string idTarifa,string Nombre, string Precio)
        {
            cn.Open();
            SqlCommand cmd = new("update_Tarifa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idTarifa", idTarifa);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@PrecioPorHora", Precio);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public List<DataTarifa> ComboBox()
        {
            List<DataTarifa> listaTarifa = new();
            cn.Open();
            string query = "SELECT idTarifa, Nombre FROM TARIFA";
            SqlCommand cmd = new(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listaTarifa.Add(new DataTarifa
                {
                    idTarifa = Convert.ToInt32(reader["idTarifa"]),
                    Nombre = Convert.ToString(reader["Nombre"].ToString())
                });
            }
            cn.Close();
            return listaTarifa;
        }
    }
}
