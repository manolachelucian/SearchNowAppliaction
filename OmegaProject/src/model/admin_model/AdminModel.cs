using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;

namespace SearchNow.src.model.admin_model;

public class AdminModel
{

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
