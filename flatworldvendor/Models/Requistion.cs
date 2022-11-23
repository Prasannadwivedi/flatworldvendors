using System.ComponentModel.DataAnnotations;

namespace flatworldvendor.Models
{
    public class Requistion
    {

        [Key]
        public int ReqId { get; set; }
        [Required]
        public int PotentialId { get; set; }
        public string Complexity { get; set; }
        public string ClientName { get; set; }
        public string ProjectType { get; set; }
        public string SalesPerson { get; set; }
        public string ProjectManager { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public string Tenurre { get; set; }
        public string MinExprience { get; set; }
        public string MaxExprience { get; set; }
        public string Description { get; set; }
        public int Resource { get; set; }
        public int OpenPosition { get; set; }

    }
}
