using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class ContractorPostProductsConfiguration : IEntityTypeConfiguration<ContractorPostProduct>
    {
        public void Configure(EntityTypeBuilder<ContractorPostProduct> builder)
        {
            builder.ToTable("ContractorPostProduct");
            builder.HasKey(x => new { x.ProductSystemID, x.ContractorPostID });


            builder.HasOne(x => x.ContractorPost).WithMany(x =>x.ContractorPostProducts).HasForeignKey(x => x.ContractorPostID);
            builder.HasOne(x => x.ProductSystem).WithMany(x => x.ContractorPostProducts).HasForeignKey(x => x.ProductSystemID);
        }
    }
}
