using MyWallet.Debts.Shared.Dto;

namespace MyWallet.Debts.Application.Loans.BrowseLoans;

public class LoanDto
{
    public int Id { get; set; }
    public string Summary { get; set; }
    public LenderDto Lender { get; set; }
}