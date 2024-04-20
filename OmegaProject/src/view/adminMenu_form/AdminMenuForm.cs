using SearchNow.src.controller.admin_controller;

namespace SearchNow.src.adminMenu_form
{
    public partial class AdminMenuForm : Form
    {

        private AdminController adminController;
        public AdminMenuForm()
        {
            this.adminController = new AdminController();
            InitializeComponent();
            this.buttonUnbanUser.Click += unBanUserFunction;
            this.buttonBanUser.Click += banOrSuspendFunction;
        }


        private void unBanUserFunction(object sender, EventArgs e)
        {
            adminController.unBanUser(bannedUserTextBox);
        }


        private void banOrSuspendFunction(object sender, EventArgs e)
        {
            adminController.banOrSuspendUser(bannedUserTextBox, suspendRadio, banRadio);
        }
    }
}
