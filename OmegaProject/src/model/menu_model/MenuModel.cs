using MySql.Data.MySqlClient;
using SearchNow.src.objects;
using System.Windows.Forms;

namespace SearchNow.src.model.menu_model
{
    /// <summary>
    /// Provides functionality related to menu operations.
    /// </summary>
    public class MenuModel
    {
        /// <summary>
        /// Loads forums data into the specified ListBox control based on the selected filter and search term.
        /// </summary>
        /// <param name="listBoxForums">The ListBox control to populate with forum names.</param>
        /// <param name="filterBox">The ComboBox control used for filtering forum data.</param>
        /// <param name="searchTerm">The TextBox control containing the search term for filtering forum names.</param>
        public void LoadForums(ListBox listBoxForums, ComboBox filterBox, TextBox searchTerm)
        {
            try
            {
                listBoxForums.Items.Clear(); // Clear the ListBox items

                string orderByClause = "DESC"; // Default order by clause

                if (filterBox.SelectedItem != null)
                {
                    string sortOrder = filterBox.SelectedItem.ToString();
                    orderByClause = sortOrder == "From oldest to newest" ? "ASC" : "DESC";
                }

                // Construct the SQL query with optional search filter and order by clause
                string searchFilter = string.IsNullOrEmpty(searchTerm.Text) ? "" : " WHERE forum_name LIKE @searchTerm";
                string query = $"SELECT forum_name FROM forums{searchFilter} ORDER BY created_at {orderByClause}";

                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.GetConnection()))
                {
                    connection.Open();
                    // Create MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter for the search term
                        if (!string.IsNullOrEmpty(searchTerm.Text))
                            command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm.Text}%");

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string forumName = reader.GetString("forum_name");
                                listBoxForums.Items.Add(forumName);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message + ex.StackTrace, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load fun", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog(ex.Message + ex.StackTrace, true);
            }
        }
    }
}
