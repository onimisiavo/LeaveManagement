using LeaveManagement.Data.Domains;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Models
{
    public class LeaveHistoryVM
    {
        public int Id { get; set; }
        public EmployeeVM RequestingEmployeeId { get; set; } = default!;
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DetialsLeaveTypeVM LeaveType { get; set; } = default!;
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; } = default!;
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public EmployeeVM ApprovedBy { get; set; } = default!;
        public string ApprovedById { get; set; } = default!;
    }
}
