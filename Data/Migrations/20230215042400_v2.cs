using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5285), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5354), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 596, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 605, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 614, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 622, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 631, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "76881ec8-61e8-4196-96d3-ae04f4983485");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "ee3fa693-51ac-41d6-98da-d8c1d97c88eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "0d7804fc-364d-4e41-a9d4-8e9b9b3b82f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "bc8d2037-ec11-48c0-a20d-5f29ad13b6aa");

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5373), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5389), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a9bb4143-0c4a-4872-b1f5-d8c6c6b32623", new DateTime(2023, 2, 15, 11, 23, 58, 622, DateTimeKind.Local).AddTicks(9639), "AQAAAAEAACcQAAAAEA96BrPkJWacP9TeZUHldaptoYRNFEhEq1M0zrmxnbxmzPCLTrBq6FtMDWLyZkGHvg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "477571eb-3945-45c4-9a5b-d9a1ec0ed1bc", new DateTime(2023, 2, 15, 11, 23, 58, 631, DateTimeKind.Local).AddTicks(8042), "AQAAAAEAACcQAAAAEFvU1/7xEf8YwGW4YEOhCY+/ZdnbU86UUvOGp9j8nGZSU5AZr7EzcTrtj2bvHsB42Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6526f812-59c1-4852-87e3-c9b2c87fbf7b", new DateTime(2023, 2, 15, 11, 23, 58, 596, DateTimeKind.Local).AddTicks(9505), "AQAAAAEAACcQAAAAEDQR7wz5kTCue5+gooc2UPq+rmBiYFG8ApKJ/kPJwASityTCPd86CaSqqi1akCbfHA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "4fac719f-4763-4aa9-ba70-c4d1b87d1035", new DateTime(2023, 2, 15, 11, 23, 58, 614, DateTimeKind.Local).AddTicks(3856), "AQAAAAEAACcQAAAAEBm0PMByVRVLkbgSVGXmYOJrEjQXsN/Ns1aTg/LiMsSbFv2ntmTnqBTuSt2hqpbbBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "dbac5495-f917-40bc-951f-edbca2349fc1", new DateTime(2023, 2, 15, 11, 23, 58, 605, DateTimeKind.Local).AddTicks(5355), "AQAAAAEAACcQAAAAEK1Tk3MKpOoeH7IZNC68xIoX4E6vpjiJwqGkAPnC5ryp4HbjO9c8bHWTGq6kGhpHgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0cb03e0b-f5f4-4a63-98e6-731358c2c3b6", new DateTime(2023, 2, 15, 11, 23, 58, 588, DateTimeKind.Local).AddTicks(1727), "AQAAAAEAACcQAAAAELJUWCi0/Y8xoAVFz5OA9EAi9uecfBVrUvIdGkj8ttJHybngQzmc63u/mGCzbNGFrQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "ProductType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "ProductType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9223), new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 627, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 633, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 640, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 647, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 654, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "b624c328-5be3-4513-8a22-a41642739699");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "f24032de-5528-4385-9212-b4fbc3aced4d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "859edd66-35ed-46b6-a98c-286bafb1ef42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "e9e098c4-517f-48aa-9bb8-57be849ff512");

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9236), new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9246), new DateTime(2023, 2, 15, 11, 19, 5, 660, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5305ebda-da06-4f75-a4ca-4d2097df5315", new DateTime(2023, 2, 15, 11, 19, 5, 647, DateTimeKind.Local).AddTicks(1793), "AQAAAAEAACcQAAAAEAUDQ36CBSF8pC6tScP29PsYbXn+c3jvnUKRh5wKPttvUT8BoJh1J1MI3pCSjf/k+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c598e3e6-4e8e-47f0-8d0b-36c2ccb58929", new DateTime(2023, 2, 15, 11, 19, 5, 654, DateTimeKind.Local).AddTicks(445), "AQAAAAEAACcQAAAAEPL7D9K1gaM5oimwzvuPXNXH5DVkPTfT+ZCheLZZkwNNjwMkk/4RoQLSFMUTkTxL8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "9e0890f2-5c6e-4eaf-bf81-87f492413a8f", new DateTime(2023, 2, 15, 11, 19, 5, 627, DateTimeKind.Local).AddTicks(1556), "AQAAAAEAACcQAAAAEIFKkPgFutIBwFo7+lFNAgTF4EhPxS1CiEn3MqAA740gS6CTfpVmRhlqd7Uu5qNIuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0318cbbf-f85d-4c92-85fb-148c80aa27d8", new DateTime(2023, 2, 15, 11, 19, 5, 640, DateTimeKind.Local).AddTicks(3021), "AQAAAAEAACcQAAAAEB/lV9XuKKmIEfwns7JrinU3lhOmk3cr2TezhU9RRaR8SpXq658InsRj1H8OgVcjaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "7f46c1ab-2407-4b0a-9fb6-6448860d6a58", new DateTime(2023, 2, 15, 11, 19, 5, 633, DateTimeKind.Local).AddTicks(6412), "AQAAAAEAACcQAAAAEAMUafkOYIdxQuUi/PoVosGyqtFB/Ifhq6994jk+1Aemy9GjBE6l5eVw4YtwllmY2g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a3804613-013a-4b79-8254-873256e9629f", new DateTime(2023, 2, 15, 11, 19, 5, 620, DateTimeKind.Local).AddTicks(9355), "AQAAAAEAACcQAAAAEHO9D9SsKYjQeDLj/CVGpwYr3CnluUUOwBhzBzJxf61qq80iKSZPSypnQVSEeI5M+w==" });
        }
    }
}
