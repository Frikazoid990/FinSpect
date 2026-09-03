using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FinSpect.Application.Common.Filters;

public class ExceptionFilter : IExceptionFilter, IAsyncExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is ValidationException)
        {
            context.Result = new ObjectResult(new { error = context.Exception.Message })
            {
                StatusCode = StatusCodes.Status422UnprocessableEntity
            };
        }
        context.ExceptionHandled = true;
    }
    
    public Task OnExceptionAsync(ExceptionContext context)
    {
        if (context.Exception is ValidationException)
        {
            context.Result = new ObjectResult(new { error = context.Exception.Message })
            {
                StatusCode = StatusCodes.Status422UnprocessableEntity
            };
        }
        context.ExceptionHandled = true;
        return Task.CompletedTask;
    }
}