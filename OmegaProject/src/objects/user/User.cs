namespace SearchNow.src.objects.user
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user account was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the biography of the user.
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// Gets or sets the role of the user (e.g., admin, moderator, regular user).
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets the account status of the user (e.g., active, suspended, banned).
        /// </summary>
        public string AccountStatus { get; set; }
    }
}
