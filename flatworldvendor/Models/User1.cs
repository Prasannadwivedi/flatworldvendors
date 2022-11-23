using System.ComponentModel.DataAnnotations;

namespace flatworldvendor.Models
{
    public class User1
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public int RoleId { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
