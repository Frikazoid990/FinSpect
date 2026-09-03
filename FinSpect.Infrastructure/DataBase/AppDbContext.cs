using FinSpect.Domain.Entities;
using FinSpect.Domain.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace FinSpect.Infrastructure.DataBase;

public class AppDbContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ApplyAuditFields();
        return base.SaveChangesAsync(true, cancellationToken);
    }

    private void ApplyAuditFields()
    {
        var date = DateTime.UtcNow;
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = date;
                    entry.Entity.UpdatedAt = date;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAt = date;
                    break;
            }
        }
    }
}