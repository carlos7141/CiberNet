using System.Data;
namespace CapaSQL
{
    public class Class_SQL_Backup
    {
        readonly SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public void CrearBackup(string Path)
        {
            cn.Open();
            SqlCommand cmd = new("crear_Backup", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@BackupFilePath", Path);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
