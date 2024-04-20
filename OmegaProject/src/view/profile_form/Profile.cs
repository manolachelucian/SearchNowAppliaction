using SearchNow.src.controller.profile_controller;
using SearchNow.src.objects.ui_functions;
using SearchNow.src.objects.user;

namespace OmegaProject.src.profile_form
{
    /// <summary>
    /// Represents the profile form for displaying user information.
    /// </summary>
    public partial class Profile : Form
    {
        private User user;          // The user whose profile is being displayed.
        private UIUtilities uiUtilities; // Utility class for UI-related tasks.
        private ProfileController profileController;
        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        /// <param name="user">The user object whose profile is being displayed.</param>
        public Profile(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.profileController = new ProfileController();
            // Assigns the provided user object and initializes UIUtilities.
            this.user = user;
            this.uiUtilities = new UIUtilities();

            // Populates UI elements with user information.
            _labelDisplayName.Text = user.DisplayName;
            _labelUserName.Text = user.Username;
            _labelEmail.Text = user.Email;
            _labelCreatedAt.Text += user.CreatedAt;
            _labelRole.Text = user.Role;
            _labelAccountStatus.Text = user.AccountStatus;
            _bio.Text = user.Bio;

            // Registers event handler for the settings button.
            buttonSettings.Click += openSettingsForm;

            // Sets the color of the account status label based on the user's account status.
            statusColor();
        }

        //// <summary>
        /// Handles the click event of the button to update the user's biography.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void _updateBio_Click(object sender, EventArgs e)
        {
            // Updates the user's biography with the provided text.
            profileController.updateUserBio(user.Username, _bio.Text);

        }


        /// <summary>
        /// Sets the color of the account status label based on the current user status.
        /// </summary>
        private void statusColor()
        {
            // Retrieves the current account status of the user.
            string accountStatus = user.AccountStatus;

            // Sets the label color based on the account status.
            if (accountStatus.Equals("banned"))
            {
                // Sets the color to red if the account is banned.
                _labelAccountStatus.ForeColor = Color.Red;
            }
            else if (accountStatus.Equals("suspended"))
            {
                // Sets the color to orange if the account is suspended.
                _labelAccountStatus.ForeColor = Color.Orange;
            }
            // Additional conditions can be added for other account statuses if needed.
        }




        /// <summary>
        /// Opens the application settings form upon button click.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void openSettingsForm(object sender, EventArgs e)
        {
            // Calls the function to open the settings form using user utilities.
            uiUtilities.formDirectionFunction(this, buttonSettings, user);
        }



    }
}
