using LeaveManagement.Data.Domains;

namespace LeaveManagement.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        ICollection<LeaveAllocation> GetLeaveAllocationByEmployee(int id);
    }
}
