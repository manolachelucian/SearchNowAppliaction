using SearchNow.src.model.user_model;
using SearchNow.src.objects;
using SearchNow.src.objects.user;

namespace SearchNow.src.controller.profile_controller
{
    /// <summary>
    /// Controller class responsible for managing user profile-related actions.
    /// </summary>
    public class ProfileController
    {
        private UserModel userModel; // Instance of UserModel for user-related operations.

        /// <summary>
        /// Constructor for ProfileController class. Initializes UserModel instance.
        /// </summary>
        public ProfileController()
        {
            this.userModel = new UserModel(); // Initialize UserModel instance.
        }

        /// <summary>
        /// Updates the bio of a user.
        /// </summary>
        /// <param name="username">Username of the user whose bio is to be updated.</param>
        /// <param name="bio">New bio to be set.</param>
        public void updateUserBio(User user, string bio)
        {
            try
            {

                if(userModel.UpdateUserBio(user.Username, bio) == true)// Update user bio in the database.
                {
                    MessageBox.Show("Bio has been succesfully updated");
                    user.Bio = bio;
                }
                
                
            }
            catch (Exception ex)
            {
                // Handle the exception by displaying a message box and logging the error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message, true); // Log the error message.
            }
        }
    }
}
