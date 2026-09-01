using System.ComponentModel.DataAnnotations.Schema;
using FinSpect.Domain.Entities.BaseEntities;
using FinSpect.Domain.Enums;

namespace FinSpect.Domain.Entities;

[Table("Transactions", Schema = "dbo")]
public class Transaction : BaseEntity
{
    /// <summary>
    /// Сумма транзакции
    /// </summary>
    public decimal Amount { get; set; }
    
    /// <summary>
    /// Категория транзакции
    /// </summary>
    public string Category { get; set; }

    /// <summary>
    /// Валюта 
    /// </summary>
    public byte Currency { get; set; }
}