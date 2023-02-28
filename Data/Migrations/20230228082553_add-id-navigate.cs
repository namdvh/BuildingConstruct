using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class addidnavigate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NavigateId",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(5461), new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(5528), new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 811, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 820, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Xuất xứ" },
                    { 2, "Chất liệu" },
                    { 3, "Phong cách " },
                    { 4, "Vị trí " }
                });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 830, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 840, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 852, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "5L");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "10L");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Trắng");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Đen");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitInStock", "UnitPrice" },
                values: new object[] { "CMC", "- Màng sơn mịn có độ phủ cao, siêu bóng sang trọng,bám dính tốt\r\n\r\n- Hạn chế vết bẩn, vết nứt nhỏ, chống rêu mốc, độ bền màu cao\r\n\r\n- Thân thiện môi trường và an toàn cho sức khỏe\r\n\r\n- Bảo vệ 10 năm\r\n\r\n- Độ phủ lý thuyết: 12-14m2/lít/ lớp", "https://admin.mingstores.com/core/public/themes/mingstores/products/vx9kXzl3FacoKvdbZLki3kWM6nO3PimJ.jpg", "Sơn Ngoại Thất Bóng Cao Cấp CMC ARMOS07 1 - 4.5L", "Lít", 200, 857000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitPrice" },
                values: new object[] { "KANSAI PAINT", "- Sơn chống thấm Một thành phần Aqua Shield\r\n\r\n- Chống thấm tuyệt hảo\r\n\r\n- Kháng nước tuyệt đối\r\n\r\n- Che phủ vết nứt, co giãn tốt, dễ thi công (không chứa xi măng)\r\n\r\n", "https://admin.mingstores.com/core/public/themes/mingstores/products/OOUUL3p3xO6kV63bOCyr4qCMZBNDo2yc.jpg", "K023 Sơn Kansai chống thấm Aqua Shield 5L, 18L", "Lít", 960000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitPrice" },
                values: new object[] { "INAX", "Sen cây nóng lạnh INAX BFV-515S là sản phẩm sen cây INAX  được thiết kế tay sen cài liền cùng thân sen cây thay vì để gắn tường, giúp cho tổng thể bộ sen cây trở nên gọn gàng, linh hoạt, đặc biệt phù hợp cả với những căn phòng tắm kích thước nhỏ, quý khách hàng vẫn có thể lắp đặt mẫu sen cây này và cảm nhận trải nghiệm khác biệt khi tắm vòi sen cây với bát sen lớn.\r\nMẫu thiết kế sen cây thuộc dòng sản phẩm SEN VÒI INAX có thiết kế đẹp mắt, sáng tạo từ kiểu dáng đến tính năng thích hợp cho mọi loại hình phòng tắm từ những phòng tắm đơn giản, nhỏ hẹp, đến những căn phòng tắm hiện đại, tiện nghi. ", "https://admin.mingstores.com/core/public/themes/mingstores/products/Mjzhtin7lD3gCUXksET0srIdUnABPNE3.jpg", "SEN TẮM CÂY INAX BFV-515S", "Cái", 12485000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitPrice" },
                values: new object[] { "INAX", "Là mẫu chậu rửa mặt Inax đặt bàn mới nhất 2017, sản phẩm tiêu biểu cho năm 2018", "https://admin.mingstores.com/core/public/themes/mingstores/products/JnyguIQW8EMvvUqcZ6BZnGSLOeL5OgpK.jpg", "Chậu Rửa Lavabo Inax AL-536V", "Cái", 2046000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CreatedBy", "Description", "Image", "MaterialStoreID", "Name", "SoldQuantities", "Unit", "UnitInStock", "UnitPrice" },
                values: new object[,]
                {
                    { 30, "NIRO GRANITE", null, "Gạch cao cấp đến từ thương hiệu nổi tiếng NIRO GRANITE", "https://admin.mingstores.com/core/public/themes/mingstores/products/Elgda4SYGE52gAn2wi5AEXipIEMqiYiB.jpg", 1, "Gạch GCA-Clay Art 60x60", 1500, "Gạch", 200, 400000m },
                    { 31, "ARISTON", null, "Công suất định mức: 4500(W)\r\nHình dáng: Hình tròn\r\nĐiện năng: 220V\r\nChế độ vòi sen: 5\r\nÁp lực nước tối thiểu: 30/0,3 Kpa/bar\r\nÁp lực nước tối đa: 380/3.8 Kpa/bar\r\nKích thước (DxCxR): 350 X 80\r\nTrọng lượng: 2 kg\r\nKhông có bơm trợ lực", "https://admin.mingstores.com/core/public/themes/mingstores/products/MbcC070BBSf4q97sgghpjBbqFiNr7JEP.jpg", 1, "Aures Smart Round RMC-45E-VN", 1500, "Bộ", 200, 3200000m },
                    { 32, "TOTO", null, "Thiết kế nguyên khối sang trọng, hiện đại\r\nNắp bàn cầu đóng êm, kèm vòi rửa nước lạnh Eco-washer\r\nBề mặt nước rộng giúp ngăn mùi hiệu quả\r\nThiết kế thân kín, vành kín tiện dụng cho việc vệ sinh hàng ngày\r\nCông nghệ CeFiONtect giúp lòng bàn cầu siêu nhẵn, hạn chế tối đa các vết bẩn, vi khuẩn\r\nCông nghệ xả G-Max êm, mạnh mẽ hiệu quả", "https://admin.mingstores.com/core/public/themes/mingstores/products/UYZ61ie7Z7i5Hmjd6D7XyUWhBZVL7y8v.jpg", 1, "Bồn cầu một khối TOTO MS904E4", 1500, "Bộ", 200, 19037000m },
                    { 33, "INAX", null, "Dòng sản phẩm bồn cầu INAX AC-1017R 1 khối cao cấp đến từ thương hiệu thiết bị vệ sinh INAX\r\nBệt Inax AC-1017R CW-KA22AVN 1 khối với thiết kế mới đơn giản, gọn gàng và sang trọng hơn kết hợp với những tính năng cải tiến\r\nCông nghệ ECO-X xã xoáy cuốn trôi mọi vết bẩn\r\nCông nghệ Aqua Ceramic giúp bề mạt men sứ trắng sáng trong suốt thời gian sữ dụng\r\nCông nghệ chống khuẩn HYPERKILAMIC kháng khuẩn độc quyền của INAX Nhật Bản. \r\nE-Clean: Chức năng phun rửa  tự động\r\nEvaClean: Chức năng vệ sinh phụ nữ\r\nCozyCare: Chức năng sưởi ấm bệ ngồi\r\nX-Fresh: Chức năng khử mùi nhanh \r\nEcoPower: Chức năng tiết kiệm điện “1 lần chạm” (8 tiếng sau tự khôi phục)\r\nDung tích két nước nóng: 0.67L (lít) Vòi phun rửa:\r\nVòi phun rửa và vòi phun dùng riêng cho phụ nữ đều là loại trượt tự động.  \r\nThiết bị an toàn: Rơ-le nhiệt, cảm ứng từ kiểm soát nhiệt độ cao, phao ngắt để thiết bị ngừng hoạt động khi không đủ nước, cảm ứng tự ngắt khi gặp sự cố. \r\nNước cấp: Nối trực tiếp từ đường ống nước ", "https://admin.mingstores.com/core/public/themes/mingstores/products/ryBdemssBcpSt6vbeQdirRUMcBszbZKt.jpg", 1, "Bồn Cầu Thông Minh INAX AC-1017R/CW-KA22AVN", 1500, "Bộ", 200, 26301000m },
                    { 34, "NIRO GRANITE", null, "Màu sắc: vàng, xám, trắng, đen\r\nKích thước: 30x60, 60x60", "https://admin.mingstores.com/core/public/themes/mingstores/products/U3SmJsX6rBhkAPyQ3Xym2wlyoNTH6pGz.jpg", 1, "GFS Gạch Granite Fusion Bán Bóng/Sần", 1500, "Cái", 200, 520000m },
                    { 35, "JINMEI", null, "ông nghệ sản xuất tủ lavabo của chúng tôi đã được chuyên nghiệp hóa qua nhiều năm phát triển, với phần khung bên ngoài được làm bằng nhôm, là cấu trúc chính hỗ trợ, giúp toàn bộ tủ chắc chắn, bên cạnh phần bản lề được làm bằng INOX 304 dày, giúp cho việc vận hành được trơn tru, ổn định.\r\n- Các bộ phận chính đều được làm bằng thép không gỉ 304 (INOX 304), tăng độ bền cho sản phẩm trong quá trình sử dụng.\r\n- Cấu hình cạnh và tay nắm cửa được làm bằng máy vát 45 độ đặc biệt, góc nhôm được gắn chặt vào thành bên trong tủ, để bề mặt sản phẩm mịn & tinh tế, tạo sự thoải mái khi sử dụng.\r\n\r\n- Việc sử dụng nhôm để làm vật liệu chính sản xuất tủ Lavabo là lựa chọn tối ưu nhất hiện nay, không chỉ có độ bền cao, nhôm hoàn toàn không độc hại với môi trường cũng như người sử dụng. Một số ưu điểm chính của nhôm:\r\n  + Trọng lượng nhẹ, độ bền cao, khả năng chịu lực lớn.\r\n  + Độ cứng tốt, không dễ biến dạng.\r\n  + Không thấm nước trong môi trường có độ ẩm cao, không bắt lửa và chịu được tác động mạnh.\r\n  + Lớp sơn phủ bền màu, chống ăn mòn do thời tiết hoặc hóa chất thông thường.\r\n  + Tạo không gian sang trọng, thoải mái và tiện lợi.", "https://admin.mingstores.com/core/public/themes/mingstores/products/P5GERhsHMvYboHFoSTcetoIuHKJJApvD.jpg", 1, "Tủ Lavabo JM843", 1500, "Bộ", 200, 9520000m },
                    { 36, "KANSAI PAINT", null, "Sơn ngoại thất câo cấp đến từ thương hiệu Kansai nổi tiếng", "https://admin.mingstores.com/core/public/themes/mingstores/products/JnLYt6lx4OLgmoplQoxTPU1e9SBjZf9a.jpg", 1, "K015 Sơn Kansai chống thấm Water Proof 4L, 17L", 1500, "Lít", 200, 750000m },
                    { 37, "COSMOS", null, "KARI SQUARE STEP LIGHT (3W) mang đến ánh sáng tinh tế đến gia đình bạn ", "https://admin.mingstores.com/core/public/themes/mingstores/products/N23c1P48S9v157cAYlNRc35gS92VeYVE.jpg", 1, "KARI SQUARE STEP LIGHT (3W)", 1500, "Cái", 200, 460000m },
                    { 38, "NIRO GRANITE", null, "GHR Gạch Granite Hardrock Mờ/Bán bóng ", "https://admin.mingstores.com/core/public/themes/mingstores/products/6TauBDiJiwnvQaJTuCl9D0SYHFayTRHk.jpg", 1, "GHR Gạch Granite Hardrock Mờ/Bán bóng", 1500, "Viên", 200, 360000m }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "15ad8f5a-1754-43d4-a859-9ec1938ce0e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "eb764b7d-6b8a-4ee1-8988-20a46682e8b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "6a7c8708-ee52-4ad7-9b2e-29349fa511c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "74226100-69bd-42a3-b966-958f125d6562");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "08f9d5cb-4baa-44e7-8baf-bb407af5d323", new DateTime(2023, 2, 28, 15, 25, 51, 840, DateTimeKind.Local).AddTicks(6575), "AQAAAAEAACcQAAAAEGcuu5m4FeQTisl2CdYSqBcb99+qIMD23dnNWYksI+ag0jTPsOaC8X5btn8h/1Jl1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "56f4409b-f4be-42ad-a370-3332c5742219", new DateTime(2023, 2, 28, 15, 25, 51, 852, DateTimeKind.Local).AddTicks(868), "AQAAAAEAACcQAAAAECX27gdXkQb8vfG7ar6pmB44E+Yqq6ixznpT7XKkeV00vVyJIFb4nqAQamjeAsdRIQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f6fbf980-8f7d-423a-aa36-74afb2ec7831", new DateTime(2023, 2, 28, 15, 25, 51, 811, DateTimeKind.Local).AddTicks(5840), "AQAAAAEAACcQAAAAEDtuKVSZmJhNpoICJTMYC1zk7CYvHUWjLJPrBPhRpHqY+LWTgxbAbX77R2ell4nsPg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "44430cd3-f6f0-490b-bb07-8bcae24f132f", new DateTime(2023, 2, 28, 15, 25, 51, 830, DateTimeKind.Local).AddTicks(5027), "AQAAAAEAACcQAAAAEJKAA26rPiEjOA0LgjPNCi6FhuJn8uEfFcGy8eE46v2f5aOp6hmzpw0YrZv+VMxeOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "238115a5-8a79-4130-931b-3c4f8bba3f48", new DateTime(2023, 2, 28, 15, 25, 51, 820, DateTimeKind.Local).AddTicks(9900), "AQAAAAEAACcQAAAAEA0HuA4Cz85KgH8MFe+rYDkRmw8zvd2RhGwqA4K81LrAxu/t9ucJ+FB8cP0aoJIhsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "7bb9cc29-ba1e-45fc-9104-1045f718674f", new DateTime(2023, 2, 28, 15, 25, 51, 802, DateTimeKind.Local).AddTicks(1300), "AQAAAAEAACcQAAAAEIFpVXtbykZHjFtpEO6ULTH8ZUOsDyjaaMkCUx3ALNZbIXHYDue9I6cRj5YvCEJpTA==" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoriesID", "ProductID", "Name" },
                values: new object[,]
                {
                    { 1, 7, "Mỹ" },
                    { 2, 7, "Sơn ngoại thất" },
                    { 1, 20, "Niro – Indonesia" },
                    { 2, 20, "Lít" },
                    { 4, 20, "Sơn ngoại thất" },
                    { 1, 21, "Nhật Bản" },
                    { 2, 21, "Cái" },
                    { 4, 21, "Nhà tắm" },
                    { 1, 22, "Nhật Bản" },
                    { 2, 22, "Cái" },
                    { 4, 22, "Nhà tắm" },
                    { 1, 30, "Mỹ" },
                    { 2, 30, "Gạch bóng" },
                    { 1, 31, "Mỹ" },
                    { 2, 31, "Thép" },
                    { 1, 32, "Mỹ" },
                    { 2, 32, "Cái" },
                    { 3, 32, "Ý" },
                    { 4, 32, "Nhà vệ sinh" },
                    { 1, 33, "Mỹ" },
                    { 2, 33, "Cái" },
                    { 3, 33, "Ý" },
                    { 4, 33, "Nhà vệ sinh" },
                    { 1, 34, "Niro – Indonesia" },
                    { 2, 34, "Cái" },
                    { 1, 35, "Niro – Indonesia" },
                    { 2, 35, "Bộ" },
                    { 4, 35, "Nhà tắm" },
                    { 1, 36, "Ý" },
                    { 2, 36, "Bộ" },
                    { 4, 36, "Sơn nội thất" },
                    { 1, 37, "Ý" },
                    { 2, 37, "Bộ" },
                    { 4, 37, "Phòng khách" },
                    { 1, 38, "Niro – Indonesia" },
                    { 2, 38, "Cái" },
                    { 4, 38, "Nội thất" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 6, "Màu vàng", 34, 5 },
                    { 7, "Màu xám", 34, 10 },
                    { 8, "Màu trắng", 34, 1220 },
                    { 9, "Màu đen", 34, 33 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 30 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 31 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 32 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 3, 32 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 33 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 3, 33 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 33 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 35 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 36 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 36 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 36 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 37 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 2, 38 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoriesID", "ProductID" },
                keyValues: new object[] { 4, 38 });

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DropColumn(
                name: "NavigateId",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(2491), new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 478, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 500, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 520, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 557, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 579, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 22, 21, 35, 36, 607, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Maù xanh");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Maù đỏ");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Sắt");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Gỗ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitInStock", "UnitPrice" },
                values: new object[] { "Pháp", "Gạch hoa lát cổ điển, màu trắng đen tương thích với các kiến trúc cổ", "http://anhduongphat.vn/wp-content/uploads/2020/03/gach-bong-trang-tri-hoa-van.jpg", "Gạch Hoa Cổ Điển", "ton", 30000, 50000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitPrice" },
                values: new object[] { "Kangaroo", "Description 1", null, "Product 1", "ton", 4000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitPrice" },
                values: new object[] { "Sony", "Description 2", null, "Product 2", "ton", 5000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Brand", "Description", "Image", "Name", "Unit", "UnitPrice" },
                values: new object[] { "Samsung", "Description 3", null, "Product 3", "ton", 6000m });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "b57d4b03-136f-4ef1-8b63-3bcfb53e72b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "c259f9ff-69fe-463e-b2b5-ebd8e065030b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "62879160-0d0f-4641-acad-aea61573d2de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "ba8a866a-c4e4-4173-9ea8-b3d7d8910ccf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "808dc13a-a28b-4316-8809-0d2684987f45", new DateTime(2023, 2, 22, 21, 35, 36, 557, DateTimeKind.Local).AddTicks(553), "AQAAAAEAACcQAAAAEPzN6OlvkOUynkihF41B3+u9yULCNjDTAJEIUdeFORY0g3/3X9lx/m0btqOy8QATjA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "e59edf7c-35c2-43c3-b773-40ba286c2f8f", new DateTime(2023, 2, 22, 21, 35, 36, 579, DateTimeKind.Local).AddTicks(3804), "AQAAAAEAACcQAAAAEAiE0OdGJia/H30SqUHiufMRoUfOtTmmNdMrKI+EmcmsOEIFooszBixg8l55KWbSaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f8ac8400-5e8e-4177-b968-85c038619e5e", new DateTime(2023, 2, 22, 21, 35, 36, 478, DateTimeKind.Local).AddTicks(6239), "AQAAAAEAACcQAAAAECe64++OZrXzq9Eqwmnx66Be4M8LZ33MZWdXuDTC5KxJpGGpIdxR05ITjcTEFQQpKg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "052a252b-5b7e-4ccf-b3ac-9f5123eda2e3", new DateTime(2023, 2, 22, 21, 35, 36, 520, DateTimeKind.Local).AddTicks(3686), "AQAAAAEAACcQAAAAEHtC/dSHONuMqeOEiAKoEMepgQm+y1AOE7yp0ryh6MH+pXT2BQ121JX4CLOYNvBggg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "75faf50a-bd0b-41fb-b5da-71b4ba6e506c", new DateTime(2023, 2, 22, 21, 35, 36, 500, DateTimeKind.Local).AddTicks(6661), "AQAAAAEAACcQAAAAELGwSD+DQpVtj3rzRAFdnOEiWpuYo/0kL3VgbiGhuJ4OYIS0gTcGd6uHCmRZ3br60A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b84eccaa-5633-4bf1-b714-b1a88de2bc90", new DateTime(2023, 2, 22, 21, 35, 36, 459, DateTimeKind.Local).AddTicks(5401), "AQAAAAEAACcQAAAAENsac1nj+uIWSAfq6+In4c7jj2Qk3T8q3weU5YEeU6sdzSrMs496q+m96OO+FbD+xA==" });
        }
    }
}
