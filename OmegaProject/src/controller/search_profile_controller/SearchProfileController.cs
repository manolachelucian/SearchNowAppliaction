using SearchNow.src.model.user_model;
using SearchNow.src.objects.user;
using System.Windows.Forms;

namespace SearchNow.src.controller.search_profile_controller
{
    /// <summary>
    /// Controller class responsible for handling operations related to searching and loading user profiles.
    /// </summary>
    public class SearchProfileController
    {
        private UserModel userModel;
        private User user;

        /// <summary>
        /// Initializes a new instance of the SearchProfileController class.
        /// </summary>
        public SearchProfileController()
        {
            // Initialize UserModel instance
            this.userModel = new UserModel();
        }

        /// <summary>
        /// Loads the profile details of a user based on the provided username.
        /// </summary>
        /// <param name="searchProfileName">The username of the profile to load.</param>
        /// <param name="username">The label to display the username.</param>
        /// <param name="displayName">The label to display the display name.</param>
        /// <param name="email">The label to display the email address.</param>
        /// <param name="birth">The label to display the birth date.</param>
        /// <param name="status">The label to display the account status.</param>
        /// <param name="bio">The label to display the biography.</param>
        public void loadProfile(string searchProfileName, Label username, Label displayName, Label email, Label birth, Label status, Label bio)
        {
            // Retrieve user details based on the provided username
            user = userModel.GetUser(searchProfileName);

            // Populate UI labels with user profile details
            if (user != null)
            {
                username.Text = user.Username;
                displayName.Text = user.DisplayName;
                email.Text = user.Email;
                birth.Text = user.CreatedAt.ToString();
                status.Text = user.AccountStatus;
                bio.Text = user.Bio;
            }
            else
            {
                // If user is not found, clear the labels
                username.Text = string.Empty;
                displayName.Text = string.Empty;
                email.Text = string.Empty;
                birth.Text = string.Empty;
                status.Text = string.Empty;
                bio.Text = string.Empty;
            }
        }
    }
}
