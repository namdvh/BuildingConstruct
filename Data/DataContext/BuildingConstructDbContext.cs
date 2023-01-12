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
            modelBuilder.ApplyConfiguration(new ProductSystemCategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSystemConfiguration());
            modelBuilder.ApplyConfiguration(new VerifyConfiguration());
            modelBuilder.ApplyConfiguration(new BuilderSkillConfiguration());
            modelBuilder.ApplyConfiguration(new ContractorPostSkillConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new GroupMemberConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ContractorPostProductsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new AppliedPostConfiguration());
            modelBuilder.ApplyConfiguration(new CommitmentConfiguration());
            modelBuilder.ApplyConfiguration(new PostCommitmentsConfigurations());
            modelBuilder.ApplyConfiguration(new ContractorPostTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BuilderPostTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BuilderPostSkillConfigurations());
            modelBuilder.ApplyConfiguration(new SaveConfiguration());
            modelBuilder.ApplyConfiguration(new SystemCategoriesConfiguration());

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
        public DbSet<Entities.Type> Types { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }    
        public DbSet<ContractorPostProduct> ContractorPostProducts { get; set; }    
        public DbSet<Categories> Categories { get; set; }    
        public DbSet<ProductCategories> ProductCategories { get; set; }    
        public DbSet<ProductSystem> ProductSystems { get; set; }    
        public DbSet<ProductSystemCategories> ProductSystemCategories { get; set; }    
        public DbSet<AppliedPost> AppliedPosts { get; set; }    
        public DbSet<PostCommitment> PostCommitments { get; set; }    
        public DbSet<Commitment> Commitments { get; set; }    
        public DbSet<ContractorPostType> ContractorPostTypes { get; set; }    
        public DbSet<BuilderPostType> BuilderPostTypes { get; set; }    
        public DbSet<BuilderPostSkill> BuilderPostSkills { get; set; }    
        public DbSet<Save> Saves { get; set; }    
        public DbSet<SystemCategories> SystemCategories { get; set; }    
    }
}
