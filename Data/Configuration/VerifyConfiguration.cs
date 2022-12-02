using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class VerifyConfiguration : IEntityTypeConfiguration<Verify>
    {
        public void Configure(EntityTypeBuilder<Verify> builder)
        {
            builder.ToTable("Verifies");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LastModifiedAt).HasDefaultValueSql("getutcdate()");

            builder
                   .HasOne(x => x.User)
                   .WithOne(x => x.Verify).HasForeignKey<User>(x => x.VerifyID);
        }
    }
}
