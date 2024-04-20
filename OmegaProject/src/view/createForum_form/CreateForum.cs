using SearchNow.src.controller.CreateForum_controler;
using SearchNow.src.objects.user;

namespace SearchNow.src.createForum_form
{
    public partial class CreateForum : Form
    {
        private User user;
        private CreateForumController createForumController;
        public CreateForum(User user)
        {
            this.createForumController = new CreateForumController();
            this.user = user;
            InitializeComponent();
            buttonCreateForum.Click += btnCreateForum_Click;
        }
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
