using SearchNow.src.model.user_model;
using SearchNow.src.model.validation_model;
using SearchNow.src.objects.check_functions;
using User = SearchNow.src.objects.user.User;


namespace SearchNow.src.controller.settings_controller
{
    public class SettingsController
    {

        private UserModel userModel;
        private HashHelper hashHelper;
        private CheckFunctions checkFunctions;
        private ValidationModel validationModel;
        public SettingsController() {
            validationModel = new ValidationModel();
            hashHelper = new HashHelper();
            checkFunctions = new CheckFunctions();
            userModel = new UserModel();    
            
        }


        public void changePassword(TextBox _currentPassword,TextBox _newPassword,User user)
        {
            string currentPassword = _currentPassword.Text;
            string newPassword = _newPassword.Text;
            try
            {
                
                if (hashHelper.ComputeSha256Hash(currentPassword) == user.Password)
                {

                    if (newPassword == currentPassword)
                    {
                        MessageBox.Show("New password is same as old password"); 
                    }
                    else
                    {

                        if (checkFunctions.IsStrongPassword(newPassword))
                        {
                            
                            userModel.UpdatePassword(user.Username, newPassword);
                            MessageBox.Show("Password has been successfully updated"); 
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
                MessageBox.Show(ex.Message);
            }
        }

        public void changeEmail(TextBox _currentPassword,TextBox _newEmail,User user)
        {
            string currentPassword = _currentPassword.Text;
            string newEmail = _newEmail.Text;
            try
            {
                if (hashHelper.ComputeSha256Hash(currentPassword) == user.Password)
                {
                    if (newEmail == user.Password)
                    {
                        MessageBox.Show("E-mail is same as old");
                    }

                    else
                    {
                        if (checkFunctions.emailCheck(newEmail) == true)
                        {
                            if (validationModel.isEmailAvailable(newEmail) == true)
                            {
                                MessageBox.Show("Email is already in use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                
                            }
                            else
                            {
                                userModel.UpdateEmail(user.Username, newEmail);
                                MessageBox.Show("Email has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                _currentPassword.Clear();
                                _newEmail.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong format of e-mail");
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
                MessageBox.Show("Error with changing e-mail" + ex.Message);
            }
        }


        public void changeDisplayName(TextBox _currentPassword,TextBox _newDisplayName, User user)
        {
            string currentPassword = _currentPassword.Text;
            string newDisplayName = _newDisplayName.Text;
            try
            {

                if (hashHelper.ComputeSha256Hash(currentPassword) == user.Password)
                {
                    if (newDisplayName == user.DisplayName)
                    {
                        MessageBox.Show("This Display name is same as old");
                    }
                    else
                    {
                        userModel.UpdateUserDisplayName(user.Username, newDisplayName);
                        MessageBox.Show("Your name has updated successfully");
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
                MessageBox.Show(ex.Message);
            }

        }


    }
}
