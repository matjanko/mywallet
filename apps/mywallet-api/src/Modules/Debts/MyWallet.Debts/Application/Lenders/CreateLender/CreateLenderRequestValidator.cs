using FastEndpoints;
using FluentValidation;

namespace MyWallet.Debts.Application.Lenders.CreateLender;

public class CreateLenderRequestValidator : Validator<CreateLenderRequest>
{
    public CreateLenderRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required")
            .MaximumLength(100)
            .WithMessage("Name is too long");
    }
}