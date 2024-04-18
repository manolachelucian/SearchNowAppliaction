using MySql.Data.MySqlClient;
using SearchNow.src.model.user_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchNow.src.createForum_form
{
    public partial class CreateForum : Form
    {
        private User user;
        
        

        public CreateForum(User user)
        {
            this.user = user;
            InitializeComponent();
            buttonCreateForum.Click += btnCreateForum_Click;
        }
        private void btnCreateForum_Click(object sender, EventArgs e)
        {
            string forumName = textBoxForumName.Text;
            string forumDescription = textBoxDescription.Text;

            if (!string.IsNullOrWhiteSpace(forumName))
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                    {
                        using (MySqlCommand command = new MySqlCommand("createForum", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@p_forum_name", forumName);
                            command.Parameters.AddWithValue("@p_forum_description", forumDescription);
                            command.Parameters.AddWithValue("@p_creator_user_id", user.GetUserId());

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Forum created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to create forum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Forum name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
    }
}
