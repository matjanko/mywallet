using FastEndpoints;
using FluentValidation;

namespace MyWallet.Debts.Application.Loans.CreateLoan;

internal class CreateLoanRequestValidator : Validator<CreateLoanRequest>
{
    public CreateLoanRequestValidator()
    {
        RuleFor(x => x.Summary)
            .NotEmpty()
            .WithMessage("Summary is required")
            .MaximumLength(150)
            .WithMessage("Summary is too long");
    }
}