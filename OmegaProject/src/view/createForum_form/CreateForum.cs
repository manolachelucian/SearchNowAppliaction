using SearchNow.src.controller.CreateForum_controler;
using SearchNow.src.objects.user;

namespace SearchNow.src.createForum_form
{
    /// <summary>
    /// Represents the form for creating a new forum.
    /// </summary>
    public partial class CreateForum : Form
    {
        private User user;
        private CreateForumController createForumController;

        /// <summary>
        /// Initializes a new instance of the CreateForum class.
        /// </summary>
        /// <param name="user">The user creating the forum.</param>
        public CreateForum(User user)
        {
            this.createForumController = new CreateForumController();
            this.user = user;
            InitializeComponent();
            buttonCreateForum.Click += btnCreateForum_Click;
        }

        /// <summary>
        /// Event handler for creating a new forum.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnCreateForum_Click(object sender, EventArgs e)
        {
            string forumName = textBoxForumName.Text;

            if (!string.IsNullOrWhiteSpace(forumName))
            {
                createForumController.createForum(textBoxForumName, textBoxDescription, user);
            }
            else
            {
                MessageBox.Show("Forum name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
