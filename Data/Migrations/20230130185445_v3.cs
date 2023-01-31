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
                value: new DateTime(2023, 1, 31, 1, 54, 44, 175, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 54, 44, 187, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "CompanyName", "CreateBy", "Description", "LastModifiedAt", "Website" },
                values: new object[,]
                {
                    { 1, "Bat dong san Vinhome", new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"), null, new DateTime(2023, 1, 31, 1, 54, 44, 222, DateTimeKind.Local).AddTicks(3162), "abcdef.com.vn" },
                    { 2, "Bat dong san Thang Long", new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"), null, new DateTime(2023, 1, 31, 1, 54, 44, 233, DateTimeKind.Local).AddTicks(1866), "nguyenduy.com.vn" }
                });

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 54, 44, 200, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.InsertData(
                table: "MaterialStores",
                columns: new[] { "Id", "CreateBy", "Description", "Experience", "Image", "LastModifiedAt", "Place", "TaxCode", "Website" },
                values: new object[] { 2, new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"), null, null, null, new DateTime(2023, 1, 31, 1, 54, 44, 211, DateTimeKind.Local).AddTicks(6970), 51, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "ceadbcf5-ca6a-4f2f-a9a3-127f6d76db04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "6a317259-d09e-492b-ada1-948841ace27a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "2b7634cf-8f66-4659-a79a-5173ab048322");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "7311e09f-465c-4cf8-a876-11744450e599");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "3d362c80-f8c6-4f6a-837b-a09d8fa87be5", new DateTime(2023, 1, 31, 1, 54, 44, 187, DateTimeKind.Local).AddTicks(8278), "AQAAAAEAACcQAAAAEPFgPY2H6GS/2183cyEGOzJHj5JbIFBkIPch2bH3T9poUh/+YFy7xeOz2JWE3n+Hfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6704b12f-c646-4fa9-9246-66357ee86690", new DateTime(2023, 1, 31, 1, 54, 44, 175, DateTimeKind.Local).AddTicks(2553), "AQAAAAEAACcQAAAAEMAyAyW0WJ7M9EqNCv45osvRanZG4mnoj2W0AkreKHbfCei0NkX1dbPXqxZ76XFszw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "237bed4d-d513-435d-8b9b-6c56ed573099", new DateTime(2023, 1, 31, 1, 54, 44, 159, DateTimeKind.Local).AddTicks(6196), "AQAAAAEAACcQAAAAENcDeZDOnVcWHgB9T74PdCuS+HDMdggGZw84zRrxQANRiDx4IbBI70QW6R1ruEmzvQ==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName", "VerifyID" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"), 0, "18, Phuoc Thien, Nhon Trach, Dong Nai", null, null, "2abafa66-90cf-4e27-919c-276e959b71bd", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoainam@gmail.com", false, "Store", 0, null, new DateTime(2023, 1, 31, 1, 54, 44, 200, DateTimeKind.Local).AddTicks(9692), "Dien May Xanh", false, null, 2, null, null, "AQAAAAEAACcQAAAAEAj1vkiA+2YwEymymaDZcNeKG/RRaZ27BI4Yw/m1e2Esr68rc3+a/BxrOMB4vU1Cmw==", "033451444", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, "xxx", false, "hoainam@gmail.com", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName", "VerifyID" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"), 0, "18, Phuoc Thien, Nhon Trach, Dong Nai", null, null, "db1b4353-49a1-4554-ae93-3ea83ba25bc4", 1, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoainam123@gmail.com", false, "Nguyen", 1, null, new DateTime(2023, 1, 31, 1, 54, 44, 211, DateTimeKind.Local).AddTicks(7009), "Hong", false, null, null, null, null, "AQAAAAEAACcQAAAAEEbJCbZz9k4kXB/7ZpSraN5UdnL7JEZLwWhW0ODuBPsimQX0etKXaGf0FgctnLJ9Fg==", "0333999444", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "hoainam123@gmail.com", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName", "VerifyID" },
                values: new object[] { new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"), 0, "18, Phuoc Thien, Nhon Trach, Dong Nai", null, null, "c99e763a-535e-4060-9915-b0cfaa58a9b5", 2, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoainam2001@gmail.com", false, "Nguyen", 0, null, new DateTime(2023, 1, 31, 1, 54, 44, 222, DateTimeKind.Local).AddTicks(3233), "Duy", false, null, null, null, null, "AQAAAAEAACcQAAAAEDKyghxAvieJxeIg28VgFanBkrQqYh7oLC1s+G/fRDXIuAfXGvwjJjTtT3fYUzPM3w==", "0333999444", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "hoainam2001@gmail.com", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"));

            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
