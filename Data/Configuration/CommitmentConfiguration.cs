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
    public class CommitmentConfiguration : IEntityTypeConfiguration<Commitment>
    {
        public void Configure(EntityTypeBuilder<Commitment> builder)
        {
            builder.ToTable("Commitment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                  .ValueGeneratedOnAdd();
        }

    }
}
