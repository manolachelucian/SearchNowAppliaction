using SearchNow.src.model.user_model;

namespace SearchNow.src.controller.profile_controller
{
    public class ProfileController
    {
        private UserModel userModel;

        public ProfileController()
        {
            this.userModel = new UserModel();
        }

        public void updateUserBio(string username,string bio)
        {
            try
            {
                userModel.UpdateUserBio(username, bio);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



    }
}
