using FinSpect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinSpect.Infrastructure.DataBase.Configuration;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    { 
        builder.ToTable("Transactions")
            .HasIndex(e => e.Id);
        
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd() // Генерация Guid на стороне БД или приложения
            .HasColumnType("guid")
            .HasConversion<Guid>()
            .IsRequired();

        builder.Property(e => e.Currency)
            .HasColumnName("currency")
            .HasConversion<byte>()
            .IsRequired();
        
        builder.Property(e => e.Amount)
            .HasColumnName("amount")
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.Category)
            .HasColumnName("category")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.CreatedAt)
            .HasColumnName("createdAt")
            .IsRequired()
            .HasColumnType("datetime");

        builder.Property(e => e.UpdatedAt)
            .HasColumnName("updatedAt")
            .IsRequired()
            .HasColumnType("datetime");
    }
}