﻿namespace LeaveManagement.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
