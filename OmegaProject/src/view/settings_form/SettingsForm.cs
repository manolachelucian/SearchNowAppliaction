
using SearchNow.src.controller.settings_controller;
using SearchNow.src.objects.user;

namespace OmegaProject.src.settings_form
{
    public partial class SettingsForm : Form
    {
        
        private User user;
        private SettingsController settingsController;
                        
        public SettingsForm(User user)
        {
            this.settingsController = new SettingsController();

            this.user = user;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void _passBtnApply_Click(object sender, EventArgs e)
        {

            settingsController.changePassword(current_password, new_password, user);
            
        }

        private void _emailBtnApply_Click(object sender, EventArgs e)
        {
  
            settingsController.changeEmail(email_password, new_email, user);
        }

        private void _btnDisplayName_Click(object sender, EventArgs e)
        {

            settingsController.changeDisplayName(displayName_password, new_displayName, user);
        }

       
    }
}
