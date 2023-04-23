namespace MyWallet.Debts.Domain.Entities;

public class Lender
{
    public int Id { get; }
    public string Name { get; }

    public Lender(string name)
    {
        Name = name;
    }
}