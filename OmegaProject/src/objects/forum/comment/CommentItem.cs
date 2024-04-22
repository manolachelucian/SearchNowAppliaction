namespace SearchNow.src.objects.forum.comment
{
    /// <summary>
    /// Represents a comment item in a forum.
    /// </summary>
    public class CommentItem
    {
        /// <summary>
        /// Gets or sets the unique identifier of the comment.
        /// </summary>
        public int CommentId { get; set; }

        /// <summary>
        /// Gets or sets the content of the comment.
        /// </summary>
        public string CommentInfo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentItem"/> class with the specified comment identifier and content.
        /// </summary>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="commentInfo">The content of the comment.</param>
        public CommentItem(int commentId, string commentInfo)
        {
            CommentId = commentId;
            CommentInfo = commentInfo;
        }

        /// <summary>
        /// Returns a string representation of the comment item.
        /// </summary>
        /// <returns>A string representing the content of the comment.</returns>
        public override string ToString()
        {
            return CommentInfo;
        }
    }
}
