using NUnit.Framework;
using OmegaProject.src.forum_form;
using OmegaProject.src.profile_form;
using SearchNow.src.adminMenu_form;
using SearchNow.src.controller.search_profile_form;
using SearchNow.src.createForum_form;
using SearchNow.src.model.menu_functions;
using SearchNow.src.model.panel_form;
using SearchNow.src.model.UIfunctions;
using SearchNow.src.model.user_class;
using SearchNow.src.model.user_forums_functions;
using SearchNow.src.user_forums_form;
using System.Windows.Forms;
using ZstdSharp;

namespace OmegaProject.src
{
    public partial class MenuForm : CustomForm
    {
        private User user;
        
        private AdminMenuForm adminMenuForm;
        private ForumDetailsForm forumDetailsForm;
        private CreateForum createForum;
        private User_forums userForums;
        private MenuFunctions menuFunctions;
        private UIUtilities uiUtilities;
        private SearchProfile SearchProfile;

        public MenuForm(User user)
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.user = user;
            this.menuFunctions = new MenuFunctions();
            this.uiUtilities = new UIUtilities();

            listBoxForums.SelectedIndexChanged += listBoxForums_SelectedIndexChanged;
            _btnLogOut.Click += logOut;
            adminMenuButton.Click += admin_menu_form;
            createDiscussion.Click += openCreateForumForm;
            refreshForumButton.Click += clickLoadForum;
            myForumsButton.Click += openUserForms_click;
            labelDisplayNameProfile.Text = user.getDisplayName();
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
                    if (user.getAccount_status().Equals("banned") || user.getAccount_status().Equals("suspended"))
                    {
                        MessageBox.Show("You have been banned"); 
                    }
                    else
                    {
                        if (forumDetailsForm == null)
                        {
                            forumDetailsForm = new ForumDetailsForm(selectedForum, DatabaseConnection.GetConnection(), user); ;
                            forumDetailsForm.FormClosed += (s, e) => forumDetailsForm = null;
                            forumDetailsForm.Show();
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
                if (user.getRole().Equals("admin"))
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


        private void openCreateForumForm(object sender, EventArgs e)
        {
            if (user.getAccount_status().Equals("banned") || user.getAccount_status().Equals("suspended"))
            {
                MessageBox.Show("You have been banned you cant create forums");
            }
            else
            {
                uiUtilities.formDirectionFunction(this, createDiscussion,user);
            }
        }

        private void admin_menu_form(object sender, EventArgs e)
        {
            if (adminMenuForm == null)
            {
                adminMenuForm = new AdminMenuForm();
                adminMenuForm.FormClosed += (s, e) => adminMenuForm = null;
                adminMenuForm.Show();

            }
            else
            {
                adminMenuForm.Focus();
            }
        }

        private void openUserForms_click(object sender, EventArgs e)
        {
            uiUtilities.formDirectionFunction(this, myForumsButton, user);
        }


    }
}
