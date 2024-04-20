using SearchNow.src.model.user_forums_functions;

namespace SearchNow.src.user_forums_form
{
    public partial class User_forums : Form
    {
        private UserForumsFunctions userForumsFunctions;
        

        public User_forums(UserForumsFunctions userForumsFunctions)
        {
            InitializeComponent();
            this.userForumsFunctions = userForumsFunctions;
           

            // Load user forums and bind to DataGridView
            userForumsFunctions.LoadMyForums(dataGridView);

            // Attach event handler for delete button click
            deleteForumButton.Click += deleteFormClick;
        }

        private void deleteFormClick(object sender, EventArgs e)
        {
            // Call the method to handle delete forum action
            userForumsFunctions.ButtonDeleteForum_Click(dataGridView);
        }



    }
}
