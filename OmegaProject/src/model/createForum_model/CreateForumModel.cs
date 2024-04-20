using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using SearchNow.src.objects.user;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = SearchNow.src.objects.user.User;

namespace SearchNow.src.model.createForum_model
{
    public class CreateForumModel
    {
        public bool createForum(string forumName,string forumDescription,User currentUser)
        {
            bool result = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    using (MySqlCommand command = new MySqlCommand("createForum", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_forum_name", forumName);
                        command.Parameters.AddWithValue("@p_forum_description", forumDescription);
                        command.Parameters.AddWithValue("@p_creator_user_id", currentUser.Id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result = true;   
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error communicating with the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }


    }
}
