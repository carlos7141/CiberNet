using System.Data;
namespace CapaSQL
{
    public class Class_SQL_Usuario
    {
        SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void insertarAdmin(string Nombre, string Usuario, string Password)
        {
            cn.Open();
            SqlCommand cmd = new("insertar_Administrador", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Contraseña", Password);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("REGISTRO COMPLETADO");
        }
        public void insertarUser(string Nombre, string Usuario, string Correo, string FNac)
        {
            cn.Open();
            SqlCommand cmd = new("insertar_Usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.Parameters.AddWithValue("@FNac", FNac);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("El Usuario " + Nombre + " a sido añadido a la lista.");
        }
        public void EliminarUser(string Correo)
        {
            cn.Open();
            SqlCommand cmd = new("eliminar_Usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void UpdateUsuario(string Nombre, string Usuario, string Correo, string FNac)
        {
            cn.Open();
            SqlCommand cmd = new("update_Usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.Parameters.AddWithValue("@FNac", FNac);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void UpdateUsuarioPassword(string Pwd, string Correo)
        {
            cn.Open();
            SqlCommand cmd = new("update_Usuario_Password", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.Parameters.AddWithValue("@Pwd", Pwd);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void buscarUser(string Buscar, string Filtro, DataGridView Tabla)
        {
            cn.Open();
            string consulta = "SELECT * FROM ACCOUNTUSER WHERE " + Filtro + " LIKE " + "'%" + Buscar + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            dt.Columns.Remove("idUser");
            dt.Columns.Remove("Pwd");
            Tabla.DataSource = dt;
            cn.Close();
        }
        public bool UserRepeat(string Filtro, string Buscar)
        {
            bool exist = false;
            cn.Open();
            string consulta = "SELECT * FROM ACCOUNTUSER WHERE " + Filtro + " LIKE " + "'%" + Buscar + "%'";
            SqlCommand comando = new(consulta, cn);

            // Utilizamos ExecuteScalar para obtener el resultado de la consulta como un objeto
            object resultado = comando.ExecuteScalar();

            // Convertimos el resultado a int y verificamos si es mayor que cero para determinar si se encontraron registros
            if (resultado != null && Convert.ToInt32(resultado) > 0)
            {
                exist = true;
            }
            cn.Close();
            return exist;
        }
        public void llenarTablasUser(DataGridView Tabla)
        {
            cn.Open();
            string consulta = "SELECT * FROM ACCOUNTUSER";
            SqlDataAdapter adaptador = new(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            dt.Columns.Remove("idUser");
            dt.Columns.Remove("Pwd");
            Tabla.DataSource = dt;
            cn.Close();
        }
        public bool BuscarIP(string ipAddress)
        {
            bool ipExists = false;
            cn.Open();
            SqlCommand cmd = new SqlCommand("buscar_Ip", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ipAddress", ipAddress);
            int result = (int)cmd.ExecuteScalar();
            ipExists = result > 0;
            cn.Close();
            return ipExists;
        }
    }
}