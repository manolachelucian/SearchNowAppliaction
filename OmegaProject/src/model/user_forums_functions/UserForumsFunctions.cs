using MySql.Data.MySqlClient;
using SearchNow.src.objects.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchNow.src.model.user_forums_functions
{
    public class UserForumsFunctions
    {
        private User user;
        public UserForumsFunctions(User user)
        {
            this.user = user;
        }

        public void LoadMyForums(DataGridView dataGridView)
        {
            // Clear existing rows
            dataGridView.Rows.Clear();

            // Define columns if not already defined
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("forum_name", "Forum Name");
                dataGridView.Columns.Add("forum_description", "Forum Description");
                dataGridView.Columns.Add("created_at", "Created At");
            }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ButtonDeleteForum_Click(DataGridView dataGridView)
        {
            // Check if a forum is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the name of the selected forum
                string forumName = dataGridView.SelectedRows[0].Cells["forum_name"].Value.ToString();

                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this forum?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Attempt to delete the forum
                    if (DeleteForum(forumName))
                    {
                        MessageBox.Show("Forum deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the DataGridView after deletion
                        LoadMyForums(dataGridView);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the forum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a forum to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteForum(string forumName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    string query = "DELETE FROM forums WHERE forum_name = @forumName";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@forumName", forumName);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error communicating with the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
