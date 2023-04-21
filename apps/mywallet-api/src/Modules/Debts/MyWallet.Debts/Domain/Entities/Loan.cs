namespace MyWallet.Debts.Domain.Entities;

public class Loan
{
    public int Id { get; }
    public string Summary { get; }

    public Loan(string summary)
    {
        Summary = summary;
    }
}
