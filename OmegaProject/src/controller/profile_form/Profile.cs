using OmegaProject.src.settings_form;
using SearchNow.src.model.user_class;
using System.Configuration;

namespace OmegaProject.src.profile_form
{
    public partial class Profile : Form
    {
        private User user;
        private SettingsForm settingsForm;
        
        public Profile(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.user = user;

            _labelDisplayName.Text = user.getDisplayName();
            _labelUserName.Text = user.getUsername();
            _labelEmail.Text = user.getEmail();
            _labelCreatedAt.Text += user.getCreated_at();
            _labelRole.Text = user.getRole();
            _labelAccountStatus.Text = user.getAccount_status();
            statusColor();
            _bio.Text = user.getBio();
            buttonSettings.Click += settings_Click;
            
        }

        private void _updateBio_Click(object sender, EventArgs e)
        {
            user.UpdateUserBio(_bio.Text, DatabaseConnection.GetConnection());
        }

        private void statusColor()
        {
            if (user.getAccount_status().Equals("banned"))
            {
                _labelAccountStatus.ForeColor =Color.Red;
            }
            if (user.getAccount_status().Equals("suspended"))
            {
                _labelAccountStatus.ForeColor = Color.Orange;
            }
        }


        private void settings_Click(object sender, EventArgs e)
        {
            if (settingsForm == null)
            {
                settingsForm = new SettingsForm(user);
                settingsForm.FormClosed += (s, e) => settingsForm = null;
                settingsForm.Show();
                settingsForm.Focus();

            }
            else
            {
                settingsForm.Focus();
            }
        }

    }
}
