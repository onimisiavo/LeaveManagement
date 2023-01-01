using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Data.Domains
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
