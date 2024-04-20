using MySql.Data.MySqlClient;
using SearchNow.src.objects.forum;
using SearchNow.src.objects.forum.comment;
using SearchNow.src.objects.user;

namespace SearchNow.src.model.forum_model
{
    public class ForumModel
    {

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
                                    ForumName = "Název fóra: " + reader.GetString("forum_name"),
                                    Description = "Popis fóra: " + reader.GetString("forum_description"),
                                    CreatedAt = "Vytvořeno: " + reader.GetDateTime("created_at").ToString(),
                                    CreatedBy = "Vytvořil: " + reader.GetString("creator_username")
                                };

                                return forum;
                            }

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
            return forum;
        }

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
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




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
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

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
                            MessageBox.Show("Komentář byl úspěšně smazán.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nepodařilo se smazat komentář.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chyba při komunikaci s databází: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }




    }
}
