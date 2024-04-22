using OmegaProject.src;
using SearchNow.src.model.login_register_access;
using SearchNow.src.model.user_model;
using SearchNow.src.objects;


namespace SearchNow.src.controller.login_controller
{
    /// <summary>
    /// Controller class responsible for handling login actions.
    /// </summary>
    public class LoginController
    {
        private LoginModel _loginModel;
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            _loginModel = new LoginModel();
            
        }

        /// <summary>
        /// Handles the login process.
        /// </summary>
        /// <param name="username">The username input provided by the user.</param>
        /// <param name="password">The password input provided by the user.</param>
        /// <returns>True if the login attempt is successful, otherwise false.</returns>
        public bool HandleLogin(string username, string password)
        {
            
            bool loginAttempt = false;
            try
            {
                if (_loginModel.checkLoginDetails(username, password))
                {
                    loginAttempt = true;

                    // Create a User object with the provided username

                    UserModel userModel = new UserModel();
                    // Create an instance of the main menu form and show it
                    MenuForm menuApp = new MenuForm(userModel.GetUser(username));
                    menuApp.Show();
                    
                }
                
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
            return loginAttempt;
        }
    }
}
