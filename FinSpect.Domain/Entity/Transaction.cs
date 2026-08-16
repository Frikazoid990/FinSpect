using System.ComponentModel.DataAnnotations.Schema;
using FinSpect.Domain.Enums;

namespace FinSpect.Domain;

[Table("Transactions", Schema = "dbo")]
public class Transaction
{
    /// <summary>
    /// Номер транзакции 
    /// </summary>
    public Guid Id { get; set; }
    
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
    public Currency Currency { get; set; }
    
    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Дата последнего обновления
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}