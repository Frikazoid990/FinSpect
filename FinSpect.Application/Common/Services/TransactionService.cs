using System.ComponentModel.DataAnnotations;
using FinSpect.Application.Common.Interfaces.Repository;
using FinSpect.Application.Common.Interfaces.Services;
using FinSpect.Application.Common.Models.Dto;
using FinSpect.Domain.Entities;
using FinSpect.Domain.Enums;

namespace FinSpect.Application.Common.Services;

public class TransactionService(ITransactionRepository transactionRepository) : ITransactionService
{
    public async Task CreateTransaction(TransactionDto transaction)
    {
        if (transaction is null)
        {
            throw new ValidationException("Not valid transaction");
        }

        if (transaction.Amount == 0)
        {
            throw new ValidationException("Amount can't be zero");
        }

        if (transaction.Amount < 0)
        {
            throw new ValidationException("Amount can't be negative");
        }

        //if(Curreny) // todo
      //  var  s = Enum.IsDefined(typeof(Currency), transaction.Currency);
        
        var entity = new Transaction
        {
            Id = Guid.NewGuid(),
            Amount = transaction.Amount,
            Category = transaction.Category,
            Currency = transaction.Currency,
        };
        await transactionRepository.Add(entity);
    }

    public Task<TransactionDto> GetTransaction(Guid id)
    {
        throw new NotImplementedException();
    }
}