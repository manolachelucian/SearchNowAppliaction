
using SearchNow.src.controller.notification_controller;
using SearchNow.src.model.forum_model;
using SearchNow.src.objects;
using SearchNow.src.objects.forum;
using SearchNow.src.objects.forum.comment;
using SearchNow.src.objects.user;


namespace SearchNow.src.controller.forum_controller
{
    /// <summary>
    /// Controller class responsible for managing forum-related actions.
    /// </summary>
    public class ForumController
    {
        private ForumModel forumModel; // Instance of ForumModel for forum operations.
        private Forum forum = null; // Current forum being managed.
        private NotificationController notificationController; // Instance of NotificationController for handling notifications.

        /// <summary>
        /// Constructor for ForumController class. Initializes required models.
        /// </summary>
        public ForumController()
        {
            this.notificationController = new NotificationController(); // Initialize NotificationController instance.
            this.forumModel = new ForumModel(); // Initialize ForumModel instance.
        }

        /// <summary>
        /// Loads forum details and comments into UI elements.
        /// </summary>
        /// <param name="forumName">Name of the forum to load.</param>
        /// <param name="_labelForumName">Label to display forum name.</param>
        /// <param name="_labelDescription">Label to display forum description.</param>
        /// <param name="_labelCreatedAt">Label to display forum creation timestamp.</param>
        /// <param name="_labelCreatedBy">Label to display forum creator.</param>
        /// <param name="commentBox">ListBox to display comments.</param>
        public void LoadForum(string forumName, Label _labelForumName, Label _labelDescription, Label _labelCreatedAt, Label _labelCreatedBy, ListBox commentBox)
        {
            try
            {
                forum = forumModel.GetLoadForumDetails(forumName); // Load forum details.
                _labelForumName.Text = forum.ForumName;
                _labelDescription.Text = forum.Description;
                _labelCreatedAt.Text = forum.CreatedAt;
                _labelCreatedBy.Text = forum.CreatedBy;

                forumModel.LoadComments(commentBox, forum); // Load comments associated with the forum.
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }

        /// <summary>
        /// Adds a comment to the forum.
        /// </summary>
        /// <param name="currentUser">Current user adding the comment.</param>
        /// <param name="commentList">ListBox displaying comments.</param>
        /// <param name="commentBox">TextBox containing the comment text.</param>
        public void AddComment(User currentUser, ListBox commentList, TextBox commentBox)
        {
            try
            {
                string commentText = commentBox.Text;
                if (!string.IsNullOrWhiteSpace(commentText))
                {
                    // Add the comment to the database
                    bool success = forumModel.commentFunction(currentUser, commentText, commentList, commentBox, forum);

                    if (success)
                    {
                        // Refresh the comment list
                        commentList.Items.Clear();
                        forumModel.LoadComments(commentList, forum);

                        // Clear the comment textbox
                        commentBox.Clear();
                        MessageBox.Show("Comment has been successfully added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int ownerId = forumModel.GetUserIdByForumId(forum.Id);
                        // Send notification if the commenter is not the forum creator
                        if (currentUser.Id != ownerId)
                        {
                            notificationController.SendNotification(ownerId, currentUser.Id, commentText);
                        }
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
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }

        /// <summary>
        /// Deletes a comment from the forum.
        /// </summary>
        /// <param name="commentsBox">ListBox displaying comments.</param>
        /// <param name="currentUser">Current user attempting to delete the comment.</param>
        public void DeleteButtonFun(ListBox commentsBox, User currentUser)
        {
            try
            {
                // Check if a comment is selected
                if (commentsBox.SelectedIndex != -1)
                {
                    // Get the selected comment's index and extract its ID
                    CommentItem selectedComment = (CommentItem)commentsBox.SelectedItem;
                    int commentId = selectedComment.CommentId;

                    // Check if the current user has permission to delete the comment
                    if (forumModel.GetCommentAuthorId(commentId) == currentUser.Id || forumModel.GetUserIdByForumId(forum.Id) == currentUser.Id || currentUser.Role.Equals("admin"))
                    {
                        // Call the delete comment method
                        forumModel.DeleteComment(commentId);

                        // Refresh the comment list
                        commentsBox.Items.Clear();
                        forumModel.LoadComments(commentsBox, forum);
                    }
                    else
                    {
                        MessageBox.Show("You can't delete others' comments", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a comment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }
    }
}
