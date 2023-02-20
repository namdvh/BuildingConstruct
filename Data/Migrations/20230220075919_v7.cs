using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuilderPostId",
                table: "Saves");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9493), new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 107, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 108, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 111, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 113, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 114, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 59, 18, 116, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "9ead5394-b793-4b00-ab06-1b30e8d8ccf4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "7e0b9816-0fe9-4d23-a5c1-364f1cb260ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "eb8a3ebb-c2a3-456c-9697-0a120ba6c658");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "62318d65-8c85-4bae-a4bf-68918eb41dc8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "45b4d516-4726-4aa4-ab26-c866b3fe4c4c", new DateTime(2023, 2, 20, 14, 59, 18, 113, DateTimeKind.Local).AddTicks(78), "AQAAAAEAACcQAAAAEIG5h5SPQyHSrRgq47LCuXTevynj9qN3ltIQnbs7Z29lpWPyJmcOZydDncyG0tGCdg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "90f07fb3-4695-47c1-a6af-f8541e52f0ef", new DateTime(2023, 2, 20, 14, 59, 18, 114, DateTimeKind.Local).AddTicks(9505), "AQAAAAEAACcQAAAAEDCb8dlQgxEq+2M2xQdtZRAuMfkgI4Pa5fVJwHvqn8AJ2DNk6Aaxc0zLzaYPAzdCeA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ff008505-b494-45c8-acfa-420fea62b28d", new DateTime(2023, 2, 20, 14, 59, 18, 107, DateTimeKind.Local).AddTicks(605), "AQAAAAEAACcQAAAAEKm3Y4kdUZnDXPFiB3o+ggdUNYNDGK7VrCglk3SX1P32I24OYCc0KPNlbVxiUOVuOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "51340308-8148-4a8a-b50a-f7ff42903efc", new DateTime(2023, 2, 20, 14, 59, 18, 111, DateTimeKind.Local).AddTicks(397), "AQAAAAEAACcQAAAAEGvy6B/IwMak2Q9GPleLyDHLAx3QsVE2z+oxNW+b7Ge40eYn4sKhGWxBmamKp5gJhA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "76c81fed-9cc6-47f5-b552-c6c210e6f005", new DateTime(2023, 2, 20, 14, 59, 18, 108, DateTimeKind.Local).AddTicks(9851), "AQAAAAEAACcQAAAAEDLFMYADfGlrePMAsnnozgua8vQdqEQBjkK8okitPzzL3ripPXtY+4g9PA8fsvGR9Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "32482aa3-e5f0-4097-b258-5fd9fe2e52c9", new DateTime(2023, 2, 20, 14, 59, 18, 105, DateTimeKind.Local).AddTicks(1292), "AQAAAAEAACcQAAAAEEocFUKuuf9Wu3FSNtksW6bsLwsau/xK2L1dcB4CiNAWIn4wK7CPZ/WH7b59u6Xa8g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuilderPostId",
                table: "Saves",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(991), new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(1063), new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 715, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 717, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 719, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 721, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 723, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 20, 14, 54, 11, 725, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "869dff30-f448-4f08-a26f-c8f0b8731b54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "125b1ebb-8a88-464e-ad34-ae3eeaaefb60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "5a542cf5-8b67-4479-b489-7e49f077bc40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "009087fb-2160-43ed-97a0-0ac988f899e2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "876cd4c0-f1b4-4e75-8e29-37dc5c880b48", new DateTime(2023, 2, 20, 14, 54, 11, 721, DateTimeKind.Local).AddTicks(1545), "AQAAAAEAACcQAAAAEGyrlsWMyfMBLmUgfoK18qfmriAsisch1fMFFWCF0Llg+zeTDbJOw/dLCW75j8Qqnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ea9ea50e-03fc-4c8f-856f-27e41c63f6ad", new DateTime(2023, 2, 20, 14, 54, 11, 723, DateTimeKind.Local).AddTicks(1465), "AQAAAAEAACcQAAAAEDVJLUnvetHa+8jNbs/E6tEwdq1fTf7k7e8ITNtclXxNeW4NsmxZah5xvbPoN3Uy9Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "7805af76-9463-45a3-bfaa-96291f4a923c", new DateTime(2023, 2, 20, 14, 54, 11, 715, DateTimeKind.Local).AddTicks(3340), "AQAAAAEAACcQAAAAEC4fiYk6yAWPGoirYzuzxrgo74+mlNQ6JTwL1QZm6A3/sYuFHxTxd6mU0vnJJzYRDg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "539bd3ac-fdc6-4110-a3dc-232e01df9fb7", new DateTime(2023, 2, 20, 14, 54, 11, 719, DateTimeKind.Local).AddTicks(2198), "AQAAAAEAACcQAAAAEFdSZI/sep3sIP2OUOlaYzvyFFYWYhHiOYAsf111IQC+dycE3Nsz0EO4S3Ankt8Ibg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5761dc78-b1c7-4707-9ab4-881cab487a51", new DateTime(2023, 2, 20, 14, 54, 11, 717, DateTimeKind.Local).AddTicks(3063), "AQAAAAEAACcQAAAAEHiDVtLKSvcFxTve6VJEEu8VJHzMM4qG9a7PffeeaHGPzyGGahDDMYDzxJssOv2axw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f5ca8177-6ddc-4aff-b2d8-eed17abea450", new DateTime(2023, 2, 20, 14, 54, 11, 713, DateTimeKind.Local).AddTicks(4014), "AQAAAAEAACcQAAAAEKomsb5m54NO3bpRNkyPyRDpGfbrWTrlXLZppf5llleFII/Fqqu7kOy5x7GM4hyzIw==" });
        }
    }
}
