using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExtendDate",
                table: "Payments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 8, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 8, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 415, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 421, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 427, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 433, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 439, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 445, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "6b080554-d604-4db0-9f8c-eb14783b94a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "149f818a-c4ad-4681-bb6f-459cd9450f71");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "31fc555c-c34d-4b2d-bfc1-c7f6fde0d2f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "eade455c-07fa-447c-9138-45571b79eca9");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 3, 13, 15, 19, 451, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b919821d-91a3-467a-bac9-ef0f3e2f062e", new DateTime(2023, 4, 3, 13, 15, 19, 439, DateTimeKind.Local).AddTicks(1421), "AQAAAAEAACcQAAAAELC5T8dFhgH37y1Eb8CMDXbNTjxhE1CEItGbN0ZkLOsPrv/rQ7W/8GRNXENVXO2a+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "eff2fc02-d40c-41a0-91bc-02965c9547e0", new DateTime(2023, 4, 3, 13, 15, 19, 445, DateTimeKind.Local).AddTicks(1440), "AQAAAAEAACcQAAAAEODVRYZwZUKP3CI38htpFxI2sTOIR+sOWXM8TzI57ggWLfvYkm8D8YI6qRsndkgARQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5157075a-139e-469b-a5e0-051d70c95af7", new DateTime(2023, 4, 3, 13, 15, 19, 415, DateTimeKind.Local).AddTicks(3726), "AQAAAAEAACcQAAAAEPGtXzfCPzdmSpLeX1ohmRaVKLlbGYwyHcRXgHlsmXRqPcfuKoC2th9GcH5d4/AMmA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "62438679-0782-4b1c-ac16-61e84a359335", new DateTime(2023, 4, 3, 13, 15, 19, 433, DateTimeKind.Local).AddTicks(1632), "AQAAAAEAACcQAAAAEHQvO8mznJFWdsHqfJ6quDIS3VhB8PNX+plb61p1VVHVISSCDTkZSyvD32mj/7rSKg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "34d69a43-6e0d-4181-bd05-251c5312d1d0", new DateTime(2023, 4, 3, 13, 15, 19, 427, DateTimeKind.Local).AddTicks(1225), "AQAAAAEAACcQAAAAED+x2p4XqNsxCoBmsm+xh9WQM2zIEPtM2PA3t9M+MhmGQ+wJKtXJbd/73foOEUGWvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b1e2767d-3c94-4c8c-9460-da493f43d7ff", new DateTime(2023, 4, 3, 13, 15, 19, 409, DateTimeKind.Local).AddTicks(3877), "AQAAAAEAACcQAAAAEMPxT7842DPoZXoF6DgQslJVtlD2M5ExGQk/9wMiyD2+tH1mlnSuCqsibN2bWkttkg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "8beae0bb-57ae-4586-a5d5-0f1ba3670634", new DateTime(2023, 4, 3, 13, 15, 19, 403, DateTimeKind.Local).AddTicks(5343), "AQAAAAEAACcQAAAAEHANjzvbuqfMk4TwQoSN7aOQV4BJHx8GVtNmILRRqo0GbQ5ExeUzKVfBDWgoBxu9Tw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ae5a7010-8b5f-4c57-a852-71bec2ee9fc9", new DateTime(2023, 4, 3, 13, 15, 19, 421, DateTimeKind.Local).AddTicks(2249), "AQAAAAEAACcQAAAAEJDDAOc4tRoVE6kHrpdfu3cai5isFL9YduYxIKh8dK63oxhRpbm20tNQ8xY4ahaKeg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtendDate",
                table: "Payments");

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
