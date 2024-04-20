using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using SearchNow.src.objects.user;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SearchNow.src.model.user_model
{
    public interface IUser
    {
       User GetUser(string username);
       void UpdatePassword(string username, string newPassword);
    }

    public class UserModel
    {

        /// <summary>
        /// Gets a user by username from the database and populates the User object with the retrieved data.
        /// </summary>
        /// <param name="username">The username of the user to retrieve.</param>
        /// <returns>The User object populated with user data if found, otherwise null.</returns>
        public User GetUser(string username)
        {
            User user = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("GetUserByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    Id = reader.GetInt32("id_user"),
                                    Username = reader.GetString("username"),
                                    Password = reader.GetString("password_hash"),
                                    Email = reader.GetString("email"),
                                    DisplayName = reader.GetString("display_name"),
                                    CreatedAt = reader.GetDateTime("created_at"),
                                    Bio = reader.GetString("bio"),
                                    Role = reader.GetString("role_name"),
                                    AccountStatus = reader.GetString("status_name")
                                };
                            }
                            else
                            {
                                Console.WriteLine("User not found.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return user;
        }

        /// <summary>
        /// Updates the password of a user in the database.
        /// </summary>
        /// <param name="username">The username of the user whose password will be updated.</param>
        /// <param name="newPassword">The new password for the user.</param>
        public void UpdatePassword(string username, string newPassword)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdatePassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);
                        command.Parameters.AddWithValue("@p_new_password", newPassword);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating password: " + ex.Message);
            }
        }
        public void UpdateUserBio(string username, string bio)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdateUserBio", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);
                        command.Parameters.AddWithValue("@p_bio", bio);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Updates the display name of a user in the database.
        /// </summary>
        /// <param name="username">The username of the user whose display name will be updated.</param>
        /// <param name="newDisplayName">The new display name for the user.</param>
        public void UpdateUserDisplayName(string username, string newDisplayName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdateUserDisplayName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);
                        command.Parameters.AddWithValue("@p_display_name", newDisplayName);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Updates the email address of a user in the database.
        /// </summary>
        /// <param name="username">The username of the user whose email will be updated.</param>
        /// <param name="newEmail">The new email address for the user.</param>
        public void UpdateEmail(string username, string newEmail)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdateEmail", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);
                        command.Parameters.AddWithValue("@p_email", newEmail);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Gets the user ID corresponding to the provided username from the database.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>The user ID if found, otherwise -1.</returns>
        public int GetUserId(string username)
        {
            int userId = -1;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    string query = "SELECT id_user FROM users WHERE username = @username";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return userId;
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
                                if (roleId == 1)
                                {

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
