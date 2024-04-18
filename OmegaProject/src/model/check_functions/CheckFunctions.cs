using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace SearchNow.src.model.check_functions
{
    public class CheckFunctions
    {
        private Regex regex;

        /// <summary>
        /// Initializes a new instance of the CheckFunctions class.
        /// </summary>
        public CheckFunctions()
        {
            // Initializes the Regex object without a pattern
            regex = new Regex("");
        }

        /// <summary>
        /// Checks if an email address is in a valid format.
        /// </summary>
        /// <param name="email">The email address to check.</param>
        /// <returns>True if the email address is in a valid format, otherwise false.</returns>
        public bool emailCheck(string email)
        {
            // Regular expression pattern to check for a valid email format
            string email_pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Creating a Regex object with the specified pattern
            Regex regex = new Regex(email_pattern);

            // Checking if the email address matches the pattern
            if (regex.IsMatch(email))
            {
                // If the email address matches the pattern, return true
                return true;
            }
            else
            {
                // If the email address does not match the pattern, return false
                return false;
            }
        }


        /// <summary>
        /// Checks if a password meets the criteria of being a strong password.
        /// </summary>
        /// <param name="password">The password to check.</param>
        /// <returns>True if the password meets the criteria of being a strong password, otherwise false.</returns>
        public bool IsStrongPassword(string password)
        {
            // Regular expression pattern to check for a strong password
            string password_pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$";

            // Creating a Regex object with the specified pattern
            Regex regex = new Regex(password_pattern);

            // Checking if the password matches the pattern
            if (regex.IsMatch(password))
            {
                // If the password matches the pattern, return true
                return true;
            }
            else
            {
                // If the password does not match the pattern, return false
                return false;
            }
        }

        /// <summary>
        /// Validates the format of a username according to a specific pattern.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <returns>True if the username format is valid, otherwise false.</returns>
        public bool ValidateUsernameFormat(string username)
        {
            // Regular expression pattern to validate username format
            string Username_pattern = @"^(?!.*\.\.)(?!.*\.$)[^\W][\w.]{0,29}$";

            // Creating a Regex object with the specified pattern
            Regex regex = new Regex(Username_pattern);

            // Checking if the username matches the pattern
            if (regex.IsMatch(username))
            {
                // If the username matches the pattern, return true
                return true;
            }
            else
            {
                // If the username does not match the pattern, return false
                return false;
            }
        }

        public void checkConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    // If the connection is successful, display a success message
                    MessageBox.Show("Connection Successful", "Connection status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                // If the connection fails, display an error message
                MessageBox.Show("Connection failed!", "Connection status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




    }
}
