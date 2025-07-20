using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UniR.Domain.Common.Abstract;

namespace UniR.Contracts.Repositories;

public interface IRepository<in TKey, TEntity> where TEntity : Entity where TKey : notnull
{
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<TEntity?> FindByIdAsync(TKey id, CancellationToken cancellationToken = default);
    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
}