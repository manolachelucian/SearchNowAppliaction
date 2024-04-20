using OmegaProject.src;
using SearchNow.src.controller.login_controller;
using SearchNow.src.model.login_register_access;
using SearchNow.src.view.panel_form;
using SearchNow.src.objects.ui_functions;
using SearchNow.src.objects.check_functions;
using SearchNow.src.objects;

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
        private LoginController _loginController;

        public Login()
        {
            // Initialize the components of the form
            InitializeComponent();
            this.uiUtilities = new UIUtilities();
            this._loginController = new LoginController();

            // Subscribe to the Click event of the btnCheckCon button
            // The checkConnection method of the databaseConnection object will be invoked
            // when the btnCheckCon button is clicked
            btnCheckCon.Click += _checkDatabaseConnectionClick;
            _passwordShow.CheckedChanged += _passwordShow_CheckedChanged;
            btnRegister.Click += _directionRegisterForm;
            btnLogin.Click += login_Click;

        }

        private void login_Click(object sender, EventArgs e)
        {
            string _username = username.Text;
            string _password = password.Text;
            try
            {
                if (_loginController.HandleLogin(_username, _password) == true)
                {
                    this.Hide();
                    // If login is successful, display a success message
                    MessageBox.Show("Log in has been successful", "Login attempt", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
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
