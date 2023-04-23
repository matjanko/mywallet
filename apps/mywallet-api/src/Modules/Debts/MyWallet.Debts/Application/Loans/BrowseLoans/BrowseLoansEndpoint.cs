using Dapper;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using MyWallet.Abstractions.Dabatase;
using MyWallet.Debts.Shared.Dto;

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
        const string sql = @$"
            SELECT 
                lo.loan_id as Id, 
                lo.summary,
                lo.lender_id as LenderId,
                le.lender_id as Id,
                le.name as Name
            FROM debts.loans lo
            LEFT JOIN debts.lenders le ON lo.lender_id = le.lender_id";
        
        var loans = connection.Query<LoanDto, LenderDto, LoanDto>(sql, (loan, lender) =>
        {
            loan.Lender = lender;
            return loan;
        }, splitOn: "LenderId").ToList();
        
        await SendAsync(loans, cancellation: ct);
    }
}