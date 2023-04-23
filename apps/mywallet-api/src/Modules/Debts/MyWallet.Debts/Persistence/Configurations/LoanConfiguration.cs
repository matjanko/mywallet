using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWallet.Debts.Domain.Entities;

namespace MyWallet.Debts.Persistence.Configurations;

internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.ToTable("loans");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("loan_id").ValueGeneratedOnAdd();
        builder.Property(x => x.LenderId).HasColumnName("lender_id").IsRequired();
        builder.Property(x => x.Summary).HasColumnName("summary").HasMaxLength(150).IsRequired();

        builder.HasOne<Lender>().WithMany().HasForeignKey(x => x.LenderId);
    }
}
