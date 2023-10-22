using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace CapaSQL
{
    public class Class_SQL_Reserva
    {
        SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void Add(string Fecha, string HoraInicio, string HoraFin, string Pago, string idUser, string idPC)
        {
            cn.Open();
            SqlCommand cmd = new("insertar_Reserva", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@HoraInicio", HoraInicio);
            cmd.Parameters.AddWithValue("@HoraFin", HoraFin);
            cmd.Parameters.AddWithValue("@Pago", Pago);
            cmd.Parameters.AddWithValue("@idUser", idUser);
            cmd.Parameters.AddWithValue("@idPC", idPC);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Remove(string idReserva)
        {
            cn.Open();
            SqlCommand cmd = new("eliminar_Reserva", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idReserva", idReserva);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(string idReserva, string Fecha, string HoraInicio, string HoraFin, string Pago, string idUser, string idPC)
        {
            cn.Open();
            SqlCommand cmd = new("update_Reserva", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idReserva", idReserva);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@HoraInicio", HoraInicio);
            cmd.Parameters.AddWithValue("@HoraFin", HoraFin);
            cmd.Parameters.AddWithValue("@Pago", Pago);
            cmd.Parameters.AddWithValue("@idUser", idUser);
            cmd.Parameters.AddWithValue("@idPC", idPC);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable LlenarReservaDGV()
        {
            cn.Open();
            string consulta = "SELECT r.*, a.Usuario, a.Correo, m.Nombre FROM RESERVA r INNER JOIN ACCOUNTUSER a ON r.idUser = a.idUser INNER JOIN MAQUINA m ON r.idPC = m.idPC";
            SqlDataAdapter adaptador = new(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable LlenarUsuariosDGV()
        {
            cn.Open();
            string consulta = "SELECT idUser, Usuario, Correo FROM ACCOUNTUSER";
            SqlDataAdapter adaptador = new(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            cn.Close();
            return dt;
        }
        public void BuscarUsuario(string Buscar, string Filtro, DataGridView Tabla)
        {
            cn.Open();
            string consulta = "SELECT idUser, Usuario, Correo FROM ACCOUNTUSER WHERE " + Filtro + " LIKE " + "'%" + Buscar + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            Tabla.DataSource = dt;
            Tabla.Columns["idUser"].Visible = false;
            cn.Close();
        }
        public List<DataMaquina> ComboBox()
        {
            List<DataMaquina> listaMaquina = new();
            cn.Open();
            string query = "SELECT idPC, Nombre FROM MAQUINA";
            SqlCommand cmd = new(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listaMaquina.Add(new DataMaquina
                {
                    idPC = Convert.ToInt32(reader["idPC"]),
                    Nombre = Convert.ToString(reader["Nombre"].ToString())
                });
            }
            cn.Close();
            return listaMaquina;
        }
    }
}
