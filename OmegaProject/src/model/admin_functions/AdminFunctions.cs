using MySql.Data.MySqlClient;
using System.Data;

namespace SearchNow.src.model.admin_functions
{
    public class AdminFunctions
    {


        public void banUser( string username)
        {
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
                        MessageBox.Show(username + " has been banned!", "ban info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        MessageBox.Show(username + " has been suspended!", "suspend info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show(username + " has been unbanned!", "unban info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();

                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public bool getStatusFromUser(string username)
        {
            // Default status to false
            bool status = false;

            try
            {
                // Open connection
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();

                    // SQL query to retrieve role_id for the provided username
                    string query = "SELECT role_id FROM users WHERE username = @p_username";

                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter for username
                        command.Parameters.AddWithValue("@p_username", username);

                        // Execute the query and read the result
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // If there's a result, set status based on role_id
                            if (reader.Read())
                            {
                                int roleId = reader.GetInt32("role_id");
                                if(roleId == 1) { 
                                
                                return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exception
                Console.WriteLine("MySQL error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error: " + ex.Message);
            }

            return status;
        }

    }
}
