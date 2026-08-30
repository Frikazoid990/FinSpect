using FinSpect.Domain.Entities.BaseEntities.Interfaces;

namespace FinSpect.Domain.Entities.BaseEntities;

public abstract class BaseEntity : IEntity, IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}