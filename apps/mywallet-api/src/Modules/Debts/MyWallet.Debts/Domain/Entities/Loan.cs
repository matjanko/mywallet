namespace MyWallet.Debts.Domain.Entities;

public class Loan
{
    public int Id { get; }
    public int LenderId { get; }
    public string Summary { get; }
    
    
    public Loan(string summary, int lenderId)
    {
        Summary = summary;
        LenderId = lenderId;
    }
}
