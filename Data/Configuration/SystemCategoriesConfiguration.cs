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
    public class SystemCategoriesConfiguration : IEntityTypeConfiguration<SystemCategories>
    {
        public void Configure(EntityTypeBuilder<SystemCategories> builder)
        {
            builder.ToTable("SystemCategories");
            builder.HasKey(x => x.ID);

        }
    }

}
