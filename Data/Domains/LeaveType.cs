using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Data.Domains
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
