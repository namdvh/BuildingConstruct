using Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class BillDetailConfigurations : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.ToTable("BillDetail");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasOne(x => x.Bill).WithMany(x => x.BillDetails).HasForeignKey(x => x.BillId);
            builder.HasOne(x => x.Products).WithMany(x => x.BillDetails).HasForeignKey(x => x.ProductID);
        }

    }
}
