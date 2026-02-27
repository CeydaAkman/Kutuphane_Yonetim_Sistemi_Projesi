using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace GRUP6
{
    public static class DbHelper
    {
        private static string connectionString = @"Data Source=CYDKMN\SQLEXPRESS; Initial Catalog=KutuphaneYonetimDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";

        public static Microsoft.Data.SqlClient.SqlConnection GetConnection()
        {
            return new Microsoft.Data.SqlClient.SqlConnection(connectionString);
        }

        public static DataTable GetData(string query, Microsoft.Data.SqlClient.SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                using (var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    da.Fill(dt);
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return dt;
        }

        public static int ExecuteCommand(string query, Microsoft.Data.SqlClient.SqlParameter[] parameters = null)
        {
            int affectedRows = 0;
            try
            {
                using (var connection = GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    if (parameters != null) command.Parameters.AddRange(parameters);
                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return affectedRows;
        }

        public static bool TestConnection()
        {
            try { using (var connection = GetConnection()) { connection.Open(); return true; } }
            catch { return false; }
        }
    }
}