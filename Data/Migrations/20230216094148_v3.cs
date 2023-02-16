using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_BillDetail_BillDetailsId",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_BillDetailsId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "BillDetailsId",
                table: "ProductTypes");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7110), new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7175), new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 926, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 935, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 944, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 954, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 963, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "7efe741f-6775-4cb1-81bf-5230b08209fd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "e7a7438a-2ee5-43b0-868f-7c58ce0071d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "0afb6e4d-315a-460e-92e9-861b381e8ceb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "46734b66-c981-43d9-a51d-fafcaefabd11");

            migrationBuilder.UpdateData(
                table: "SmallBills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7193), new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "SmallBills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7212), new DateTime(2023, 2, 16, 16, 41, 46, 972, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "1ba6bc55-8547-44ea-8026-21008542cd40", new DateTime(2023, 2, 16, 16, 41, 46, 954, DateTimeKind.Local).AddTicks(40), "AQAAAAEAACcQAAAAEOq0IhRDG8oqJ0WUO5+0kZJGltpkeJWuylg+wdFP+N8ixm8SuIZpajMrF9JVY1bb+Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c7b14625-b35d-433e-a235-7985f12c1785", new DateTime(2023, 2, 16, 16, 41, 46, 963, DateTimeKind.Local).AddTicks(3253), "AQAAAAEAACcQAAAAEGZVZ5n2KDWwQrRNk+j/mfLinyZhN67Z4hc4GdQ6UyHDP3BRTg6GqZlakwJRQZAXxg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "76b6c536-d336-4c55-9417-bbc04dff6c71", new DateTime(2023, 2, 16, 16, 41, 46, 926, DateTimeKind.Local).AddTicks(1256), "AQAAAAEAACcQAAAAELpaLKNXjK6TyVy9UoCY5V5xshIAYmP+NtjAz+esSq91t6ybzRXLTHzUx+Y2ukd2Wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6ae79575-12d8-4a52-89ed-2d60bef1c3eb", new DateTime(2023, 2, 16, 16, 41, 46, 944, DateTimeKind.Local).AddTicks(7192), "AQAAAAEAACcQAAAAEMHpmRrJPO9aelEknw/irQysLf9D8W2IFUuN8NFTXEckd/RCbcKCl+nkNQ5Wobmvbg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ee57139f-b88f-4b6a-81d7-872706f16956", new DateTime(2023, 2, 16, 16, 41, 46, 935, DateTimeKind.Local).AddTicks(6528), "AQAAAAEAACcQAAAAELQ5Hz918LhAsRzfJ43T7wBt3DdD+z+3Fc29hY0tHwySb+XpaCY/9Z428P3BfgRFUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "cde3b414-0d3d-4728-a388-f18112cf3b7d", new DateTime(2023, 2, 16, 16, 41, 46, 916, DateTimeKind.Local).AddTicks(7998), "AQAAAAEAACcQAAAAEC7Czg6E0vNcRaXWvJ9wQZN4rUbaqFNHbB7nSWLr2U2ycEoECqC6DVdo2M3IcdDfUg==" });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_ProductTypeId",
                table: "BillDetail",
                column: "ProductTypeId",
                unique: true,
                filter: "[ProductTypeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_ProductTypes_ProductTypeId",
                table: "BillDetail",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_ProductTypes_ProductTypeId",
                table: "BillDetail");

            migrationBuilder.DropIndex(
                name: "IX_BillDetail_ProductTypeId",
                table: "BillDetail");

            migrationBuilder.AddColumn<int>(
                name: "BillDetailsId",
                table: "ProductTypes",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 132, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 140, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 147, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 154, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 161, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "b2f69e57-d3bc-45eb-a506-cd4efb154315");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "8d8868c3-85f7-47ed-9731-423156df0ada");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "4fe2a976-ba0b-469f-9985-a77f8d1da694");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "f8d06531-2006-406b-a874-ab5e6c9e8360");

            migrationBuilder.UpdateData(
                table: "SmallBills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2591), new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "SmallBills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2604), new DateTime(2023, 2, 16, 16, 33, 52, 169, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "49bf7add-34af-412a-91be-574b2e2e4fa4", new DateTime(2023, 2, 16, 16, 33, 52, 154, DateTimeKind.Local).AddTicks(6218), "AQAAAAEAACcQAAAAEFtcAJlI6+cbdFJfpsMho4M1De5AlY+eMB92we7vmyWTjLDh+GngbVcxa3UGhd3ECg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ee8b864d-2622-43a4-b641-6b772c1ec700", new DateTime(2023, 2, 16, 16, 33, 52, 161, DateTimeKind.Local).AddTicks(9379), "AQAAAAEAACcQAAAAEDwycntz+y4bzdCsEKo6/sg2Saq3APlG/miXv0vTjbu1xk32P9vEjORid+yf9cAxwg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "28483815-acd4-4a15-a6f5-b68740abd054", new DateTime(2023, 2, 16, 16, 33, 52, 132, DateTimeKind.Local).AddTicks(8179), "AQAAAAEAACcQAAAAEPJj4MT+Y2eTtrovqZ+yrEKvDHbwBsYpE4H5IK/g1hYhdlQx0eBzc/t9ot43a2/xng==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "be948b1c-8b8d-4d18-8a54-64732b719ffa", new DateTime(2023, 2, 16, 16, 33, 52, 147, DateTimeKind.Local).AddTicks(3899), "AQAAAAEAACcQAAAAED4wGDZWl90NQYW23jc/HbBngLDJOMtqL54gZeaX1X8lo+cWPOZYon3PrfRtR6aU3w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "676c86be-ed63-4d69-8aa2-8b8084ec3928", new DateTime(2023, 2, 16, 16, 33, 52, 140, DateTimeKind.Local).AddTicks(1423), "AQAAAAEAACcQAAAAEFk2MBOZe6aPbwOQbbvB2NGqUFEWG1cXg6H+Y0ptAw/fVEG8x+hVtgtkCEw15su8rA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "370866dd-f4e3-4a64-8058-d10b58261010", new DateTime(2023, 2, 16, 16, 33, 52, 125, DateTimeKind.Local).AddTicks(5502), "AQAAAAEAACcQAAAAEMoGKw2rigHTzYclGiBsHf5slsxyj1eTByHlMNWEpTzjRmODPqM8SK6Il27IiIrHuQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_BillDetailsId",
                table: "ProductTypes",
                column: "BillDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_BillDetail_BillDetailsId",
                table: "ProductTypes",
                column: "BillDetailsId",
                principalTable: "BillDetail",
                principalColumn: "Id");
        }
    }
}
