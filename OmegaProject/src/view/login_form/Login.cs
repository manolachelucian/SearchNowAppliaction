using SearchNow.src.controller.login_controller;
using SearchNow.src.view.panel_form;
using SearchNow.src.objects.ui_functions;
using SearchNow.src.objects.check_functions;
using SearchNow.src.objects;

namespace OmegaProject
{
    /// <summary>
    /// The Login class represents the login form of the OmegaProject application.
    /// </summary>
    public partial class Login : ClosingForm
    {
        private UIUtilities uiUtilities;
        private LoginController _loginController;

        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// Constructs a new Login form and sets up event handlers.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            this.uiUtilities = new UIUtilities();
            this._loginController = new LoginController();

            // Subscribe to the Click event of the btnCheckCon button
            btnCheckCon.Click += _checkDatabaseConnectionClick;
            // Subscribe to the CheckedChanged event of the _passwordShow checkbox
            _passwordShow.CheckedChanged += _passwordShow_CheckedChanged;
            // Subscribe to the Click event of the btnRegister button
            btnRegister.Click += _directionRegisterForm;
            // Subscribe to the Click event of the btnLogin button
            btnLogin.Click += login_Click;
        }

        /// <summary>
        /// Handles the Click event of the btnLogin button.
        /// Attempts to log in using the provided username and password.
        /// </summary>
        private void login_Click(object sender, EventArgs e)
        {
            string _username = username.Text;
            string _password = password.Text;
            try
            {
                if (_loginController.HandleLogin(_username, _password))
                {
                    this.Hide();
                    MessageBox.Show("Log in has been successful", "Login attempt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.WriteLog($"login has been successful {_username}\n", false);
                }
                else
                {
                    username.Clear();
                    password.Clear();
                    MessageBox.Show("Invalid login details. Please try again.", "Login attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + ex.StackTrace, true);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCheckCon button.
        /// Checks the database connection status.
        /// </summary>
        private void _checkDatabaseConnectionClick(object sender, EventArgs e)
        {
            try
            {
                CheckFunctions checkFunctions = new CheckFunctions();
                checkFunctions.checkConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnRegister button.
        /// Redirects to the registration form.
        /// </summary>
        private void _directionRegisterForm(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, btnRegister, null);
        }

        /// <summary>
        /// Handles the CheckedChanged event of the _passwordShow checkbox.
        /// Toggles the visibility of the password.
        /// </summary>
        private void _passwordShow_CheckedChanged(object sender, EventArgs e)
        {
            uiUtilities.togglePasswordVisibility(_passwordShow, password, null);
        }
    }
}
