using MySql.Data.MySqlClient;
using System.Data;

namespace SearchNow.src.model.user_class
{
    public class User
    {
        private string username;
        private string password;
        private string email;
        private string displayName;
        private DateTime created_at;
        private string bio;
        private string role;
        private string account_status;

        public void SetUser(string username)
        {
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
                                this.username = username;
                                username = reader.GetString("username");
                                password = reader.GetString("password_hash");
                                email = reader.GetString("email");
                                displayName = reader.GetString("display_name");
                                created_at = reader.GetDateTime("created_at");
                                bio = reader.GetString("bio");
                                role = reader.GetString("role_name");
                                account_status = reader.GetString("status_name");
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
        }
        public void UpdatePassword(string _username, string newPassword, string connectionString)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdatePassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", _username);
                        command.Parameters.AddWithValue("@p_new_password", newPassword);
                        command.ExecuteNonQuery();
                    }

                }  
                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating password: " + ex.Message);
            }
            
        }

        public void UpdateUserBio(string bio, string connectionString)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdateUserBio", connection))
                    {
                        
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);
                        command.Parameters.AddWithValue("@p_bio", bio);
                        command.ExecuteNonQuery();
                        this.bio = bio;
                        MessageBox.Show("Bio has been successfully updated");
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

        public void UpdateUserDisplayName(string username, string newDisplayName, string connectionString)
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
                        displayName = newDisplayName;
                    }

                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void UpdateEmail(string username, string newEmail)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdateEmail", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_username", username);
                        command.Parameters.AddWithValue("@p_email", newEmail);
                        command.ExecuteNonQuery();
                        email = newEmail;
                        MessageBox.Show("E-mail has been successfully changed");
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

        public int GetUserId()
        {
            int userId = -1;

            try
            {
                using(MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
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



        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;

        }
        public void setPassword(string newPassword)
        {
            password = newPassword;
        }

        public string getEmail()
        {
            return email;
        }
        public string getDisplayName()
        {
            return displayName;
        }
        public DateTime getCreated_at()
        {
            return created_at;
        }
        public string getBio()
        {
            return bio;
        }
        public string getRole()
        {
            return role;
        }
        public string getAccount_status()
        {
            return account_status;
        }

    }
}
