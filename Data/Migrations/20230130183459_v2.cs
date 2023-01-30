using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f") });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 34, 58, 595, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 34, 58, 606, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 34, 58, 617, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "ab1e9c10-2404-4673-a3a2-739ddf6af405");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "7e0a0c6b-1199-4f8e-bede-1e917a4e661d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "0dffb776-efa1-4776-82aa-9f2358fe26b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "e246b923-3651-4976-9f50-9913486c0bad");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ea46bf80-0dc3-4e6f-80fd-6b41169d4c05", new DateTime(2023, 1, 31, 1, 34, 58, 606, DateTimeKind.Local).AddTicks(5909), "AQAAAAEAACcQAAAAEPNivp8Cx4IIeDMg3GqOOtWKxrZ2wTxfIRSs4zuGGxn+Kmv3hH+U22/jyEC0ILV3Sw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a4342eea-0a79-49b5-b68e-ca2da9a546d8", new DateTime(2023, 1, 31, 1, 34, 58, 595, DateTimeKind.Local).AddTicks(5725), "AQAAAAEAACcQAAAAEKCjL5j6pQZu6hirOZcg1ZTdJZwSXpP9dqXIpCvbmoGEvdX0DF3mkarXNozHoN0pCQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c5323dc6-f2e9-4004-88c9-6c40f1502304", new DateTime(2023, 1, 31, 1, 34, 58, 586, DateTimeKind.Local).AddTicks(7), "AQAAAAEAACcQAAAAEPQREUYlSUUz4rIutFvIYwsy7V1yqpo3bIokk382h6v/qSTaom55/jwxfZwwt0wfwQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4") });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 31, 44, 530, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 31, 44, 537, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 31, 44, 545, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "3552501f-0e37-4f85-ab7d-898dbc38463b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "e63c5ec7-5e1a-4b3e-9d81-a94451007d98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "d2e675b5-57d0-483f-bfce-617db836521e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "f260d1cc-e5fd-4f3c-958b-f160525b0b23");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "7161f51e-de20-4aab-b610-7df29f743128", new DateTime(2023, 1, 31, 1, 31, 44, 537, DateTimeKind.Local).AddTicks(9795), "AQAAAAEAACcQAAAAEFZ6Rk2Lq/OPgvch+qfU78h9j5VeILKzcRg4L6Ip22+6RHYuVmgnFLF/ITkxTMedzg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b9f96ab0-b38c-4b2e-89c5-2b7212d37bce", new DateTime(2023, 1, 31, 1, 31, 44, 530, DateTimeKind.Local).AddTicks(1039), "AQAAAAEAACcQAAAAELfBEgEt/PxtKkl80pQEUWGGeMW88ojTVh9/8bU8poKzv9VkRc/2fyOGYhxmIw5wUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d64429a3-adf2-4fc3-95d4-446700970884", new DateTime(2023, 1, 31, 1, 31, 44, 522, DateTimeKind.Local).AddTicks(1218), "AQAAAAEAACcQAAAAEISaGOjEeEErv4S4sRTnDFoyYB5PlqgSkZ6+uwtM32xN9eSbcQPH0PMmm0S7oQBOWQ==" });
        }
    }
}
