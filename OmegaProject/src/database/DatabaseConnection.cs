using System.Configuration;
using MySql.Data.MySqlClient;


public class DatabaseConnection
{
 
    private static string connectionString = null;
    
    public static string GetConnection()
    {
        connectionString = ConfigurationManager.ConnectionStrings["localHostConnection"].ConnectionString;
        return connectionString;
    }
}
