using SearchNow.src.model.notification_model;
using SearchNow.src.objects;
using SearchNow.src.objects.notification;
using SearchNow.src.objects.user;

namespace SearchNow.src.controller.notification_controller
{
    /// <summary>
    /// Controller class for managing notifications.
    /// </summary>
    public class NotificationController
    {
        private NotificationModel notificationModel;

        /// <summary>
        /// Constructor initializes a new instance of the NotificationController class.
        /// </summary>
        public NotificationController()
        {
            this.notificationModel = new NotificationModel();
        }

        /// <summary>
        /// Sends a notification to the specified user.
        /// </summary>
        /// <param name="userId">The ID of the user receiving the notification.</param>
        /// <param name="message">The message content of the notification.</param>
        public void SendNotification(int userId, string message)
        {
            notificationModel.SendNotification(userId, message);
        }

        /// <summary>
        /// Marks a notification as read.
        /// </summary>
        /// <param name="notificationId">The ID of the notification to mark as read.</param>
        public void MarkAsRead(int notificationId)
        {
            notificationModel.MarkAsRead(notificationId);
        }

        /// <summary>
        /// Loads notifications for the current user into the specified DataGridView.
        /// </summary>
        /// <param name="notificationGrid">The DataGridView to load notifications into.</param>
        /// <param name="currentUser">The current user whose notifications to load.</param>
        /// <param name="sortBy">The sorting criterion for the notifications.</param>
        public void LoadNotifications(DataGridView notificationGrid, User currentUser, string sortBy)
        {
            notificationGrid.Rows.Clear();
            try
            {
                // Retrieve notifications for the current user
                List<Notification> notifications = notificationModel.GetNotifications(currentUser.Id, sortBy);

                // Clear existing columns before adding new ones
                notificationGrid.Columns.Clear();

                // Add columns to the DataGridView
                notificationGrid.Columns.Add("NotificationId", "Notification ID");
                notificationGrid.Columns.Add("Username", "Username");
                notificationGrid.Columns.Add("Message", "Message");
                notificationGrid.Columns.Add("Timestamp", "Timestamp");
                notificationGrid.Columns.Add("IsRead", "Is Read");

                // Populate DataGridView with notifications
                foreach (Notification notification in notifications)
                {
                    notificationGrid.Rows.Add(notification.NotificationId, notification.Username, notification.Message, notification.Timestamp, notification.IsRead);
                }
            }
            catch (Exception ex)
            {
               
                Logger.WriteLog(ex.Message, true);
                
            }
        }
    }
}
