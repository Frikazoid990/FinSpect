using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FinSpect.Domain.Entities.BaseEntities.Interfaces;

namespace FinSpect.Domain.Entities.BaseEntities;

public abstract class BaseEntity : IEntity, IAuditableEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}