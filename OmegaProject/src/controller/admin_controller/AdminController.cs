using SearchNow.src.model.admin_model;
using SearchNow.src.model.user_model;
using SearchNow.src.model.validation_model;

namespace SearchNow.src.controller.admin_controller
{
    public class AdminController
    {
        private AdminModel adminModel;
        private ValidationModel validationModel;
        private UserModel userModel;
        public AdminController()
        {
            adminModel = new AdminModel();
            validationModel = new ValidationModel();
            userModel = new UserModel();
        }


        public void unBanUser(TextBox _bannedUsername)
        {
            string bannedUsername = _bannedUsername.Text;
            try
            {
                if (validationModel.usernameInUse(bannedUsername) == true)
                {
                    adminModel.unBanUser(bannedUsername);
                    MessageBox.Show(bannedUsername + " has been unbanned!", "unban info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _bannedUsername.Clear();
                }
                else
                {
                    MessageBox.Show("User has not been found");
                }

            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }

        }


        public void banOrSuspendUser(TextBox _bannedUsername,RadioButton suspendRadio,RadioButton banRadio)
        {
            string bannedUsername = _bannedUsername.Text;

            try
            {
                if (validationModel.usernameInUse(bannedUsername) == true)
                {
                    if (userModel.getStatusFromUser(bannedUsername) == true)
                    {
                        if (suspendRadio.Checked)
                        {
                            adminModel.suspendUser(bannedUsername);
                            MessageBox.Show(bannedUsername + " has been banned!", "ban info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _bannedUsername.Clear();
                            suspendRadio.Checked = false;
                        }
                        else if (banRadio.Checked)
                        {
                            adminModel.banUser(bannedUsername);
                            MessageBox.Show(bannedUsername + " has been Suspended!", "Suspend info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _bannedUsername.Clear();
                            banRadio.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Choose what type of ban", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can not ban or suspend admin", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("User has not been found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
