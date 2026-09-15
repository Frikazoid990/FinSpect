using FinSpect.Domain.Entities.BaseEntities;

namespace FinSpect.Application.Common.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
{
    public Task Add(TEntity entity);
    public Task AddRange(List<TEntity> entities);
    
    public Task Update(TEntity entity);
    public Task UpdateRange(List<TEntity> entities);
    
    public Task<TEntity> GetEntityById(Guid id);
    public Task<IEnumerable<TEntity>> GetEntitysByIds(List<Guid> ids);
    
    public Task RemoveEntityById(Guid id);
    public Task RemoveEntitysByIdsRange(List<Guid> ids);
}