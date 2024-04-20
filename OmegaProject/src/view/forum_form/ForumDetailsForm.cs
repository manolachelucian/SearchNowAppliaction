using SearchNow.src.controller.forum_controller;
using SearchNow.src.objects.forum.comment;
using SearchNow.src.objects.user;

namespace OmegaProject.src.forum_form
{
    public partial class ForumDetailsForm : Form
    {
        private User currentUser;
        private ForumController forumController;
        public ForumDetailsForm(string forumName, User user)
        {
            this.currentUser = user;
            this.forumController = new ForumController();
            
            InitializeComponent();

            forumController.LoadForum(forumName, labelForumName, labelDescription, labelCreatedAt,labelCreatedBy,listBoxComments);
            
            deleteButton.Click += btnDeleteComment_Click;
            
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            forumController.DeleteButtonFun(listBoxComments,currentUser);
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            forumController.AddComment(currentUser, listBoxComments,textBoxComment);
        }
       

    }
}

