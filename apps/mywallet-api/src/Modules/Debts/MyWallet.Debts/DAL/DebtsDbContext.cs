using Microsoft.EntityFrameworkCore;
using MyWallet.Debts.Entities;

namespace MyWallet.Debts.DAL;

internal sealed class DebtsDbContext : DbContext
{
    public DbSet<Loan> Loans { get; set; }

    public DebtsDbContext(DbContextOptions<DebtsDbContext> options) : base(options)
    {
        Loans = Set<Loan>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("debts");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
