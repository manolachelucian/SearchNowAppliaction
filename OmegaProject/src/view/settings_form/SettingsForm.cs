using SearchNow.src.controller.settings_controller;
using SearchNow.src.objects.user;
using System;
using System.Windows.Forms;

namespace OmegaProject.src.settings_form
{
    /// <summary>
    /// Represents the settings form where users can update their account settings.
    /// </summary>
    public partial class SettingsForm : Form
    {
        private User user; // Current user accessing the settings
        private SettingsController settingsController; // Controller for handling settings operations

        /// <summary>
        /// Initializes a new instance of the SettingsForm class.
        /// </summary>
        /// <param name="user">The user accessing the settings.</param>
        public SettingsForm(User user)
        {
            // Initialize settings controller and set current user
            this.settingsController = new SettingsController();
            this.user = user;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Set form border style
        }

        /// <summary>
        /// Event handler for applying password changes.
        /// </summary>
        private void _passBtnApply_Click(object sender, EventArgs e)
        {
            settingsController.changePassword(current_password, new_password, user);
        }

        /// <summary>
        /// Event handler for applying email changes.
        /// </summary>
        private void _emailBtnApply_Click(object sender, EventArgs e)
        {
            settingsController.changeEmail(email_password, new_email, user);
        }

        /// <summary>
        /// Event handler for applying display name changes.
        /// </summary>
        private void _btnDisplayName_Click(object sender, EventArgs e)
        {
            settingsController.changeDisplayName(displayName_password, new_displayName, user);
        }
    }
}
