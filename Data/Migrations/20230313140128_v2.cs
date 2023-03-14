using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRefund = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 18, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8198), new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8203), new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 18, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8253), new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 701, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 707, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 713, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 719, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 725, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 3, 13, 20, 51, 56, 731, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "8b488a22-d1e4-4989-a069-e2042af3223c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "9858a397-b09b-473e-93fd-ba31633b4a8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "ff252122-5b8a-4b3c-87ec-e0dfd156af18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "55837df2-88c2-4f1c-adbf-821847ea801f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "4c83c20d-b917-4b1d-8f84-afeab9c61b0c", new DateTime(2023, 3, 13, 20, 51, 56, 719, DateTimeKind.Local).AddTicks(5231), "AQAAAAEAACcQAAAAEIG/xQrnHqofJ1bKp9U5AEbCkvEDChW6Q9H8Mcnkqu3CRlENOTcqflmiHF1Y0ZW92w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b4be7faf-ed84-4bbd-b111-99f84356e8cd", new DateTime(2023, 3, 13, 20, 51, 56, 725, DateTimeKind.Local).AddTicks(6907), "AQAAAAEAACcQAAAAEMlPzzOFZHhqkJYQIGOPaYWvYuWxObDDlg3UYcTGfaAm/WDyI7KvQzx6Rdn8YRF8fQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0720bfe1-a422-4e9e-ac18-77a310ef7571", new DateTime(2023, 3, 13, 20, 51, 56, 701, DateTimeKind.Local).AddTicks(5132), "AQAAAAEAACcQAAAAEL1P6mC0bqHHs0JF3IJ+RcAqQljQo4+Zdyf3cMb7HLGPFpScsO01UjoYOjsxxmm9QA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "61980fd1-5cdf-4512-a043-1cef99422806", new DateTime(2023, 3, 13, 20, 51, 56, 713, DateTimeKind.Local).AddTicks(5264), "AQAAAAEAACcQAAAAEAwkbSQ9KFiYjbcVrY2a74Z5Y1ZESYwWpwptaW6gs2F3YbGJotWHGPjFPr1iF+1ang==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "375bf489-e99f-428b-8b4c-159eb84967a7", new DateTime(2023, 3, 13, 20, 51, 56, 707, DateTimeKind.Local).AddTicks(5354), "AQAAAAEAACcQAAAAED7MBmDP/p+VgxTpFuHkwYZ2/7E8VSpjP/sMSuBPeGHJPT2wKc/bjtbQ1+npjzESkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "520d600b-ded1-46e2-b248-e0817c808eeb", new DateTime(2023, 3, 13, 20, 51, 56, 695, DateTimeKind.Local).AddTicks(4831), "AQAAAAEAACcQAAAAEKfT0AkCsCCv4ubEAXQ8O8mW5vskFjTFTbs+EqXdb3BQ0K6CJXUbA2HgHHqEiaHkLg==" });
        }
    }
}
