using UniR.Domain.Common.Abstract;

namespace UniR.Domain.Common.Contracts;

public interface IRepository<in TKey, TEntity> where TEntity : Entity
{
    
}