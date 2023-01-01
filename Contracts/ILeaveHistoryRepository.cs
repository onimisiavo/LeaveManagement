using LeaveManagement.Data.Domains;

namespace LeaveManagement.Contracts
{
    public interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
        ICollection<LeaveHistory> GetLeaveHistoryByEmployee (int id);
    }
}
