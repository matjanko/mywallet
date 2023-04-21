using FastEndpoints;

namespace MyWallet.Debts.Application.Loans.CreateLoan;

internal class CreateLoanSummary : Summary<CreateLoanEndpoint>
{
    public CreateLoanSummary()
    {
        Summary = "Create a new loan";
    }
}
