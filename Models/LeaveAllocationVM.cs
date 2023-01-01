using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeVM Employee { get; set; } = default!;
        public string? EmployeeId { get; set; }
        public DetialsLeaveTypeVM LeaveType { get; set; } = default!;
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> Employees { get; set; } = default!;
        public IEnumerable<SelectListItem> LeaveTypes { get; set; } = default!;

    }
}
