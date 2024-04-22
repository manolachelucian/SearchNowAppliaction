using MySql.Data.MySqlClient;
using SearchNow.src.objects;
using SearchNow.src.objects.user;

namespace SearchNow.src.model.user_forums_model
{
    /// <summary>
    /// Model class responsible for database operations related to user forums.
    /// </summary>
    public class UserForumsModel
    {
        /// <summary>
        /// Loads user forums into the provided DataGridView.
        /// </summary>
        /// <param name="user">The user whose forums need to be loaded.</param>
        /// <param name="dataGridView">The DataGridView control to display user forums.</param>
        public void LoadUserForums(User user, DataGridView dataGridView)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    string query = "SELECT forum_name, forum_description, created_at FROM forums WHERE creator_user_id = @userId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", user.Id);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string forumName = reader.GetString("forum_name");
                                string forumDescription = reader.GetString("forum_description");
                                DateTime createdAt = reader.GetDateTime("created_at");

                                // Add the forum details to the DataGridView
                                dataGridView.Rows.Add(forumName, forumDescription, createdAt.ToString());
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error communicating with the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message, true); // Assuming Logger is a custom logging utility
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message, true); // Assuming Logger is a custom logging utility
            }
        }

        /// <summary>
        /// Deletes the specified forum from the database.
        /// </summary>
        /// <param name="forumName">The name of the forum to delete.</param>
        /// <param name="userId">The ID of the user who created the forum.</param>
        /// <returns>True if the forum was successfully deleted; otherwise, false.</returns>
        public bool DeleteForum(string forumName, int userId)
        {
            bool result = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    string query = "DELETE FROM forums WHERE forum_name = @forumName AND creator_user_id = @userId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@forumName", forumName);
                        command.Parameters.AddWithValue("@userId", userId);
                        int rowsAffected = command.ExecuteNonQuery();
                        Logger.WriteLog("Deleted forum successfully", false); // Assuming Logger is a custom logging utility
                        if (rowsAffected > 0)
                        {
                            result = true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Logger.WriteLog(ex.Message + ex.StackTrace, true); // Assuming Logger is a custom logging utility
            }
            return result;
        }
    }
}
