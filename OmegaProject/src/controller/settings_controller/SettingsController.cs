
using SearchNow.src.model.user_model;
using SearchNow.src.model.validation_model;
using SearchNow.src.objects;
using SearchNow.src.objects.check_functions;
using User = SearchNow.src.objects.user.User;

namespace SearchNow.src.controller.settings_controller
{
    /// <summary>
    /// Controller class responsible for managing user settings.
    /// </summary>
    public class SettingsController
    {
        private UserModel userModel; // Instance of UserModel for user-related operations.
        private HashHelper hashHelper; // Instance of HashHelper for password hashing.
        private CheckFunctions checkFunctions; // Instance of CheckFunctions for checking password strength and email format.
        private ValidationModel validationModel; // Instance of ValidationModel for validation operations.

        /// <summary>
        /// Constructor for SettingsController class. Initializes required models and helpers.
        /// </summary>
        public SettingsController()
        {
            validationModel = new ValidationModel(); // Initialize ValidationModel instance.
            hashHelper = new HashHelper(); // Initialize HashHelper instance.
            checkFunctions = new CheckFunctions(); // Initialize CheckFunctions instance.
            userModel = new UserModel(); // Initialize UserModel instance.
        }

        /// <summary>
        /// Changes the user's password.
        /// </summary>
        /// <param name="_currentPassword">TextBox containing the current password.</param>
        /// <param name="_newPassword">TextBox containing the new password.</param>
        /// <param name="user">User whose password is being changed.</param>
        public void changePassword(TextBox _currentPassword, TextBox _newPassword, User user)
        {
            string currentPassword = _currentPassword.Text;
            string newPassword = _newPassword.Text;
            try
            {
                if (hashHelper.ComputeSha256Hash(currentPassword) == user.Password)
                {
                    if (newPassword == currentPassword)
                    {
                        MessageBox.Show("New password is the same as the old password");
                    }
                    else
                    {
                        if (checkFunctions.IsStrongPassword(newPassword))
                        {
                            userModel.UpdatePassword(user.Username, newPassword);
                            MessageBox.Show("Password has been successfully updated");
                            user.Password = newPassword;
                            _currentPassword.Clear();
                            _newPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Weak password... must have at least 6 characters, including at least one uppercase letter, one lowercase letter, and one digit");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + ex.StackTrace, true);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Changes the user's email address.
        /// </summary>
        /// <param name="_currentPassword">TextBox containing the current password.</param>
        /// <param name="_newEmail">TextBox containing the new email address.</param>
        /// <param name="user">User whose email address is being changed.</param>
        public void changeEmail(TextBox _currentPassword, TextBox _newEmail, User user)
        {
            string currentPassword = _currentPassword.Text;
            string newEmail = _newEmail.Text;
            try
            {
                if (hashHelper.ComputeSha256Hash(currentPassword) == user.Password)
                {
                    if (newEmail == user.Password)
                    {
                        MessageBox.Show("Email is the same as the old one");
                    }
                    else
                    {
                        if (checkFunctions.emailCheck(newEmail))
                        {
                            if (validationModel.isEmailAvailable(newEmail))
                            {
                                MessageBox.Show("Email is already in use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                userModel.UpdateEmail(user.Username, newEmail);
                                MessageBox.Show("Email has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                user.Email = newEmail;
                                _currentPassword.Clear();
                                _newEmail.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong format of email");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + ex.StackTrace, true);
                MessageBox.Show("Error with changing email" + ex.Message);
            }
        }

        /// <summary>
        /// Changes the user's display name.
        /// </summary>
        /// <param name="_currentPassword">TextBox containing the current password.</param>
        /// <param name="_newDisplayName">TextBox containing the new display name.</param>
        /// <param name="user">User whose display name is being changed.</param>
        public void changeDisplayName(TextBox _currentPassword, TextBox _newDisplayName, User user)
        {
            string currentPassword = _currentPassword.Text;
            string newDisplayName = _newDisplayName.Text;
            try
            {
                if (hashHelper.ComputeSha256Hash(currentPassword) == user.Password)
                {
                    if (newDisplayName == user.DisplayName)
                    {
                        MessageBox.Show("This display name is the same as the old one");
                    }
                    else
                    {
                        userModel.UpdateUserDisplayName(user.Username, newDisplayName);
                        MessageBox.Show("Your name has been updated successfully");
                        user.DisplayName = newDisplayName;
                        _currentPassword.Clear();
                        _newDisplayName.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password", "Password Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message+ex.StackTrace,true);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
