using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Users_UserId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_UserId",
                table: "Payments",
                newName: "IX_Payments_UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "PaymentId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VnPayResponseCode",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3297), new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3383), new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 668, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 680, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 691, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 701, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 711, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 14, 0, 8, 13, 722, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "020148bd-68f4-4f87-9116-6c55e4095c5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "86b380f2-3c30-4ef0-a59a-efa6ace1a1d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "f57eca50-08b3-485b-923d-51529140ecb3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "cb3d2b9d-ca39-4f3e-9537-439cbda55271");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "76327be7-f3c1-4a2c-a6c3-773b334e5d6e", new DateTime(2023, 3, 14, 0, 8, 13, 701, DateTimeKind.Local).AddTicks(3625), "AQAAAAEAACcQAAAAEFB96gD9UauwdmRqqsMhusovMNwsUi46Hkx/MjmJtelnBitnjn5kiXcmEKNWjXAOvg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "74e6722e-44a7-4ddf-a199-6420e4c3b3e3", new DateTime(2023, 3, 14, 0, 8, 13, 711, DateTimeKind.Local).AddTicks(6811), "AQAAAAEAACcQAAAAEHNONSpDD/9jAB+Kt89Z0tvdlAQguUabYuvvORa5tBY/vwqU6EtnsRQpf70LeZVd2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6bc67c5a-4ee4-4be2-9159-5512d14116fc", new DateTime(2023, 3, 14, 0, 8, 13, 668, DateTimeKind.Local).AddTicks(9169), "AQAAAAEAACcQAAAAEMNKaQLlwO+Pplsb2K2rj5aoLfEAtYgcLTSRtHOLIZScaDXuYj513ywsxwQ3S/9hjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "1c7179c0-d2c0-4443-a199-aeed3a6881db", new DateTime(2023, 3, 14, 0, 8, 13, 691, DateTimeKind.Local).AddTicks(1877), "AQAAAAEAACcQAAAAEN9Fa20WZoptVX/NVjVUi1FMOvB/swPJmAB8lHJZW+M93TeYxrf87MNmiV/eiyisFw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a82884b0-c800-4c8e-a2dc-1ae2880e9385", new DateTime(2023, 3, 14, 0, 8, 13, 680, DateTimeKind.Local).AddTicks(1260), "AQAAAAEAACcQAAAAEB6AcQRKVgGHDE8gD1hFXkpSiLO7BZwUWobxkLq3zyRW72pN73xMQFKlEm/DsYUhwA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "38f5e180-0c36-494c-9c62-a66512c42b02", new DateTime(2023, 3, 14, 0, 8, 13, 658, DateTimeKind.Local).AddTicks(7114), "AQAAAAEAACcQAAAAEM4IhptqpmxuQIJ6i026BCw5q+Ja00jEqQH9NI1PH2nxGcOORKtFYWt4N7bgu2AAFg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "VnPayResponseCode",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserId",
                table: "Payment",
                newName: "IX_Payment_UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 18, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3867), new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 18, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3927), new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 455, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 464, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 472, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 480, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 488, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 21, 1, 26, 497, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "e1dc74fe-08f5-4c5b-8fbe-bfedb1ca2674");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "0a73cf6e-240e-4abb-84ec-a40d007054d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "9b4fccb4-f4cf-4633-ba6a-a9ca7d28d4e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "96e2c0e5-e59b-407d-aa9d-bfb75e2328f7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "1d057e11-2487-491f-a5e8-d800adf7a6e8", new DateTime(2023, 3, 13, 21, 1, 26, 480, DateTimeKind.Local).AddTicks(7337), "AQAAAAEAACcQAAAAEH7UUlzOlEkuwQGBYkusXbeDvM53Kcl2bucN2Qg3WcrgTqWf7UobVPnEbZQos59ffw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "79fe669d-473e-4289-bb8b-a37c61f65e09", new DateTime(2023, 3, 13, 21, 1, 26, 488, DateTimeKind.Local).AddTicks(9880), "AQAAAAEAACcQAAAAEBHWefesvXIklQ2WBDalE4RUvTgmz361apCLuxnMMbgpf0xIo3MWIT7+YJyZA3eUgA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b38d867b-2991-4099-b1a5-f4f9440c9a41", new DateTime(2023, 3, 13, 21, 1, 26, 455, DateTimeKind.Local).AddTicks(7827), "AQAAAAEAACcQAAAAEEEi8ifyXj3EqdgpLtEjPQQbWJ1q4vWw1XejfetqhLCgRY1eFHeoWDvwk9vKFtbB2g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b59cbc39-4c44-459a-a2fd-9fe576d609d9", new DateTime(2023, 3, 13, 21, 1, 26, 472, DateTimeKind.Local).AddTicks(4439), "AQAAAAEAACcQAAAAEMhQofswrpOZ6VV+5r3VGiZQJqC1ckR+qO+HTo6aBQP9olux6C1k435m0dcZHiiRUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6e4f461b-8102-46f4-ad4c-2dbe19123715", new DateTime(2023, 3, 13, 21, 1, 26, 464, DateTimeKind.Local).AddTicks(1165), "AQAAAAEAACcQAAAAED3FQwTuVYLOrtqewgE8W2oqPRYtl92zS7kkY96AdkNz4W5RpOV15JqOa5yahotxBA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "675061f2-f3d6-402c-b30e-1fff0268ac00", new DateTime(2023, 3, 13, 21, 1, 26, 447, DateTimeKind.Local).AddTicks(4659), "AQAAAAEAACcQAAAAEBf36pC7bVAGdBPx2PjHW2mT8rbNJ7QspwFWFeiIPjwxHzv2tVLc8vwiIorShUdD4Q==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Users_UserId",
                table: "Payment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
