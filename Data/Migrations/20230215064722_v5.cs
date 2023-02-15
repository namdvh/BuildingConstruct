using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductType_Products_ProductID",
                table: "ProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType");

            migrationBuilder.RenameTable(
                name: "ProductType",
                newName: "ProductTypes");

            migrationBuilder.RenameIndex(
                name: "IX_ProductType_ProductID",
                table: "ProductTypes",
                newName: "IX_ProductTypes_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Products_ProductID",
                table: "ProductTypes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Products_ProductID",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "ProductType");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTypes_ProductID",
                table: "ProductType",
                newName: "IX_ProductType_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductType_Products_ProductID",
                table: "ProductType",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
