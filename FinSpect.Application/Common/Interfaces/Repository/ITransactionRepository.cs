using FinSpect.Domain.Entities;

namespace FinSpect.Application.Common.Interfaces.Repository;

public interface ITransactionRepository : IRepositoryBase<Transaction>
{
    public Task<IReadOnlyList<Transaction>> GetAllTransactions();
}