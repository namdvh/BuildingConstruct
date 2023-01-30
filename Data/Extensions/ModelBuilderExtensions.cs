using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = Guid.Parse("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                Description = "Admin",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
           new Role
           {
               Id = Guid.Parse("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
               Description = "User",
               Name = "User",
               NormalizedName = "USER"
           },
            new Role
            {
                Id = Guid.Parse("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                Description = "Contractor",
                Name = "Contractor",
                NormalizedName = "CONTRACTOR"
            },
            new Role
            {
                Id = Guid.Parse("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                Description = "Store",
                Name = "Store",
                NormalizedName = "STORE"
            });
            //user
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                Email = "namhoaidoan15@gmail.com",
                UserName= "namhoaidoan15@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Hoai",
                LastName = "Nam",
                DOB = new DateTime(2001, 4, 30),
                PhoneNumber = "0879411575",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar=null,
                BuilderId=1,
                Address="18, Phuoc Thien, Nhon Trach, Dong Nai"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                UserId = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
            });
            modelBuilder.Entity<Builder>().HasData(new Builder()
            {
                Id = 1,
                CreateBy=Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                Place=Enum.Place._60 
            }) ;
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                Email = "namhoaidoan1@gmail.com",
                UserName = "namhoaidoan1@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Hoai",
                LastName = "Nam Doan Vu",
                DOB = new DateTime(2001, 4, 30),
                PhoneNumber = "0392799276",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                BuilderId = 2,
                Address = "18, Phuoc Thien, Nhon Trach, Dong Nai"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                UserId = Guid.Parse("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
            });
            modelBuilder.Entity<Builder>().HasData(new Builder()
            {
                Id = 2,
                CreateBy = Guid.Parse("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                Place = Enum.Place._61
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                Email = "namhoai1@gmail.com",
                UserName = "namhoai1@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Store",
                LastName = "Nguyen Anh Vu",
                DOB = new DateTime(1999, 4, 30),
                PhoneNumber = "0123456789",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level2,
                Avatar = null,
                MaterialStoreID = 1,
                Address = "18, Phuoc Thien, Nhon Trach, Dong Nai"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                UserId = Guid.Parse("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
            });
            modelBuilder.Entity<MaterialStore>().HasData(new MaterialStore()
            {
                Id = 1,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                Place = Enum.Place._52
            });
        }
    }
}
