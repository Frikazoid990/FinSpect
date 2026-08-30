namespace FinSpect.Domain.Entities.BaseEntities.Interfaces;

public interface IAuditableEntity 
{
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
}