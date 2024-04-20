using MySql.Data.MySqlClient;
using System.Data;

namespace SearchNow.src.model.validation_model
{
    /// <summary>
    /// Interface for validation functions related to user registration.
    /// </summary>
    public interface IValidationModel
    {
        /// <summary>
        /// Checks if the provided username is already in use.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns>True if the username is in use, otherwise false.</returns>
        bool usernameInUse(string username);

        /// <summary>
        /// Checks if the provided email is available (not already in use) in the database.
        /// </summary>
        /// <param name="email">The email address to check.</param>
        /// <returns>True if the email is available, otherwise false.</returns>
        bool isEmailAvailable(string email);
    }

    /// <summary>
    /// Provides validation functions related to user registration.
    /// </summary>
    public class ValidationModel : IValidationModel
    {
        /// <inheritdoc/>
        public bool usernameInUse(string username)
        {
            // Variable to store whether the username is in use
            bool usernameInUse = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    // Creates a MySqlCommand object to execute the "check_username" stored procedure
                    using (MySqlCommand command = new MySqlCommand("check_username", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);

                        // Executes the command and retrieves the count of usernames matching the provided username
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Sets usernameInUse to true if count is greater than 0
                        usernameInUse = count > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handles MySQL exceptions
                Console.WriteLine("MySQL error occurred while checking username: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handles other exceptions
                Console.WriteLine("Error occurred while checking username: " + ex.Message);
            }

            // Returns whether the username is in use
            return usernameInUse;
        }

        /// <inheritdoc/>
        public bool isEmailAvailable(string email)
        {
            // Variable to store whether the email is in use
            bool emailInUse = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    // SQL query to count the occurrences of the provided email in the 'users' table
                    string emailAvailableQuery = "SELECT COUNT(*) FROM users WHERE email = @email";

                    // Creates a MySqlCommand object with the query and connection
                    using (MySqlCommand command = new MySqlCommand(emailAvailableQuery, connection))
                    {
                        // Adds the email parameter to the command
                        command.Parameters.AddWithValue("@email", email);
                        // Executes the command and retrieves the count of emails matching the provided email
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Sets emailInUse to true if count is greater than 0 (email is in use)
                        emailInUse = count > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handles MySQL exceptions
                Console.WriteLine("MySQL error occurred while checking email availability: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handles other exceptions
                Console.WriteLine("Error occurred while checking email availability: " + ex.Message);
            }

            // Returns whether the email is in use
            return emailInUse;
        }
    }
}
