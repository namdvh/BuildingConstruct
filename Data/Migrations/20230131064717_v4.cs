using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Bill",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 13, 47, 16, 303, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 13, 47, 16, 309, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 13, 47, 16, 327, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 13, 47, 16, 333, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 13, 47, 16, 315, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 13, 47, 16, 321, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "10690cca-0ec3-4d62-9106-2e5a1ce84f75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "fe125344-ef81-4858-b652-89533999b026");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "79250aa7-9aaf-499a-b619-ef39d3d9b8e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "337ab3f1-a177-466c-84b6-c2bb7f0d406e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ee328ad7-8836-4222-b2f4-a2395b395331", new DateTime(2023, 1, 31, 13, 47, 16, 309, DateTimeKind.Local).AddTicks(5034), "AQAAAAEAACcQAAAAEIFgTla1/+0+u0CBAKBdiJ8caK7Pqpuf6alZ98JmHIBmb7NqOqsoYqY86JmJcXl5YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "3aeb9eff-0bc3-476e-882d-a5ba67bf998d", new DateTime(2023, 1, 31, 13, 47, 16, 315, DateTimeKind.Local).AddTicks(5347), "AQAAAAEAACcQAAAAEALzcLIMzhN1YgLXqxhVggVj6681gOjlCHl8ItTVDSvc8o0GacFo/I/qhLe84tvDww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "1e6850a5-cf9e-4432-b7f8-211e70e1a899", new DateTime(2023, 1, 31, 13, 47, 16, 321, DateTimeKind.Local).AddTicks(5218), "AQAAAAEAACcQAAAAEGWtlFlOaggYmcvYsEEf6B4WhcgaGbqmomlosdOBA4vRTRTVBSl/2e27VgtKBrL8dQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2db4e992-9df5-486a-afc5-c73d383d787c", new DateTime(2023, 1, 31, 13, 47, 16, 327, DateTimeKind.Local).AddTicks(5914), "AQAAAAEAACcQAAAAEEIj1pHLzdGA3RholGY88mYu2dHAjULUQPotVo0+1jyQB5eeN36peWTjs3vDCv6q1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "e20d2519-d15a-47b9-93ca-a08904612a67", new DateTime(2023, 1, 31, 13, 47, 16, 303, DateTimeKind.Local).AddTicks(2381), "AQAAAAEAACcQAAAAEDkehPkJl1hzTH7lkxWfdUJbqNnRAvZw13d+dEHRqAp/i1GuupiCg8QKIi2E/K8oOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d19ae633-af02-41e1-b576-81425d302b21", new DateTime(2023, 1, 31, 13, 47, 16, 297, DateTimeKind.Local).AddTicks(2299), "AQAAAAEAACcQAAAAEOobC6b103WXmdsvqug5vWhfVbT5BEZqYKwzgJc9OrvDVRkT+NlodeBk+AQ+kxP2Rw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Bill");

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

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 54, 44, 222, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 54, 44, 233, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 54, 44, 200, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 1, 54, 44, 211, DateTimeKind.Local).AddTicks(6970));

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "3d362c80-f8c6-4f6a-837b-a09d8fa87be5", new DateTime(2023, 1, 31, 1, 54, 44, 187, DateTimeKind.Local).AddTicks(8278), "AQAAAAEAACcQAAAAEPFgPY2H6GS/2183cyEGOzJHj5JbIFBkIPch2bH3T9poUh/+YFy7xeOz2JWE3n+Hfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2abafa66-90cf-4e27-919c-276e959b71bd", new DateTime(2023, 1, 31, 1, 54, 44, 200, DateTimeKind.Local).AddTicks(9692), "AQAAAAEAACcQAAAAEAj1vkiA+2YwEymymaDZcNeKG/RRaZ27BI4Yw/m1e2Esr68rc3+a/BxrOMB4vU1Cmw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "db1b4353-49a1-4554-ae93-3ea83ba25bc4", new DateTime(2023, 1, 31, 1, 54, 44, 211, DateTimeKind.Local).AddTicks(7009), "AQAAAAEAACcQAAAAEEbJCbZz9k4kXB/7ZpSraN5UdnL7JEZLwWhW0ODuBPsimQX0etKXaGf0FgctnLJ9Fg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c99e763a-535e-4060-9915-b0cfaa58a9b5", new DateTime(2023, 1, 31, 1, 54, 44, 222, DateTimeKind.Local).AddTicks(3233), "AQAAAAEAACcQAAAAEDKyghxAvieJxeIg28VgFanBkrQqYh7oLC1s+G/fRDXIuAfXGvwjJjTtT3fYUzPM3w==" });

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
        }
    }
}
