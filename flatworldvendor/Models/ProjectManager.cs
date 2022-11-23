using System.ComponentModel.DataAnnotations;

namespace flatworldvendor.Models
{
    public class ProjectManager
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public int EmployeeName { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Qualification { get; set; }
        public string skills { get; set; }
        public string Language { get; set; }
        public string Email { get; set; }
        public int Exprience { get; set; }
        public long Mobile { get; set; }
    }
}
