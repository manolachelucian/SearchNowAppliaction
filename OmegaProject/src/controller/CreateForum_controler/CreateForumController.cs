using SearchNow.src.model.createForum_model;
using SearchNow.src.objects.user;

namespace SearchNow.src.controller.CreateForum_controler
{
    /// <summary>
    /// Controller class responsible for creating forums.
    /// </summary>
    public class CreateForumController
    {
        private CreateForumModel createForumModel; // Instance of CreateForumModel for forum creation.

        /// <summary>
        /// Constructor for CreateForumController class. Initializes CreateForumModel instance.
        /// </summary>
        public CreateForumController()
        {
            createForumModel = new CreateForumModel(); // Initialize CreateForumModel instance.
        }

        /// <summary>
        /// Creates a forum with the given name, description, and current user.
        /// </summary>
        /// <param name="_forumName">TextBox containing the forum name.</param>
        /// <param name="_forumDescription">TextBox containing the forum description.</param>
        /// <param name="currentUser">User object representing the current user creating the forum.</param>
        public void createForum(TextBox _forumName, TextBox _forumDescription, User currentUser)
        {
            string forumName = _forumName.Text; // Get forum name from TextBox input.
            string forumDescription = _forumDescription.Text; // Get forum description from TextBox input.

            if (createForumModel.createForum(forumName, forumDescription, currentUser))
            {
                MessageBox.Show("Forum created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _forumName.Clear(); // Clear forum name TextBox input.
                _forumDescription.Clear(); // Clear forum description TextBox input.
            }
            else
            {
                MessageBox.Show("Failed to create forum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
