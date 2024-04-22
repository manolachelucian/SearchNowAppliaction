using SearchNow.src.controller.notification_controller;
using SearchNow.src.objects;
using SearchNow.src.objects.user;

namespace SearchNow.src.view.notification_form
{
    /// <summary>
    /// Represents a form for displaying notifications.
    /// </summary>
    public partial class NotificationForum : Form
    {
        private User currentUser;
        private NotificationController notificationController;

        /// <summary>
        /// Initializes a new instance of the NotificationForum class.
        /// </summary>
        /// <param name="currentUser">The current user for whom notifications are displayed.</param>
        public NotificationForum(User currentUser)
        {
            try
            {
                this.currentUser = currentUser;
                this.notificationController = new NotificationController();
                InitializeComponent();
                LoadNotifications("DESC");

                // Event handlers for radio buttons
                radioFromNewest.Click += radioFromNewest_CheckedChanged;
                radioFromOldest.Click += radioFromOldest_CheckedChanged;

                // Event handler for DataGridView cell click
                notificationGrid.CellClick += notificationGrid_CellClick;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }

        /// <summary>
        /// Event handler for the radio button to sort notifications from newest to oldest.
        /// </summary>
        private void radioFromNewest_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioFromNewest.Checked)
                {
                    LoadNotifications("DESC");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }

        /// <summary>
        /// Event handler for the radio button to sort notifications from oldest to newest.
        /// </summary>
        private void radioFromOldest_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioFromOldest.Checked)
                {
                    LoadNotifications("ASC");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
                
            }
        }

        /// <summary>
        /// Loads notifications into the DataGridView.
        /// </summary>
        /// <param name="sortBy">The sorting order for the notifications.</param>
        private void LoadNotifications(string sortBy)
        {
            try
            {
                notificationController.LoadNotifications(notificationGrid, currentUser, sortBy);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }

        /// <summary>
        /// Event handler for DataGridView cell click to mark a notification as read.
        /// </summary>
        private void notificationGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int notificationId = Convert.ToInt32(notificationGrid.Rows[e.RowIndex].Cells["NotificationId"].Value);
                    notificationController.MarkAsRead(notificationId);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }
    }
}
