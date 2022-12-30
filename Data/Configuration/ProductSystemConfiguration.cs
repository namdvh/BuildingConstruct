using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProductSystemConfiguration : IEntityTypeConfiguration<ProductSystem>
    {
            public void Configure(EntityTypeBuilder<ProductSystem> builder)
            {
                builder.ToTable("ProductSystems");

                builder.HasKey(x => x.Id);

                builder.Property(x => x.Id)
                      .ValueGeneratedOnAdd();
            }
    }
}
