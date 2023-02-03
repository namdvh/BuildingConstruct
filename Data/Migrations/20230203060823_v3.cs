using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContractorId",
                table: "Bill",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 857, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 863, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 870, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 878, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 884, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 3, 13, 8, 22, 891, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "dcdc277c-4918-4c8f-bf61-bb8bc026067f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "58b908c9-a547-4e65-a3bb-ca271578aa0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "95924b09-9171-468f-9e31-5a752b054ecd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "ef71fe4b-3fdd-410c-aa41-4680ea0f798a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ba1d7779-79ee-4ec9-ab2f-bdad50870f65", new DateTime(2023, 2, 3, 13, 8, 22, 878, DateTimeKind.Local).AddTicks(3626), "AQAAAAEAACcQAAAAEPL2WAs32t0D8+q/hpERwlWDutRnU3BMam+i4eQgX/1Po7B7fFJDnY4gMbnPQg4wPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "054b8acd-f6fb-469d-afe1-74337ed94579", new DateTime(2023, 2, 3, 13, 8, 22, 884, DateTimeKind.Local).AddTicks(7171), "AQAAAAEAACcQAAAAELJOhNALjC9REBOXBLe+oy112Tn/Ziz48JzW+HyliZOvdfH2lS1cR8p7rnkMyRj+6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6bbb4b08-d8d1-44e9-b405-e490123bf4b8", new DateTime(2023, 2, 3, 13, 8, 22, 857, DateTimeKind.Local).AddTicks(1105), "AQAAAAEAACcQAAAAEE4c9xypnWTDBxZx+xWGUbyvHjCgvzA59VsyEaDqKKSRWd5WVQaTsBBXrV32RBT7sQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "527960e8-7881-4d10-99f9-c2550a431f49", new DateTime(2023, 2, 3, 13, 8, 22, 870, DateTimeKind.Local).AddTicks(1655), "AQAAAAEAACcQAAAAEAIOslNUXyyqZgbYkTakAB5DJfbktKrQK61ewjSxU1e7VkTs3NUaXC51sHL3WY5ysA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5f7ff822-901a-4e5d-bc00-4943ab2357e4", new DateTime(2023, 2, 3, 13, 8, 22, 863, DateTimeKind.Local).AddTicks(222), "AQAAAAEAACcQAAAAEFkAjUPofJQsMHg7GyZh6/ygRpZsX2W+BEUwxkyjUVAhXofW1FzUQ1shVe6C4DPVMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "fb346ad8-e0c3-439c-b158-bf5d82630de8", new DateTime(2023, 2, 3, 13, 8, 22, 851, DateTimeKind.Local).AddTicks(888), "AQAAAAEAACcQAAAAEBv9DXVKSJ5ywXNw/ncs8Pz4RmX1etOZ8pFUcgkqc+N/zLpucLhGBE2WbNJio/soJg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContractorId",
                table: "Bill",
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
    }
}
