/// <summary>
/// The controller class responsible for managing user forums within the application.
/// </summary>
/// 
using MySql.Data.MySqlClient;
using SearchNow.src.model.user_forums_model;
using SearchNow.src.objects;
using SearchNow.src.objects.user;

namespace SearchNow.src.controller.user_forums_controller
{

    /// <summary>
    /// Controller class for user forums management.
    /// </summary>
    public class UserForumController
    {
        private UserForumsModel userForumModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForumController"/> class.
        /// </summary>
        public UserForumController()
        {
            this.userForumModel = new UserForumsModel();
        }

        /// <summary>
        /// Loads user forums into the provided DataGridView.
        /// </summary>
        /// <param name="user">The user whose forums need to be loaded.</param>
        /// <param name="dataGridView">The DataGridView control to display user forums.</param>
        public void LoadUserForums(User user, DataGridView dataGridView)
        {
            try
            {
                // Clear existing rows in the DataGridView
                dataGridView.Rows.Clear();

                // Define columns if not already defined
                if (dataGridView.Columns.Count == 0)
                {
                    dataGridView.Columns.Add("forum_name", "Forum Name");
                    dataGridView.Columns.Add("forum_description", "Forum Description");
                    dataGridView.Columns.Add("created_at", "Created At");
                }

                // Load user forums using the UserForumsModel
                userForumModel.LoadUserForums(user, dataGridView);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error communicating with the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message + ex.StackTrace, true); // Assuming Logger is a custom logging utility
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message + ex.StackTrace, true); // Assuming Logger is a custom logging utility
            }
        }

        /// <summary>
        /// Deletes the selected forum from the provided DataGridView.
        /// </summary>
        /// <param name="dataGridView">The DataGridView control containing user forums.</param>
        /// <param name="user">The user whose forum is to be deleted.</param>
        public void DeleteForum(DataGridView dataGridView, User user)
        {
            try
            {
                // Check if a forum is selected
                if (dataGridView.SelectedRows.Count > 0)
                {
                    // Check if forum_name cell value is not null
                    if (dataGridView.SelectedRows[0].Cells["forum_name"].Value != null)
                    {
                        string forumName = dataGridView.SelectedRows[0].Cells["forum_name"].Value.ToString();

                        // Prompt the user for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this forum?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Attempt to delete the forum using UserForumsModel
                            if (userForumModel.DeleteForum(forumName, user.Id))
                            {
                                // Reload user forums after successful deletion
                                LoadUserForums(user, dataGridView);
                                MessageBox.Show("Forum deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the forum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a forum to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error communicating with the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message + ex.StackTrace, true); // Assuming Logger is a custom logging utility
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + ex.StackTrace, true); // Assuming Logger is a custom logging utility
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
