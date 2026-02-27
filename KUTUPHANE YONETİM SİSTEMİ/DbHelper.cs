using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
public static class DbHelper
{
    // Bağlantı dizesi
    private static string connectionString = @"Data Source=VINCENZA;
    Initial Catalog=gorselProgramlama;
    Integrated Security=True;
    Persist Security Info=False;
    Pooling=False;
    MultipleActiveResultSets=False;
    Encrypt=True;
    TrustServerCertificate=True;
    Command Timeout=0";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // ✅ YENİ EKLENEN METOT: SELECT işlemleri için (CS1929 hatasını çözer)
    public static DataTable GetData(string query, SqlParameter[] parameters = null)
    {
        DataTable dt = new DataTable();
        try
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                conn.Open();
                da.Fill(dt);
            }
        }
        catch (SqlException ex)
        {
            Debug.WriteLine($"GetData SQL Hatası: {ex.Message}");
            // DataTable boş dönecektir, form hata mesajını gösterebilir.
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"GetData Genel Hata: {ex.Message}");
        }
        return dt;
    }

    // INSERT, UPDATE, DELETE için (ExecuteCommand)
    public static int ExecuteCommand(string query, SqlParameter[] parameters = null)
    {
        int affectedRows = 0; // CS0161 hatası için dönüş garantisi

        try
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        catch (SqlException ex)
        {
            System.Diagnostics.Debug.WriteLine("SQL Hata: " + ex.Message);
            // Hata durumunda istisna fırlatılabilir, böylece çağıran kod (Service katmanı) bunu yakalar.
            throw new Exception("Veritabanı işlemi başarısız oldu: " + ex.Message);
        }
        return affectedRows;
    }

    // Bağlantı Test Metodu (TestConnection)
    public static bool TestConnection()
    {
        using (SqlConnection connection = GetConnection())
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Veritabanı bağlantı hatası: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Genel hata: {ex.Message}");
                return false;
            }
        }
    }
}