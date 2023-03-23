using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LoginTime",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 28, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3911), new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 28, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4059), new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 23, 959, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 23, 968, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 23, 978, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 22, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 22, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 22, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 22, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 22, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 22, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 23, 988, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 23, 997, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 9, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 22, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "e7eb3aa2-92a7-47ec-8bdb-4fa5e27e1c1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "6824b916-a6a1-4e3e-a769-4b592be1bbfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "0a1d01a3-76a3-4692-89f0-bb31b90f0740");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "602182b5-b7a4-4e77-b940-a0fe4f97d119");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 22, 3, 24, 23, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "7d511e44-03a5-4d02-bec8-03b3867a6a70", new DateTime(2023, 3, 23, 22, 3, 23, 997, DateTimeKind.Local).AddTicks(7121), null, "AQAAAAEAACcQAAAAECh56ZoBEfWry270s1SoZnsA0Ic57sQx/UtvyOLckUiIG9HXG3P8eMNKxmtuk5gaag==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "77626cab-e406-4045-8b46-c385efc4349e", new DateTime(2023, 3, 23, 22, 3, 24, 9, DateTimeKind.Local).AddTicks(5530), null, "AQAAAAEAACcQAAAAEC42fP86Xq7vPTsGEQ72eiWo1X2Up4am4S4CK98hD/8+UYBalmtP1AsPfvOl7qkcCQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "b0640d7d-883e-423a-b23c-412335ff0b8c", new DateTime(2023, 3, 23, 22, 3, 23, 959, DateTimeKind.Local).AddTicks(9659), null, "AQAAAAEAACcQAAAAED1wTplTEVUZ5I/tiI+e6VWv8OC9YB+CmvbTqBn/YCvTOpOOoHvH3yLPNE1dxyx89Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "aac9800d-22ce-494c-b673-88a904937349", new DateTime(2023, 3, 23, 22, 3, 23, 988, DateTimeKind.Local).AddTicks(5284), null, "AQAAAAEAACcQAAAAEGQ3jkQvDQHeAOKlfvEBBQEWjicG37/G8Ly8nNiHYv666rZn5dAleID9uYAzRnv0Bg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "de162d27-c0b4-44cd-afe8-f54bfed00ab7", new DateTime(2023, 3, 23, 22, 3, 23, 978, DateTimeKind.Local).AddTicks(9557), null, "AQAAAAEAACcQAAAAECsrU4X50LVyYjBO2XYuN+oxqj+4zw6QEpDEEHJpXZMhTU0MQIxzlquxj5/1Opr4pA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "eb6821b0-d1ad-4094-b642-a308b06d9d9b", new DateTime(2023, 3, 23, 22, 3, 23, 950, DateTimeKind.Local).AddTicks(8016), null, "AQAAAAEAACcQAAAAEPOSmMpWWOyws/q4J8v1Smv75gGcwhc7UOLx5pboHGSrAMESg1a4GLaDWlPnEiETWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "13db2745-4597-470a-ae50-6e5f3ce55339", new DateTime(2023, 3, 23, 22, 3, 23, 938, DateTimeKind.Local).AddTicks(2269), null, "AQAAAAEAACcQAAAAEJ70PM7v7g/lqvlpq9RmzDQ+co5nyThcc1647WgbbPVKnWIDc7FWkQvvIZkPJ/5JnQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "9a794f6f-6f40-4252-b566-283a2505a712", new DateTime(2023, 3, 23, 22, 3, 23, 968, DateTimeKind.Local).AddTicks(9142), null, "AQAAAAEAACcQAAAAEOm/pb5Y5g03UyAt+vs1ZGr1gaYXtf5fSJ78qB/oDceeukP3hKgjond5zYZidJTaUA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 28, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 28, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6552), new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 234, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 241, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 248, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 256, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 263, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 271, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "1dbfb12b-bd15-4fb7-974d-4b2948e0090f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "8042f173-477d-4e6f-aea6-a87d1e31c548");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "24c8f72a-8977-48c8-94b1-80c4ae874bca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "886256c6-4383-4013-98e9-ca61a77d0b57");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 23, 21, 48, 35, 278, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "cd694316-0703-4d23-b1b4-d0eb74820121", new DateTime(2023, 3, 23, 21, 48, 35, 263, DateTimeKind.Local).AddTicks(3354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEAgSI890kXey2mD8Qu52k6OuD2EXQCh/oGbZoDDljb3xstoCP2Ejj2tZTQWdoumUvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "b2d13c08-5931-47f2-8768-94dbb8ed387b", new DateTime(2023, 3, 23, 21, 48, 35, 271, DateTimeKind.Local).AddTicks(2309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEB5rij1MnxpyocuCeViYC21bRRyzpuOFeySboio/m7VO0gmoaf4wAa+T17DUi2EOCA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "e368aea1-ba15-4092-b36e-1a198e78d366", new DateTime(2023, 3, 23, 21, 48, 35, 234, DateTimeKind.Local).AddTicks(2032), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEDmwoDDOPb+3cB8VkTaWxEmYz9XOM85Rcm4asQ4Gzfi8xK5twXZ0vUnlxqQ+/pSvCA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "c9641a90-729a-4328-80d7-47330624ee3a", new DateTime(2023, 3, 23, 21, 48, 35, 256, DateTimeKind.Local).AddTicks(812), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEEwxK4wwm5wY41AQHZLNf9Z3zJiXM8vw9JVtrfPXcRdfnE9K5QBEuHu8QUWiDEm2gg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "ceef6725-af8d-453f-a293-e77f15e307c6", new DateTime(2023, 3, 23, 21, 48, 35, 248, DateTimeKind.Local).AddTicks(6663), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEIKLGJzt05Xh8MxCMAlDpb7Nz7eV3Ac/9MtinBCbMTltYqDG2fhz6Nn55IZrT7u+9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "3a856da3-3f07-4ef2-b377-b36c703e3f78", new DateTime(2023, 3, 23, 21, 48, 35, 226, DateTimeKind.Local).AddTicks(9608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEIwPLpTvxUundcrdDREWumnvovJV8Z+caIEWa6tjrzS1Ha5iNygMf15wujfvRH32tQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "797ed546-4927-4b85-bacc-fddb645391e7", new DateTime(2023, 3, 23, 21, 48, 35, 219, DateTimeKind.Local).AddTicks(7252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAELA3TrTMIX/jHTLwOw1SkfM7p9tMuBkrRErzSroRtCFlNw/4948Qh09bor8Z8WexXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "LoginTime", "PasswordHash" },
                values: new object[] { "dbca710f-536d-49f2-bc8b-166e8fadec55", new DateTime(2023, 3, 23, 21, 48, 35, 241, DateTimeKind.Local).AddTicks(4433), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEO1KPtZtcHFx+vs9wfl3lgOg8h7vjNaCuRC4pmHRF9EAc4CZeRGpUo5yV3n+1b/rVQ==" });
        }
    }
}
