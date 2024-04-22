using System.Configuration;

/// <summary>
/// Class responsible for managing database connections.
/// </summary>
public class DatabaseConnection 
{
    private static string connectionString = null;

    /// <summary>
    /// Retrieves the connection string from the configuration file.
    /// </summary>
    /// <returns>The connection string for the database.</returns>
    public static string GetConnection()
    {
        // Retrieve the connection string from the configuration file
        connectionString = ConfigurationManager.ConnectionStrings["localHostConnection"].ConnectionString;
        return connectionString;
    }
}
