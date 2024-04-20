using MySql.Data.MySqlClient;
using System.Data;

namespace SearchNow.src.objects.user
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Bio { get; set; }
        public string Role { get; set; }
        public string AccountStatus { get; set; }

    }
}
