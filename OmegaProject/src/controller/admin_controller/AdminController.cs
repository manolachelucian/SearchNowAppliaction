using SearchNow.src.model.admin_model;
using SearchNow.src.model.user_model;
using SearchNow.src.model.validation_model;

namespace SearchNow.src.controller.admin_controller
{
    /// <summary>
    /// Controller class responsible for handling administrative actions.
    /// </summary>
    public class AdminController
    {
        private AdminModel adminModel; // Instance of AdminModel for administrative operations.
        private ValidationModel validationModel; // Instance of ValidationModel for input validation.
        private UserModel userModel; // Instance of UserModel for user-related operations.

        /// <summary>
        /// Constructor for AdminController class.
        /// </summary>
        public AdminController()
        {
            adminModel = new AdminModel(); // Initialize AdminModel instance.
            validationModel = new ValidationModel(); // Initialize ValidationModel instance.
            userModel = new UserModel(); // Initialize UserModel instance.
        }

        /// <summary>
        /// Unban a user based on their username.
        /// </summary>
        /// <param name="_bannedUsername">TextBox containing the banned username.</param>
        public void unBanUser(TextBox _bannedUsername)
        {
            string bannedUsername = _bannedUsername.Text; // Get banned username from TextBox input.
            try
            {
                if (validationModel.usernameInUse(bannedUsername))
                {
                    adminModel.unBanUser(bannedUsername); // Unban the user.
                    MessageBox.Show(bannedUsername + " has been unbanned!", "Unban Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _bannedUsername.Clear(); // Clear TextBox input.
                }
                else
                {
                    MessageBox.Show("User has not been found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ban or suspend a user based on selected action.
        /// </summary>
        /// <param name="_bannedUsername">TextBox containing the username to be banned or suspended.</param>
        /// <param name="suspendRadio">RadioButton indicating suspension action.</param>
        /// <param name="banRadio">RadioButton indicating ban action.</param>
        public void banOrSuspendUser(TextBox _bannedUsername, RadioButton suspendRadio, RadioButton banRadio)
        {
            string bannedUsername = _bannedUsername.Text; // Get banned username from TextBox input.
            try
            {
                if (validationModel.usernameInUse(bannedUsername))
                {
                    if (userModel.getStatusFromUser(bannedUsername))
                    {
                        if (suspendRadio.Checked)
                        {
                            adminModel.suspendUser(bannedUsername); // Suspend the user.
                            MessageBox.Show(bannedUsername + " has been suspended!", "Suspend Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _bannedUsername.Clear(); // Clear TextBox input.
                            suspendRadio.Checked = false; // Uncheck RadioButton.
                        }
                        else if (banRadio.Checked)
                        {
                            adminModel.banUser(bannedUsername); // Ban the user.
                            MessageBox.Show(bannedUsername + " has been banned!", "Ban Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _bannedUsername.Clear(); // Clear TextBox input.
                            banRadio.Checked = false; // Uncheck RadioButton.
                        }
                        else
                        {
                            MessageBox.Show("Choose what type of ban", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot ban or suspend an admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("User has not been found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
