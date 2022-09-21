using System.ComponentModel.DataAnnotations;

namespace Labb_1_MVC_o_Razor_v2.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [MinLength(7)]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MinLength(9)]
        public string PhoneNumber { get; set; }
    }
}
