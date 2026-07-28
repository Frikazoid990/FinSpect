
using FinSpect.Domain;
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
        var transactionsEntity = modelBuilder.Entity<Transaction>()
            .ToTable("Transactions");
        transactionsEntity.HasKey(e => e.Id);
        transactionsEntity.Property(e => e.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd(); // Генерация Guid на стороне БД или приложения
        
        transactionsEntity.Property(e => e.Currency)
            .HasColumnName("currency")
            .IsRequired();
        
        transactionsEntity.Property(e => e.Amount)
            .HasColumnName("amount")
            .IsRequired()
            .HasColumnType("decimal(18,2)");
        


    }
}