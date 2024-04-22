
using SearchNow.src.controller.register_controller;
using SearchNow.src.model.validation_model;
using SearchNow.src.objects;
using SearchNow.src.objects.check_functions;
using SearchNow.src.objects.ui_functions;
using SearchNow.src.view.panel_form;

namespace OmegaProject.src
{
    /// <summary>
    /// Represents the registration form for creating a new user account.
    /// </summary>
    public partial class RegisterForm : ClosingForm
    {
        private RegisterController registerController;
        private UIUtilities uiUtilities;
        private ValidationModel validationFunctions;
        private CheckFunctions checkFunctions;

        /// <summary>
        /// Initializes a new instance of the RegisterForm class.
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
            this.registerController = new RegisterController();
            this.validationFunctions = new ValidationModel();
            this.uiUtilities = new UIUtilities();
            this.checkFunctions = new CheckFunctions();
            _registerBtn.Click += _validateInput;
            registerShowPassword.CheckedChanged += _passwordShow_CheckedChanged;
            _btnLoginForm.Click += _directionLoginForm;
        }

        /// <summary>
        /// Event handler for the password show checkbox checked changed event.
        /// </summary>
        private void _passwordShow_CheckedChanged(object sender, EventArgs e)
        {
            uiUtilities.togglePasswordVisibility(registerShowPassword, password, confirmPassword);
        }

        /// <summary>
        /// Event handler for the button to navigate to the login form.
        /// </summary>
        private void _directionLoginForm(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, _btnLoginForm, null);
        }

        /// <summary>
        /// Event handler for the register button click event.
        /// </summary>
        private void _validateInput(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(password.Text))
                {
                    MessageBox.Show("Password cannot be empty!", "Password Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Focus();
                }
                else if (string.IsNullOrWhiteSpace(username.Text))
                {
                    MessageBox.Show("Username cannot be empty!", "Username Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Focus();
                }
                else if (string.IsNullOrWhiteSpace(email.Text))
                {
                    MessageBox.Show("E-mail cannot be empty!", "E-mail Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.Focus();
                }
                else if (string.IsNullOrWhiteSpace(displayName.Text))
                {
                    MessageBox.Show("Display name cannot be empty!", "Display Name Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    displayName.Focus();
                }
                else
                {
                    if (checkFunctions.emailCheck(email.Text) && checkFunctions.IsStrongPassword(password.Text) && checkFunctions.ValidateUsernameFormat(username.Text) && password.Text == confirmPassword.Text)
                    {
                        if (!validationFunctions.usernameInUse(username.Text) && !validationFunctions.isEmailAvailable(email.Text))
                        {
                            _register();
                        }
                        else
                        {
                            if (validationFunctions.isEmailAvailable(email.Text))
                            {
                                MessageBox.Show("E-mail is already in use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            if (validationFunctions.usernameInUse(username.Text))
                            {
                                MessageBox.Show("Username is already in use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (!checkFunctions.emailCheck(email.Text))
                    {
                        MessageBox.Show("Wrong format of e-mail", "Format Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!checkFunctions.IsStrongPassword(password.Text))
                    {
                        MessageBox.Show("Weak password... At least 1 number and 1 uppercase letter required", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (password.Text != confirmPassword.Text)
                    {
                        MessageBox.Show("Passwords do not match", "Password Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error with creating account", "Creating Account Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Registers a new user account.
        /// </summary>
        private void _register()
        {
            try
            {
                string _username = username.Text;
                string _password = password.Text;
                string _email = email.Text;
                string _displayName = displayName.Text;
                string _date = birth.Text;

                if (registerController.RegisterUser(_username, _password, _email, _displayName, _date))
                {
                    username.Clear();
                    password.Clear();
                    email.Clear();
                    displayName.Clear();
                    confirmPassword.Clear();
                    MessageBox.Show("Creating a new account was successful", "Account Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.WriteLog("Creating a new account was successful", false);

                }
                else
                {
                    MessageBox.Show("Error creating account", "Account Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message,true);
            }
        }
    }
}
