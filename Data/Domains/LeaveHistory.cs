using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Data.Domains
{
    public class LeaveHistory
    {
        [Key]
        public int Id { get; set; }
        public Employee RequestingEmployeeId { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; } = default!;
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        [ForeignKey("ApprovedById")]
        public Employee ApprovedBy { get; set; } = default!;
        public string ApprovedById { get; set; } = default!;
    }
}
