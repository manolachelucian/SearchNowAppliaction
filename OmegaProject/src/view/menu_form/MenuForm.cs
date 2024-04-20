using OmegaProject.src.forum_form;
using SearchNow.src.model.menu_functions;
using SearchNow.src.objects.ui_functions;
using SearchNow.src.objects.user;
using SearchNow.src.view.panel_form;

namespace OmegaProject.src
{
    public partial class MenuForm : CustomForm
    {
        private User user;
        private MenuFunctions menuFunctions;
        private UIUtilities uiUtilities;

        public MenuForm(User user)
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.user = user;
            this.menuFunctions = new MenuFunctions();
            this.uiUtilities = new UIUtilities();

            listBoxForums.SelectedIndexChanged += listBoxForums_SelectedIndexChanged;
            _btnLogOut.Click += logOut;
            adminMenuButton.Click += openAdminMenu;
            createDiscussion.Click += openCreateForumForm;
            refreshForumButton.Click += clickLoadForum;
            myForumsButton.Click += openUserForms_click;
            labelDisplayNameProfile.Text = user.DisplayName;
            searchForumButton.Click += clickLoadForum;
            profile_form.Click += profileOpenClick;
            AdminMenuButtonVisible();
            loadFilterBox();
            menuFunctions.LoadForums(listBoxForums, filterBox, searchForum);
        }


        private void clickLoadForum(object sender, EventArgs e)
        {
            menuFunctions.LoadForums(listBoxForums,filterBox,searchForum);
        }
        
        private void loadFilterBox()
        {
           filterBox.Items.Clear();
           filterBox.Items.Add("From oldest to newest");
           filterBox.Items.Add("From newest ot oldest");
           filterBox.Items.Add("My favorite");
           filterBox.SelectedIndex = 1;
    
        }

        



        private void listBoxForums_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Zkontrolujte, zda je vybraný nějaký prvek v ListBoxu
            if (listBoxForums.SelectedItem != null)
            {
                // Získání názvu vybraného fóra
                string selectedForum = listBoxForums.SelectedItem.ToString();

                try
                {
                    if (user.AccountStatus.Equals("banned") || user.AccountStatus.Equals("suspended"))
                    {
                        MessageBox.Show("You have been banned"); 
                    }
                    else
                    {
                        ForumDetailsForm forumDetailsForm = null;
                        if (forumDetailsForm == null)
                        {
                            forumDetailsForm = new ForumDetailsForm(selectedForum, user);
                            forumDetailsForm.FormClosed += (s, e) => {
                                forumDetailsForm = null;
                                this.Enabled = true;
                                this.Focus();
                            };
                            this.Enabled = false;
                            forumDetailsForm.Show();
                            forumDetailsForm.Activate();   
                        }
                        else
                        {
                            forumDetailsForm.Focus();
                        }
                        
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

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

        

        private void profileOpenClick(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, profile_form, user);
        }

        private void logOut(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, _btnLogOut, null);
        }

        private void openAdminMenu(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, adminMenuButton, null);
        }

        private void openUserForms_click(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, myForumsButton, user);
        }


        private void openCreateForumForm(object sender, EventArgs e)
        {
            if (user.AccountStatus.Equals("banned") || user.AccountStatus.Equals("suspended"))
            {
                MessageBox.Show("You have been banned you cant create forums");
            }
            else
            {
                uiUtilities.formDirectionFunction(this, createDiscussion,user);
            }
        }


    }
}
