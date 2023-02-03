using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SmallBillID",
                table: "BillDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "BillDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BillID",
                table: "BillDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 604, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 610, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 616, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 622, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 628, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 10, 51, 634, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "e41fc560-9e3e-4ac6-b2a0-ccc5553c3524");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "3ebac26a-1036-4c44-b769-9d7448985d4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "61061a62-dbde-4c4f-8197-addbaf8b2a0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "1df4c4c5-09cc-4ee4-b2c3-4e21cda9562f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "70bb6c70-7f0a-49c8-a49d-e6e067a3d061", new DateTime(2023, 2, 3, 11, 10, 51, 622, DateTimeKind.Local).AddTicks(3447), "AQAAAAEAACcQAAAAEBPhmJNAJ0NRW8IctDgZmvLKhewcCul9CzJPAhrAYpfcynS1KPxtcGhs6NM0tA9EmQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "8f927138-3042-4ec8-a0a9-51b2036e5890", new DateTime(2023, 2, 3, 11, 10, 51, 628, DateTimeKind.Local).AddTicks(3201), "AQAAAAEAACcQAAAAEPlJRva/yfuYpA16tYZ+3rDIkYB+Wd5UuYgpb4cNAWx+LSh2FhUeR1+7WJSimwdlVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d5421b52-ab9e-4f99-ae6f-8c1c6e5cb970", new DateTime(2023, 2, 3, 11, 10, 51, 604, DateTimeKind.Local).AddTicks(3817), "AQAAAAEAACcQAAAAEE85GaEVP1prJXByOPtqFxX8YXF//VR+8TNi+7c4o1Dd9xGnqPIuqYOM5I6vduaoSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "78bc32ca-1b13-4876-b35c-6cc3f4c6d15c", new DateTime(2023, 2, 3, 11, 10, 51, 616, DateTimeKind.Local).AddTicks(3535), "AQAAAAEAACcQAAAAEOK5MgrIbMmJOtpxOQ4iah3r1xWga9T9OAmXE7YehdWHf85G3vHPAzHS0S77mLhvlg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "baabd14a-b578-4981-8cf4-3d352a83759e", new DateTime(2023, 2, 3, 11, 10, 51, 610, DateTimeKind.Local).AddTicks(3652), "AQAAAAEAACcQAAAAEEsh0OFq++Ape+dlLt9iXxDwX3lK/ayrVjbhSmq4/CEOSuPgxAMDX8N1FzPt8woD/g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "fa5bfcd1-ea2d-460d-8b55-fa304c0f0c7f", new DateTime(2023, 2, 3, 11, 10, 51, 598, DateTimeKind.Local).AddTicks(3454), "AQAAAAEAACcQAAAAEEVwpH0xhicXshcM9G6ErJleOQQe1mOPoffGYoraalbcA+i9iS6nHxFi8e2olDo4XA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SmallBillID",
                table: "BillDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "BillDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BillID",
                table: "BillDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 0, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 6, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 13, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 24, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 31, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 11, 8, 0, 37, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "4cdf133b-6ece-46c3-9e48-ce2d77bcee42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "e5002896-ca63-4926-b2c2-85533a10526c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "a6e43012-13ab-448c-a88e-d82bce55b318");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "7c199daa-39d8-4c91-aed3-580e9642109f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2907d71e-b02b-43c7-904c-cfd940c1d600", new DateTime(2023, 2, 3, 11, 8, 0, 24, DateTimeKind.Local).AddTicks(7384), "AQAAAAEAACcQAAAAEFzlwOxdhlV1LQ8gf6O22cvgPGCUUHw/itCcdhYw1kb9JB2aBMTYOH9GrLtmVZrofg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a82798c3-4172-4fe4-b1dc-0f9394597bad", new DateTime(2023, 2, 3, 11, 8, 0, 31, DateTimeKind.Local).AddTicks(4115), "AQAAAAEAACcQAAAAEETb8bxFBFWz3oX6poe5XXdrh1kFA/0sSIRr1fYLz8a/Y1F4dNGqzbOf0p0dkK7wEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "9ae77921-0b95-41ea-8297-a4d5cbdfa5c2", new DateTime(2023, 2, 3, 11, 8, 0, 0, DateTimeKind.Local).AddTicks(4234), "AQAAAAEAACcQAAAAEIzMo9cHEKLhQ2mj+fMVy7ypXgKvCFBBS1WoJ2PjhKto+3hY+479oURSUjRMh2PjYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "bc2ed2b6-c136-4a56-a209-2a0ecebbc3ff", new DateTime(2023, 2, 3, 11, 8, 0, 13, DateTimeKind.Local).AddTicks(4560), "AQAAAAEAACcQAAAAEA4BXCZ+vdbOdkGILRnWNHetd2nZFuJD5HUnOcxpYm+SECLnboHKDxbm6ubxxAmSIw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "81121370-6fa0-4f1c-8533-6f07867d9fd8", new DateTime(2023, 2, 3, 11, 8, 0, 6, DateTimeKind.Local).AddTicks(9054), "AQAAAAEAACcQAAAAEKURfKgdGoaV8DEX+f3w3GZ0DxEfY3shclsEy1CCEhiDD0rovNe+bcBlG0yhDrqGzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6781e92c-d360-42f3-971c-7709eaba338b", new DateTime(2023, 2, 3, 11, 7, 59, 994, DateTimeKind.Local).AddTicks(559), "AQAAAAEAACcQAAAAEEVKMS28xZKYP+eN7B+GZIswksKVafAl2geg/dEDCqmbM3JBKBpY0fWNP5Ht4xrNMw==" });
        }
    }
}
