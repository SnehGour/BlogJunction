using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Body { get; set; }
        public Users User { get; set; }
        public Categories Category { get; set; }
    }
}