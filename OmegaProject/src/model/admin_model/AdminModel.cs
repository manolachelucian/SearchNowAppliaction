using MySql.Data.MySqlClient;
using System.Data;

namespace SearchNow.src.model.admin_model;
/// <summary>
/// Represents the model for administrative actions.
/// </summary>
public class AdminModel
{
    /// <summary>
    /// Bans a user from the system.
    /// </summary>
    /// <param name="username">The username of the user to ban.</param>
    /// <returns>True if the user was successfully banned; otherwise, false.</returns>
    public bool banUser(string username)
    {
        bool result = false;
        try
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("giveBan", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_username", username);
                    command.ExecuteNonQuery();
                    result = true;
                    connection.Close();
                }

            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Suspends a user's account.
    /// </summary>
    /// <param name="username">The username of the user to suspend.</param>
    public void suspendUser(string username)
    {
        try
        {

            using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("giveSuspended", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_username", username);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    /// <summary>
    /// Unbans a previously banned user.
    /// </summary>
    /// <param name="username">The username of the user to unban.</param>
    public void unBanUser(string username)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("giveUnban", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_username", username);
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }

        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }




}
