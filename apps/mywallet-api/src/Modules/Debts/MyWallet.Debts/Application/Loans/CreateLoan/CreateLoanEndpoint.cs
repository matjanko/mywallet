using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MyWallet.Debts.Domain.Entities;
using MyWallet.Debts.Persistence;
using MyWallet.Debts.Shared.Dto;

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
        var lender = await _context.Lenders
            .FirstOrDefaultAsync(x => x.Id == req.LenderId, cancellationToken: ct);

        if (lender is null)
        {
            ThrowError("Lender not exists");
        }
        
        var loan = new Loan(req.Summary, req.LenderId);
        await _context.Loans.AddAsync(loan, cancellationToken: ct);
        await _context.SaveChangesAsync(ct);
        
        var response = new CreateLoanResponse
        {
            Id = loan.Id,
            Summary = loan.Summary,
            Lender = new LenderDto
            {
                Id = lender.Id,
                Name = lender.Name
            }
        };
        
        await SendAsync(response, cancellation: ct);
    }
}
