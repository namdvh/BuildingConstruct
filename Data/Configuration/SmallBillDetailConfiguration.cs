using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class SmallBillDetailConfiguration : IEntityTypeConfiguration<SmallBillDetail>
    {
        public void Configure(EntityTypeBuilder<SmallBillDetail> builder)
        {
            builder.ToTable("SmallBillDetail");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasOne(x => x.SmallBill).WithMany(x => x.Details).HasForeignKey(x => x.SmallBillID);
            builder.HasOne(x => x.Products).WithMany(x => x.SmallBillDetails).HasForeignKey(x => x.ProductID);
        }

    }
}
