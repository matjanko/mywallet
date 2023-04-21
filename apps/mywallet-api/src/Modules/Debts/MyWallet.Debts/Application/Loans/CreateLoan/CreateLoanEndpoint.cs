using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using MyWallet.Debts.Domain.Entities;
using MyWallet.Debts.Persistence;

namespace MyWallet.Debts.Application.Loans.CreateLoan;

[HttpPost("loans")]
[AllowAnonymous]
internal class CreateLoanEndpoint : Endpoint<CreateLoanRequest, CreateLoanResponse>
{
    private readonly DebtsDbContext _context;

    public CreateLoanEndpoint(DebtsDbContext context)
    {
        _context = context;
    }

    public override async Task HandleAsync(CreateLoanRequest req, CancellationToken ct)
    {
        var loan = new Loan(req.Summary);
        await _context.Loans.AddAsync(loan, cancellationToken: ct);
        await _context.SaveChangesAsync(ct);
        
        var response = new CreateLoanResponse
        {
            Id = loan.Id,
            Summary = loan.Summary
        };
        
        await SendAsync(response, cancellation: ct);
    }
}
