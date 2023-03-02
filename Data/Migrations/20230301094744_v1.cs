using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreateBy",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6521), new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 382, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 390, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Accommodation", "ConstructionType", "EndTime", "LastModifiedAt", "StartTime", "Transport" },
                values: new object[] { true, "Nhà ở", "17:30", new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5744), "8:00", true });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Accommodation", "ConstructionType", "EndTime", "LastModifiedAt", "StartTime", "Transport" },
                values: new object[] { true, "Tòa nhà/Chung cư", "17:30", new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5762), "8:00", true });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Accommodation", "ConstructionType", "EndTime", "LastModifiedAt", "StartTime", "Transport" },
                values: new object[] { true, "Công trình công cộng", "17:30", new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5775), "8:00", true });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 398, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 406, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 413, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreateBy", "IsRead", "LastModifiedAt", "Message", "NavigateId", "Title", "Type", "UserID" },
                values: new object[,]
                {
                    { 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), false, new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6587), "Someone has saved your post", 1, "New Notification", 0, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6") },
                    { 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), false, new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6608), "Someone has applied your post", 1, "New Notification", 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6") },
                    { 3, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), false, new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6621), "Create commitment successfully", 1, "New Notification", 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6") }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "d7de15b3-672f-4763-80e2-04586053d2b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "3e61bdf9-4cac-489a-91e9-7d5f57a7b796");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "1c9f1023-c23d-404f-acc1-b85dc7507831");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "44f96253-d9d7-4422-8e03-473665ae5792");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "Address", "Avatar", "ConcurrencyStamp", "Email", "FirstName", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { "Giồng Ông Tố, Thành Phố Thủ Đức, TPHCM, Việt Nam", "https://baodautu.vn/Images/chicong/2018/11/28/thi-truong-vat-lieu-xay-dung-mua-kinh-doanh-da-thay-doi1543390455.jpg", "ce4d8d37-91c5-4cf8-9d1c-be34f4429c04", "store123@gmail.com", "TPHCM", new DateTime(2023, 3, 1, 16, 47, 43, 406, DateTimeKind.Local).AddTicks(2096), "Cửa Hàng Vật Liệu", "AQAAAAEAACcQAAAAENxQ4a3qMLj4cjtPlUTQjVpOL6cLeOmYfFjb7eddIwpYsgzuxGeoF4jmAEdR9h6sKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "Address", "Avatar", "ConcurrencyStamp", "FirstName", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { "Thành Phố Cần Thơ, Việt Nam", "data:image/jpeg;base64,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", "64b2c046-aaff-48ac-b8e7-845741ca8d03", "Cần Thơ", new DateTime(2023, 3, 1, 16, 47, 43, 413, DateTimeKind.Local).AddTicks(8479), "VLXD", "AQAAAAEAACcQAAAAEMgBeiZZC4VQ1si4QV8jlsyI1dJacsXXj1W0++9qgxBZv4Rn7lt5igoj4ORDya96rg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { "https://scontent.fsgn5-3.fna.fbcdn.net/v/t1.6435-9/86186750_1329130013936346_7257030880831471616_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=174925&_nc_ohc=Z1GTPvzRt7wAX_WbRZ5&_nc_ht=scontent.fsgn5-3.fna&oh=00_AfAYtaD2dHE_84_-PSlDqLaeyBlH9zJ3b308pHcTWucCXw&oe=642552F2", "6e1f4db9-bf63-448d-9b0d-27b35dd4357e", new DateTime(2023, 3, 1, 16, 47, 43, 382, DateTimeKind.Local).AddTicks(3415), "Nguyen Anh", "AQAAAAEAACcQAAAAEN5pvUghPkCCBIDUzTuTBFQOjSZENGo0t1FNA+dKoD+OyEqroNyCnb1y4lDQ9O9OOQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "030b78c9-33f2-4bf1-9b6d-431628e47105", new DateTime(2023, 3, 1, 16, 47, 43, 398, DateTimeKind.Local).AddTicks(2264), "AQAAAAEAACcQAAAAEHQwjb7/rWzUi5v04wZFfOpHNCYErIP2sHg6WkA4hj87xfTJ1+pTSLbNls5SuwCZoQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a5d02fe5-17b8-4e0f-b525-bc49f1822e94", new DateTime(2023, 3, 1, 16, 47, 43, 390, DateTimeKind.Local).AddTicks(2408), "AQAAAAEAACcQAAAAEJnfiiwAgiWw81a8dBcIPH+xmApkqsqxNeKmtcE/OIZyFAOqKfySgkEcQXxpNn4Z3w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "FirstName", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { "https://i1-giaitri.vnecdn.net/2013/08/15/DK-02756-1376528749.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=mX89l0q4HQgntQ5wJesOcw", "de7ea253-2c09-4134-9add-d02a90f80590", "Hoai Nam", new DateTime(2023, 3, 1, 16, 47, 43, 374, DateTimeKind.Local).AddTicks(2166), "Doan Vu", "AQAAAAEAACcQAAAAEC4ePQGXo5ZwL9exlVPa0as7xELdv+lJKc7+JwuFOESLzFh8b3MCUombwL14yGg/oA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Products");

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

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Accommodation", "ConstructionType", "EndTime", "LastModifiedAt", "StartTime", "Transport" },
                values: new object[] { false, null, null, new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2796), null, false });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Accommodation", "ConstructionType", "EndTime", "LastModifiedAt", "StartTime", "Transport" },
                values: new object[] { false, null, null, new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2833), null, false });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Accommodation", "ConstructionType", "EndTime", "LastModifiedAt", "StartTime", "Transport" },
                values: new object[] { false, null, null, new DateTime(2023, 2, 28, 15, 25, 51, 862, DateTimeKind.Local).AddTicks(2861), null, false });

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
                columns: new[] { "Address", "Avatar", "ConcurrencyStamp", "Email", "FirstName", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { "Q2", null, "08f9d5cb-4baa-44e7-8baf-bb407af5d323", "store@gmail.com", "Store", new DateTime(2023, 2, 28, 15, 25, 51, 840, DateTimeKind.Local).AddTicks(6575), "Store", "AQAAAAEAACcQAAAAEGcuu5m4FeQTisl2CdYSqBcb99+qIMD23dnNWYksI+ag0jTPsOaC8X5btn8h/1Jl1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "Address", "Avatar", "ConcurrencyStamp", "FirstName", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { "Q2", null, "56f4409b-f4be-42ad-a370-3332c5742219", "Store2", new DateTime(2023, 2, 28, 15, 25, 51, 852, DateTimeKind.Local).AddTicks(868), "Store2", "AQAAAAEAACcQAAAAECX27gdXkQb8vfG7ar6pmB44E+Yqq6ixznpT7XKkeV00vVyJIFb4nqAQamjeAsdRIQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "Avatar", "ConcurrencyStamp", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { null, "f6fbf980-8f7d-423a-aa36-74afb2ec7831", new DateTime(2023, 2, 28, 15, 25, 51, 811, DateTimeKind.Local).AddTicks(5840), "Nguyen", "AQAAAAEAACcQAAAAEDtuKVSZmJhNpoICJTMYC1zk7CYvHUWjLJPrBPhRpHqY+LWTgxbAbX77R2ell4nsPg==" });

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
                columns: new[] { "Avatar", "ConcurrencyStamp", "FirstName", "LastModifiedAt", "LastName", "PasswordHash" },
                values: new object[] { null, "7bb9cc29-ba1e-45fc-9104-1045f718674f", "Hoai", new DateTime(2023, 2, 28, 15, 25, 51, 802, DateTimeKind.Local).AddTicks(1300), "Nam", "AQAAAAEAACcQAAAAEIFpVXtbykZHjFtpEO6ULTH8ZUOsDyjaaMkCUx3ALNZbIXHYDue9I6cRj5YvCEJpTA==" });
        }
    }
}
