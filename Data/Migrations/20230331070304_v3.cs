using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReportProblem",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2212), new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 492, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 500, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 510, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 518, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 526, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 533, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "51f4af99-09c3-444a-b5d3-d63824cd615f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "d431ce01-e091-4db9-9156-49798391618e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "633ecc9f-d864-4187-b0bd-e0b31483b761");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "d8d8f2b7-7669-457f-b850-312935e0c352");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 14, 3, 2, 541, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "49546fa0-585f-4c37-a67a-ae93173748e6", new DateTime(2023, 3, 31, 14, 3, 2, 526, DateTimeKind.Local).AddTicks(57), "AQAAAAEAACcQAAAAEAd9xqBMhrvJaCHZ0sN/soUh7eGxECi/KdBJ/drda1G0pekAVje/HO2tQM1b3SwSdg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "fe183942-aac1-43fa-90b2-ff86f9a5a9c8", new DateTime(2023, 3, 31, 14, 3, 2, 533, DateTimeKind.Local).AddTicks(5945), "AQAAAAEAACcQAAAAEDj+2ANIGkRFhUyqnsK58OyA7+cO68KbjCuSGUuTIgHZqabyrtH8b7GxFB9BVJVuXw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "9966d918-5f50-4a24-b05d-60c8467d220f", new DateTime(2023, 3, 31, 14, 3, 2, 492, DateTimeKind.Local).AddTicks(7700), "AQAAAAEAACcQAAAAEDvWwkneTwsM/ND3Puny1P+wR6bvBqa5jgssUmWDlTZz+4mhC976o3lyJJbPwSLmDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5cab7da6-e286-4af8-a550-a2b1b86e747c", new DateTime(2023, 3, 31, 14, 3, 2, 518, DateTimeKind.Local).AddTicks(4698), "AQAAAAEAACcQAAAAEELe50qCGWLyVg3C079SqB95rK8PdkBXbJZ6+m7HTbv6eLQazVEH5iGNuargBO3VGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "3cb9bda4-c90f-4ac4-8f09-17a9c3b6b065", new DateTime(2023, 3, 31, 14, 3, 2, 510, DateTimeKind.Local).AddTicks(8724), "AQAAAAEAACcQAAAAEDfF+edA7db3rwK8VKDKO27JDV+WGsXoa6E7EzgqW/r6gR13pFm7LTOzfOx+oNPi1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "aebb1d51-f94e-497b-afea-619a04c524f5", new DateTime(2023, 3, 31, 14, 3, 2, 485, DateTimeKind.Local).AddTicks(2879), "AQAAAAEAACcQAAAAEGaTTXocVlyibIMFSSmL3GFD39QgS9Kpd/BaWYTGXLM42pv8dDXk9fw/lbfM8BVQEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f0d666fe-8c7a-4ccf-a8a8-4c6f74471270", new DateTime(2023, 3, 31, 14, 3, 2, 477, DateTimeKind.Local).AddTicks(4878), "AQAAAAEAACcQAAAAEBnt5gvIhkz1/B3iczewmjDesPVCeBTrGbs+6ALqDl205YGXEEcGZNyPUCwu0LSc7A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "9ac017a7-9246-4634-8e70-84ae35f38f30", new DateTime(2023, 3, 31, 14, 3, 2, 503, DateTimeKind.Local).AddTicks(3121), "AQAAAAEAACcQAAAAEBAug+Y4OzAJCVLMcLDR2y3c5DDD8xBgv4NqI06yyVJVSa4iKAYqcz+I2i60Jm5yJg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportProblem",
                table: "Reports");

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
        }
    }
}
