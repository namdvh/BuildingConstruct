﻿using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
                UserName = "namhoaidoan15@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Hoai",
                LastName = "Nam",
                DOB = new DateTime(2001, 4, 30),
                PhoneNumber = "0879411575",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                BuilderId = 1,
                Address = "18, Phuoc Thien, Nhon Trach, Dong Nai"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                UserId = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
            });
            modelBuilder.Entity<Builder>().HasData(new Builder()
            {
                Id = 1,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                Place = Enum.Place._60
            });
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
                UserId = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f4"),
            });
            modelBuilder.Entity<MaterialStore>().HasData(new MaterialStore()
            {
                Id = 1,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                Place = Enum.Place._52
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f5"),
                Email = "hoainam@gmail.com",
                UserName = "hoainam@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Store",
                LastName = "Dien May Xanh",
                DOB = new DateTime(1995, 5, 30),
                PhoneNumber = "033451444",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level2,
                Avatar = null,
                MaterialStoreID = 2,
                Address = "18, Phuoc Thien, Nhon Trach, Dong Nai"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                UserId = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f5"),
            });
            modelBuilder.Entity<MaterialStore>().HasData(new MaterialStore()
            {
                Id = 2,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f5"),
                Place = Enum.Place._51
            });
            //Contractor
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f6"),
                Email = "hoainam123@gmail.com",
                UserName = "hoainam123@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyen",
                LastName = "Hong",
                DOB = new DateTime(1995, 5, 30),
                PhoneNumber = "0333999444",
                Gender = Enum.Gender.FEMALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                ContractorId = 1,
                Address = "18, Phuoc Thien, Nhon Trach, Dong Nai"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                UserId = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f6"),
            });
            modelBuilder.Entity<Contractor>().HasData(new Contractor()
            {
                Id = 1,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f6"),
                CompanyName = "Bat dong san Vinhome",
                Website = "abcdef.com.vn"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                Email = "hoainam2001@gmail.com",
                UserName = "hoainam2001@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyen",
                LastName = "Duy",
                DOB = new DateTime(1995, 5, 30),
                PhoneNumber = "0333999444",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = null,
                ContractorId = 2,
                Address = "18, Phuoc Thien, Nhon Trach, Dong Nai"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                UserId = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f7"),
            });
            modelBuilder.Entity<Contractor>().HasData(new Contractor()
            {
                Id = 2,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                CompanyName = "Bat dong san Thang Long",
                Website = "nguyenduy.com.vn"
            });
            modelBuilder.Entity<Entities.Type>().HasData(new Entities.Type
            {
                Id = Guid.Parse("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0"),
                Name = "Thợ xây"
            });
            modelBuilder.Entity<Entities.Type>().HasData(new Entities.Type
            {
                Id = Guid.Parse("bd880489-5c76-4854-93ab-66e3a541bf24"),
                Name = "Thợ hồ"
            });
            modelBuilder.Entity<Entities.Type>().HasData(new Entities.Type
            {
                Id = Guid.Parse("ce9fa65b-d005-46b6-953e-e6462a59cfb3"),
                Name = "Thợ sơn"
            });
            modelBuilder.Entity<Entities.Type>().HasData(new Entities.Type
            {
                Id = Guid.Parse("cf9fa65b-d005-46b6-953e-e6462a59cfb3"),
                Name = "Thợ hàn"
            });
            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id=1,
                Name = "Xây dựng",
                FromSystem = true,
                TypeId = Guid.Parse("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0")
            });
            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id = 2,
                Name = "Sơn tường",
                FromSystem = true,
                TypeId = Guid.Parse("ce9fa65b-d005-46b6-953e-e6462a59cfb3")
            });
            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id = 3,
                Name = "Lát gạch",
                FromSystem = true,
                TypeId = Guid.Parse("bd880489-5c76-4854-93ab-66e3a541bf24")
            });
            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id = 4,
                Name = "Thạch Cao",
                FromSystem = true,
                TypeId = Guid.Parse("ce9fa65b-d005-46b6-953e-e6462a59cfb3")
            });
            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id=1,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "- Đưa ra phương án và biện pháp thi công, phối hợp với các bộ phận liên quan để lên phương án thi công."
  + "- Giám sát thi công công trình, đảm bảo thi công đúng, đủ số lượng, chất lượng và tiến độ được giao, điều phối các đội thi công trong dự án mình phụ trách."
  + "- Tiếp nhận, chuyển và xử lý các vấn đề phát sinh tại công trình."
  + "- Chịu trách nhiệm về việc nghiệm thu khối lượng với khách hàng/nhà thầy phụ."
  + "- Thực hiện các công việc khác theo yêu cầu của cấp trên.",
                Benefit = "Bao ăn ở, bảo hiểm, và các phúc lợi khác",
                Required = "Nam, tốt nghiệp Cao đẳng trở lên chuyên ngành Xây dựng, kiến trúc, nội thất."
  + "- Ít nhất 1 năm kinh nghiệm ở vị trí tương đương."
  + "- Ưu tiên ứng viên có kinh nghiệm mảng dân dụng."
  + "- Cẩn thận, trung thực, chịu khó, có tinh thần trách nhiệm trong công việc."
  + "- Có khả năng đi công tác và tăng ca (nếu có yêu cầu).",
                StarDate=new DateTime(2023,3,15),
                EndDate=new DateTime(2023,5,15),
                Status=Enum.Status.SUCCESS,
                Place=Enum.Place._52,
                PostCategories=Enum.PostCategories.Categories1,
                Salaries="10.000.000 - 15.000.000",
                NumberPeople=20,
                ContractorID=1,
                CreateBy=Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f6")
            });
            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 2,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "- Đưa ra phương án và biện pháp thi công, phối hợp với các bộ phận liên quan để lên phương án thi công."
  + "- Giám sát thi công công trình, đảm bảo thi công đúng, đủ số lượng, chất lượng và tiến độ được giao, điều phối các đội thi công trong dự án mình phụ trách."
  + "- Tiếp nhận, chuyển và xử lý các vấn đề phát sinh tại công trình."
  + "- Chịu trách nhiệm về việc nghiệm thu khối lượng với khách hàng/nhà thầy phụ."
  + "- Thực hiện các công việc khác theo yêu cầu của cấp trên.",
                Benefit = "Bao ăn ở, bảo hiểm, và các phúc lợi khác",
                Required = "Nam, tốt nghiệp Cao đẳng trở lên chuyên ngành Xây dựng, kiến trúc, nội thất."
  + "- Ít nhất 1 năm kinh nghiệm ở vị trí tương đương."
  + "- Ưu tiên ứng viên có kinh nghiệm mảng dân dụng."
  + "- Cẩn thận, trung thực, chịu khó, có tinh thần trách nhiệm trong công việc."
  + "- Có khả năng đi công tác và tăng ca (nếu có yêu cầu).",
                StarDate = new DateTime(2023, 3, 15),
                EndDate = new DateTime(2023, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._52,
                PostCategories = Enum.PostCategories.Categories1,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 20,
                ContractorID = 2,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f7")

            });
            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 3,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "- Đưa ra phương án và biện pháp thi công, phối hợp với các bộ phận liên quan để lên phương án thi công."
  + "- Giám sát thi công công trình, đảm bảo thi công đúng, đủ số lượng, chất lượng và tiến độ được giao, điều phối các đội thi công trong dự án mình phụ trách."
  + "- Tiếp nhận, chuyển và xử lý các vấn đề phát sinh tại công trình."
  + "- Chịu trách nhiệm về việc nghiệm thu khối lượng với khách hàng/nhà thầy phụ."
  + "- Thực hiện các công việc khác theo yêu cầu của cấp trên.",
                Benefit = "Bao ăn ở, bảo hiểm, và các phúc lợi khác",
                Required = "Nam, tốt nghiệp Cao đẳng trở lên chuyên ngành Xây dựng, kiến trúc, nội thất."
  + "- Ít nhất 1 năm kinh nghiệm ở vị trí tương đương."
  + "- Ưu tiên ứng viên có kinh nghiệm mảng dân dụng."
  + "- Cẩn thận, trung thực, chịu khó, có tinh thần trách nhiệm trong công việc."
  + "- Có khả năng đi công tác và tăng ca (nếu có yêu cầu).",
                StarDate = new DateTime(2023, 3, 15),
                EndDate = new DateTime(2023, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._52,
                PostCategories = Enum.PostCategories.Categories1,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 20,
                ContractorID = 2,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f7")

            });
            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 4,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "- Đưa ra phương án và biện pháp thi công, phối hợp với các bộ phận liên quan để lên phương án thi công."
  + "- Giám sát thi công công trình, đảm bảo thi công đúng, đủ số lượng, chất lượng và tiến độ được giao, điều phối các đội thi công trong dự án mình phụ trách."
  + "- Tiếp nhận, chuyển và xử lý các vấn đề phát sinh tại công trình."
  + "- Chịu trách nhiệm về việc nghiệm thu khối lượng với khách hàng/nhà thầy phụ."
  + "- Thực hiện các công việc khác theo yêu cầu của cấp trên.",
                Benefit = "Bao ăn ở, bảo hiểm, và các phúc lợi khác",
                Required = "Nam, tốt nghiệp Cao đẳng trở lên chuyên ngành Xây dựng, kiến trúc, nội thất."
  + "- Ít nhất 1 năm kinh nghiệm ở vị trí tương đương."
  + "- Ưu tiên ứng viên có kinh nghiệm mảng dân dụng."
  + "- Cẩn thận, trung thực, chịu khó, có tinh thần trách nhiệm trong công việc."
  + "- Có khả năng đi công tác và tăng ca (nếu có yêu cầu).",
                StarDate = new DateTime(2023, 3, 15),
                EndDate = new DateTime(2023, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._20,
                PostCategories = Enum.PostCategories.Categories1,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 20,
                ContractorID = 1,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f6")
            });
            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 5,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "- Đưa ra phương án và biện pháp thi công, phối hợp với các bộ phận liên quan để lên phương án thi công."
  + "- Giám sát thi công công trình, đảm bảo thi công đúng, đủ số lượng, chất lượng và tiến độ được giao, điều phối các đội thi công trong dự án mình phụ trách."
  + "- Tiếp nhận, chuyển và xử lý các vấn đề phát sinh tại công trình."
  + "- Chịu trách nhiệm về việc nghiệm thu khối lượng với khách hàng/nhà thầy phụ."
  + "- Thực hiện các công việc khác theo yêu cầu của cấp trên.",
                Benefit = "Bao ăn ở, bảo hiểm, và các phúc lợi khác",
                Required = "Nam, tốt nghiệp Cao đẳng trở lên chuyên ngành Xây dựng, kiến trúc, nội thất."
  + "- Ít nhất 1 năm kinh nghiệm ở vị trí tương đương."
  + "- Ưu tiên ứng viên có kinh nghiệm mảng dân dụng."
  + "- Cẩn thận, trung thực, chịu khó, có tinh thần trách nhiệm trong công việc."
  + "- Có khả năng đi công tác và tăng ca (nếu có yêu cầu).",
                StarDate = new DateTime(2023, 5, 15),
                EndDate = new DateTime(2024, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._14,
                PostCategories = Enum.PostCategories.Categories2,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 30,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                ContractorID = 2
            });
            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 6,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "- Đưa ra phương án và biện pháp thi công, phối hợp với các bộ phận liên quan để lên phương án thi công."
 + "- Giám sát thi công công trình, đảm bảo thi công đúng, đủ số lượng, chất lượng và tiến độ được giao, điều phối các đội thi công trong dự án mình phụ trách."
 + "- Tiếp nhận, chuyển và xử lý các vấn đề phát sinh tại công trình."
 + "- Chịu trách nhiệm về việc nghiệm thu khối lượng với khách hàng/nhà thầy phụ."
 + "- Thực hiện các công việc khác theo yêu cầu của cấp trên.",
                Benefit = "Bao ăn ở, bảo hiểm, và các phúc lợi khác",
                Required = "Nam, tốt nghiệp Cao đẳng trở lên chuyên ngành Xây dựng, kiến trúc, nội thất."
 + "- Ít nhất 1 năm kinh nghiệm ở vị trí tương đương."
 + "- Ưu tiên ứng viên có kinh nghiệm mảng dân dụng."
 + "- Cẩn thận, trung thực, chịu khó, có tinh thần trách nhiệm trong công việc."
 + "- Có khả năng đi công tác và tăng ca (nếu có yêu cầu).",
                StarDate = new DateTime(2023, 6, 15),
                EndDate = new DateTime(2024, 5, 30),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._14,
                PostCategories = Enum.PostCategories.Categories2,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 30,
                ContractorID = 1,
                CreateBy = Guid.Parse("7ba0a48f-551b-4de5-b853-81a1243267f6")

            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=7,
                Name="Gạch Hoa Cổ Điển",
                UnitInStock=30000,
                UnitPrice=50000,
                Image= "http://anhduongphat.vn/wp-content/uploads/2020/03/gach-bong-trang-tri-hoa-van.jpg",
                SoldQuantities=1500,
                Description="Gạch hoa lát cổ điển, màu trắng đen tương thích với các kiến trúc cổ",
                MaterialStoreID=1,
                Brand="Pháp"
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=1,
                Name = "Ngói lợp",
                UnitInStock = 300000,
                UnitPrice = 700,
                Image= "https://hailongtiles.com/sites/default/files/styles/213x213/public/sanphamlamphuc/092021/ngoi_mui_hai_lop_biet_thu_phap.jpg?itok=Bc8v69y6",
                SoldQuantities = 3000,
                Description = "Ngói lợp kiểu Pháp cổ điển",
                MaterialStoreID = 1,
                Brand = "Pháp"
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 2,
                Name = "Gạch lỗ",
                UnitInStock = 300000,
                UnitPrice = 500,
                Image = "data:image/jpeg;base64,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",
                SoldQuantities = 1500,
                Description = "Gạch 2 lỗ",
                MaterialStoreID = 1,
                Brand = "Việt Nam"
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=3,
                Name = "Sơn chống thấm",
                UnitInStock = 2000,
                UnitPrice = 1000000,
                Image= "https://nipponpaint.com.vn/sites/default/files/inline-images/son-chong-tham-la-gi-1.jpg",
                SoldQuantities = 1500,
                Description = "Sơn chống thấm Nippon",
                MaterialStoreID = 1,
                Brand = "Mỹ"
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=4,
                Name = "Cát Mịn",
                UnitInStock = 200000,
                UnitPrice = 100,
                Image= "https://sbshouse.vn/wp-content/uploads/2020/09/cat-xay-dung.jpg",
                SoldQuantities = 50,
                Description = "Cát mịn dành cho xây dựng",
                MaterialStoreID = 1,
                Brand = "Việt Nam"
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=5,
                Name = "Xi măng Hà Tiên",
                UnitInStock = 5000,
                UnitPrice = 80000,
                Image= "http://ximang.vn/Upload/48/Nam_2022/Thang_5/Ngay_31/ximang_vicemhatien1.jpg",
                SoldQuantities = 300,
                Description = "Xi măng Hà Tiên",
                MaterialStoreID = 2,
                Brand = "Việt Nam"
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=6,
                Name = "Gạch 4 lỗ",
                UnitInStock = 500000,
                UnitPrice = 600,
                Image= "data:image/jpeg;base64,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",
                SoldQuantities = 2000,
                Description = "Gạch 4 lỗ",
                MaterialStoreID = 2,
                Brand = "Việt Nam"
            });
        }
    }
}
