using System.ComponentModel.DataAnnotations;

namespace Labb_1_MVC_o_Razor_v2.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
