using FinSpect.Application.Common.Models.Dto;

namespace FinSpect.Application.Common.Interfaces.Services;

public interface ITransactionService
{
    public Task CreateTransaction(TransactionDto transaction);
    public Task<List<TransactionDto>> GetAllTransaction(); 
}