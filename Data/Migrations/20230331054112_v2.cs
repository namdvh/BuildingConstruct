using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ContractorPosts_ContractorPostId",
                table: "Reports");

            migrationBuilder.AlterColumn<int>(
                name: "ContractorPostId",
                table: "Reports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3168), new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3174), new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 776, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 784, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 792, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 801, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 809, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 817, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "7c51e35f-89d8-47e2-a9ac-5174981bad68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "db543d41-81f7-41f0-84eb-1810b5ecf566");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "c93bc497-6af8-4516-82e2-71d1f230497c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "e2623512-92c7-4eb6-9e2b-87977b94d99b");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 41, 9, 826, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "8dec7ced-3b9e-4800-87cb-b09a588fe98a", new DateTime(2023, 3, 31, 12, 41, 9, 809, DateTimeKind.Local).AddTicks(4381), "AQAAAAEAACcQAAAAEB6ko9bFMV9uFlUH0iTAHmaPf++xAT347Da2WLEUzn/zAVCy+Scw9ekN+KeluLmf9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ecc22526-c65a-43fd-a425-56d4154d364d", new DateTime(2023, 3, 31, 12, 41, 9, 817, DateTimeKind.Local).AddTicks(7397), "AQAAAAEAACcQAAAAECfHD0E/JGkQjSB2GDOx6Z7PKAQmQbAhdt5/WInDChujzFTuldBH5XfYYxGFXKiT7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "96801d66-cce9-4151-a154-cd49379b347c", new DateTime(2023, 3, 31, 12, 41, 9, 776, DateTimeKind.Local).AddTicks(2449), "AQAAAAEAACcQAAAAEHsU/3G8slBMxAQOLBkI2+HlHysMdwobhe8KcQ8kt89MlRD/gTE5MGYbIXo2ibfeew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "92d14701-d95a-4d5d-9934-6d8fa029a13d", new DateTime(2023, 3, 31, 12, 41, 9, 801, DateTimeKind.Local).AddTicks(1959), "AQAAAAEAACcQAAAAEPpOZAxng5Tvk1zP5PdrSBBQVBRKqVh94WnisG/Qi/XBIY/AfmaciUXmzEILJ6lu7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2df35d24-2f16-49b4-8d81-1d3372b2badf", new DateTime(2023, 3, 31, 12, 41, 9, 792, DateTimeKind.Local).AddTicks(8568), "AQAAAAEAACcQAAAAEAo/mZh1siYtfL6fGVEZGCaShCWDzSGSvxt6Zeg+r6i5W4wuTkXugHY2WvSndlflMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "94e18250-c019-40d2-adaf-c04c78acd794", new DateTime(2023, 3, 31, 12, 41, 9, 767, DateTimeKind.Local).AddTicks(9610), "AQAAAAEAACcQAAAAEL6UbTgbB3VZaK+XaFik9Sohr2mWVAf915iD0Tmis89luHCRCfMgFgv5bkzKxX8C2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0fc114ea-5eac-4f8b-848b-5e22ae884013", new DateTime(2023, 3, 31, 12, 41, 9, 759, DateTimeKind.Local).AddTicks(5939), "AQAAAAEAACcQAAAAEKCC+N4ySW+gB4c6YOM87cI7zWI2q84ahwaV7FjOL6PJfV6jtadtSB7zaCyn0wQNMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "4191ca2a-4605-4f4d-9e28-828ce1b0e551", new DateTime(2023, 3, 31, 12, 41, 9, 784, DateTimeKind.Local).AddTicks(6044), "AQAAAAEAACcQAAAAEA9etB28yrsr4ZUj5KmmlCbrgsrRJIip75iGVfWu9p9jpWOwObNgYSxYuM1cELsB3A==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ContractorPosts_ContractorPostId",
                table: "Reports",
                column: "ContractorPostId",
                principalTable: "ContractorPosts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ContractorPosts_ContractorPostId",
                table: "Reports");

            migrationBuilder.AlterColumn<int>(
                name: "ContractorPostId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7922), new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7929), new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 553, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 562, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 571, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 579, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 588, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 596, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "df48905f-1767-4d58-a1eb-ef987e263c50");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "d9159f1d-c52a-4280-b236-a612616a6c05");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "83180b85-71d8-4d1c-8e00-33a987e1868a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "f547886c-28bb-4cbc-adb0-325b70cda069");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 12, 39, 41, 605, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0c3c697e-91e4-4896-8a6c-4b41e6b58d98", new DateTime(2023, 3, 31, 12, 39, 41, 588, DateTimeKind.Local).AddTicks(3169), "AQAAAAEAACcQAAAAEPJPA5dO+dlJxRRaKebnjBKVoXlXJ4gpR2H1mIpIrz0Pc9eBqLUIX1+XkzlSEPjf3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "51a70d71-810c-4347-85b6-afb284c2ba86", new DateTime(2023, 3, 31, 12, 39, 41, 596, DateTimeKind.Local).AddTicks(8962), "AQAAAAEAACcQAAAAEEjWUMhSmwL5KoIRfWSruqxqBiOVGQ+ZVNdrwvQQA8m2j7GsEbBr34LSALXzw1EVtQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a3b287cf-842c-4208-a625-2ba350a21bf9", new DateTime(2023, 3, 31, 12, 39, 41, 553, DateTimeKind.Local).AddTicks(8374), "AQAAAAEAACcQAAAAENq2rfkLLoReHcJXFrsznkAMxHnWOITQEKeCVmPOvZi+ux4RG/khgkIAztwIQQm2Jg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "edc10e5f-ec24-41ec-8b85-d21514f2c3d5", new DateTime(2023, 3, 31, 12, 39, 41, 579, DateTimeKind.Local).AddTicks(6675), "AQAAAAEAACcQAAAAEPEj55mae+4U/tcG8gPUsk0x+FtO/iBKk0kmrMCJxFhEG4+da7GjAKWs21XJXXcLYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a991db1d-2704-46e7-a297-3bafe3935c7a", new DateTime(2023, 3, 31, 12, 39, 41, 571, DateTimeKind.Local).AddTicks(611), "AQAAAAEAACcQAAAAEJg4CCLWOwavfle/ICK6HjtcsdRWu1icoYLzaKnJp0iRjQPq6UW/e9/BMqtN3NypxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d6110dc5-41d0-44aa-90ec-f9b9c693ebdc", new DateTime(2023, 3, 31, 12, 39, 41, 545, DateTimeKind.Local).AddTicks(2249), "AQAAAAEAACcQAAAAEH1Hc0Jp1a28U6k5t3KjmmAxdGK7b3lkK8iXvGOuNgQRuyGDojDbQMsFAc2clswllQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5ebc0a15-ca21-4c9c-8b0b-d8c139633e6b", new DateTime(2023, 3, 31, 12, 39, 41, 536, DateTimeKind.Local).AddTicks(6052), "AQAAAAEAACcQAAAAEJNiGAxaiOGb9wdq+3JZfv/pdg4HqsP+8C8M4agmHfbS2LhnUZGZKTiNbubSHedLmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "74172066-f65e-41af-ad16-58c62069ccf4", new DateTime(2023, 3, 31, 12, 39, 41, 562, DateTimeKind.Local).AddTicks(5048), "AQAAAAEAACcQAAAAEAgverxCXy9Gj6lPROfrOgZJbxx1DUUmn89apNs3xwsaERYlGMgcc1NILu4Jh7l6wg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ContractorPosts_ContractorPostId",
                table: "Reports",
                column: "ContractorPostId",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
