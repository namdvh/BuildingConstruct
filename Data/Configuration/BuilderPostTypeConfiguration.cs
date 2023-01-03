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
    public class BuilderPostTypeConfiguration : IEntityTypeConfiguration<BuilderPostType>
    {

        public void Configure(EntityTypeBuilder<BuilderPostType> builder)
        {
            builder.ToTable("BuilderPostType");
            builder.HasKey(x => new { x.TypeID, x.BuilderPostID });


            builder.HasOne(x => x.BuilderPosts).WithMany(x => x.BuilderPostTypes).HasForeignKey(x => x.BuilderPostID);
            builder.HasOne(x => x.Types).WithMany(x => x.BuilderPostTypes).HasForeignKey(x => x.TypeID);
        }
    }
}
