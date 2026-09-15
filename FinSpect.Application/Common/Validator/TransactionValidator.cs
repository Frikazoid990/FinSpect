using FinSpect.Domain.Entities;
using FluentValidation;

namespace FinSpect.Application.Common.Validator;

public class TransactionValidator : AbstractValidator<Transaction>
{ 
    public TransactionValidator()
    {
        RuleFor(t => t)
            .NotNull();
        RuleFor(t => t.Amount)
            .NotEqual(0)
            .LessThan(0)
            .WithMessage("Amount can't be zero");
        RuleFor(t => t.Category)
            .NotNull()
            .NotEmpty()
            .WithMessage("Category can't be empty");
        RuleFor(t => t.Currency);
    }
}