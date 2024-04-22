using MySql.Data.MySqlClient;
using SearchNow.src.objects;
using System.Data;
using User = SearchNow.src.objects.user.User;

namespace SearchNow.src.model.createForum_model
{
    /// <summary>
    /// Represents the model for creating a new forum.
    /// </summary>
    public class CreateForumModel
    {
        /// <summary>
        /// Creates a new forum with the specified name and description.
        /// </summary>
        /// <param name="forumName">The name of the forum to create.</param>
        /// <param name="forumDescription">The description of the forum to create.</param>
        /// <param name="currentUser">The user who is creating the forum.</param>
        /// <returns>True if the forum was successfully created; otherwise, false.</returns>
        public bool createForum(string forumName, string forumDescription, User currentUser)
        {
            bool result = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    using (MySqlCommand command = new MySqlCommand("createForum", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_forum_name", forumName);
                        command.Parameters.AddWithValue("@p_forum_description", forumDescription);
                        command.Parameters.AddWithValue("@p_creator_user_id", currentUser.Id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result = true;
                            Logger.WriteLog("Creating forum",false);
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error communicating with the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message+ex.StackTrace, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message + ex.StackTrace, true);
            }
            return result;
        }
    }
}
