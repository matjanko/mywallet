using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWallet.Debts.Domain.Entities;

namespace MyWallet.Debts.Persistence.Configurations;

internal class LenderConfiguration : IEntityTypeConfiguration<Lender>
{
    public void Configure(EntityTypeBuilder<Lender> builder)
    {
        builder.ToTable("lenders");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("lender_id").ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
    }
}