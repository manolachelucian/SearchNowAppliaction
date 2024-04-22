using SearchNow.src.controller.forum_controller;
using SearchNow.src.objects.user;

namespace OmegaProject.src.forum_form
{
    /// <summary>
    /// Represents the form for displaying forum details.
    /// </summary>
    public partial class ForumDetailsForm : Form
    {
        private User currentUser;
        private ForumController forumController;

        /// <summary>
        /// Initializes a new instance of the ForumDetailsForm class.
        /// </summary>
        /// <param name="forumName">The name of the forum.</param>
        /// <param name="user">The current user.</param>
        public ForumDetailsForm(string forumName, User user)
        {
            this.currentUser = user;
            this.forumController = new ForumController();

            InitializeComponent();

            forumController.LoadForum(forumName, labelForumName, labelDescription, labelCreatedAt, labelCreatedBy, listBoxComments);

            deleteButton.Click += btnDeleteComment_Click;
        }

        /// <summary>
        /// Event handler for deleting a comment.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            forumController.DeleteButtonFun(listBoxComments, currentUser);
        }

        /// <summary>
        /// Event handler for adding a comment.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            forumController.AddComment(currentUser, listBoxComments, textBoxComment);
        }
    }
}
