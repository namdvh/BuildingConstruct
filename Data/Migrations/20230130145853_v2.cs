using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 30, 21, 58, 52, 929, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.InsertData(
                table: "Builders",
                columns: new[] { "Id", "Certificate", "CreateBy", "Experience", "ExperienceDetail", "LastModifiedAt", "Place", "TypeID" },
                values: new object[] { 2, null, new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"), null, null, new DateTime(2023, 1, 30, 21, 58, 52, 935, DateTimeKind.Local).AddTicks(9216), 61, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "b4cadfcf-da10-4ba4-b5fa-f77d1bf4ec33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "1ea1b2d9-b397-4792-a57e-95383d60d87a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "311822f9-8f84-4a01-8762-a9d6e41a6693");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "aa6a77ff-d236-44ce-bc1e-e76444afa9bc");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a5bd828d-b4d0-44db-8995-84b2e2a1cddf", new DateTime(2023, 1, 30, 21, 58, 52, 923, DateTimeKind.Local).AddTicks(8655), "AQAAAAEAACcQAAAAEKcbg4uDsw6rWnN8bfr34d0uRynwrCUjzQn/B6/LMZ0dI4EwfFDEAi9U+g9aS25Rsg==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName", "VerifyID" },
                values: new object[] { new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"), 0, "18, Phuoc Thien, Nhon Trach, Dong Nai", null, 2, "1ef8d3a8-e9a4-4ec9-a8b4-ba47a2e09148", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhoaidoan1@gmail.com", false, "Hoai", 0, null, new DateTime(2023, 1, 30, 21, 58, 52, 929, DateTimeKind.Local).AddTicks(8948), "Nam Doan Vu", false, null, null, null, null, "AQAAAAEAACcQAAAAEOr2JRs5fhhJF6e9RvASkdsu51um7nEkMmeztIBZQB/UkwxqRa6rDKuK8uPtSMm5Wg==", "0392799276", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "namhoaidoan1@gmail.com", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"));

            migrationBuilder.DeleteData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 28, 15, 21, 44, 632, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "d00dd60c-ed9a-41a2-aaf8-c2d2483f0582");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "0b99b3c4-4e41-4896-a23d-c814d7f7a4ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "6a425fb6-c974-44d3-9d5b-81c607e6dea6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "4a96d844-3a27-4685-9e21-16f3c3ea26a7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "576e716f-0592-47f6-ac4b-9a568c7b9c02", new DateTime(2023, 1, 28, 15, 21, 44, 626, DateTimeKind.Local).AddTicks(1019), "AQAAAAEAACcQAAAAEPQFSAZTW8tIpKN7iTOw1ikUa0ZlaSGPK2TyzhTY8BQsholzpSojjmDgU0z+7cYm2Q==" });
        }
    }
}
