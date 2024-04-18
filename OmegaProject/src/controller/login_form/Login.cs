using OmegaProject.src;
using SearchNow.src.model.check_functions;
using SearchNow.src.model.login_register_access;
using SearchNow.src.model.panel_form;
using SearchNow.src.model.UIfunctions;
using SearchNow.src.model.user_class;

namespace OmegaProject
{
    public partial class Login : CustomForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// Constructs a new Login form and sets up event handlers.
        /// </summary>
        /// 

        private UIUtilities uiUtilities;
        public Login()
        {
            // Initialize the components of the form
            InitializeComponent();
            this.uiUtilities = new UIUtilities();
            // Subscribe to the Click event of the btnCheckCon button
            // The checkConnection method of the databaseConnection object will be invoked
            // when the btnCheckCon button is clicked
            btnCheckCon.Click += _checkDatabaseConnectionClick;
            _passwordShow.CheckedChanged += _passwordShow_CheckedChanged;
            btnRegister.Click += _directionRegisterForm;

        }

        /**
        * Handles the click event of the Login button.
        * Attempts to log in using the provided username and password.
        * If successful, shows the main menu form and hides the login form.
        * If unsuccessful, displays an error message and clears the input fields.
        * 
        * @param sender The object that raised the event.
        * @param e An EventArgs that contains the event data.
        */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username;
            string _password;
            try
            {
                LoginFunctions loginFunctions = new LoginFunctions();

               _username = username.Text;
                _password = password.Text;

                // Attempt to log in using the provided credentials
                if (loginFunctions.checkLoginDetails(_username, _password))
                {
                    // If login is successful, display a success message
                    MessageBox.Show("Log in has been successful", "Login attempt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Create a User object with the provided username and password
                    User user = new User();

                    // Retrieve additional user data and set it in the User object
                    user.SetUser(_username);

                    // Create an instance of the main menu form and show it
                    MenuForm menuApp = new MenuForm(user);
                    menuApp.Show();

                    // Hide the current login form
                    this.Hide();
                }
                else
                {
                    // If login is unsuccessful, display an error message
                    MessageBox.Show("Invalid login details. Please try again.", "Login attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear the input fields
                    username.Clear();
                    password.Clear();
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, display the error message
                MessageBox.Show(ex.Message);
            }
        }
        private void _checkDatabaseConnectionClick(object sender, EventArgs e)
        {
            try
            {
                CheckFunctions checkFunctions = new CheckFunctions();
                checkFunctions.checkConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _directionRegisterForm(object sender, EventArgs e)
        {

            uiUtilities.formDirectionFunction(this, btnRegister, null);
        }

        private void _passwordShow_CheckedChanged(object sender, EventArgs e)
        {
            uiUtilities.togglePasswordVisibility(_passwordShow, password, null);
        }

    }
}
