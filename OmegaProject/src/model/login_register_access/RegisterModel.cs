using MySql.Data.MySqlClient;
using System.Data;

namespace SearchNow.src.model.login_register_access
{
    public interface IRegisterModel
    {
        bool registerUser(string username, string password, string email, string displayName, string dateOfBirth);
    }

    public class RegisterModel: IRegisterModel
    {
        /// <summary>
        /// Registers a new user with the specified details.
        /// </summary>
        /// <param name="username">The username of the new user.</param>
        /// <param name="password">The password of the new user.</param>
        /// <param name="email">The email address of the new user.</param>
        /// <param name="displayName">The display name of the new user.</param>
        /// <param name="dateOfBirth">The date of birth of the new user.</param>
        public bool registerUser(string username, string password, string email, string displayName, string dateOfBirth)
        {
            bool registrationAttempt = false;
            try
            {
                using(MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    
                    using (MySqlCommand cmd = new MySqlCommand("create_user", connection))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_username", username);
                        cmd.Parameters.AddWithValue("@p_password_hash", password);
                        cmd.Parameters.AddWithValue("@p_email", email);
                        cmd.Parameters.AddWithValue("@p_display_name", displayName);
                        cmd.Parameters.AddWithValue("@p_date", dateOfBirth);
                        cmd.ExecuteNonQuery();
                    }
                    registrationAttempt = true;
                }
            }
            catch (MySqlException ex)
            {
                // Displays an error message if a MySQL exception occurs
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Displays an error message if any other exception occurs
                MessageBox.Show(ex.Message);
            }
            return registrationAttempt;
        }
    }
}
