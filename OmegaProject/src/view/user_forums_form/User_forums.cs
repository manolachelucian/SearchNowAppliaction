using SearchNow.src.controller.user_forums_controller;
using SearchNow.src.objects.user;

namespace SearchNow.src.user_forums_form
{
    /// <summary>
    /// Form for displaying and managing user forums.
    /// </summary>
    public partial class User_forums : Form
    {
        private UserForumController userForumController;
        private User currentUser;

        /// <summary>
        /// Initializes a new instance of the <see cref="User_forums"/> class.
        /// </summary>
        /// <param name="user">The current user.</param>
        public User_forums(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.userForumController = new UserForumController();
            LoadUserForums();

            // Attach event handler for delete button click
            deleteForumButton.Click += DeleteForumButtonClick;
        }

        /// <summary>
        /// Event handler for the delete forum button click event.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DeleteForumButtonClick(object sender, EventArgs e)
        {
            userForumController.DeleteForum(userFormsGrid, currentUser);
        }


        /// <summary>
        /// Loads user forums into the DataGridView control.
        /// </summary>
        private void LoadUserForums()
        {
            userForumController.LoadUserForums(currentUser, userFormsGrid);
        }

    }
}
