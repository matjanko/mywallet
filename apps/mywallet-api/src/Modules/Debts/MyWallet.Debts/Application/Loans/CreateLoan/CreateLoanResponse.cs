
using MyWallet.Debts.Shared.Dto;

namespace MyWallet.Debts.Application.Loans.CreateLoan;

internal class CreateLoanResponse
{
    public int Id { get; set; }
    public string Summary { get; set; } = string.Empty;
    public LenderDto? Lender { get; set; }
}
