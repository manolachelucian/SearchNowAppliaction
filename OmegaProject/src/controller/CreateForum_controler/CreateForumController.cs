using SearchNow.src.model.createForum_model;
using SearchNow.src.objects.user;

namespace SearchNow.src.controller.CreateForum_controler
{
    public class CreateForumController
    {
        private CreateForumModel createForumModel;

        public CreateForumController()
        {
            createForumModel = new CreateForumModel();
        }


        public void createForum(TextBox _forumName,TextBox _forumDescription, User currentUser)
        {
            string forumName = _forumName.Text;
            string forumDescription = _forumDescription.Text;

            if (createForumModel.createForum(forumName,forumDescription,currentUser) == true)
            {
                MessageBox.Show("Forum created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _forumName.Clear();
                _forumDescription.Clear();
            }
            else
            {
                MessageBox.Show("Failed to create forum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
