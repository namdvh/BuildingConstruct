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
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(653), new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(743), new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(745), new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 836, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 838, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 839, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 841, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 842, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 844, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "c2b59e7a-b4bd-4ec7-946e-ca4147a16281");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "a1a4f29c-b7a4-4058-b9e6-b12b76b948a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "5b1dedc8-892f-418a-806a-2ae6798b0baa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "c7e764c9-64c8-481f-9288-4669601fcb93");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 845, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 1, 16, 54, 20, 846, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ac34c78c-671d-49b3-8754-3fa54f6380a9", new DateTime(2023, 4, 1, 16, 54, 20, 842, DateTimeKind.Local).AddTicks(7051), "AQAAAAEAACcQAAAAECK++jPN3HXSfQ4uLlRKJsg1ckp5xG+AX+LvN0A3JCx/Cx48/+KUKIKJqFGQ5Vk/Nw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "671c041a-c040-444c-8777-ba9a17aa650a", new DateTime(2023, 4, 1, 16, 54, 20, 844, DateTimeKind.Local).AddTicks(2816), "AQAAAAEAACcQAAAAEItB+QgJ6m0GhzbB40mTA3JmKwOpXf73v4Z/CKsTnOTpL0YEUmIdZWleAYLaBtL8Rg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5a995c41-4e32-4f93-b42d-f6c9057628ec", new DateTime(2023, 4, 1, 16, 54, 20, 836, DateTimeKind.Local).AddTicks(5008), "AQAAAAEAACcQAAAAENVlsTOWKpNiAunAzrwDbZqj1mtS+mXUTyn4St01RQoQLat3i1Qe5RpfhtjkU4IVgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "df1039d9-90a6-46ca-9b9c-78a45c924c51", new DateTime(2023, 4, 1, 16, 54, 20, 841, DateTimeKind.Local).AddTicks(1497), "AQAAAAEAACcQAAAAEKiWbSgeziiv0IOne2ZfzQ27ziXyczUL8B4zGrGoFf/qL7a6b5TNiBoT7QpEvYNfug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "56805ab7-65da-4d5c-b8e9-f54389ed3e84", new DateTime(2023, 4, 1, 16, 54, 20, 839, DateTimeKind.Local).AddTicks(5947), "AQAAAAEAACcQAAAAEGGZtZDWIMzA6pwezpEtQHVTFlD27raMpyTjeCH1KUD8ICp1x7FBBazrP1Y32zZ5ZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "739293bf-04b0-436b-b950-374daa1deb00", new DateTime(2023, 4, 1, 16, 54, 20, 834, DateTimeKind.Local).AddTicks(9324), "AQAAAAEAACcQAAAAEN/ZQajZv1PbtZgMLywHNXMQ+jf8ley8adjAstzsKlCwExhf179cBJ0KSIeZTYK7Zg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "109116bb-de74-41fb-95bb-47cea191577f", new DateTime(2023, 4, 1, 16, 54, 20, 833, DateTimeKind.Local).AddTicks(2870), "AQAAAAEAACcQAAAAEAXXmpVltYgy5OTQi4ss3HDb033Ey6gPmyOJSY4xzvlSZn2/BOHWI+ocHxRpDDj66w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "160c3b93-457f-4300-a1fd-c25aab0f42bb", new DateTime(2023, 4, 1, 16, 54, 20, 838, DateTimeKind.Local).AddTicks(478), "AQAAAAEAACcQAAAAEFXXsdQfIQSHKQAA0eoI+L3/K4uqcgJnf3Qo2iX88KwACdIO9UF66xvJuIirh2RzrQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1002), new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1008), new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 5, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1084), new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1086), new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 518, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 519, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 521, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 523, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 524, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 526, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "c925c4b1-c582-4e85-a464-98d28f14969d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "ab6631fa-09b3-4d48-a462-a37a30791cb1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "16a66479-595f-47b4-b7b3-55ab4830f3e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "33c33a63-b8ae-4867-9229-0919d76259c8");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 527, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 31, 15, 41, 46, 528, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "3871e05c-9100-4e0b-a5e5-9964388eb294", new DateTime(2023, 3, 31, 15, 41, 46, 524, DateTimeKind.Local).AddTicks(6992), "AQAAAAEAACcQAAAAELFjgaR0ZuMCKmepyGOJBZVdvaaZlqX0OakpEUyz/ifSdrk4CuxZ0XPBhW3sP6Dzkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0096be9f-e904-406b-b6c2-e1f69904dc8b", new DateTime(2023, 3, 31, 15, 41, 46, 526, DateTimeKind.Local).AddTicks(2692), "AQAAAAEAACcQAAAAEPrucwIohpQKUE013Cnm1wBrMKS8x2lK/tHVf57Ksn3+jtWQ9tTUC9W+L9dzkdyYyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "4aa1ba17-fe53-4f4f-961b-60f0dcf51c7f", new DateTime(2023, 3, 31, 15, 41, 46, 518, DateTimeKind.Local).AddTicks(2009), "AQAAAAEAACcQAAAAEBFUe+rWd2TObPYJSkxNex18LQpJHVZDKQFGDIp7dVAGPjja3AobCoKx1+Jd/fBnqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ac610863-b69a-4d8e-8360-c321c7450832", new DateTime(2023, 3, 31, 15, 41, 46, 523, DateTimeKind.Local).AddTicks(986), "AQAAAAEAACcQAAAAEFOtusT8PrS8+zb2BhUH+r9b7cdTHlRI5aguzU6Qz9aIkFVvprVHIyuVxRGV7hd5pA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "848f57db-af47-4976-ae9b-b337594d5713", new DateTime(2023, 3, 31, 15, 41, 46, 521, DateTimeKind.Local).AddTicks(4887), "AQAAAAEAACcQAAAAEAR8YlqkSCDS9UfliVMbRkbNJ1r8L22WLdKvldyxBpAHqdXqRU6Vnksn3/vW3wjCzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "8fb256e2-345b-464a-84e3-7a8976af1e6e", new DateTime(2023, 3, 31, 15, 41, 46, 516, DateTimeKind.Local).AddTicks(5651), "AQAAAAEAACcQAAAAEIfWLXbsDfcw40/6Q5YRm98wUOp64n+82F0S+v3W2hcCRX6VveS2XKdY99cAoyj9sQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a225562a-96ed-4deb-8438-56950543ab40", new DateTime(2023, 3, 31, 15, 41, 46, 514, DateTimeKind.Local).AddTicks(9450), "AQAAAAEAACcQAAAAELLKAEcxPar4+69GFX5+smgWwR8a1T9oiRlW8KMzZ+6xRLXTpNWcIPssTENG1QPMZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "fe633eaa-3d0f-4a88-80de-eef907762ff2", new DateTime(2023, 3, 31, 15, 41, 46, 519, DateTimeKind.Local).AddTicks(8467), "AQAAAAEAACcQAAAAEOxgFbnEb2H30CLPo/7+Z2kbvPvSxDo0M6zfIAwHlzMyhmFscHxnLKbZlh/QcoNepw==" });
        }
    }
}
