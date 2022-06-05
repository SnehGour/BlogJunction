using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Body { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public Users User { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
    }
}