using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "ProductType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5494), new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 599, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 606, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 614, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 622, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 629, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "1b7803d9-9f27-4dfb-98c8-62ef034b6840");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "e3e72414-b1c3-455d-8009-bfd284553d0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "f3140b69-3829-46cf-ac12-936b4abb95af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "2de0c7dd-d154-493e-b27f-231534001c77");

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 2, 15, 13, 20, 4, 637, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c29d4e35-aaf9-4fbf-a884-8a18f10b4298", new DateTime(2023, 2, 15, 13, 20, 4, 622, DateTimeKind.Local).AddTicks(420), "AQAAAAEAACcQAAAAEJnv+ZE3/MmnTX8+TGFDneEozHW8G2Oj3Pki4liM+x88f767w7L6XACMLVvgz+Mm+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "53aaa77e-bfca-4959-a722-125089d33897", new DateTime(2023, 2, 15, 13, 20, 4, 629, DateTimeKind.Local).AddTicks(7990), "AQAAAAEAACcQAAAAEIkBNbSyCFvu51YxdfSzxeajVE0pQHRDW6PBrDSMQtpxBnjq/+rVl8/NGUau55z0fw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "97b886ea-98f8-461f-b01c-16f6a6706406", new DateTime(2023, 2, 15, 13, 20, 4, 599, DateTimeKind.Local).AddTicks(2840), "AQAAAAEAACcQAAAAEKw3HqgJovYnxulVW6QGZYt8Mh6UsDexcU9hzxNK7AORrRIkZhxZ3pk7kf7oexOe5Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0333b302-5692-4df6-938a-cc76efc6d827", new DateTime(2023, 2, 15, 13, 20, 4, 614, DateTimeKind.Local).AddTicks(4381), "AQAAAAEAACcQAAAAEEvz1pSS9h64/VoaSmwU+cgBNonJihIMcif7UXHHBtgW8pJ5FlxxWTCZge8xC5kxBw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "4a53f6e3-ef51-4403-9266-afe4da6901da", new DateTime(2023, 2, 15, 13, 20, 4, 606, DateTimeKind.Local).AddTicks(8889), "AQAAAAEAACcQAAAAEC2PlsVaLYlEHN9GDK1sn+ntAhCKEtnRHLw8nsMxx1/g6IhWLs0jZPrluxxBfSICFA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "8e244eec-3124-4666-b547-506e1b17ef2e", new DateTime(2023, 2, 15, 13, 20, 4, 591, DateTimeKind.Local).AddTicks(7241), "AQAAAAEAACcQAAAAEI4yq2I+ebVank1fEJTBOMcbTzNzEn6i4b2dBYvdlt0p07v2IggJm9TR3x0u/I12iw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductType");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5285), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5354), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 596, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 605, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 614, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 622, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 631, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "76881ec8-61e8-4196-96d3-ae04f4983485");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "ee3fa693-51ac-41d6-98da-d8c1d97c88eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "0d7804fc-364d-4e41-a9d4-8e9b9b3b82f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "bc8d2037-ec11-48c0-a20d-5f29ad13b6aa");

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5373), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5389), new DateTime(2023, 2, 15, 11, 23, 58, 640, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "a9bb4143-0c4a-4872-b1f5-d8c6c6b32623", new DateTime(2023, 2, 15, 11, 23, 58, 622, DateTimeKind.Local).AddTicks(9639), "AQAAAAEAACcQAAAAEA96BrPkJWacP9TeZUHldaptoYRNFEhEq1M0zrmxnbxmzPCLTrBq6FtMDWLyZkGHvg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "477571eb-3945-45c4-9a5b-d9a1ec0ed1bc", new DateTime(2023, 2, 15, 11, 23, 58, 631, DateTimeKind.Local).AddTicks(8042), "AQAAAAEAACcQAAAAEFvU1/7xEf8YwGW4YEOhCY+/ZdnbU86UUvOGp9j8nGZSU5AZr7EzcTrtj2bvHsB42Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6526f812-59c1-4852-87e3-c9b2c87fbf7b", new DateTime(2023, 2, 15, 11, 23, 58, 596, DateTimeKind.Local).AddTicks(9505), "AQAAAAEAACcQAAAAEDQR7wz5kTCue5+gooc2UPq+rmBiYFG8ApKJ/kPJwASityTCPd86CaSqqi1akCbfHA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "4fac719f-4763-4aa9-ba70-c4d1b87d1035", new DateTime(2023, 2, 15, 11, 23, 58, 614, DateTimeKind.Local).AddTicks(3856), "AQAAAAEAACcQAAAAEBm0PMByVRVLkbgSVGXmYOJrEjQXsN/Ns1aTg/LiMsSbFv2ntmTnqBTuSt2hqpbbBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "dbac5495-f917-40bc-951f-edbca2349fc1", new DateTime(2023, 2, 15, 11, 23, 58, 605, DateTimeKind.Local).AddTicks(5355), "AQAAAAEAACcQAAAAEK1Tk3MKpOoeH7IZNC68xIoX4E6vpjiJwqGkAPnC5ryp4HbjO9c8bHWTGq6kGhpHgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0cb03e0b-f5f4-4a63-98e6-731358c2c3b6", new DateTime(2023, 2, 15, 11, 23, 58, 588, DateTimeKind.Local).AddTicks(1727), "AQAAAAEAACcQAAAAELJUWCi0/Y8xoAVFz5OA9EAi9uecfBVrUvIdGkj8ttJHybngQzmc63u/mGCzbNGFrQ==" });
        }
    }
}
