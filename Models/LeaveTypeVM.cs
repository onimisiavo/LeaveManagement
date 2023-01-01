using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class DetialsLeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public DateTime DateCreated { get; set; }
    } 
    
    public class CreateLeaveTypeVM
    {
        [Required]
        public string? Name { get; set; }
    }
}
