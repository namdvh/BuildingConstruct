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
                name: "FK_ProductTypes_Bill_ProductID",
                table: "ProductTypes");

            migrationBuilder.RenameColumn(
                name: "BillID",
                table: "ProductTypes",
                newName: "BillDetailsId");

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "BillDetail",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_BillDetail_BillDetailsId",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_BillDetailsId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "BillDetail");

            migrationBuilder.RenameColumn(
                name: "BillDetailsId",
                table: "ProductTypes",
                newName: "BillID");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 470, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 476, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 482, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 488, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 494, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "65571474-8e3e-4d8b-aa95-691b02e672ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "06dfe791-4dc5-4a4f-85fb-270498e3929b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "11d7e0e5-e3d5-4ce7-be20-aa2c813a2533");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "344d553f-a0ab-4157-909f-55137899a4c4");

            migrationBuilder.UpdateData(
                table: "SmallBills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "SmallBills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "56f1a4aa-820a-4365-9531-7882be5626f7", new DateTime(2023, 2, 16, 13, 43, 51, 488, DateTimeKind.Local).AddTicks(2705), "AQAAAAEAACcQAAAAEOOX44ufwSnNRNwBQUK9tfJJHOnMrqa9iNH7nqfOFsPaByFax+Gc8hV69GfSevWJAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0050a252-bf04-4705-beb7-6aa9d52dde94", new DateTime(2023, 2, 16, 13, 43, 51, 494, DateTimeKind.Local).AddTicks(2702), "AQAAAAEAACcQAAAAENUGzbx8Ra7rfKs8UfkKtoBpfUw+tW8hg1/Ij64Kmss1/HoraippWc9LNW4/L7kPjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d3f4943d-99b1-49e8-8d2e-bdda16b9f4c9", new DateTime(2023, 2, 16, 13, 43, 51, 470, DateTimeKind.Local).AddTicks(1932), "AQAAAAEAACcQAAAAEBCQwE+nJbBdQ5My3SW/gfxD/ARe4jOyUEwE10lvMG/5Rcacinhbh34ifKQgWR02cg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d7cc3cdf-9bed-4986-bf37-f30124f674d5", new DateTime(2023, 2, 16, 13, 43, 51, 482, DateTimeKind.Local).AddTicks(2106), "AQAAAAEAACcQAAAAEMJEMdpTp370MNow+hn4fijEgfyDbC63YpXjEXQukbsY1B6Ml3TAq3preCxphMXGpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a0f237a4-c300-402a-adf0-35ce001a2f7c", new DateTime(2023, 2, 16, 13, 43, 51, 476, DateTimeKind.Local).AddTicks(2099), "AQAAAAEAACcQAAAAEB80z7g5KTykdGU5LeX0vc68K3BfD/zTWLympVVGRnzrMat+W9DSvHHYNWRV44o7nA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "cbd2f3b2-ce7e-49ca-be5a-52a5737bb70c", new DateTime(2023, 2, 16, 13, 43, 51, 464, DateTimeKind.Local).AddTicks(728), "AQAAAAEAACcQAAAAEE5dhCFOoEJRpcJCQEaLwNi7YA/ZWogU2PU3wh0qFRtu9w75u0FToUh5LcT2cVkDPQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Bill_ProductID",
                table: "ProductTypes",
                column: "ProductID",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
