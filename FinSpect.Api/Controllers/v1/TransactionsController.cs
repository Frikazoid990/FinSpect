using Asp.Versioning;
using FinSpect.Application.Common.Interfaces.Services;
using FinSpect.Application.Common.Models.Dto;
using FinSpect.Application.Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinSpect.Api.Controllers.v1;

[ApiController]
[ApiVersion(1.0)]
[Route( "api/v{version:apiVersion}/transactions" )]
public class TransactionsController(ITransactionService transactionService) : ControllerBase
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateTransaction([FromBody]  TransactionDto transaction)
    {
        try
        {
            await transactionService.CreateTransaction(transaction);
            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    
}