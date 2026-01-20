using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
    }
}