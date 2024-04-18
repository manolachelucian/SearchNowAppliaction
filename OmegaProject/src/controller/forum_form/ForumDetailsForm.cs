using MySql.Data.MySqlClient;
using SearchNow.src.model.user_class;

namespace OmegaProject.src.forum_form
{
    public partial class ForumDetailsForm : Form
    {
        
        private string connectionString;
        private int forumId; // Store the ID of the current forum
        private User currentUser; // Store information about the current user

        public ForumDetailsForm(string forumName, string connection, User user)
        {
            this.connectionString = connection;
            this.currentUser = user;
            InitializeComponent();
            LoadForumDetails(forumName);
            LoadComments();
            
        }

        private void LoadForumDetails(string forumName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT f.forum_id, f.forum_name, f.forum_description, f.created_at, u.username AS creator_username FROM forums f JOIN users u ON f.creator_user_id = u.id_user WHERE f.forum_name = @forumName", connection))
                    {
                        command.Parameters.AddWithValue("@forumName", forumName);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store the forum ID for later use
                                forumId = reader.GetInt32("forum_id");

                                // Display forum details
                                labelForumName.Text = "Název fóra: " + reader.GetString("forum_name");
                                labelDescription.Text = "Popis fóra: " + reader.GetString("forum_description");
                                labelCreatedAt.Text = "Vytvořeno: " + reader.GetDateTime("created_at").ToString();
                                labelCreatedBy.Text = "Vytvořil: " + reader.GetString("creator_username");
                            }
                            else
                            {
                                MessageBox.Show("Fórum nenalezeno.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chyba při komunikaci s databází: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba: " + ex.Message);
            }
        }

        private void LoadComments()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT c.comment_text, c.created_at, u.username AS commenter_username FROM comments c JOIN users u ON c.user_id = u.id_user WHERE c.forum_id = @forumId", connection))
                    {
                        command.Parameters.AddWithValue("@forumId", forumId);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Display comments
                                string commentText = reader.GetString("comment_text");
                                DateTime createdAt = reader.GetDateTime("created_at");
                                string commenterUsername = reader.GetString("commenter_username");

                                string commentInfo = $"[{createdAt}] {commenterUsername}: {commentText}";
                                listBoxComments.Items.Add(commentInfo);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Chyba při komunikaci s databází: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba: " + ex.Message);
            }
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string commentText = textBoxComment.Text;

            if (!string.IsNullOrWhiteSpace(commentText))
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = "INSERT INTO comments (forum_id, user_id, comment_text) VALUES (@forumId, @userId, @commentText)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@forumId", forumId);
                            command.Parameters.AddWithValue("@userId", currentUser.GetUserId());
                            command.Parameters.AddWithValue("@commentText", commentText);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Komentář byl úspěšně přidán.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Clear the comment textbox and reload comments
                                textBoxComment.Clear();
                                listBoxComments.Items.Clear();
                                LoadComments();
                            }
                            else
                            {
                                MessageBox.Show("Nepodařilo se přidat komentář.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Chyba při komunikaci s databází: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Prosím, zadejte text komentáře.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       

    }
}

