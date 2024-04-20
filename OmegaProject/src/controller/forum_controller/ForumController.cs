using SearchNow.src.model.forum_model;
using SearchNow.src.objects.forum;
using SearchNow.src.objects.forum.comment;
using SearchNow.src.objects.user;

namespace SearchNow.src.controller.forum_controller
{
    public class ForumController
    {
        private ForumModel forumModel;
        private Forum forum = null;

        public ForumController()
        {
            this.forumModel = new ForumModel();
        }


        public void LoadForum(string forumName, Label _labelForumName, Label _labelDescription, Label _labelCreatedAt,Label _labelCreatedBy,ListBox commentBox) {
            
            try
            {
                forum = forumModel.GetLoadForumDetails(forumName);
                _labelForumName.Text = forum.ForumName;
                _labelDescription.Text = forum.Description;
                _labelCreatedAt.Text = forum.CreatedAt;
                _labelCreatedBy.Text = forum.CreatedBy;

                
                forumModel.LoadComments(commentBox, forum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AddComment( User currentUser, ListBox commentList,TextBox commentBox)
        {
            if (!string.IsNullOrWhiteSpace(commentBox.Text))
            {
                // Add the comment to the database
                bool success = forumModel.commentFunction(currentUser, commentBox.Text, commentList, commentBox, forum);

                if (success)
                {
                    // Refresh the comment list
                    commentList.Items.Clear();
                    forumModel.LoadComments(commentList, forum);

                    // Clear the comment textbox
                    commentBox.Clear();

                    MessageBox.Show("Comment has been successfully added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add comment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter text! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        public void DeleteButtonFun(ListBox commentsBox,User currentUser)
        {
            // Check if a comment is selected
            if (commentsBox.SelectedIndex != -1)
            {
                // Get the selected comment's index and extract its ID
                CommentItem selectedComment = (CommentItem)commentsBox.SelectedItem;
                int commentId = selectedComment.CommentId;


                if (forumModel.GetCommentAuthorId(commentId) == currentUser.Id)
                {
                    // Call the delete comment method
                    forumModel.DeleteComment(commentId);

                    // Refresh the comment list
                    commentsBox.Items.Clear();
                    forumModel.LoadComments(commentsBox, forum);
                }
                else
                {
                    MessageBox.Show("You cant delete others comment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a comment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
