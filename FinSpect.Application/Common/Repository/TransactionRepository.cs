using EFCore.BulkExtensions;
using FinSpect.Application.Common.Interfaces.Repository;
using FinSpect.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;
using Transaction = FinSpect.Domain.Entities.Transaction;

namespace FinSpect.Application.Common.Repository;

public class TransactionRepository(AppDbContext context) : ITransactionRepository
{
    public async Task Add(Transaction entity)
    {
        context.Transactions.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task AddRange(List<Transaction> entities)
    {
        var data = DateTime.UtcNow;

        foreach (var entity in entities)
        {
            entity.CreatedAt = data;
            entity.UpdatedAt = data;
        }
        
        await context.BulkInsertAsync(entities);
    }

    public async Task RemoveEntityById(Guid id)
    {
        var entity = await GetEntityById(id);
        context.Transactions.Remove(entity);
        await context.SaveChangesAsync();
    }

    public async Task RemoveEntitysByIdsRange(List<Guid> ids)
    {
        var entitysList = await GetEntitysByIds(ids);
        context.Transactions.RemoveRange(entitysList);
        await context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<Transaction>> GetAllTransactions()
    {
        return await context.Transactions
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task Update(Transaction entity)
    {
        context.Transactions.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateRange(List<Transaction> entities)
    {
        context.Transactions.UpdateRange(entities);
        await context.SaveChangesAsync();
    }

    public async Task<Transaction> GetEntityById(Guid id)
    {
        return await context.Transactions
            .FirstAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Transaction>> GetEntitysByIds(List<Guid> ids)
    {
        return await context.Transactions
            .Where(x => ids.Contains(x.Id))
            .ToListAsync();
    }
}