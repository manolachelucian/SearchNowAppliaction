using MySql.Data.MySqlClient;
using SearchNow.src.objects;
using SearchNow.src.objects.notification;

namespace SearchNow.src.model.notification_model
{
    /// <summary>
    /// Model class for managing notifications in the database.
    /// </summary>
    public class NotificationModel
    {
        /// <summary>
        /// Sends a notification to the specified user.
        /// </summary>
        /// <param name="userId">The ID of the user receiving the notification.</param>
        /// <param name="message">The message content of the notification.</param>
        public void SendNotification(int userId, string message)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                   
                    string query = "INSERT INTO Notifications (user_id, message_text) VALUES (@userId, @message)";
                    using(MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@message", message);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Logger.WriteLog("Notification inserted successfully.",false);
                        }
                        else{
                            Logger.WriteLog("Failed to insert notification.", false);
                        }
                    }
                }
            }
            catch(MySqlException ex) {
                Logger.WriteLog(ex.Message,true);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
        }

        /// <summary>
        /// Retrieves notifications for the specified user.
        /// </summary>
        /// <param name="userId">The ID of the user whose notifications to retrieve.</param>
        /// <param name="sortOrder">The sorting order for the notifications.</param>
        /// <returns>A list of notifications for the specified user.</returns>
        public List<Notification> GetNotifications(int userId, string sortOrder)
        {
            List<Notification> notifications = new List<Notification>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    string query = "SELECT n.notificaiton_id, n.user_id, n.message_text, n.Timestamp, n.isRead, u.username " +
                                   "FROM Notifications AS n " +
                                   "JOIN users AS u ON n.user_id = u.id_user " +
                                   "WHERE n.user_id = @UserId " +
                                   $"ORDER BY n.Timestamp {sortOrder};";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Notification notification = new Notification();
                            notification.NotificationId = Convert.ToInt32(reader["notificaiton_id"]);
                            notification.UserId = Convert.ToInt32(reader["user_id"]);
                            notification.Message = Convert.ToString(reader["message_text"]);
                            notification.Timestamp = Convert.ToDateTime(reader["Timestamp"]);
                            notification.IsRead = Convert.ToBoolean(reader["isRead"]);
                            notification.Username = Convert.ToString(reader["username"]);

                            notifications.Add(notification);
                        }
                    }
                }
            }
            catch(MySqlException ex) {

                Logger.WriteLog(ex.Message, true);

            }
            catch (Exception ex)
            {

                Logger.WriteLog(ex.Message, true);
                
            }

            return notifications;
        }

        /// <summary>
        /// Marks a notification as read.
        /// </summary>
        /// <param name="notificationId">The ID of the notification to mark as read.</param>
        /// <returns>True if the notification is marked as read successfully; otherwise, false.</returns>
        public bool MarkAsRead(int notificationId)
        {
            bool result = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    string sql = "UPDATE Notifications SET isRead = 1 WHERE notification_id = @NotificationId";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NotificationId", notificationId);
                        command.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, true);
            }
            return result;
        }
    }
}
