using MySql.Data.MySqlClient;
using SearchNow.src.objects;
using SearchNow.src.objects.forum;
using SearchNow.src.objects.forum.comment;
using SearchNow.src.objects.user;

namespace SearchNow.src.model.forum_model
{

    public interface IForumModel
    {
        Forum GetLoadForumDetails(string forumName);
    }

    /// <summary>
    /// Represents the model for forum-related operations.
    /// </summary>
    public class ForumModel : IForumModel
    {
        /// <summary>
        /// Retrieves details of a forum.
        /// </summary>
        /// <param name="forumName">The name of the forum.</param>
        /// <returns>The forum details.</returns>
        public Forum GetLoadForumDetails(string forumName)
        {
            Forum forum = null;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT f.forum_id, f.forum_name, f.forum_description, f.created_at, u.username AS creator_username FROM forums f JOIN users u ON f.creator_user_id = u.id_user WHERE f.forum_name = @forumName", connection))
                    {
                        command.Parameters.AddWithValue("@forumName", forumName);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                forum = new Forum
                                {
                                    Id = reader.GetInt32("forum_id"),
                                    ForumName = "Name of forum: " + reader.GetString("forum_name"),
                                    Description = "Description: " + reader.GetString("forum_description"),
                                    CreatedAt = "Created: " + reader.GetDateTime("created_at").ToString(),
                                    CreatedBy = "Created by: " + reader.GetString("creator_username")
                                };
                                Logger.WriteLog("Successful load forum",false);
                                return forum;
                                
                            }

                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Logger.WriteLog(ex.Message, false);
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, false);
                MessageBox.Show(ex.Message);
            }
            return forum;
        }
        /// <summary>
        /// Loads comments for a forum into a ListBox control.
        /// </summary>
        /// <param name="listBoxComments">The ListBox control to load comments into.</param>
        /// <param name="forum">The forum for which comments are loaded.</param>
        public void LoadComments(ListBox listBoxComments, Forum forum)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT c.comment_id, c.comment_text, c.created_at, u.username AS commenter_username FROM comments c JOIN users u ON c.user_id = u.id_user WHERE c.forum_id = @forumId ORDER BY c.created_at DESC", connection))
                    {
                        command.Parameters.AddWithValue("@forumId", forum.Id);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Get comment details
                                int commentId = reader.GetInt32("comment_id");
                                string commentText = reader.GetString("comment_text");
                                DateTime createdAt = reader.GetDateTime("created_at");
                                string commenterUsername = reader.GetString("commenter_username");

                                // Format comment info
                                string commentInfo = $"[{createdAt}] {commenterUsername}: {commentText}";

                                // Add comment info along with its ID to the list box
                                listBoxComments.Items.Add(new CommentItem(commentId, commentInfo));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Logger.WriteLog(ex.Message, false);
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, false);
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// Posts a comment to a forum.
        /// </summary>
        /// <param name="currentUser">The user posting the comment.</param>
        /// <param name="commentText">The text of the comment.</param>
        /// <param name="listBoxComments">The ListBox control displaying comments.</param>
        /// <param name="textBoxComment">The TextBox control for entering comments.</param>
        /// <param name="forum">The forum to which the comment is posted.</param>
        /// <returns>True if the comment was successfully posted; otherwise, false.</returns>
        public bool commentFunction(User currentUser, string commentText, ListBox listBoxComments, TextBox textBoxComment, Forum forum)
        {
            bool result = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    string query = "INSERT INTO comments (forum_id, user_id, comment_text) VALUES (@forumId, @userId, @commentText)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@forumId", forum.Id);
                        command.Parameters.AddWithValue("@userId", currentUser.Id);
                        command.Parameters.AddWithValue("@commentText", commentText);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadComments(listBoxComments, forum);
                            result = true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Logger.WriteLog(ex.Message, false);
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, false);
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Deletes a comment from a forum.
        /// </summary>
        /// <param name="commentId">The ID of the comment to delete.</param>
        public void DeleteComment(int commentId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    string query = "DELETE FROM comments WHERE comment_id = @commentId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@commentId", commentId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Comment has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the comment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error communicating with the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message, false);
            }
        }

        /// <summary>
        /// Gets the author ID of a comment.
        /// </summary>
        /// <param name="commentId">The ID of the comment.</param>
        /// <returns>The ID of the comment's author.</returns>
        public int GetCommentAuthorId(int commentId)
        {
            int result = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    string query = "SELECT user_id FROM comments WHERE comment_id = @commentId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@commentId", commentId);

                        connection.Open();
                        object userID = command.ExecuteScalar();

                        if (result != null)
                        {
                            result = Convert.ToInt32(userID);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message, false);
            }
            return result;
        }

        /// <summary>
        /// Retrieves the user ID associated with a forum.
        /// </summary>
        /// <param name="forumId">The ID of the forum.</param>
        /// <returns>The user ID associated with the forum.</returns>
        public int GetUserIdByForumId(int forumId)
        {
            int userId = -1; // Default value indicating failure
            try
            {
                string query = "SELECT creator_user_id FROM forums WHERE forum_id = @ForumId";

                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ForumId", forumId);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exception
                Console.WriteLine("MySQL Error: " + ex.Message);
                Logger.WriteLog(ex.Message, false);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error: " + ex.Message);
                Logger.WriteLog(ex.Message, false);
            }

            return userId;
        }
    }
}
