using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}