using Dapper;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using MyWallet.Abstractions.Dabatase;

namespace MyWallet.Debts.Application.Loans.BrowseLoans;

[HttpGet("loans")]
[AllowAnonymous]
internal class BrowseLoansEndpoint : Endpoint<BrowseLoansRequest, IEnumerable<LoanDto>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;
    
    public BrowseLoansEndpoint(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public override async Task HandleAsync(BrowseLoansRequest req, CancellationToken ct)
    {
        using var connection = _sqlConnectionFactory.GetConnection();
        const string sql = $"SELECT id, summary FROM debts.loans";
        var loans = connection.Query<LoanDto>(sql).ToList();
        await SendAsync(loans, cancellation: ct);
    }
}