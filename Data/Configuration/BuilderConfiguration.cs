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
    public class BuilderConfiguration : IEntityTypeConfiguration<Entities.Builder>
    {

        public void Configure(EntityTypeBuilder<Entities.Builder> builder)
        {
            builder.ToTable("Builders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.LastModifiedAt).HasDefaultValueSql("getutcdate()");


            builder
                   .HasOne(x => x.User)
                   .WithOne(x => x.Builder).HasForeignKey<User>(x => x.BuilderId).IsRequired(false);

        }
    }
}
