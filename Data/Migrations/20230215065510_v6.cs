using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5659), new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 815, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 823, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 831, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 839, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 847, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "ab6f5d79-b4c6-4829-a642-9902ab5b34ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "22ec76d1-0760-4e38-9c04-b94e27725981");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "76e048aa-da83-4760-b9f9-5b6c0c61cd63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "99b665ef-b067-40a0-8505-85fd22c0294a");

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 2, 15, 13, 55, 8, 855, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6ba2ca19-0778-46b9-b4bc-e29421c445ff", new DateTime(2023, 2, 15, 13, 55, 8, 839, DateTimeKind.Local).AddTicks(3571), "AQAAAAEAACcQAAAAED+806Ygm7rFmbJ5vXN6+7q2FQowGYRpxRn+05wb2i6gPff9QL4rzJeo/olSpmoYug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a7be849e-6478-4ee9-8589-e7e5eafaa60a", new DateTime(2023, 2, 15, 13, 55, 8, 847, DateTimeKind.Local).AddTicks(4508), "AQAAAAEAACcQAAAAEJeQv2+WM082CFWlS5i5AAarqPuluamxp2lRLIGSwyre7WD8xxJYpr0TNED0ZdmXiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "82f5b3e1-53be-4b41-9369-7b52e4b24c21", new DateTime(2023, 2, 15, 13, 55, 8, 815, DateTimeKind.Local).AddTicks(701), "AQAAAAEAACcQAAAAEPdwII1HayDkRSN+EPVkjSK1KzlhFz4YDUC1Lxshk/ETJWCYgDk6BOVTY+d8l40Iaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b419a9da-7715-4fd1-9986-ee32dc6164ba", new DateTime(2023, 2, 15, 13, 55, 8, 831, DateTimeKind.Local).AddTicks(3135), "AQAAAAEAACcQAAAAEFH9zcDrHs6Dhwe6xXFTVuRBOUH2IIcIU8sb7X/RITec5QMxp7SiXhBtPmfuRcQQeQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f66b532c-205c-4b41-bdff-324374db4475", new DateTime(2023, 2, 15, 13, 55, 8, 823, DateTimeKind.Local).AddTicks(2295), "AQAAAAEAACcQAAAAEM4VMiN22Omr6zYi+JqMRGfHpTTI94JcU6wu+uLa5BZYL1+5roNTc9fIH1tPrl0KjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "9b8a2ad5-3bfe-4fe6-b98d-f41bb1ddc08e", new DateTime(2023, 2, 15, 13, 55, 8, 806, DateTimeKind.Local).AddTicks(6941), "AQAAAAEAACcQAAAAEMlgoo/WvQ5E50jUHatOfYSnmRJOrRomcUTTDUSxRl5awdZ56AOquTLS3m13uGYSGA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "ProductTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(289), new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(350), new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 437, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 446, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 455, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 464, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 473, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 47, 20, 482, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "5af12aaa-3740-45d2-9efd-2226132769e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "08109cea-1764-4138-92d5-1491df6fb747");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "f6d23047-1aa5-4d61-8d21-da7f5b033c34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "55c2a3bb-c950-4adc-bf1b-a0040c27977d");

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(382), new DateTime(2023, 2, 15, 13, 47, 20, 483, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "acd0b0ab-6f98-4b00-98bf-7500c7f694fc", new DateTime(2023, 2, 15, 13, 47, 20, 464, DateTimeKind.Local).AddTicks(8912), "AQAAAAEAACcQAAAAEO9Eiy/ytjMpBIj2iS+HXQhh3ZB+EJXYa2e155nz8Qdtn9HET0ZjBr41krspPmSdkg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "4acd735a-51ec-4ee7-adcd-d89d45bcebaf", new DateTime(2023, 2, 15, 13, 47, 20, 473, DateTimeKind.Local).AddTicks(8183), "AQAAAAEAACcQAAAAEC9RwnMtKUuQGytMMtMVsg7YJWB7hsnoz4RCWKwV6szU/t4GibIZlxJHQ5VYsPawQw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f0a84df5-04ac-49b0-8cf7-65ecd93ec375", new DateTime(2023, 2, 15, 13, 47, 20, 437, DateTimeKind.Local).AddTicks(4466), "AQAAAAEAACcQAAAAENpafoppkbZQDuTNeL4woia7vNdTyeK18dDG2JOLaI6zIZum8N2mMvjS/Mb/qBwlEw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "39ebc8ed-b634-4da9-84ef-364e480b999e", new DateTime(2023, 2, 15, 13, 47, 20, 455, DateTimeKind.Local).AddTicks(8983), "AQAAAAEAACcQAAAAEI1t3KCoQ37cJ2TI3ldZE6OYTUrpieHznaNqWeWaQwgsWvJCwV3b4NsRBTbsfJSbdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "895a2704-4484-4071-b831-56dfe1f5a4e6", new DateTime(2023, 2, 15, 13, 47, 20, 446, DateTimeKind.Local).AddTicks(8709), "AQAAAAEAACcQAAAAEJaP/cEZNpfsUMWotVB47tc5W1eay73N6Iyt2vgSR2S+evmEnzLFYYw6fvGOq+NiyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "e3502147-2277-4baf-bcbf-66279a609875", new DateTime(2023, 2, 15, 13, 47, 20, 427, DateTimeKind.Local).AddTicks(2166), "AQAAAAEAACcQAAAAEMF1jwk//18vAKvVAt3WI8fy6iWBGWjdiMQ1awUQDVdPtZdmWfG69Zpt6woytV4t5A==" });
        }
    }
}
