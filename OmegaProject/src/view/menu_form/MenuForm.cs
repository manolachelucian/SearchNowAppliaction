using OmegaProject.src.forum_form;
using SearchNow.src.controller.search_profile_controller;
using SearchNow.src.controller.search_profile_form;
using SearchNow.src.model.menu_model;
using SearchNow.src.model.user_model;
using SearchNow.src.model.validation_model;
using SearchNow.src.objects;
using SearchNow.src.objects.ui_functions;
using SearchNow.src.objects.user;
using SearchNow.src.view.panel_form;
using static Mysqlx.Crud.Order.Types;

namespace OmegaProject.src
{
    public partial class MenuForm : ClosingForm
    {
        private User user;
        private MenuModel menuFunctions;
        private UIUtilities uiUtilities;
        private ValidationModel validationModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuForm"/> class.
        /// </summary>
        /// <param name="user">The current user.</param>
        public MenuForm(User user)
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.user = user;
            this.menuFunctions = new MenuModel();
            this.uiUtilities = new UIUtilities();
            this.validationModel = new ValidationModel();
            listBoxForums.SelectedIndexChanged += listBoxForums_SelectedIndexChanged;
            notificationButton.Click += openNotificationClick;
            _btnLogOut.Click += logOut;
            adminMenuButton.Click += openAdminMenu;
            createDiscussion.Click += openCreateForumForm;
            refreshForumButton.Click += clickLoadForum;
            myForumsButton.Click += openUserForms_click;
            labelDisplayNameProfile.Text = user.DisplayName;
            searchForumButton.Click += clickLoadForum;
            profile_form.Click += profileOpenClick;
            searchProfile.Click += openSearchProfile;
            AdminMenuButtonVisible();
            loadFilterBox();
            menuFunctions.LoadForums(listBoxForums, filterBox, searchForum);
        }


        /// <summary>
        /// Loads forums into the ListBox based on filter criteria.
        /// </summary>
        private void clickLoadForum(object sender, EventArgs e)
        {
            menuFunctions.LoadForums(listBoxForums, filterBox, searchForum);
        }

        /// <summary>
        /// Loads filter options into the filter box.
        /// </summary>
        private void loadFilterBox()
        {
            filterBox.Items.Clear();
            filterBox.Items.Add("From oldest to newest");
            filterBox.Items.Add("From newest to oldest");
            filterBox.SelectedIndex = 1;
        }




        /// <summary>
        /// Event handler for the selected index change of the ListBox. This method is triggered when the user selects a forum from the list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void listBoxForums_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected in the ListBox
            if (listBoxForums.SelectedItem != null)
            {
                // Get the name of the selected forum
                string selectedForum = listBoxForums.SelectedItem.ToString();

                try
                {
                    // Check if the user is banned or suspended
                    if (user.AccountStatus.Equals("banned") || user.AccountStatus.Equals("suspended"))
                    {
                        // Display a message informing the user that they are banned
                        MessageBox.Show("You have been banned");
                    }
                    else
                    {
                        // Open the forum details form
                        ForumDetailsForm forumDetailsForm = null;
                        if (forumDetailsForm == null)
                        {
                            // Create a new instance of the ForumDetailsForm
                            forumDetailsForm = new ForumDetailsForm(selectedForum, user);

                            // Event handler for the closing of the forum details form
                            forumDetailsForm.FormClosed += (s, e) =>
                            {
                                forumDetailsForm = null;
                                this.Enabled = true;
                                this.Focus();
                            };

                            // Disable the current form and show the forum details form
                            this.Enabled = false;
                            forumDetailsForm.Show();
                            forumDetailsForm.Activate();
                        }
                        else
                        {
                            // Focus on the already opened forum details form
                            forumDetailsForm.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log and display any errors that occur during the process
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Sets the visibility of the admin menu button based on the user's role.
        /// </summary>
        private void AdminMenuButtonVisible()
        {
            try
            {
                if (user.Role.Equals("admin"))
                {
                    adminMenuButton.Visible = true;
                }
                else
                {
                    adminMenuButton.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event of the notification button.
        /// </summary>
        private void openNotificationClick(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, notificationButton, user);
        }

        /// <summary>
        /// Handles the click event of the profile form button.
        /// </summary>
        private void profileOpenClick(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, profile_form, user);
        }

        /// <summary>
        /// Handles the click event of the log out button.
        /// </summary>
        private void logOut(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, _btnLogOut, null);
        }

        /// <summary>
        /// Handles the click event of the admin menu button.
        /// </summary>
        private void openAdminMenu(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, adminMenuButton, null);
        }

        /// <summary>
        /// Handles the click event of the my forums button.
        /// </summary>
        private void openUserForms_click(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, myForumsButton, user);
        }

        

        /// <summary>
        /// Opens the create forum form if the user is not banned or suspended.
        /// </summary>
        private void openCreateForumForm(object sender, EventArgs e)
        {
            try
            {
                if (user.AccountStatus.Equals("banned") || user.AccountStatus.Equals("suspended"))
                {
                    MessageBox.Show("You have been banned you cant create forums");
                }
                else
                {
                    uiUtilities.formDirectionFunction(this, createDiscussion, user);
                }
            }
            catch (Exception ex)
            {
                // Log error while opening create forum form and show error message
                Logger.WriteLog(ex.Message, true);
            }

        }

        /// <summary>
        /// Opens a search profile form based on the username entered in the search user textbox.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        public void openSearchProfile(object sender, EventArgs e)
        {
            // Check if the search user textbox is not empty
            if (!string.IsNullOrWhiteSpace(searchUser_textbox.Text))
            {
                // Check if the entered username exists in the system
                if (validationModel.usernameInUse(searchUser_textbox.Text))
                {
                    SearchProfile searchProfile = null;
                    // Check if the searchProfile form instance is null
                    if (searchProfile == null)
                    {
                        // Create a new instance of SearchProfile form with the entered username
                        searchProfile = new SearchProfile(searchUser_textbox.Text);
                        // Subscribe to the FormClosed event to handle cleanup after the form is closed
                        searchProfile.FormClosed += (s, e) =>
                        {
                            searchProfile = null;
                            this.Enabled = true;
                            this.Focus();
                        };
                        // Disable the current form to prevent interaction while the searchProfile form is open
                        this.Enabled = false;
                        // Show the searchProfile form
                        searchProfile.Show();
                        // Activate the searchProfile form
                        searchProfile.Activate();
                    }
                    else
                    {
                        // If the searchProfile form instance already exists, focus it
                        searchProfile.Focus();
                    }
                }
                else
                {
                    // Display a message indicating that the profile hasn't been found
                    MessageBox.Show("Profile hasn't been found");
                }
            }
            else
            {
                // Display a message indicating that the username should be entered
                MessageBox.Show("Enter username");
                // Set focus to the search user textbox
                searchUser_textbox.Focus();
            }
        }


    }
}
