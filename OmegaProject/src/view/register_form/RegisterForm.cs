using SearchNow.src.controller.register_controller;
using SearchNow.src.model.validation_model;
using SearchNow.src.objects.check_functions;
using SearchNow.src.objects.ui_functions;
using SearchNow.src.view.panel_form;

namespace OmegaProject.src
{
    public partial class RegisterForm : CustomForm
    {

        private RegisterController registerController;
        private UIUtilities uiUtilities;
        private ValidationModel validationFunctions;
        private CheckFunctions checkFunctions;
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

        private void _passwordShow_CheckedChanged(object sender, EventArgs e)
        {
            uiUtilities.togglePasswordVisibility(registerShowPassword, password, confirmPassword);
        }

        private void _directionLoginForm(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, _btnLoginForm, null);
        }

        private void _validateInput(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(password.Text))
                {
                    MessageBox.Show("Password cannot be empty!", "Password issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Focus();
                }
                else if (string.IsNullOrWhiteSpace(username.Text))
                {
                    MessageBox.Show("Username cannot be empty!", "Username issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Focus();
                }
                else if (string.IsNullOrWhiteSpace(email.Text))
                {
                    MessageBox.Show("E-mail cannot be empty!", "E-mail issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.Focus();
                }
                else if (string.IsNullOrWhiteSpace(displayName.Text))
                {
                    MessageBox.Show("Display name cannot be empty!", "Display name issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    displayName.Focus();
                }
                else
                {
                    if (checkFunctions.emailCheck(email.Text) == true && checkFunctions.IsStrongPassword(password.Text) == true && checkFunctions.ValidateUsernameFormat(username.Text) == true && password.Text == confirmPassword.Text)
                    {

                        if(validationFunctions.usernameInUse(username.Text) != true && validationFunctions.isEmailAvailable(email.Text) != true) {
                            _register();
                        }
                        else
                        {
                            if (validationFunctions.isEmailAvailable(email.Text) == true)
                            {
                                MessageBox.Show("E-mail is already in use");

                            }
                            if(validationFunctions.usernameInUse(username.Text) == true)
                            {
                                MessageBox.Show("Username is already in use");
                            }
                        } 
                    }
                    else if (checkFunctions.emailCheck(email.Text) == false)
                    {
                        MessageBox.Show("Wrong format of e-mail", "format issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (checkFunctions.IsStrongPassword(password.Text) == false)
                    {
                        MessageBox.Show("to week password... At least 1 number and 1 letter uppercase", "Week password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (password.Text != confirmPassword.Text)
                    {
                        MessageBox.Show("Passwords are not same", "password issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error with creating account", "creating account issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void _register()
        {
            
            string _username = username.Text;
            string _password = password.Text;
            string _email = email.Text;
            string _displayName = displayName.Text;
            string _date = birth.Text;


            if (registerController.RegisterUser(_username, _password, _email, _displayName, _date) == true)
            {
                username.Clear();
                password.Clear();
                email.Clear();
                displayName.Clear();
                confirmPassword.Clear();
                MessageBox.Show("Creating new account has been successful", "Creating account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error with creating account", "Creating account error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
