using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}