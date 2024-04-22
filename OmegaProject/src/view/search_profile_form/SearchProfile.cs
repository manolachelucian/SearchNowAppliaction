using SearchNow.src.controller.search_profile_controller;

namespace SearchNow.src.controller.search_profile_form
{
    /// <summary>
    /// Form for displaying the profile details of a searched user.
    /// </summary>
    public partial class SearchProfile : Form
    {
        private SearchProfileController searchProfileController;
        private string searchProfileName;

        /// <summary>
        /// Initializes a new instance of the SearchProfile form.
        /// </summary>
        /// <param name="searchProfileName">The username of the profile to display.</param>
        public SearchProfile(string searchProfileName)
        {
            // Initialize SearchProfileController instance
            this.searchProfileController = new SearchProfileController();
            InitializeComponent();

            // Set the username of the profile to display
            this.searchProfileName = searchProfileName;

            // Load the profile details of the searched user
            LoadSearchedProfile();
        }

        /// <summary>
        /// Loads the profile details of the searched user.
        /// </summary>
        private void LoadSearchedProfile()
        {
            // Call the loadProfile method of SearchProfileController to populate the UI labels with user profile details
            searchProfileController.loadProfile(searchProfileName, username, displayname, email, birth, status, bio);
        }
    }
}
