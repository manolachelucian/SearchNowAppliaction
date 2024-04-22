using SearchNow.src.controller.admin_controller;

namespace SearchNow.src.adminMenu_form
{
    /// <summary>
    /// Represents the form for administering user-related actions.
    /// </summary>
    public partial class AdminMenuForm : Form
    {
        private AdminController adminController;

        /// <summary>
        /// Initializes a new instance of the AdminMenuForm class.
        /// </summary>
        public AdminMenuForm()
        {
            this.adminController = new AdminController();
            InitializeComponent();
            this.buttonUnbanUser.Click += unBanUserFunction;
            this.buttonBanUser.Click += banOrSuspendFunction;
        }

        /// <summary>
        /// Event handler for unbanning a user.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void unBanUserFunction(object sender, EventArgs e)
        {
            adminController.unBanUser(bannedUserTextBox);
        }

        /// <summary>
        /// Event handler for banning or suspending a user.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void banOrSuspendFunction(object sender, EventArgs e)
        {
            adminController.banOrSuspendUser(bannedUserTextBox, suspendRadio, banRadio);
        }
    }
}
