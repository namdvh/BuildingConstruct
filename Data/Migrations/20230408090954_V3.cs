using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<bool>(
                name: "IsRefund",
                table: "Payments",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 4, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 3 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 359, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 376, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 394, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 411, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 426, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 444, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 458, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 469, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 483, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 497, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 508, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "cb58b8f5-eff7-4794-a560-3e14ba386cd6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "1f75367e-e5ad-4279-a1bd-d877346a870c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "9c22fd02-df59-4dba-9dfb-e08102e008d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "4049b423-8b33-417f-89bd-950703621b20");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 16, 9, 51, 509, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17c76dfe-7a0b-4ac9-ab8b-ba95e588a135"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "812852de-f257-4271-b921-68252a28e42d", new DateTime(2023, 4, 8, 16, 9, 51, 426, DateTimeKind.Local).AddTicks(818), "AQAAAAEAACcQAAAAEHYq7GaSUy51ADwf2TCowg8bNIfUix8ONr04zhnZs3n7q5L8Tce+XyGLzaIDnw86wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("319d2a06-92cc-434d-abce-7e8a33650a0d"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ef0c33b4-eca6-4052-bffc-d00fbd290287", new DateTime(2023, 4, 8, 16, 9, 51, 394, DateTimeKind.Local).AddTicks(6217), "AQAAAAEAACcQAAAAEB4O29rW+GISv/M+xjHBsvbZWA5jXZpgSLIdarAkFyNFKSTdYGB4cEpcz4c1qSQC1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86b8070e-00c5-45de-8db7-199cee7350d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "210e3f11-d110-4e42-b02b-8cbaa9ecae8e", new DateTime(2023, 4, 8, 16, 9, 51, 469, DateTimeKind.Local).AddTicks(1089), "AQAAAAEAACcQAAAAEAVbOhxEdpkOvdyQEwaL4kkukYJiJPd5W+chwqDQ/bpKT5Jdm1jt3/tF71lg3aDE2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f314589-0c7c-40a4-b5bc-c73639664922"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "78a3b5aa-34b5-4a5b-9378-0ec57aa42702", new DateTime(2023, 4, 8, 16, 9, 51, 411, DateTimeKind.Local).AddTicks(3497), "AQAAAAEAACcQAAAAEENey7qCTv0NptfQm1uwXEuDo5oyPfMRCnEOUghKA540fJgvU+Fx8UegSvFmB5wYZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6731897c-cbf9-4eeb-ac12-0e74fd35b3dc", new DateTime(2023, 4, 8, 16, 9, 51, 483, DateTimeKind.Local).AddTicks(2925), "AQAAAAEAACcQAAAAECVO22Pg7U90LsvqnWZaYpJX/Ggdv5cZkkLKXae36m4Wv/0s8OMB88t1akqDIQKaMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "bfd124c1-115d-4287-aa22-985c06b5d8ee", new DateTime(2023, 4, 8, 16, 9, 51, 497, DateTimeKind.Local).AddTicks(6768), "AQAAAAEAACcQAAAAEMJbA7/UcCvhSfUwTmJEU8/OlOMnvfroefrsZZJ9OHlCPhfgp23RKLC7albPfqCMpQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6223c60e-8bda-471d-8cc1-8ed9caf9df28", new DateTime(2023, 4, 8, 16, 9, 51, 359, DateTimeKind.Local).AddTicks(6421), "AQAAAAEAACcQAAAAEBCc4KZvryT2e6L7TDNL3fO6Jn3YD78pi/TtjgXC9aO4Fsiw2E2drj48mTvyJtwkVw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "90f75442-d4ab-468a-b63a-0cf5e2d69ea9", new DateTime(2023, 4, 8, 16, 9, 51, 458, DateTimeKind.Local).AddTicks(9967), "AQAAAAEAACcQAAAAEF7fiQ7lhttGn8Lih6o4Y1F5yW7Q7ENc7ihRJ6uwdeOy83iCm3g7E66vc241lT1gpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "08b9f114-f799-43d2-9996-5fd1df75a328", new DateTime(2023, 4, 8, 16, 9, 51, 444, DateTimeKind.Local).AddTicks(7182), "AQAAAAEAACcQAAAAEEprbSakDxQMhPGa1l2FB6O4SuoqfsAl8UY7Vv8j0IZd39s7TW1mjL9e71h7e/kYZw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "fe15395e-e202-4b9f-a032-18bab25e7db0", new DateTime(2023, 4, 8, 16, 9, 51, 345, DateTimeKind.Local).AddTicks(2680), "AQAAAAEAACcQAAAAEG7xfFQa12taQGQhXEL5yb75zlNXDS0nqqMUZ4o3d5fXV1m+N9yFuQVZLsS85x5wtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ffeeac3d-1261-495f-aa5f-9c3682e20254", new DateTime(2023, 4, 8, 16, 9, 51, 332, DateTimeKind.Local).AddTicks(6572), "AQAAAAEAACcQAAAAEC/8KCnv0lNfyQhF0F+9i77CnAJv4hNKRSO6KdVcSY4BiBXCFQQNoNKb54iZb5QLUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "50c29226-7e7d-4cdb-bc1f-752444334143", new DateTime(2023, 4, 8, 16, 9, 51, 376, DateTimeKind.Local).AddTicks(271), "AQAAAAEAACcQAAAAEMf3O4kS1dmnjd+wgP2zClBzcEVmGTBd0tZivGnbwvjznOCDpD9e5wLUM41yVe4BVA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsRefund",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 4, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 3 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "ContractorId", "CreateBy", "EndDate", "LastModifiedAt", "Note", "PaymentDate", "Reason", "StartDate", "Status", "StoreID", "TotalPrice", "Type" },
                values: new object[,]
                {
                    { 1, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), new DateTime(2023, 4, 13, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7414), new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7421), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", null, null, new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7420), 5, 1, 500000m, 0 },
                    { 2, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), new DateTime(2023, 4, 13, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7502), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", null, null, new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7501), 5, 1, 60000000m, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 577, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 579, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 580, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 582, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 584, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 585, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 587, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 588, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 590, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 591, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "8b6f0e12-2174-4a7a-a33a-3519d930ac19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "b932d9fa-c81d-4d36-b4b0-df332296c5bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "5bd0e59a-f9dd-406d-962f-44f1fc44f402");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "b11010e1-a138-4c89-b6c6-6e10c3eb8f0d");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 8, 12, 45, 2, 593, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17c76dfe-7a0b-4ac9-ab8b-ba95e588a135"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "07ba26cf-c101-4a08-b186-14b9aa7e0707", new DateTime(2023, 4, 8, 12, 45, 2, 584, DateTimeKind.Local).AddTicks(258), "AQAAAAEAACcQAAAAEI5CoTcV80bwW5Ub0JDlT62bDa0PrzCjXbW35uoY44JPr5aoyb1GgOtKjX0QnH/5VQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("319d2a06-92cc-434d-abce-7e8a33650a0d"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "17a52a9b-8533-4ca0-b1bc-dc9f182ef264", new DateTime(2023, 4, 8, 12, 45, 2, 580, DateTimeKind.Local).AddTicks(8808), "AQAAAAEAACcQAAAAEFzP2gGtGR+McPY/94sYnLWLeyVNyxKC0ovwy1MYKEUB8pfsBiJ3I1pjYaYQdqBqqg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86b8070e-00c5-45de-8db7-199cee7350d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "44547775-0805-4d31-8490-489ba23f4b24", new DateTime(2023, 4, 8, 12, 45, 2, 588, DateTimeKind.Local).AddTicks(8097), "AQAAAAEAACcQAAAAEP/evUg4au6D4mflt62P8jO/Owku3pxg3Fotwx/5HWg63UIcI+HO2o29BzMqdvkxjw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f314589-0c7c-40a4-b5bc-c73639664922"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "cf3714b4-927d-4cb8-ab4e-cb172857e9cb", new DateTime(2023, 4, 8, 12, 45, 2, 582, DateTimeKind.Local).AddTicks(4747), "AQAAAAEAACcQAAAAEP7+c4+aGJvQAwY86uAMo/5+GUGB/8OpULFWgPszjBt718oYJmExeFKd1sM5vtF+cQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5dabed33-06bb-4ca9-beba-67477c25dd52", new DateTime(2023, 4, 8, 12, 45, 2, 590, DateTimeKind.Local).AddTicks(3653), "AQAAAAEAACcQAAAAEBzNTwDPWlFX6KrDWuCBpLTvvStnyx5SH0lft6n5Pc/MehZrRUyufrBxi+5J1L6QqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a16f7ab0-fd6b-45a1-a62b-b35a6c086e54", new DateTime(2023, 4, 8, 12, 45, 2, 591, DateTimeKind.Local).AddTicks(9144), "AQAAAAEAACcQAAAAEGHnLeF+B4VPd51X0/wFAcSVo+W3txYyW7MCSlLQvArkG2rbuPXH7CnUTIkomYL/hQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "455c1e57-9a05-43ed-b737-dc096cdb6d3a", new DateTime(2023, 4, 8, 12, 45, 2, 577, DateTimeKind.Local).AddTicks(6236), "AQAAAAEAACcQAAAAEAeaYr0JFeHrxjsF8rjSq7WGnUDR2zBsf4pFAv27YjjwtRPwSnS/+pGkDJfpd2WaYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "8583d951-95ca-424e-b70e-bfa91556adda", new DateTime(2023, 4, 8, 12, 45, 2, 587, DateTimeKind.Local).AddTicks(2405), "AQAAAAEAACcQAAAAEFiO0FZcirIxLmAqzodOV3IikZNWpGTERDMcDM5xNlGuh78i8A2JLOXqlSN8uBE9oQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2f677a51-7e42-4e10-aadb-e537174302f0", new DateTime(2023, 4, 8, 12, 45, 2, 585, DateTimeKind.Local).AddTicks(5923), "AQAAAAEAACcQAAAAELUuSb3OPZcS4yHc1UjiV2cFOyCpZwUsIdDdUqH0D26nFE835c/bYER2PeKM+hXg5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d6e044e8-b4e6-4a80-a3a5-0ecbf5613e24", new DateTime(2023, 4, 8, 12, 45, 2, 575, DateTimeKind.Local).AddTicks(8731), "AQAAAAEAACcQAAAAEIaaL1ty4un69nrDa8zRAWkadqOGwaktkr8kgN8MJbLxsVEXxoh0/zNXtIXpXzTLGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "490ab90e-96a6-40f5-a995-4d65be75cbaf", new DateTime(2023, 4, 8, 12, 45, 2, 574, DateTimeKind.Local).AddTicks(2605), "AQAAAAEAACcQAAAAEMrMQ3oHmHLDEBvCMlEAYxrHqI5Q3JWNVl/mvJpUd+pB3lBjGrLBPV3XhU74caSa8g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5d11e583-d964-4b58-a9b0-ddf7ea9d56b3", new DateTime(2023, 4, 8, 12, 45, 2, 579, DateTimeKind.Local).AddTicks(2934), "AQAAAAEAACcQAAAAELA8ZqjKH5Iqgf4z+qok+QH9z/0FI4rbkL4Co2aWnfhLwe8bQbgG1AFH9i4ntVibYg==" });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "Id", "BillID", "Price", "ProductID", "ProductTypeId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 200000m, 20, 60, 5 },
                    { 2, 1, 150000m, 21, null, 8 },
                    { 3, 1, 450000m, 22, null, 7 },
                    { 5, 2, 20000m, 1, null, 5 },
                    { 6, 2, 150000m, 2, null, 8 },
                    { 7, 2, 45000m, 3, null, 7 }
                });
        }
    }
}
