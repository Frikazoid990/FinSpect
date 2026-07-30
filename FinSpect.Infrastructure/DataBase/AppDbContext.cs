
using FinSpect.Domain;
using FinSpect.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FinSpect.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new TransactionConfiguration().Configure(modelBuilder.Entity<Transaction>());
    }
}