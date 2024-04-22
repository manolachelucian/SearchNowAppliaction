using OmegaProject;
using OmegaProject.src;
using OmegaProject.src.profile_form;
using OmegaProject.src.settings_form;
using SearchNow.src.adminMenu_form;
using SearchNow.src.createForum_form;
using SearchNow.src.objects.user;
using SearchNow.src.user_forums_form;
using SearchNow.src.view.notification_form;

namespace SearchNow.src.objects.ui_functions
{
    /// <summary>
    /// Provides utility functions for UI-related tasks.
    /// </summary>
    public class UIUtilities
    {
        /// <summary>
        /// Toggles the visibility of password characters based on the state of a checkbox.
        /// </summary>
        /// <param name="checkBox">The checkbox used to toggle password visibility.</param>
        /// <param name="passwordTextBox">The TextBox containing the password.</param>
        /// <param name="confirmPassword">The TextBox containing the confirmation password (for registration form).</param>
        public void togglePasswordVisibility(CheckBox checkBox, TextBox passwordTextBox, TextBox confirmPassword)
        {
            try
            {
                switch (checkBox.Name)
                {
                    case "_passwordShow":
                        // Check if the _passwordShow checkbox is checked
                        if (checkBox.Checked)
                        {
                            // If checked, display password characters
                            passwordTextBox.PasswordChar = '\0'; // Display characters as plain text
                        }
                        else
                        {
                            // If unchecked, hide password characters
                            passwordTextBox.PasswordChar = '*'; // Display characters as asterisks
                        }
                        break;

                    case "registerShowPassword":
                        if (checkBox.Checked)
                        {
                            passwordTextBox.PasswordChar = '\0';
                            confirmPassword.PasswordChar = '\0';
                        }
                        else
                        {
                            passwordTextBox.PasswordChar = '*';
                            confirmPassword.PasswordChar = '*';
                        }
                        break;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Redirects to another form based on the clicked button.
        /// </summary>
        /// <param name="currentForm">The current form.</param>
        /// <param name="directionButton">The button clicked to navigate to another form.</param>
        /// <param name="user">The user object associated with the action (optional).</param>
        public void formDirectionFunction(Form currentForm, Button directionButton, User user)
        {
            try
            {
                switch (directionButton.Name)
                {
                    case "btnRegister":
                        // Show the registration form and hide the current form
                        RegisterForm registerForm = new RegisterForm();
                        registerForm.Show();
                        currentForm.Hide();
                        break;

                    case "_btnLoginForm":
                        // Show the login form and hide the current form
                        Login loginForm = new Login();
                        loginForm.Show();
                        currentForm.Hide();
                        break;

                    case "_btnLogOut":
                        Login logOut = new Login();
                        logOut.Show();
                        currentForm.Hide();
                        break;

                    case "profile_form":
                        Profile profileForm = null;
                        if (profileForm == null)
                        {
                            profileForm = new Profile(user);
                            profileForm.FormClosed += (s, e) =>
                            {
                                profileForm = null;
                                currentForm.Enabled = true;
                                currentForm.Focus();
                            };
                            profileForm.Activate();
                            profileForm.Show();
                            currentForm.Enabled = false;
                        }
                        else
                        {

                            profileForm.Focus();
                        }
                        break;

                    case "createDiscussion":
                        CreateForum createForum = null;
                        if (createForum == null)
                        {
                            createForum = new CreateForum(user);
                            createForum.FormClosed += (s, e) =>
                            {
                                createForum = null;
                                currentForm.Enabled = true;
                                currentForm.Focus();
                            };
                            createForum.Activate();
                            createForum.Show();
                            currentForm.Enabled = false;
                        }
                        else
                        {
                            currentForm.Focus();
                        }
                        break;

                    case "myForumsButton":
                        User_forums userForums = null;
                        
                        if (userForums == null)
                        {
                            userForums = new User_forums(user);
                            userForums.FormClosed += (s, e) =>
                            {
                                userForums = null;
                                currentForm.Enabled = true;
                                currentForm.Focus();
                            };
                            userForums.Activate();
                            userForums.Show();
                            currentForm.Enabled = false;
                        }
                        break;

                    case "buttonSettings":
                        SettingsForm settingsForm = null;
                        if (settingsForm == null)
                        {
                            settingsForm = new SettingsForm(user);
                            settingsForm.FormClosed += (s, e) =>
                            {
                                settingsForm = null;
                                currentForm.Enabled = true;
                                currentForm.Focus();
                            };
                            settingsForm.Activate();
                            settingsForm.Show();
                            currentForm.Enabled = false;
                        }
                        break;

                    case "adminMenuButton":
                        AdminMenuForm adminMenuForm = null;
                        if (adminMenuForm == null)
                        {
                            adminMenuForm = new AdminMenuForm();
                            adminMenuForm.Show();
                            adminMenuForm.Activate();
                            currentForm.Enabled = false;
                            adminMenuForm.FormClosed += (s, e) =>
                            {
                                adminMenuForm = null;
                                currentForm.Enabled = true;
                                currentForm.Focus();
                            };
                        }
                        break;

                    case "notificationButton":
                        NotificationForum noticationForm = null;
                        if(noticationForm == null)
                        {
                            noticationForm = new NotificationForum(user);
                            noticationForm.Show();
                            noticationForm.Activate();
                            currentForm.Enabled= false;
                            noticationForm.FormClosed += (s, e) =>
                            {
                                noticationForm = null;
                                currentForm.Enabled = true;
                                currentForm.Focus();
                            };
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
}
