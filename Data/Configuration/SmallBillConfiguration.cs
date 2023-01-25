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
    public class SmallBillConfiguration : IEntityTypeConfiguration<SmallBill>
    {
        public void Configure(EntityTypeBuilder<SmallBill> builder)
        {
            builder.ToTable("SmallBill");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasOne(x => x.Bill).WithMany(x => x.SmallBills).HasForeignKey(x => x.BillID);
        }

    }
}
