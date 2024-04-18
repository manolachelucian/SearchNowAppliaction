using MySql.Data.MySqlClient;
using System.Data;

namespace SearchNow.src.model.login_register_access
{
    public class LoginFunctions
    {

        /// <summary>
        /// Checks the login details of the user.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>True if login details are correct, otherwise false.</returns>
        public bool checkLoginDetails(string username, string password)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    // Using MySqlCommand to execute the "login" stored procedure
                    using (MySqlCommand command = new MySqlCommand("login", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@log_username", username);
                        command.Parameters.AddWithValue("@log_password", password);

                        // Executing the command and retrieving the result
                        object result = command.ExecuteScalar();

                        // If the result is not null or DBNull, convert it to an integer and check if it's equal to 1
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result) == 1;
                        }
                    }
                }
                
                
            }
            catch (MySqlException ex)
            {
                // If a MySQL exception occurs, display the error message
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // If any other exception occurs, display the error message
                MessageBox.Show(ex.Message);
            }
            // If authentication fails or an exception occurs, return false
            return false;
        }
    }
}
