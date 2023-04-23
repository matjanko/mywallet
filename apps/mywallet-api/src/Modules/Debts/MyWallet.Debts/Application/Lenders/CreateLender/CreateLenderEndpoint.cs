using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using MyWallet.Debts.Domain.Entities;
using MyWallet.Debts.Persistence;

namespace MyWallet.Debts.Application.Lenders.CreateLender;

[HttpPost("lenders")]
[AllowAnonymous]
internal class CreateLenderEndpoint : Endpoint<CreateLenderRequest, CreateLenderResponse>
{
    private readonly DebtsDbContext _context;
    
    public CreateLenderEndpoint(DebtsDbContext context)
    {
        _context = context;
    }

    public override async Task HandleAsync(CreateLenderRequest req, CancellationToken ct)
    {
        var lender = new Lender(req.Name);
        await _context.Lenders.AddAsync(lender, ct);
        await _context.SaveChangesAsync(ct);

        var response = new CreateLenderResponse
        {
            Id = lender.Id,
            Name = lender.Name
        };

        await SendAsync(response, cancellation: ct);
    }
}