using System.Text.Json.Serialization;

namespace FinSpect.Application.Common.Models.Dto;

public sealed class TransactionDto
{
    /// <summary>
    /// Идендификатор транзакции
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Сумма транзакции
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }
    
    /// <summary>
    /// Категория транзакции
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    /// <summary>
    /// Валюта 
    /// </summary>
    [JsonPropertyName("currency")]
    public byte Currency { get; set; }
    
    /// <summary>
    /// Дата создания транзакции
    /// </summary>
    [JsonPropertyName("createAt")]
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    
}