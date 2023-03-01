using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 723, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 732, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 742, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 750, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 759, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "LastModifiedAt",
                value: new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "LastModifiedAt",
                value: new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "LastModifiedAt",
                value: new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 55, 10, 768, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "c60ad1d2-afb1-4f47-b535-2ffc4a3cfd1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "da762d05-b2f2-4e1f-8049-75c4d84aafaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "bdd970c5-64d1-448c-8ace-8005602359f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "5f60c2dd-6272-4ffb-843b-8822be2ec18a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f55d4ed0-bcc2-498e-b1f8-e2cd174f70e1", new DateTime(2023, 3, 1, 16, 55, 10, 750, DateTimeKind.Local).AddTicks(7002), "AQAAAAEAACcQAAAAECNjWlgt3nCphmqZa5HQqzAhtzqO2i+Kqdbp2HpDsNOB3tXFhrBbxUOHlMdFtlQWhw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "7ba4cf5c-5284-41eb-898a-f7e02675c451", new DateTime(2023, 3, 1, 16, 55, 10, 759, DateTimeKind.Local).AddTicks(7193), "AQAAAAEAACcQAAAAEF8yazW3JAScZagbc2oKK1UjPoM/xHAIsfUKG97kcspLXJHCzkrgyzrU9CnoPD0Fsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6f6c570c-daea-490d-ae59-419a9530dc09", new DateTime(2023, 3, 1, 16, 55, 10, 724, DateTimeKind.Local).AddTicks(18), "AQAAAAEAACcQAAAAEF1q30wjeOZY1NzBRzDpgCS1gjpdpEAt3BvuqahVubCmo35oJF3wFNJz5fujCpPF0Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "aca38914-c441-4956-bf39-621becb1ca28", new DateTime(2023, 3, 1, 16, 55, 10, 742, DateTimeKind.Local).AddTicks(2348), "AQAAAAEAACcQAAAAENEsP3ccOgo9VjT4OBsCVyT2aZl1Zkx9qZ+Wbe0wpAkjD9Xsw0T2NpMWS7bhChZlIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "120b63a0-88a6-4242-ad3f-8ba398085ccd", new DateTime(2023, 3, 1, 16, 55, 10, 732, DateTimeKind.Local).AddTicks(4798), "AQAAAAEAACcQAAAAEIKYpJx0B9ISammy1EjxAxrQmtjCtakSKGhqOnHbiMU8DOmuhU7Uo8AQaJGjBYIFpw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "84c46a3b-36a6-4c64-a8f3-eeed5ab6c4d2", new DateTime(2023, 3, 1, 16, 55, 10, 715, DateTimeKind.Local).AddTicks(2433), "AQAAAAEAACcQAAAAEAkoF+r6I4zf1o5s7nZaLajAykswBcbJGCYl4x7tEKnpuqj9ErEX7XQjyNHlj53YWg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(5775));

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

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 1, 16, 47, 43, 421, DateTimeKind.Local).AddTicks(6621));

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
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ce4d8d37-91c5-4cf8-9d1c-be34f4429c04", new DateTime(2023, 3, 1, 16, 47, 43, 406, DateTimeKind.Local).AddTicks(2096), "AQAAAAEAACcQAAAAENxQ4a3qMLj4cjtPlUTQjVpOL6cLeOmYfFjb7eddIwpYsgzuxGeoF4jmAEdR9h6sKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "64b2c046-aaff-48ac-b8e7-845741ca8d03", new DateTime(2023, 3, 1, 16, 47, 43, 413, DateTimeKind.Local).AddTicks(8479), "AQAAAAEAACcQAAAAEMgBeiZZC4VQ1si4QV8jlsyI1dJacsXXj1W0++9qgxBZv4Rn7lt5igoj4ORDya96rg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6e1f4db9-bf63-448d-9b0d-27b35dd4357e", new DateTime(2023, 3, 1, 16, 47, 43, 382, DateTimeKind.Local).AddTicks(3415), "AQAAAAEAACcQAAAAEN5pvUghPkCCBIDUzTuTBFQOjSZENGo0t1FNA+dKoD+OyEqroNyCnb1y4lDQ9O9OOQ==" });

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
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "de7ea253-2c09-4134-9add-d02a90f80590", new DateTime(2023, 3, 1, 16, 47, 43, 374, DateTimeKind.Local).AddTicks(2166), "AQAAAAEAACcQAAAAEC4ePQGXo5ZwL9exlVPa0as7xELdv+lJKc7+JwuFOESLzFh8b3MCUombwL14yGg/oA==" });
        }
    }
}
