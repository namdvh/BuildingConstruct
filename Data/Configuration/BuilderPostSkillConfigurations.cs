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
    public class BuilderPostSkillConfigurations : IEntityTypeConfiguration<BuilderPostSkill>
    {

        public void Configure(EntityTypeBuilder<BuilderPostSkill> builder)
        {
            builder.ToTable("BuilderPostSkill");
            builder.HasKey(x => new { x.SkillID, x.BuilderPostID });


            builder.HasOne(x => x.BuilderPost).WithMany(x => x.BuilderPostSkills).HasForeignKey(x => x.BuilderPostID);
            builder.HasOne(x => x.Skills).WithMany(x => x.BuilderPostSkills).HasForeignKey(x => x.SkillID);
        }
    }
}
