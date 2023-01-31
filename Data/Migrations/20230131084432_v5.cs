using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonthOfInstallment",
                table: "Bill",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 15, 44, 31, 781, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 15, 44, 31, 795, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 15, 44, 31, 817, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 15, 44, 31, 824, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 15, 44, 31, 803, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 1, 31, 15, 44, 31, 810, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "374f95ca-4476-4992-ab01-dfd68f8e2827");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "2689c8d5-1643-4f4f-a706-73ba6aadbdf7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "41360ed8-e7c4-49cd-8e8e-c61315448a97");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "b48c3b70-ac82-4f8f-9cca-2ece571bd65a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f4"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "cdc0f650-0b07-4688-a0ae-914e14fad733", new DateTime(2023, 1, 31, 15, 44, 31, 795, DateTimeKind.Local).AddTicks(4842), "AQAAAAEAACcQAAAAEAVnw2u/+aGO6m2L5OaJq44XwYPdbOefzRJnS6PLsOAtCtpJ256CgPJZL2mngPGScA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f5"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0b4c4247-26ac-44e8-a7e1-c0bddce3ac8d", new DateTime(2023, 1, 31, 15, 44, 31, 803, DateTimeKind.Local).AddTicks(4376), "AQAAAAEAACcQAAAAEMhprMkNShXIuZ5exdJJUh1phY/NWcrEaAUoCBsY1FHnekKFgLCq+ScRiTU7neB2Uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "98c76a7c-3d34-4bc2-b95f-c57af8dd4999", new DateTime(2023, 1, 31, 15, 44, 31, 810, DateTimeKind.Local).AddTicks(2518), "AQAAAAEAACcQAAAAEIZRWCk0P97e08S5yw+zNoNF/NPJOwpGoC0JOZ6VcS6M4gxmT1fZ/Bn6+zJ6kHFxOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba0a48f-551b-4de5-b853-81a1243267f7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c9e8c34a-e622-4f23-b623-91ce7656863f", new DateTime(2023, 1, 31, 15, 44, 31, 817, DateTimeKind.Local).AddTicks(4058), "AQAAAAEAACcQAAAAEF9v3AfzlkRTgFPLqTFPmFZGmk5Bb8ErFxW4PlXOdMnRKKQZWVLyz/yuv4bHncxdtw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "349ae299-ecf9-4e43-8830-ae4a35093487", new DateTime(2023, 1, 31, 15, 44, 31, 781, DateTimeKind.Local).AddTicks(2921), "AQAAAAEAACcQAAAAEHlPtEQZPTFiQDN6Put0GwnSLYbiN598TI+7WQR755qxwfyJOcqSK2s66aFVOOt0YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "35d6aca9-0f46-4aaa-a398-66818a6071cf", new DateTime(2023, 1, 31, 15, 44, 31, 768, DateTimeKind.Local).AddTicks(3966), "AQAAAAEAACcQAAAAEMt380NQKLjoBvugMi0Es7wGsMRt+TMWoL5dQp57XqTo/qwB+0ZWaK7ad4rMbyHUDg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthOfInstallment",
                table: "Bill");

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
    }
}
