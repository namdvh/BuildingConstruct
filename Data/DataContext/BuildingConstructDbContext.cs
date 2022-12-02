using Data.Configuration;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataContext
{
    public class BuildingConstructDbContext : IdentityDbContext<User, Role, Guid>
    {
        public BuildingConstructDbContext()
        {
        }
        public BuildingConstructDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContractorPostConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialStoreConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new ContractorConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new VerifyConfiguration());
            modelBuilder.ApplyConfiguration(new BuilderSkillConfiguration());
            modelBuilder.ApplyConfiguration(new ContractorPostSkillConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens").HasKey(x => x.UserId);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Builder> Builders { get; set; }
        public DbSet<BuilderPost> BuilderPosts { get; set; }
        public DbSet<BuilderSkill> BuilderSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Verify> Verifies { get; set; }
        public DbSet<MaterialStore> MaterialStores { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ContractorPost> ContractorPosts { get; set; }
        public DbSet<ContractorPostSkill> ContractorPostSkills { get; set; }
    }
}
