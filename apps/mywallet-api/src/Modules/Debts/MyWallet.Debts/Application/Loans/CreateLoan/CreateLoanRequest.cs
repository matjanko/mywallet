namespace MyWallet.Debts.Application.Loans.CreateLoan;

internal class CreateLoanRequest
{
    public int LenderId { get; set; }
    public string Summary { get; set; } = string.Empty;
}
