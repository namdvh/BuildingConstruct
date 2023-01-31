using Data.Entities;
using Microsoft.AspNet.Identity;
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
            var hasher = new Microsoft.AspNetCore.Identity.PasswordHasher<User>();
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
                PasswordHash = hasher.HashPassword(null,"Hoainam@123"),
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


            //user 2 

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d8"),
                Email = "anhthinh@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Thinh",
                LastName = "Nguyen",
                UserName = "0937341639",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "0937341639",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                BuilderId = 2,
                Address = "Q2"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                UserId = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d8"),
            });
            modelBuilder.Entity<Builder>().HasData(new Builder()
            {
                Id = 2,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d8"),
                Place = Enum.Place._59
            });



            //contractor
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                Email = "contractor@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Contractor",
                LastName = "Contractor",
                UserName = "0912345678",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "0912345678",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                ContractorId = 1,
                Address = "Q2"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                UserId = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7"),
            });
            modelBuilder.Entity<Contractor>().HasData(new Contractor()
            {
                Id = 1,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d8"),
            });


            //contractor 2
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                Email = "contractor2@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Contractor2",
                LastName = "Contractor2",
                UserName = "09987654321",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "09987654321",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                ContractorId = 2,
                Address = "Q2"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                UserId = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
            });
            modelBuilder.Entity<Contractor>().HasData(new Contractor()
            {
                Id = 2,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
            });


            //store 

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("b57b172a-a044-11ed-a8fc-0242ac120002"),
                Email = "store@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Store",
                LastName = "Store",
                UserName = "0924516734",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "0924516734",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                MaterialStoreID = 1,
                Address = "Q2"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                UserId = Guid.Parse("b57b172a-a044-11ed-a8fc-0242ac120002"),
            });
            modelBuilder.Entity<MaterialStore>().HasData(new MaterialStore()
            {
                Id = 1,
                CreateBy = Guid.Parse("b57b172a-a044-11ed-a8fc-0242ac120002"),
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("be21b564-a044-11ed-a8fc-0242ac120002"),
                Email = "store2@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Store2",
                LastName = "Store2",
                UserName = "09245167342",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "09245167342",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                MaterialStoreID = 2,
                Address = "Q2"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                UserId = Guid.Parse("be21b564-a044-11ed-a8fc-0242ac120002"),
            });
            modelBuilder.Entity<MaterialStore>().HasData(new MaterialStore()
            {
                Id = 2,
                CreateBy = Guid.Parse("be21b564-a044-11ed-a8fc-0242ac120002"),
            });


            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=1,
                Name="Product 1",
                UnitPrice=4000,
                UnitInStock=1000,
                Image=null,
                Description="Description 1",
                Brand="Kangaroo",
                SoldQuantities=100,
                MaterialStoreID=1
            });

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 2,
                Name = "Product 2",
                UnitPrice = 5000,
                UnitInStock = 1200,
                Image = null,
                Description = "Description 2",
                Brand = "Sony",
                SoldQuantities = 1000,
                MaterialStoreID = 1
            });

            modelBuilder.Entity<Products>().HasData(new Products
            {

                Id = 3,
                Name = "Product 3",
                UnitPrice = 6000,
                UnitInStock = 100,
                Image = null,
                Description = "Description 3",
                Brand = "Samsung",
                SoldQuantities = 100,
                MaterialStoreID = 1
            });

        }
    }
}
