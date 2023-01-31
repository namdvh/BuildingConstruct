using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 1, 1, 12, 46, 869, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 1, 1, 12, 46, 876, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"), new DateTime(2023, 2, 1, 1, 12, 46, 900, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"), new DateTime(2023, 2, 1, 1, 12, 46, 900, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"), new DateTime(2023, 2, 1, 1, 12, 46, 900, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"), new DateTime(2023, 2, 1, 1, 12, 46, 900, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"), new DateTime(2023, 2, 1, 1, 12, 46, 900, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"), new DateTime(2023, 2, 1, 1, 12, 46, 900, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 1, 1, 12, 46, 894, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 1, 1, 12, 46, 900, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 1, 1, 12, 46, 882, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 1, 1, 12, 46, 888, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "2b5bf21d-eab3-4cda-85a1-6f69c7df15ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "5f717fb1-8709-4fae-b036-64f372450ddd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "85f496f2-d12a-4811-8e64-253772271700");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "7e81469a-761b-49a7-a57b-33a910f7b100");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "80eab973-4508-4ca9-b02c-a82567f83a98", new DateTime(2023, 2, 1, 1, 12, 46, 876, DateTimeKind.Local).AddTicks(356), "AQAAAAEAACcQAAAAEKJi77KV7MlOW0eA4O78yxyUmfgf0GT5fX7ovPboQl1G5kdXTMfrapMt2eIkqD48gA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "348a51f8-7efe-4d1d-82c1-aed94819acf5", new DateTime(2023, 2, 1, 1, 12, 46, 882, DateTimeKind.Local).AddTicks(1916), "AQAAAAEAACcQAAAAEG+roNdJ1MVhbriX8GT6T9Y3geuPyjOFaHVupql9hD7rL3EWSGiQBf9zP5qY9d+Eig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c0c76469-9508-4559-b564-62464850b6db", new DateTime(2023, 2, 1, 1, 12, 46, 888, DateTimeKind.Local).AddTicks(2507), "AQAAAAEAACcQAAAAEGSzpDZyNE38h6mQrNyzaElqeYbCqTbYFYG6iiSMAUsx2qoBI5v9a386p6hZpm1aYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "490a88d2-9367-4210-bdfb-eb120857c16d", new DateTime(2023, 2, 1, 1, 12, 46, 894, DateTimeKind.Local).AddTicks(3615), "AQAAAAEAACcQAAAAEIt29Mdm1m9oGiJawl1cobAjWpLRAhR0P028/cltQrD5u3OWs9NVKdMBB8dl95kuCA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "50b61bba-485e-4fea-96db-27f4422aed49", new DateTime(2023, 2, 1, 1, 12, 46, 869, DateTimeKind.Local).AddTicks(9496), "AQAAAAEAACcQAAAAEJX2dlSBFJvwErx8ED+g4PawYcSoV78wsQ7UmxJ8Rco0nCCvZLNRZ5c1T8eHOCeqpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b05cad2e-12c7-4b9d-bf35-8faa69ce3a4b", new DateTime(2023, 2, 1, 1, 12, 46, 863, DateTimeKind.Local).AddTicks(8749), "AQAAAAEAACcQAAAAEJ4WmS1FCIDXvKtmqFRIAQoR+znMVzhtSiIWLcPJC6MagHAX1dRObb5zcilJp9DAEA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 20, 41, 17, 56, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 20, 41, 17, 63, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 31, 20, 41, 17, 92, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 31, 20, 41, 17, 92, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 31, 20, 41, 17, 92, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 31, 20, 41, 17, 92, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 31, 20, 41, 17, 92, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateBy", "LastModifiedAt" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 31, 20, 41, 17, 92, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 20, 41, 17, 85, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 20, 41, 17, 92, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 20, 41, 17, 71, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 20, 41, 17, 78, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "81b943b6-f930-4ecf-bb06-df780cfd4733");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "d5f81c1b-cd63-408b-bd61-c448d75c4a2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "76fa1419-39f2-4612-b03b-f6b9b60b351c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "34534128-7c9f-410b-a06b-e6e59205437b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "81c3fea3-793b-4909-b35e-c28257e7b3f7", new DateTime(2023, 1, 31, 20, 41, 17, 63, DateTimeKind.Local).AddTicks(9524), "AQAAAAEAACcQAAAAEMkixKZuo9nSryks7cet65G4HQiZ0uaJBSjCWVF/Jr0O0n5ot4Gf+2PGMc7gQZVfaQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "cbfd80a4-8cb7-4197-8ade-fb90180da7b3", new DateTime(2023, 1, 31, 20, 41, 17, 71, DateTimeKind.Local).AddTicks(977), "AQAAAAEAACcQAAAAEMW/d4gc/sl3T3huPShGkRjNAnfY1/cvcbtVG31bQrDakQoZCcm0PTIYLgoRWuvmDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "80486e3d-162c-4123-9dc5-7ecb744a2de8", new DateTime(2023, 1, 31, 20, 41, 17, 78, DateTimeKind.Local).AddTicks(6596), "AQAAAAEAACcQAAAAENNs7PVDGmrUhJIrqbiukqffOLTV2wH7sKRs/ZVW2U9KTnologZvhAi9yPQ9nb0YZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "87f1eb23-3300-4b11-b420-dd810a8b205c", new DateTime(2023, 1, 31, 20, 41, 17, 85, DateTimeKind.Local).AddTicks(5752), "AQAAAAEAACcQAAAAEC2VBAXsQ0JGT6GTeWpuB7Fp0BB7hZy3KkDzqlOIiug5/DU/q0VdtS9DB3o1bwA0Cw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2dca1614-7a41-4878-938f-785498d38e9b", new DateTime(2023, 1, 31, 20, 41, 17, 56, DateTimeKind.Local).AddTicks(9971), "AQAAAAEAACcQAAAAEBFtGH0Q5wzI/bvOOGDV2S2weYEmSXVYfSvWKVm3pKJQ3ticQQeGzKZQS7Sxv3md6g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "af082b24-5b88-4a1f-aa20-44bb2ca3fba3", new DateTime(2023, 1, 31, 20, 41, 17, 50, DateTimeKind.Local).AddTicks(2845), "AQAAAAEAACcQAAAAEJi0poui5g5ClCn4qTaAeLN0deVz2m6eihjAMZ6zFHKkOQ2Icw6EeZfbtXvd2vWslw==" });
        }
    }
}
