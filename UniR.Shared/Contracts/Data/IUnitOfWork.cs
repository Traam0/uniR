using System.Threading;
using System.Threading.Tasks;

namespace UniR.Contracts.Interfaces;

public interface IUnitOfWork
{
    bool CommitChanges();
    Task<bool> CommitChangesAsync(CancellationToken cancellationToken);
    void RollbackChanges();
}