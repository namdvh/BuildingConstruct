using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_Builders_BuilderID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_ContractorPosts_PostID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_Group_GroupID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Contractors_ContractorId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_MaterialStores_StoreID",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Bill_BillID",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Products_ProductID",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_SmallBill_SmallBillID",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPosts_Builders_BuilderID",
                table: "BuilderPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_BuilderPostID",
                table: "BuilderPostSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillID",
                table: "BuilderPostSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostType_BuilderPosts_BuilderPostID",
                table: "BuilderPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostType_Types_TypeID",
                table: "BuilderPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_Builders_Types_TypeID",
                table: "Builders");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderSkills_Builders_BuilderSkillID",
                table: "BuilderSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderSkills_Skills_SkillID",
                table: "BuilderSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Builders_BuilderID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_ContractorPosts_PostID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Group_GroupID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Users_UserId",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPosts_Contractors_ContractorID",
                table: "ContractorPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostSkills_ContractorPosts_ContractorPostID",
                table: "ContractorPostSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostSkills_Skills_SkillID",
                table: "ContractorPostSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostType_ContractorPosts_ContractorPostID",
                table: "ContractorPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostType_Types_TypeID",
                table: "ContractorPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Builders_BuilderID",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMember_Group_GroupId",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMember_Types_TypeID",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserID",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Categories_CategoriesID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MaterialStores_MaterialStoreID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Products_ProductID",
                table: "ProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Saves_BuilderPosts_BuilderPostId",
                table: "Saves");

            migrationBuilder.DropForeignKey(
                name: "FK_Saves_ContractorPosts_ContractorPostId",
                table: "Saves");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Types_TypeId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SmallBill_Bill_BillID",
                table: "SmallBill");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Builders_BuilderId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Contractors_ContractorId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_IdentitficationCards_VerifyID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_MaterialStores_MaterialStoreID",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7721), new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "BuilderPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 11, 952, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Builders",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 11, 963, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 11, 973, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 11, 983, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 11, 994, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "b914f5fe-6fb9-4436-8ebd-0fdcc669e021");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "f7ca8cb9-4651-4cc0-b81b-bc240d2427c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "9e4b183d-67f9-451a-94f4-66396137fc95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "d03d8cb0-0a61-446e-93fa-902b926f3dc4");

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "SmallBill",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 2, 15, 13, 58, 12, 8, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "e708d3a9-5982-4f60-90a6-325300d1d9d5", new DateTime(2023, 2, 15, 13, 58, 11, 983, DateTimeKind.Local).AddTicks(181), "AQAAAAEAACcQAAAAECVeo8BpFk8AG2vKxZ9Ezh9ircrfjFOSoUObEt2MRa6rVqqISryVwG4utYAyUyknOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "66248989-f7bf-4bf6-958f-70ce2c3eae52", new DateTime(2023, 2, 15, 13, 58, 11, 994, DateTimeKind.Local).AddTicks(2209), "AQAAAAEAACcQAAAAEOp1uq/CiggJFHoxS6xdid8+ZnKfHHEJMybiDOpUXoft0aUl8IgefOdPDK+NxWpVEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "14303008-cb19-45eb-9c91-1a32576ca395", new DateTime(2023, 2, 15, 13, 58, 11, 952, DateTimeKind.Local).AddTicks(9841), "AQAAAAEAACcQAAAAEJGl+N/aiclDam8ghReH+MhDbq7MUqxDXQyK9FX/9o7DE3lAm/mcHPtqgzXdC2Aacg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ae279b56-488f-4983-afd9-bb65f7accbf5", new DateTime(2023, 2, 15, 13, 58, 11, 973, DateTimeKind.Local).AddTicks(3562), "AQAAAAEAACcQAAAAEL8jnOdA+EDcdcFf/QhDvWOJqOKEDlS6973lNhv/v15MBYRtErHg5/cvNPx70ZOQOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2846b65c-7b2f-4fb2-8a0a-134bb32b44da", new DateTime(2023, 2, 15, 13, 58, 11, 963, DateTimeKind.Local).AddTicks(7842), "AQAAAAEAACcQAAAAEEXXZEd225ZozDRebm9GNz7VvNIKUbibJwzUY9tEwlYCVYBSbsDsf8fYzk7o8pTEUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "2b9fb539-0c14-405c-a4f9-cd7c10785564", new DateTime(2023, 2, 15, 13, 58, 11, 939, DateTimeKind.Local).AddTicks(6008), "AQAAAAEAACcQAAAAEFIqGqV8Kjd41XUEv7VZsJIZc6dyJgVpj35sRHf/gjdRNiGAl/F7yXophsRKV1lfHQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_Builders_BuilderID",
                table: "AppliedPost",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_ContractorPosts_PostID",
                table: "AppliedPost",
                column: "PostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_Group_GroupID",
                table: "AppliedPost",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Contractors_ContractorId",
                table: "Bill",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_MaterialStores_StoreID",
                table: "Bill",
                column: "StoreID",
                principalTable: "MaterialStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Bill_BillID",
                table: "BillDetail",
                column: "BillID",
                principalTable: "Bill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Products_ProductID",
                table: "BillDetail",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_SmallBill_SmallBillID",
                table: "BillDetail",
                column: "SmallBillID",
                principalTable: "SmallBill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPosts_Builders_BuilderID",
                table: "BuilderPosts",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_BuilderPostID",
                table: "BuilderPostSkill",
                column: "BuilderPostID",
                principalTable: "BuilderPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillID",
                table: "BuilderPostSkill",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostType_BuilderPosts_BuilderPostID",
                table: "BuilderPostType",
                column: "BuilderPostID",
                principalTable: "BuilderPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostType_Types_TypeID",
                table: "BuilderPostType",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Builders_Types_TypeID",
                table: "Builders",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderSkills_Builders_BuilderSkillID",
                table: "BuilderSkills",
                column: "BuilderSkillID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderSkills_Skills_SkillID",
                table: "BuilderSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductID",
                table: "Carts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserID",
                table: "Carts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Builders_BuilderID",
                table: "Commitment",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_ContractorPosts_PostID",
                table: "Commitment",
                column: "PostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Group_GroupID",
                table: "Commitment",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Users_UserId",
                table: "Commitment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPosts_Contractors_ContractorID",
                table: "ContractorPosts",
                column: "ContractorID",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostSkills_ContractorPosts_ContractorPostID",
                table: "ContractorPostSkills",
                column: "ContractorPostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostSkills_Skills_SkillID",
                table: "ContractorPostSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostType_ContractorPosts_ContractorPostID",
                table: "ContractorPostType",
                column: "ContractorPostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostType_Types_TypeID",
                table: "ContractorPostType",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Builders_BuilderID",
                table: "Group",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMember_Group_GroupId",
                table: "GroupMember",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMember_Types_TypeID",
                table: "GroupMember",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserID",
                table: "Notifications",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Categories_CategoriesID",
                table: "ProductCategories",
                column: "CategoriesID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MaterialStores_MaterialStoreID",
                table: "Products",
                column: "MaterialStoreID",
                principalTable: "MaterialStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Products_ProductID",
                table: "ProductTypes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saves_BuilderPosts_BuilderPostId",
                table: "Saves",
                column: "BuilderPostId",
                principalTable: "BuilderPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Saves_ContractorPosts_ContractorPostId",
                table: "Saves",
                column: "ContractorPostId",
                principalTable: "ContractorPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Types_TypeId",
                table: "Skills",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SmallBill_Bill_BillID",
                table: "SmallBill",
                column: "BillID",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Builders_BuilderId",
                table: "Users",
                column: "BuilderId",
                principalTable: "Builders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Contractors_ContractorId",
                table: "Users",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_IdentitficationCards_VerifyID",
                table: "Users",
                column: "VerifyID",
                principalTable: "IdentitficationCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MaterialStores_MaterialStoreID",
                table: "Users",
                column: "MaterialStoreID",
                principalTable: "MaterialStores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_Builders_BuilderID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_ContractorPosts_PostID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_Group_GroupID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Contractors_ContractorId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_MaterialStores_StoreID",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Bill_BillID",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Products_ProductID",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_SmallBill_SmallBillID",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPosts_Builders_BuilderID",
                table: "BuilderPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_BuilderPostID",
                table: "BuilderPostSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillID",
                table: "BuilderPostSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostType_BuilderPosts_BuilderPostID",
                table: "BuilderPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostType_Types_TypeID",
                table: "BuilderPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_Builders_Types_TypeID",
                table: "Builders");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderSkills_Builders_BuilderSkillID",
                table: "BuilderSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderSkills_Skills_SkillID",
                table: "BuilderSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Builders_BuilderID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_ContractorPosts_PostID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Group_GroupID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Users_UserId",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPosts_Contractors_ContractorID",
                table: "ContractorPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostSkills_ContractorPosts_ContractorPostID",
                table: "ContractorPostSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostSkills_Skills_SkillID",
                table: "ContractorPostSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostType_ContractorPosts_ContractorPostID",
                table: "ContractorPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostType_Types_TypeID",
                table: "ContractorPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Builders_BuilderID",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMember_Group_GroupId",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMember_Types_TypeID",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserID",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Categories_CategoriesID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MaterialStores_MaterialStoreID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Products_ProductID",
                table: "ProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Saves_BuilderPosts_BuilderPostId",
                table: "Saves");

            migrationBuilder.DropForeignKey(
                name: "FK_Saves_ContractorPosts_ContractorPostId",
                table: "Saves");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Types_TypeId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SmallBill_Bill_BillID",
                table: "SmallBill");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Builders_BuilderId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Contractors_ContractorId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_IdentitficationCards_VerifyID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_MaterialStores_MaterialStoreID",
                table: "Users");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_Builders_BuilderID",
                table: "AppliedPost",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_ContractorPosts_PostID",
                table: "AppliedPost",
                column: "PostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_Group_GroupID",
                table: "AppliedPost",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Contractors_ContractorId",
                table: "Bill",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_MaterialStores_StoreID",
                table: "Bill",
                column: "StoreID",
                principalTable: "MaterialStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Bill_BillID",
                table: "BillDetail",
                column: "BillID",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Products_ProductID",
                table: "BillDetail",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_SmallBill_SmallBillID",
                table: "BillDetail",
                column: "SmallBillID",
                principalTable: "SmallBill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPosts_Builders_BuilderID",
                table: "BuilderPosts",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_BuilderPostID",
                table: "BuilderPostSkill",
                column: "BuilderPostID",
                principalTable: "BuilderPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillID",
                table: "BuilderPostSkill",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostType_BuilderPosts_BuilderPostID",
                table: "BuilderPostType",
                column: "BuilderPostID",
                principalTable: "BuilderPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostType_Types_TypeID",
                table: "BuilderPostType",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builders_Types_TypeID",
                table: "Builders",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderSkills_Builders_BuilderSkillID",
                table: "BuilderSkills",
                column: "BuilderSkillID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderSkills_Skills_SkillID",
                table: "BuilderSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductID",
                table: "Carts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserID",
                table: "Carts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Builders_BuilderID",
                table: "Commitment",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_ContractorPosts_PostID",
                table: "Commitment",
                column: "PostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Group_GroupID",
                table: "Commitment",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Users_UserId",
                table: "Commitment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPosts_Contractors_ContractorID",
                table: "ContractorPosts",
                column: "ContractorID",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostSkills_ContractorPosts_ContractorPostID",
                table: "ContractorPostSkills",
                column: "ContractorPostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostSkills_Skills_SkillID",
                table: "ContractorPostSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostType_ContractorPosts_ContractorPostID",
                table: "ContractorPostType",
                column: "ContractorPostID",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostType_Types_TypeID",
                table: "ContractorPostType",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Builders_BuilderID",
                table: "Group",
                column: "BuilderID",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMember_Group_GroupId",
                table: "GroupMember",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMember_Types_TypeID",
                table: "GroupMember",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserID",
                table: "Notifications",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Categories_CategoriesID",
                table: "ProductCategories",
                column: "CategoriesID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MaterialStores_MaterialStoreID",
                table: "Products",
                column: "MaterialStoreID",
                principalTable: "MaterialStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Products_ProductID",
                table: "ProductTypes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saves_BuilderPosts_BuilderPostId",
                table: "Saves",
                column: "BuilderPostId",
                principalTable: "BuilderPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saves_ContractorPosts_ContractorPostId",
                table: "Saves",
                column: "ContractorPostId",
                principalTable: "ContractorPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Types_TypeId",
                table: "Skills",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SmallBill_Bill_BillID",
                table: "SmallBill",
                column: "BillID",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Builders_BuilderId",
                table: "Users",
                column: "BuilderId",
                principalTable: "Builders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Contractors_ContractorId",
                table: "Users",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_IdentitficationCards_VerifyID",
                table: "Users",
                column: "VerifyID",
                principalTable: "IdentitficationCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MaterialStores_MaterialStoreID",
                table: "Users",
                column: "MaterialStoreID",
                principalTable: "MaterialStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
