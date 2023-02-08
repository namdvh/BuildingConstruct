using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreateBy",
                table: "Bill",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 949, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 955, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 961, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 967, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 973, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 6, 14, 18, 34, 981, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "037226e6-4cc3-46f9-a2ae-6dec8a5303f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "0fd544cd-764a-4e64-9ad9-4f6e3edb8d42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "60b4cfb5-843e-4c59-8e6b-df2f6ea2983f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "ec34545e-4fe5-471a-be09-32a8017e474e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c3be5ce6-63a4-4259-8dfe-8d80d05b4650", new DateTime(2023, 2, 6, 14, 18, 34, 967, DateTimeKind.Local).AddTicks(5890), "AQAAAAEAACcQAAAAED/aupCE8GTad10gDg0tZ3RHF/2djq3YZGnCtJIuHHWzXccVrsLjfU8pnZJZU9lzMA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "851c2039-c27c-4765-ac45-0fb45686c231", new DateTime(2023, 2, 6, 14, 18, 34, 973, DateTimeKind.Local).AddTicks(5217), "AQAAAAEAACcQAAAAEHwEzRBNdX4fV7hwDFK0GTUrn5Lx2ZJb5Tm5CK8I6R98nImqilOgn1NGf4xha19uOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "e19781ac-382e-4e0b-ae55-00e78ebad521", new DateTime(2023, 2, 6, 14, 18, 34, 949, DateTimeKind.Local).AddTicks(257), "AQAAAAEAACcQAAAAENXmWvVqI1yVON6QeauKQIw0hLOMMOM7FuL6ZYubt9ORECH7d802dL3blbf+e7Udyw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0645d677-9700-4c70-b3db-3d85be1cd540", new DateTime(2023, 2, 6, 14, 18, 34, 961, DateTimeKind.Local).AddTicks(3710), "AQAAAAEAACcQAAAAEBtDvZAO+KyGaXFoIq5KFpu48alQrMmclYiIeMoSr1bd9LEYo1U7TUnfw/RKnXa04g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a00e05f9-de6f-4371-a4a5-113f0d62ac8f", new DateTime(2023, 2, 6, 14, 18, 34, 955, DateTimeKind.Local).AddTicks(1695), "AQAAAAEAACcQAAAAENkL5YKl02vxsZgGLGmTB5jezHlwQ4VA4ASmoknmqGffnwlddXfKJNtZODN4RVpmdw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ae3bd2cf-8ee5-4deb-9ef4-ae4e34cb8d32", new DateTime(2023, 2, 6, 14, 18, 34, 941, DateTimeKind.Local).AddTicks(9952), "AQAAAAEAACcQAAAAEJgPKgCHsypiYaZGuxy5fawG1yA8uNXm4Lfhi7ynhMLgLVWMvXrJljhDB8t1zTSnxQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Bill");

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
    }
}
