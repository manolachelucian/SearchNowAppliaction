using MySql.Data.MySqlClient;
using SearchNow.src.model.check_functions;
using SearchNow.src.model.user_class;
using SearchNow.src.model.validation_functions;

namespace OmegaProject.src.settings_form
{
    public partial class SettingsForm : Form
    {
        private string username;
        private string storedPassword;
        private User user;
        private CheckFunctions checkFunctions;
        
        private HashHelper hashHelper;
        private ValidationFunctions validationFunctions;

        public SettingsForm(User user)
        {
            this.hashHelper = new HashHelper();
            checkFunctions = new CheckFunctions();
            this.user = user;
            this.validationFunctions = new ValidationFunctions();
            this.username = user.getUsername();
            this.storedPassword = user.getPassword();

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }


        private void _passBtnApply_Click(object sender, EventArgs e)
        {
            string currentPassword = current_password.Text;
            string newPassword = new_password.Text;

            try
            {
                if (hashHelper.ComputeSha256Hash(currentPassword) == storedPassword)
                {

                    if (newPassword == currentPassword)
                    {
                        MessageBox.Show("New password is same as old password");
                        new_password.Clear();
                        new_password.Focus();
                    }
                    else
                    {
                       
                        if (checkFunctions.IsStrongPassword(newPassword))
                        {
                            user.setPassword(hashHelper.ComputeSha256Hash(newPassword));
                            user.UpdatePassword(username, newPassword, DatabaseConnection.GetConnection());
                            MessageBox.Show("Password has been successfully updated");
                            current_password.Clear();
                            new_password.Clear();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Weak password... must have at least 6 characters, including at least one uppercase letter, one lowercase letter, and one digit");
                            new_password.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    current_password.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void _emailBtnApply_Click(object sender, EventArgs e)
        {
            string currentPassword = email_password.Text;
            string newEmail = new_email.Text;

            try
            {
                if (hashHelper.ComputeSha256Hash(currentPassword) == user.getPassword())
                {
                    if (newEmail == user.getEmail())
                    {
                        MessageBox.Show("E-mail is same as old");
                        new_email.Focus();
                    }

                    else
                    {
                        if (checkFunctions.emailCheck(newEmail) == true)
                        {
                            if (validationFunctions.isEmailAvailable(newEmail) == true)
                            {
                                MessageBox.Show("Email is already in use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                new_email.Focus();
                            }
                            else
                            {
                                user.UpdateEmail(username, newEmail);
                                email_password.Clear();
                                new_email.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong format of e-mail");
                            new_email.Clear();
                            new_email.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    email_password.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error with changing e-mail" + ex.Message);
            }
        }

        private void _btnDisplayName_Click(object sender, EventArgs e)
        {
            string currentPassword = displayName_password.Text;
            string newDisplayName = new_displayName.Text;
            try
            {

                if (hashHelper.ComputeSha256Hash(currentPassword) == storedPassword)
                {
                    if (newDisplayName == user.getDisplayName())
                    {
                        MessageBox.Show("This Display name is same as old");
                    }
                    else
                    {
                       user.UpdateUserDisplayName(username, newDisplayName, DatabaseConnection.GetConnection());
                       MessageBox.Show("Your name has updated successfully");
                       this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Wrong password", "Password Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    displayName_password.Clear();
                    displayName_password.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

       
    }
}
