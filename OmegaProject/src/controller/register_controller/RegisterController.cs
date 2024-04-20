using SearchNow.src.model.login_register_access;

namespace SearchNow.src.controller.register_controller
{
    /// <summary>
    /// Controller class responsible for handling user registration.
    /// </summary>
    public class RegisterController
    {
        private RegisterModel registerModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterController"/> class.
        /// </summary>
        public RegisterController()
        {
            registerModel = new RegisterModel();
        }

        /// <summary>
        /// Registers a new user with the specified details.
        /// </summary>
        /// <param name="username">The username of the new user.</param>
        /// <param name="password">The password of the new user.</param>
        /// <param name="email">The email address of the new user.</param>
        /// <param name="displayName">The display name of the new user.</param>
        /// <param name="dateOfBirth">The date of birth of the new user.</param>
        /// <returns>True if the user registration is successful, otherwise false.</returns>
        public bool RegisterUser(string username, string password, string email, string displayName, string dateOfBirth)
        {
            bool result = false;
            try
            {
                // Attempt to register the user using the RegisterModel
                bool registrationAttempt = registerModel.registerUser(username, password, email, displayName, dateOfBirth);
                if (registrationAttempt == true)
                {

                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during registration
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
