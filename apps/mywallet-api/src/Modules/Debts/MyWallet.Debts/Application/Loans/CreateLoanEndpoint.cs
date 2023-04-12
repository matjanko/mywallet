using FastEndpoints;

namespace MyWallet.Debts.Application.Loans;

public class CreateLoanEndpoint : Endpoint<CreateLoanRequest, CreateLoanResponse>
{
    public override void Configure()
    {
        Post("/api/loans");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateLoanRequest req, CancellationToken ct)
    {
        var response = new CreateLoanResponse();
        await SendAsync(response, cancellation: ct);
    }
}