
using Data.Entities;
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
                FirstName = "Hoai Nam",
                LastName = "Doan Vu",
                DOB = new DateTime(2001, 4, 30),
                PhoneNumber = "0879411575",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = "https://i1-giaitri.vnecdn.net/2013/08/15/DK-02756-1376528749.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=mX89l0q4HQgntQ5wJesOcw",
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
                CreateBy=Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                Place=Enum.Place._60 
            }) ;


            //user 2 

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                Email = "namhoaidoan1@gmail.com",
                UserName = "namhoaidoan1@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Thinh",
                LastName = "Nguyen Anh",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "0937341639",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = "https://scontent.fsgn5-3.fna.fbcdn.net/v/t1.6435-9/86186750_1329130013936346_7257030880831471616_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=174925&_nc_ohc=Z1GTPvzRt7wAX_WbRZ5&_nc_ht=scontent.fsgn5-3.fna&oh=00_AfAYtaD2dHE_84_-PSlDqLaeyBlH9zJ3b308pHcTWucCXw&oe=642552F2",
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



            //contractor
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                Email = "contractor@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Công Ty Cổ Phần Xây Dựng Và Công Nghiệp",
                LastName = "NSN",
                UserName = "0912345678",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "0912345678",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = "https://www.vietnamworks.com/_next/image?url=https%3A%2F%2Fimages.vietnamworks.com%2Fpictureofcompany%2F78%2F11127264.png&w=128&q=75",
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
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7"),
            });


            //contractor 2
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                Email = "contractor2@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Công Ty Cổ Phần Đầu Tư Bất Động Sản",
                LastName = "Taseco",
                UserName = "0987654321",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "09987654321",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = "https://www.vietnamworks.com/_next/image?url=https%3A%2F%2Fimages.vietnamworks.com%2Fpictureofcompany%2F69%2F11128477.png&w=128&q=75",
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
                Email = "store123@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "TPHCM",
                LastName = "Cửa Hàng Vật Liệu",
                UserName = "0924516734",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "0924516734",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = "https://baodautu.vn/Images/chicong/2018/11/28/thi-truong-vat-lieu-xay-dung-mua-kinh-doanh-da-thay-doi1543390455.jpg",
                MaterialStoreID = 1,
                Address = "Giồng Ông Tố, Thành Phố Thủ Đức, TPHCM, Việt Nam"
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                UserId = Guid.Parse("b57b172a-a044-11ed-a8fc-0242ac120002"),
            });
            modelBuilder.Entity<MaterialStore>().HasData(new MaterialStore()
            {
                Id = 1,
                Website = "https://vinasoftware.com.vn/",
                Description = "Với mục tiêu cung cấp nhiều gói sản phẩm phong phú về mẫu mã và các tính năng linh hoạt cho nhiều loại hình website như giới thiệu công ty, bán hàng, trang tin tức, thương mại điện tử… cùng với nhiều giao diện phong phú đa dạng độc đáo đã được VNS lọc chọn và đúc kết nhằm giới thiệu tới khách hàng với mong muốn có một website nhanh, đẹp, hiệu quả và giá cả hợp lý.",
                CreateBy = Guid.Parse("b57b172a-a044-11ed-a8fc-0242ac120002"),
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.Parse("be21b564-a044-11ed-a8fc-0242ac120002"),
                Email = "store2@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Hoainam@123"),
                SecurityStamp = string.Empty,
                FirstName = "Cần Thơ",
                LastName = "VLXD",
                UserName = "09245167342",
                DOB = new DateTime(2001, 9, 15),
                PhoneNumber = "09245167342",
                Gender = Enum.Gender.MALE,
                Token = "xxx",
                Status = Enum.Status.Level1,
                Avatar = "data:image/jpeg;base64,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",
                MaterialStoreID = 2,
                Address = "Thành Phố Cần Thơ, Việt Nam"
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

            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id = 5,
                Name = "Điện",
                FromSystem = true,
                TypeId = Guid.Parse("ce9fa65b-d005-46b6-953e-e6462a59cfb3")
            });

            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id = 6,
                Name = "Nước",
                FromSystem = true,
                TypeId = Guid.Parse("ce9fa65b-d005-46b6-953e-e6462a59cfb3")
            });

            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id = 7,
                Name = "Hàn Sắt",
                FromSystem = true,
                TypeId = Guid.Parse("ce9fa65b-d005-46b6-953e-e6462a59cfb3")
            });

            modelBuilder.Entity<Entities.Skill>().HasData(new Entities.Skill
            {
                Id = 8,
                Name = "Ốp lát",
                FromSystem = true,
                TypeId = Guid.Parse("ce9fa65b-d005-46b6-953e-e6462a59cfb3")
            });





            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id=1,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
                Benefit = "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>",
                Required = "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>",
                StarDate =new DateTime(2023,3,15),
                EndDate=new DateTime(2023,5,15),
                Status=Enum.Status.SUCCESS,
                Place=Enum.Place._52,
                PostCategories=Enum.PostCategories.Categories1,
                Salaries="10.000.000 - 15.000.000",
                NumberPeople=20,
                ContractorID=1,
                Accommodation=true,
                ConstructionType= "Nhà ở",
                Transport=true,
                StartTime="8:00",
                EndTime="17:30",
                CreateBy=Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7"),
            });

            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
               ContractorPostID=1,
               SkillID=1
            });

            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 1,
                SkillID = 2
            });


            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 2,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
                Benefit = "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>",
                Required = "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>",
                StarDate = new DateTime(2023, 3, 15),
                EndDate = new DateTime(2023, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._52,
                PostCategories = Enum.PostCategories.Categories1,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 20,
                Accommodation = true,
                ConstructionType = "Tòa nhà/Chung cư",
                Transport = true,
                StartTime = "8:00",
                EndTime = "17:30",
                ContractorID = 2,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6")

            });


            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 2,
                SkillID = 1
            });

            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 2,
                SkillID = 3
            });
            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 2,
                SkillID = 5
            });




            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 3,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
                Benefit = "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>",
                Required = "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>",
                StarDate = new DateTime(2023, 3, 15),
                EndDate = new DateTime(2023, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._52,
                PostCategories = Enum.PostCategories.Categories1,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 20,
                ContractorID = 2,
                Accommodation = true,
                ConstructionType = "Công trình công cộng",
                Transport = true,
                StartTime = "8:00",
                EndTime = "17:30",
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6")

            });

            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 3,
                SkillID = 3
            });

            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 4,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
                Benefit = "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>",
                Required = "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>",
                StarDate = new DateTime(2023, 3, 15),
                EndDate = new DateTime(2023, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._20,
                PostCategories = Enum.PostCategories.Categories1,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 20,
                ContractorID = 1,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7")
            });
            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 4,
                SkillID = 2
            });
            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 4,
                SkillID = 3
            });
            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 5,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
                Benefit = "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>",
                Required = "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>",
                StarDate = new DateTime(2023, 5, 15),
                EndDate = new DateTime(2024, 5, 15),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._14,
                PostCategories = Enum.PostCategories.Categories2,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 30,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                ContractorID = 2
            });

            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 5,
                SkillID = 1
            });

            modelBuilder.Entity<ContractorPost>().HasData(new ContractorPost
            {
                Id = 6,
                Title = "Tuyển dụng công nhân xây dựng",
                ProjectName = "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP",
                Description = "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
                Benefit = "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>",
                Required = "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>",
                StarDate = new DateTime(2023, 6, 15),
                EndDate = new DateTime(2024, 5, 30),
                Status = Enum.Status.SUCCESS,
                Place = Enum.Place._14,
                PostCategories = Enum.PostCategories.Categories2,
                Salaries = "10.000.000 - 15.000.000",
                NumberPeople = 30,
                ContractorID = 1,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7")

            });

            modelBuilder.Entity<ContractorPostSkill>().HasData(new ContractorPostSkill
            {
                ContractorPostID = 6,
                SkillID = 4
            });


            //Categories

            modelBuilder.Entity<Categories>().HasData(new Categories
            {

                ID=1,
                Name="Xuất xứ"
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {

                ID = 2,
                Name = "Chất liệu"
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {

                ID = 3,
                Name = "Phong cách "
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {

                ID = 4,
                Name = "Vị trí "
            });

            //PRODUCT 1

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=7,
                Name= "Sơn Ngoại Thất Bóng Cao Cấp CMC ARMOS07 1 - 4.5L",
                UnitInStock= 200,
                UnitPrice= 857000,
                Image= "https://admin.mingstores.com/core/public/themes/mingstores/products/vx9kXzl3FacoKvdbZLki3kWM6nO3PimJ.jpg",
                SoldQuantities=1500,
                Description= "- Màng sơn mịn có độ phủ cao, siêu bóng sang trọng,bám dính tốt\r\n\r\n- Hạn chế vết bẩn, vết nứt nhỏ, chống rêu mốc, độ bền màu cao\r\n\r\n- Thân thiện môi trường và an toàn cho sức khỏe\r\n\r\n- Bảo vệ 10 năm\r\n\r\n- Độ phủ lý thuyết: 12-14m2/lít/ lớp",
                MaterialStoreID=1,
                Unit="Lít",
                Brand= "CMC",
                LastModifiedAt=DateTime.Parse("2022/12/2")
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
               CategoriesID=1,
               ProductID=7,
               Name="Mỹ",
              
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 7,
                Name = "Sơn ngoại thất",

            });


            //PRODUCT 2

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 30,
                Name = "Gạch GCA-Clay Art 60x60",
                UnitInStock = 200,
                UnitPrice = 400000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/Elgda4SYGE52gAn2wi5AEXipIEMqiYiB.jpg",
                SoldQuantities = 1500,
                Description = "Gạch cao cấp đến từ thương hiệu nổi tiếng NIRO GRANITE",
                MaterialStoreID = 1,
                Unit = "Gạch",
                Brand = "NIRO GRANITE",
                LastModifiedAt = DateTime.Parse("2022/1/2")

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 30,
                Name = "Mỹ",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 30,
                Name = "Gạch bóng",
            });

            //PRODUCT 3

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 31,
                Name = "Aures Smart Round RMC-45E-VN",
                UnitInStock = 200,
                UnitPrice = 3200000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/MbcC070BBSf4q97sgghpjBbqFiNr7JEP.jpg",
                SoldQuantities = 1500,
                Description = "Công suất định mức: 4500(W)\r\nHình dáng: Hình tròn\r\nĐiện năng: 220V\r\nChế độ vòi sen: 5\r\nÁp lực nước tối thiểu: 30/0,3 Kpa/bar\r\nÁp lực nước tối đa: 380/3.8 Kpa/bar\r\nKích thước (DxCxR): 350 X 80\r\nTrọng lượng: 2 kg\r\nKhông có bơm trợ lực",
                MaterialStoreID = 1,
                Unit = "Bộ",
                Brand = "ARISTON",
                LastModifiedAt = DateTime.Parse("2023/1/2")
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 31,
                Name = "Mỹ",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 31,
                Name = "Thép",
            });


            //PRODUCT 4

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 32,
                Name = "Bồn cầu một khối TOTO MS904E4",
                UnitInStock = 200,
                UnitPrice = 19037000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/UYZ61ie7Z7i5Hmjd6D7XyUWhBZVL7y8v.jpg",
                SoldQuantities = 1500,
                Description = "Thiết kế nguyên khối sang trọng, hiện đại\r\nNắp bàn cầu đóng êm, kèm vòi rửa nước lạnh Eco-washer\r\nBề mặt nước rộng giúp ngăn mùi hiệu quả\r\nThiết kế thân kín, vành kín tiện dụng cho việc vệ sinh hàng ngày\r\nCông nghệ CeFiONtect giúp lòng bàn cầu siêu nhẵn, hạn chế tối đa các vết bẩn, vi khuẩn\r\nCông nghệ xả G-Max êm, mạnh mẽ hiệu quả",
                MaterialStoreID = 1,
                Unit = "Bộ",
                Brand = "TOTO"
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 32,
                Name = "Mỹ",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 32,
                Name = "Cái",
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 32,
                Name = "Nhà vệ sinh",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 3,
                ProductID = 32,
                Name = "Ý",
            });

            //PRODUCT 5

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 33,
                Name = "Bồn Cầu Thông Minh INAX AC-1017R/CW-KA22AVN",
                UnitInStock = 200,
                UnitPrice = 26301000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/ryBdemssBcpSt6vbeQdirRUMcBszbZKt.jpg",
                SoldQuantities = 1500,
                Description = "Dòng sản phẩm bồn cầu INAX AC-1017R 1 khối cao cấp đến từ thương hiệu thiết bị vệ sinh INAX\r\nBệt Inax AC-1017R CW-KA22AVN 1 khối với thiết kế mới đơn giản, gọn gàng và sang trọng hơn kết hợp với những tính năng cải tiến\r\nCông nghệ ECO-X xã xoáy cuốn trôi mọi vết bẩn\r\nCông nghệ Aqua Ceramic giúp bề mạt men sứ trắng sáng trong suốt thời gian sữ dụng\r\nCông nghệ chống khuẩn HYPERKILAMIC kháng khuẩn độc quyền của INAX Nhật Bản. \r\nE-Clean: Chức năng phun rửa  tự động\r\nEvaClean: Chức năng vệ sinh phụ nữ\r\nCozyCare: Chức năng sưởi ấm bệ ngồi\r\nX-Fresh: Chức năng khử mùi nhanh \r\nEcoPower: Chức năng tiết kiệm điện “1 lần chạm” (8 tiếng sau tự khôi phục)\r\nDung tích két nước nóng: 0.67L (lít) Vòi phun rửa:\r\nVòi phun rửa và vòi phun dùng riêng cho phụ nữ đều là loại trượt tự động.  \r\nThiết bị an toàn: Rơ-le nhiệt, cảm ứng từ kiểm soát nhiệt độ cao, phao ngắt để thiết bị ngừng hoạt động khi không đủ nước, cảm ứng tự ngắt khi gặp sự cố. \r\nNước cấp: Nối trực tiếp từ đường ống nước ",
                MaterialStoreID = 1,
                Unit = "Bộ",
                Brand = "INAX",
                LastModifiedAt = DateTime.Parse("2022/5/22")
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 33,
                Name = "Mỹ",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 33,
                Name = "Cái",
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 33,
                Name = "Nhà vệ sinh",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 3,
                ProductID = 33,
                Name = "Ý",
            });

            //PRODUCT 6

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 34,
                Name = "GFS Gạch Granite Fusion Bán Bóng/Sần",
                UnitInStock = 200,
                UnitPrice = 520000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/U3SmJsX6rBhkAPyQ3Xym2wlyoNTH6pGz.jpg",
                SoldQuantities = 1500,
                Description= "Màu sắc: vàng, xám, trắng, đen\r\nKích thước: 30x60, 60x60",
                MaterialStoreID = 1,
                Unit = "Cái",
                Brand = "NIRO GRANITE",
                LastModifiedAt = DateTime.Parse("2023/2/2")
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 34,
                Name = "Niro – Indonesia",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 34,
                Name = "Cái",
            });

            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "Màu vàng",
                Id = 6,
                ProductID = 34,
                Quantity = 5,
            });

            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "Màu xám",
                Id = 7,
                ProductID = 34,
                Quantity = 10,
            });

            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "Màu trắng",
                Id = 8,
                ProductID = 34,
                Quantity = 1220,
            });


            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "Màu đen",
                Id = 9,
                ProductID = 34,
                Quantity = 33,
            });

            
            //PRODUCT 7

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 35,
                Name = "Tủ Lavabo JM843",
                UnitInStock = 200,
                UnitPrice = 9520000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/P5GERhsHMvYboHFoSTcetoIuHKJJApvD.jpg",
                SoldQuantities = 1500,
                Description = "ông nghệ sản xuất tủ lavabo của chúng tôi đã được chuyên nghiệp hóa qua nhiều năm phát triển, với phần khung bên ngoài được làm bằng nhôm, là cấu trúc chính hỗ trợ, giúp toàn bộ tủ chắc chắn, bên cạnh phần bản lề được làm bằng INOX 304 dày, giúp cho việc vận hành được trơn tru, ổn định.\r\n- Các bộ phận chính đều được làm bằng thép không gỉ 304 (INOX 304), tăng độ bền cho sản phẩm trong quá trình sử dụng.\r\n- Cấu hình cạnh và tay nắm cửa được làm bằng máy vát 45 độ đặc biệt, góc nhôm được gắn chặt vào thành bên trong tủ, để bề mặt sản phẩm mịn & tinh tế, tạo sự thoải mái khi sử dụng.\r\n\r\n- Việc sử dụng nhôm để làm vật liệu chính sản xuất tủ Lavabo là lựa chọn tối ưu nhất hiện nay, không chỉ có độ bền cao, nhôm hoàn toàn không độc hại với môi trường cũng như người sử dụng. Một số ưu điểm chính của nhôm:\r\n  + Trọng lượng nhẹ, độ bền cao, khả năng chịu lực lớn.\r\n  + Độ cứng tốt, không dễ biến dạng.\r\n  + Không thấm nước trong môi trường có độ ẩm cao, không bắt lửa và chịu được tác động mạnh.\r\n  + Lớp sơn phủ bền màu, chống ăn mòn do thời tiết hoặc hóa chất thông thường.\r\n  + Tạo không gian sang trọng, thoải mái và tiện lợi.",
                MaterialStoreID = 1,
                Unit = "Bộ",
                Brand = "JINMEI",
                LastModifiedAt = DateTime.Now
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 35,
                Name = "Niro – Indonesia",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 35,
                Name = "Bộ",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 35,
                Name = "Nhà tắm",
            });

            //PRODUCT 8

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 36,
                Name = "K015 Sơn Kansai chống thấm Water Proof 4L, 17L",
                UnitInStock = 200,
                UnitPrice = 750000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/JnLYt6lx4OLgmoplQoxTPU1e9SBjZf9a.jpg",
                SoldQuantities = 1500,
                Description ="Sơn ngoại thất câo cấp đến từ thương hiệu Kansai nổi tiếng",
                MaterialStoreID = 1,
                Unit = "Lít",
                Brand = "KANSAI PAINT",
                LastModifiedAt = DateTime.Now

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 36,
                Name = "Ý",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 36,
                Name = "Bộ",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 36,
                Name = "Sơn nội thất",
            });

            //PRODUCT 9

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 37,
                Name = "KARI SQUARE STEP LIGHT (3W)",
                UnitInStock = 200,
                UnitPrice = 460000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/N23c1P48S9v157cAYlNRc35gS92VeYVE.jpg",
                SoldQuantities = 1500,
                Description = "KARI SQUARE STEP LIGHT (3W) mang đến ánh sáng tinh tế đến gia đình bạn ",
                MaterialStoreID = 1,
                Unit = "Cái",
                Brand = "COSMOS",
                LastModifiedAt = DateTime.Parse("2023/10/1")
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 37,
                Name = "Ý",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 37,
                Name = "Bộ",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 37,
                Name = "Phòng khách",
            });

            //PRODUCT 10

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 38,
                Name = "GHR Gạch Granite Hardrock Mờ/Bán bóng",
                UnitInStock = 200,
                UnitPrice = 360000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/6TauBDiJiwnvQaJTuCl9D0SYHFayTRHk.jpg",
                SoldQuantities = 1500,
                Description = "GHR Gạch Granite Hardrock Mờ/Bán bóng ",
                MaterialStoreID = 1,
                Unit = "Viên",
                Brand = "NIRO GRANITE",
                LastModifiedAt = DateTime.Now
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 38,
                Name = "Niro – Indonesia",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 38,
                Name = "Cái",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 38,
                Name = "Nội thất",
            });









            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id=1,
                Name = "Ngói lợp",
                UnitInStock = 300000,
                UnitPrice = 700,
                Unit = "ton",
                Image = "https://hailongtiles.com/sites/default/files/styles/213x213/public/sanphamlamphuc/092021/ngoi_mui_hai_lop_biet_thu_phap.jpg?itok=Bc8v69y6",
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
                Unit = "ton",
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
                Unit = "ton",
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
                Unit = "ton",
                Image = "https://sbshouse.vn/wp-content/uploads/2020/09/cat-xay-dung.jpg",
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
                Unit = "ton",
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
                Unit = "ton",
                UnitPrice = 600,
                Image= "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBQVFBgWFRUYGBgVGBgcGBUSEhERGBgSGBgaGhgYGRgcIS4lHB4rHxgYJjgmKy8xNTU1GiQ7QDs0Py40NTEBDAwMEA8QHxISGjQhJCE0NDQ0NDQ0NDQ0MTQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0MTQ0NDQ0NDQ0NDQ0NP/AABEIAOEA4QMBIgACEQEDEQH/xAAbAAEAAgMBAQAAAAAAAAAAAAAABAYBAwUCB//EADwQAAIBAgEICAQEBgIDAAAAAAABAgMRBAUSITEzQVFxBiMyYXKBwdEigqGxE0JDkVJikuHw8QcUc6Ky/8QAGgEBAAIDAQAAAAAAAAAAAAAAAAECAwQFBv/EADARAQACAQIDBgQFBQAAAAAAAAABAgMRMQQSQSEyUXGRsRMiYdEFM1LB8BQjQoHh/9oADAMBAAIRAxEAPwD7MAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABByvVcaUpRdmicQMsrqZ8it+7LJi/Mrr4wp0ssYlt2k/I0rLmJX6jfO1/oeKEtKa4v1OHjcVKNSS3JvQcuMl56y9B8LHr3Y9ITZ9NK8ZPOnUS/wDBJLnck4fpjKf6j0cYuKODLGy/3pI1DHTcp6rJaFZay3Pbxn1R8LH+mPSFzh0hrSXwz+hExHSHGQTk6sFFa24T0fsytrKM/wASEU9Gt2S0jGZTnGyTXxO2lJ6BF7+J8LH+mPR3qXTeTdnXi/Ap6/2O7k7pa3a7U1+zKHjsVmptQhfRrgtZ6q41winmxvZbraWTGS8TrEyi2DFaNLVh9ewmWaU/zZr4S0HRUj41SynNRje17LdvO5kbL9aM4xzk02lZ8LmenE9LQ0cv4fG9J9X0sHmLukejccsAAAAAAAAAAAAAAAAAAAAACDlhXoz5E4h5TV6U+RW/dlfF36+ce6i4OOrukytZVXWz5lnoP4vNorWV1arLmcir0nVCRHwi01OZIsR8Jrqc/Uunq9RXXLwnjF9qHiPcNsvD7nnEdqHMI6NmUtXzIZQXw/0jKW7xIzlDUucfQeCZ6t01q5Im5DfXwX8yIlVauS+xO6OQviafiQrrrBfaX2JGTBk6zy4AAAAAAAAAAAAAAAAAAAAAEbH7OXJkk0YzsS5Midlq96FCpP4/mK3lrbSLPBfH8xXcurrn5HHq9L/k5howi01OfqSSPhNdTmXhbqzT2y8PueK/bp8z3T23ynmrtKfmENmUdcfGMetXiRjH9qPjPWP7UfEgmeqRV1nU6KQviqfM5lXWd3obTviY9xanehTLOlLT9J9n1IAHUeZAAAAAAAAAAAAAAAAAAAAAA04nsS5M3Gqv2XyYTG6hyVpPxIr2X9q+SO7OVpvxHEy/HrPJHHh6aN3LNGE11OfqSEjRhe1U5+xPRbqU9t8vuYmusp+f3M09t8vuYltafmT1T92cb24eI9Yztx8Z5xXbj4mZxTvOC/mYEqprZYug13iV3JlcnrLP0Aj17f8AKy+Lvx5sPE9mK3lL6SADpvNgAAAAAAAAAAAAAAAAAAAAAa6nZfJmw8y1AfPa6tU0/wAT9Ti9INr8qO7jFao/E/ucLLset8kceN3p69J+jmkbC9qrz9iVYi4XtVP84Er9Sltvl9zEl1sOXqZpLrvl9w9tDl6kn3MT26fNnqoushzZivtKfNmZ7WHmQN8tZbv+Pl1svCyoSOhkXK8sPPOik7pq0r2L45itomWPiKTfHNY3l9hB86l03rtytGCunmxcXo4O+8irpfin+olxX4dP2Nz+pp9XIj8OyzvMR/PJ9PBUsgdKlUtCs0pbpWsnzLWmZqXi8aw1cuG+KdLQ9AAsxAAAAAAAAAAAAAAAABhmTAFAyhtH4vU4uXV8a8Pqd/KS6yXi9Th5fXxRfGJyJ70vS0nsr5ORYi4ft1P84EtkXD9ufJehLKxT23y+5h7aHL1M09t8vuHtocvUBV2sPMz+rHkxU2sPMytrHwshP3bpI0VqmauZvZzsqzcYx4Xdya7ovOkNn/Z7z1+N327zjqTXJ/Q2wm76tHHgZOVh53XpYjya/wAui4dG+lkoWhV+KO570UOP+nwZJpSd7PXufEVmazrBelcleW0aw+6UK8ZxUotNPU0bj5RkHL9TDu17xb0xfofScm5RhXjnQfNb0zdx5Yv5uLxHC2xTrvHj904AGVqgAAAAAAAAAAAAAAAKDlpNVZ/5vRycvaqfhOzl1dbNHFy4tEOTORbvz5vS4+5Xy/ZxyLh9pPkvQkkajtKnh9gylPbfL7mFto8jMNt8nuFto+EH3J7aHJmYbVeFiW2hyZmG1+T3CW9nLyt+XzOoyLXwEqslbsxWl8yaz2ovHyuJTjZ/yv6P2J1LD20bnq9jrRybGKszZTw8Us1+T9C83Y4og08PbRuZvjQ/K/JkxUtz/wBmyEFqfk2V1X5UWlTd7S8nx/udbJuLnQknB2trW5rgRnFapeTC0aJeUvcjmneCaxMaS+kZGy1CvFLsz3xfodc+TUKsoSvF2a3oueROkUZ2hUdpbpbnzN3Fnieyzj8VwM1+bH2x4eCzAxcybLnAAAAAAAAAAAAACkZfj10+84mXlaFPuTX2LDl6L/GfDR6ley9phDu9jk5PzJ83osE60p5fs4jItLaz8PoiWkRqW1l4V9g2Hmmuu+T3MpddHwnqG2+T3C20fD7gJLro+FmYLrX4DL20fCzNLay8CIlaG1omZM1yXdH1IrZ7ydKSqy1ZmbFPip3lZ8rFUy6FShv4mqVK50Ypdl6n9GRKlNp6QqjZm5+T493MzCN9D1/dG2cbo8RjfQ9a1PivcDyktT1ceDMuNtD1fb+xsSvoevd3r3PKdtD1ceBIxJW0PVufD+x7tbV+4tm6Hq+xh/D3x3b7d6AsmQukLhaFR3W58C40qikrxd096PlMo6rbzsZGyzOi7PTHejaxZ5jsts5vFcFF/mp2T7/9fQwRsFi41YqcXdP6PgSTeidXHmJidJAAEAAAAAAAAKl0gVqvNr7MrmXOzHm/sWfpGrVE+RWMtxf4cW/4n6nLy/mS9Bw0/wBujhoi09rPwkiJop7WXhKNohtvk9xHbR8PuILrvk9xmp1lf+H3CWf1l4GeqG0n4UeUut5Q9z1Q7cuS9CJWhubPeTk1UnK942hGUeGtqX1NZtyRTX4lWd9bjGSvosopp282CXbgtFm9K1PjESjnR064/VChG3wvVri+H+j3OSUZNrSk7rvsVY5c+VSK3mqVaOtP9uJBbNVatGKzpNJLe9CLaLOlPEppP83dxE8Smlo58yvxy5RbspPXrUZWOnCcZJNO6eponl03Vi0TtKS8U7Wty36OB5/7crWsvYjuZwsb0gSlm01nW1yd7PkWiszsi14rHasMcQ1v0HqeIlJWvo4LQV/AZSnN/HFWfC52aWlpd5MxpuiLavqfRKlm4ePfpO4QslUs2jCPCKJp0qRpWIeczW5slp+sgALMYAAAAAAACvdJqLtGffZ/depUctxf4avul7n0XKFHPpyja+i65rSj5/l5dX8xz+JppfXxdjgMmtOXw/kK3E009rLwm+KNMdrLwGF0iO2+T3MwXXLw+4jtvk9zEX13y+4SX675H6nrD9qpyj6GuG1+Rm2h2qnl9kVlMNiN+R4RzqklrzkpruzVbR5s0E7JcM1OVu1KSlyvrZCZdKEPy8NMWMRJuEnbSk1JeWs2Rju4dl9xqxavFtaHa0uRDH1V+S0lIyxi3VqPS82LtGO7Rv5l3aK9ici5s7wu09OnWjPjmInWWPNWbRpDl4LDNst2T6TjC24jYDAqOl/sdKUtHdwIvbmTjpyw4/SKq40rR0ZzUfLeV3B4ZsuGIoRms2S0P6EfC5OjB6Xydi9b6RorbHzW1MnYKyuzsZKpZ9aEeMl9yM56LLQvudvohQzsTDu0/sViOa2ibzFKTPhD6hCNklwR7AOm80AAAAAAAAAAAUTpbQzFJJaL3XJ6ff8AYvZXel2BdSjeMXKUd0U5O2vUtf8AcwZ681Ozo2+CycmWNdpfNkaI7V+D3OnSyZiHqoVW+H4VSP3RNw/Q7Fymp5qgrNP8SotW7RHOZpxS07Q7U5sdY1m0eqv2tVXfD3PK2y8L9S9UugjlKMqldJxVrU6d/wD2k/Q6uH6GYSLUpKc3HU5za+kbF44e8/Rgvx+CNp18ofMVoqu+hZmt6CXk/J9ac55lKck7WlGnNxat/Fa31PrOHyVQp6YUacWvzKnHO/q1k8yRwvjLXt+J/pp6z/Pd8zw3RHFS1xjDxzS+kbsxTyXUw96dSzkm3nRvmyUm3dX3bvI+mnIy9gPxIXivihpXfHfH/OBOTho5fl3VxfiF7ZIi+kRPh0U6C/LvWmPejVlBXg9Nk7J37tRKnC6uta1exAypZwuna+m3ejRh1Ori2PE3Za9QlNJOUnZRV2+CRUMp5VlWebH4aaehb33t+hlrSbK3yRTdaKWLhJ2U4t8M5EllSyfhG2i1xg1GN+BNoiClptHaiY/KcKPa0ya0QWt+yOQss1Zy0JRXC2d+7IuWVn4iVk/htHT3LSTMn4O+4vFaxXWWKbWtbSNnZw03KN3oZdP+P6F6058I/VuxVFTUIpb39i/9AMPalOf8TSXJDDGt4U4y3Lhn0W4AHQcEAAAAAAAAAAAAAAAAAAAAAAABU8t4HMnnRXwy+kt69Sq5aiklp16UuL3n03G4dVIOD3rQ+D3M+Y9IoOM816HHQ+dzn58fLbWNpdvgc/xK8s7x7K7lSi50pxjra/creGwMr6UXBLUlpvqS0v8AYlUMkYib+HD1H3unOK/qkkitbTppDayVrrradHMyZgbK70EirK70aloXJHco9FMZL9NQ8c4L/wCbk+j0DrfnrU4+FTn980mMV56MduKwV7OePf2UevgYTlnb3r7yTQioavqfQKHQOku1WqS8CpwX1Ujo0OiGEjrpuT4zqTf0TS+hkjBeWCePw121n/X3mHzFvTpZ9S6IUs3Cw77sm4fI+Hh2KNOL4qnG/wC5PRmxYeSdZlp8TxcZa8sRoyADO0QAAAAAAAAAAAAAAAAAAAAAAAAhYjJ1Gbzp04SfGcIy1cyaBumJmNmqlRjFWjFRXCKUfsbQAgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB//2Q==",
                SoldQuantities = 2000,
                Description = "Gạch 4 lỗ",
                MaterialStoreID = 2,
                Brand = "Việt Nam"
            });


            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 20,
                Name = "K023 Sơn Kansai chống thấm Aqua Shield 5L, 18L",
                UnitPrice = 960000,
                UnitInStock = 1000,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/OOUUL3p3xO6kV63bOCyr4qCMZBNDo2yc.jpg",
                Description = "- Sơn chống thấm Một thành phần Aqua Shield\r\n\r\n- Chống thấm tuyệt hảo\r\n\r\n- Kháng nước tuyệt đối\r\n\r\n- Che phủ vết nứt, co giãn tốt, dễ thi công (không chứa xi măng)\r\n\r\n",
                Brand = "KANSAI PAINT",
                SoldQuantities = 100,
                Unit = "Lít",
                MaterialStoreID = 1
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 20,
                Name = "Niro – Indonesia",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 20,
                Name = "Lít",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 20,
                Name = "Sơn ngoại thất",
            });

            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "5L",
                Id = 1,
                ProductID = 20,
                Quantity = 10,
            });

            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "10L",
                Id = 2,
                ProductID = 20,
                Quantity = 10,
            });




            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 21,
                Name = "SEN TẮM CÂY INAX BFV-515S",
                UnitPrice = 12485000,
                UnitInStock = 1200,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/Mjzhtin7lD3gCUXksET0srIdUnABPNE3.jpg",
                Description = "Sen cây nóng lạnh INAX BFV-515S là sản phẩm sen cây INAX  được thiết kế tay sen cài liền cùng thân sen cây thay vì để gắn tường, giúp cho tổng thể bộ sen cây trở nên gọn gàng, linh hoạt, đặc biệt phù hợp cả với những căn phòng tắm kích thước nhỏ, quý khách hàng vẫn có thể lắp đặt mẫu sen cây này và cảm nhận trải nghiệm khác biệt khi tắm vòi sen cây với bát sen lớn.\r\nMẫu thiết kế sen cây thuộc dòng sản phẩm SEN VÒI INAX có thiết kế đẹp mắt, sáng tạo từ kiểu dáng đến tính năng thích hợp cho mọi loại hình phòng tắm từ những phòng tắm đơn giản, nhỏ hẹp, đến những căn phòng tắm hiện đại, tiện nghi. ",
                Brand = "INAX",
                Unit = "Cái",
                SoldQuantities = 1000,
                MaterialStoreID = 1
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 21,
                Name = "Nhật Bản",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 21,
                Name = "Cái",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 21,
                Name = "Nhà tắm",
            });

            modelBuilder.Entity<Products>().HasData(new Products
            {

                Id = 22,
                Name = "Chậu Rửa Lavabo Inax AL-536V",
                UnitPrice = 2046000,
                UnitInStock = 100,
                Image = "https://admin.mingstores.com/core/public/themes/mingstores/products/JnyguIQW8EMvvUqcZ6BZnGSLOeL5OgpK.jpg",
                Description = "Là mẫu chậu rửa mặt Inax đặt bàn mới nhất 2017, sản phẩm tiêu biểu cho năm 2018",
                Brand = "INAX",
                Unit = "Cái",
                SoldQuantities = 100,
                MaterialStoreID = 1
            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 1,
                ProductID = 22,
                Name = "Nhật Bản",

            });

            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 2,
                ProductID = 22,
                Name = "Cái",
            });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories
            {
                CategoriesID = 4,
                ProductID = 22,
                Name = "Nhà tắm",
            });



            //bill 1
            modelBuilder.Entity<Bill>().HasData(new Bill
            {
              Id=1,
              ContractorId=1,
              CreateBy= Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7"),
              EndDate=DateTime.Now,
              LastModifiedAt=DateTime.Now,
              PaymentDate=null,
              Status=Enum.Status.SUCCESS,
              Note= "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
              StoreID=1,
              Type=Enum.BillType.Type1,
              TotalPrice=500000,

            });

            modelBuilder.Entity<BillDetail>().HasData(new BillDetail
            {
               BillID=1,
               Id=1,
               Price=200000,
               ProductID=20,
               Quantity=5,
               ProductTypeId=1
            });
            modelBuilder.Entity<BillDetail>().HasData(new BillDetail
            {
                BillID = 1,
                Id = 2,
                Price = 150000,
                ProductID = 21,
                Quantity = 8,
                ProductTypeId=3
            });
            modelBuilder.Entity<BillDetail>().HasData(new BillDetail
            {
                BillID = 1,
                Id = 3,
                Price = 450000,
                ProductID = 22,
                Quantity = 7,
            });

            modelBuilder.Entity<Bill>().HasData(new Bill
            {
                Id = 2,
                ContractorId = 1,
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                EndDate = DateTime.Now,
                LastModifiedAt = DateTime.Now,
                PaymentDate = null,
                Status = Enum.Status.SUCCESS,
                Note = "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>",
                StoreID = 1,
                Type = Enum.BillType.Type2,
                TotalPrice = 60000000,

            });
          

            modelBuilder.Entity<BillDetail>().HasData(new BillDetail
            {
                BillID = 2,
                Id = 5,
                Price = 20000,
                ProductID = 1,
                Quantity = 5,
            });
            modelBuilder.Entity<BillDetail>().HasData(new BillDetail
            {
                BillID = 2,
                Id = 6,
                Price = 150000,
                ProductID = 2,
                Quantity = 8,
            });
            modelBuilder.Entity<BillDetail>().HasData(new BillDetail
            {
                BillID = 2,
                Id = 7,
                Price = 45000,
                ProductID = 3,
                Quantity = 7,
            });


         

            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "Trắng",
                Id = 3,
                ProductID = 21,
                Quantity = 10,
            });
            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Name = "Đen",
                Id = 4,
                ProductID = 21,
                Quantity = 10,
            });
            modelBuilder.Entity<Notification>().HasData(new Notification
            {
                Id = 1,
                Type=Enum.NotificationType.TYPE_1,
                Title="New Notification",
                UserID=Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                CreateBy=Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                IsRead=false,
                LastModifiedAt=DateTime.Now,
                Message="Someone has saved your post",
                NavigateId=1
            });

            modelBuilder.Entity<Notification>().HasData(new Notification
            {
                Id = 2,
                Type = Enum.NotificationType.TYPE_2,
                Title = "New Notification",
                UserID = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                IsRead = false,
                LastModifiedAt = DateTime.Now,
                Message = "Someone has applied your post",
                NavigateId = 1
            });

            modelBuilder.Entity<Notification>().HasData(new Notification
            {
                Id = 3,
                Type = Enum.NotificationType.TYPE_3,
                Title = "New Notification",
                UserID = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                CreateBy = Guid.Parse("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                IsRead = false,
                LastModifiedAt = DateTime.Now,
                Message = "Create commitment successfully",
                NavigateId = 1
            });

        }
    }
}
