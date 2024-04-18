using MySql.Data.MySqlClient;
using SearchNow.src.model.check_functions;
using SearchNow.src.model.login_register_access;
using SearchNow.src.model.panel_form;
using SearchNow.src.model.UIfunctions;
using SearchNow.src.model.validation_functions;
using System.Xml.Linq;

namespace OmegaProject.src
{
    public partial class RegisterForm : CustomForm
    {

        private RegisterFunctions regiterFunctions;
        private UIUtilities uiUtilities;
        private ValidationFunctions validationFunctions;
        private CheckFunctions checkFunctions;
        public RegisterForm()
        {
            InitializeComponent();
            this.regiterFunctions = new RegisterFunctions();
            this.validationFunctions = new ValidationFunctions();
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
                        _register();
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
            string _username;
            string _password;
            string _email;
            string _displayName;
            string _date;

            try
            {
                _username = username.Text;
                _password = password.Text;
                _email = email.Text;
                _displayName = displayName.Text;
                _date = birth.Text;
                if (validationFunctions.usernameInUse(_username) == true)
                {
                    MessageBox.Show("Username is already in use", "Username issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Clear();
                    username.Focus();
                }
                if (validationFunctions.isEmailAvailable(_email) == true)
                {
                    MessageBox.Show("E-mail is already in use", "E-mail issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.Clear();
                    email.Focus();
                }
                else
                {
                    regiterFunctions.registerUser(_username, _password, _email, _displayName, _date);
                    username.Clear();
                    password.Clear();
                    email.Clear();
                    displayName.Clear();
                    confirmPassword.Clear();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        
    }
}
