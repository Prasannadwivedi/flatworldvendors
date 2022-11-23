using System.ComponentModel.DataAnnotations;

namespace flatworldvendor.Models
{
    public class Partner
    {
        [Key]
        public int PartnersID { get; set; }
        [Required]
        public string PartnerName { get; set; }
        public DateTime RegistredDate { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string SPOCName { get; set; }
        public string SPOCEmail { get; set; }
        public string Status { get; set; }
        public string Skillset { get; set; }
        public string TemAddress { get; set; }
        public string BillAddress { get; set; }

    }
}
