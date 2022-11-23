using System.ComponentModel.DataAnnotations;

namespace flatworldvendor.Models
{
    public class Resource
    {

       
        [Key]
        public int ResourceId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public long Pincode { get; set; }
        public string Summary { get; set; }
        public string Skills { get; set; }
        public string Company { get; set; }
        public DateTime Startdate { get; set; }
        public string University { get; set; }

        public string Degree { get; set; }
        public DateTime Date { get; set; }
        public DateTime EndDate { get; set; }
        public string Language { get; set; }
    }
}
