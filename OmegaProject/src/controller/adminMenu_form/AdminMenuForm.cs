using SearchNow.src.model.admin_functions;
using SearchNow.src.model.validation_functions;

namespace SearchNow.src.adminMenu_form
{
    public partial class AdminMenuForm : Form
    {

        private ValidationFunctions functions;
        public AdminMenuForm()
        {
            
            this.functions = new ValidationFunctions();
            
            InitializeComponent();
            this.buttonUnbanUser.Click += unBanUserFunction;
            this.buttonBanUser.Click += banOrSuspendFunction;
        }


        private void unBanUserFunction(object sender, EventArgs e)
        {
            try
            {
                if (functions.usernameInUse(bannedUserTextBox.Text) == true)
                {
                    AdminFunctions adminFunctions = new AdminFunctions();
                    adminFunctions.unBanUser(bannedUserTextBox.Text);
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


        private void banOrSuspendFunction(object sender, EventArgs e)
        {
            AdminFunctions adminFunctions = new AdminFunctions();
            try
            {
                if (functions.usernameInUse(bannedUserTextBox.Text) == true)
                {

                    if (adminFunctions.getStatusFromUser(bannedUserTextBox.Text)== true) {
                        if (suspendRadio.Checked)
                        {
                            adminFunctions.suspendUser(bannedUserTextBox.Text);
                        }
                        else if (banRadio.Checked)
                        {
                            adminFunctions.banUser(bannedUserTextBox.Text);
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
