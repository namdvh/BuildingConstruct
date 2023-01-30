using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 30, 22, 9, 18, 175, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 30, 22, 9, 18, 185, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.InsertData(
                table: "MaterialStores",
                columns: new[] { "Id", "CreateBy", "Description", "Experience", "Image", "LastModifiedAt", "Place", "TaxCode", "Website" },
                values: new object[] { 1, new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"), null, null, null, new DateTime(2023, 1, 30, 22, 9, 18, 191, DateTimeKind.Local).AddTicks(6576), 52, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "53053ffd-035b-4287-97ee-d8254b929ac2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "b7863dcf-52bd-47eb-a53f-5c97cd91b258");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "0df27fdf-ca2b-4869-ba73-a35486195134", "Store", "Store", "STORE" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "315eb8b3-48f0-44bd-b6d2-4f4b3dbe39c4");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "98b4d719-0928-4454-9cfa-9ce42780ee0e", new DateTime(2023, 1, 30, 22, 9, 18, 175, DateTimeKind.Local).AddTicks(5716), "AQAAAAEAACcQAAAAEErpZubRMFzAlIWp9H41mWy7BFUBSygxyE1ooFD05VBcp6T8li4G73CRqb8yQI4lcA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "aff302ca-efc9-474c-a4cc-6bd039994517", new DateTime(2023, 1, 30, 22, 9, 18, 168, DateTimeKind.Local).AddTicks(4560), "AQAAAAEAACcQAAAAEGSBQvSwaMtWabVRT6naq2vns+Wq5aW4unMYL96OEOoKqQjUQHPtw9E1uEWlT6fi+A==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName", "VerifyID" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"), 0, "18, Phuoc Thien, Nhon Trach, Dong Nai", null, null, "db58ce33-abc4-43f7-84d8-f42ffd741fad", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1999, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhoai1@gmail.com", false, "Store", 0, null, new DateTime(2023, 1, 30, 22, 9, 18, 185, DateTimeKind.Local).AddTicks(1485), "Nguyen Anh Vu", false, null, 1, null, null, "AQAAAAEAACcQAAAAEJrhquJMt1wbIuBJFBEqUED5CaeYDHTJqkOXxPSYhFnm4OA3RhyMWgUjCShhcAyeBA==", "0123456789", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, "xxx", false, "namhoai1@gmail.com", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"));

            migrationBuilder.DeleteData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 30, 21, 58, 52, 929, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 30, 21, 58, 52, 935, DateTimeKind.Local).AddTicks(9216));

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
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "311822f9-8f84-4a01-8762-a9d6e41a6693", "Admin", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "aa6a77ff-d236-44ce-bc1e-e76444afa9bc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "1ef8d3a8-e9a4-4ec9-a8b4-ba47a2e09148", new DateTime(2023, 1, 30, 21, 58, 52, 929, DateTimeKind.Local).AddTicks(8948), "AQAAAAEAACcQAAAAEOr2JRs5fhhJF6e9RvASkdsu51um7nEkMmeztIBZQB/UkwxqRa6rDKuK8uPtSMm5Wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a5bd828d-b4d0-44db-8995-84b2e2a1cddf", new DateTime(2023, 1, 30, 21, 58, 52, 923, DateTimeKind.Local).AddTicks(8655), "AQAAAAEAACcQAAAAEKcbg4uDsw6rWnN8bfr34d0uRynwrCUjzQn/B6/LMZ0dI4EwfFDEAi9U+g9aS25Rsg==" });
        }
    }
}
