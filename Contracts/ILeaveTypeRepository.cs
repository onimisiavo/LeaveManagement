using LeaveManagement.Data.Domains;

namespace LeaveManagement.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetLeaveTypeByEmployee(int id);
    }
}
