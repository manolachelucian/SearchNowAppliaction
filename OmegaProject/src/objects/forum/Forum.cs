namespace SearchNow.src.objects.forum
{
    /// <summary>
    /// Represents a forum.
    /// </summary>
    public class Forum
    {
        /// <summary>
        /// Gets or sets the unique identifier of the forum.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the forum.
        /// </summary>
        public string ForumName { get; set; }

        /// <summary>
        /// Gets or sets the description of the forum.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time of the forum.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who created the forum.
        /// </summary>
        public string CreatedBy { get; set; }
    }
}
