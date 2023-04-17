using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_Workers_BuilderID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderSkills_Skills_SkillID",
                table: "BuilderSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderSkills_Workers_BuilderSkillID",
                table: "BuilderSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Workers_BuilderID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Workers_BuilderID",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_PostInvite_Workers_BuilderId",
                table: "PostInvite");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_Workers_BuilderId",
                table: "UserAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Workers_BuilderId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BuilderId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuilderSkills",
                table: "BuilderSkills");

            migrationBuilder.RenameTable(
                name: "BuilderSkills",
                newName: "WorkerSkills");

            migrationBuilder.RenameColumn(
                name: "BuilderId",
                table: "Users",
                newName: "WorkerID");

            migrationBuilder.RenameColumn(
                name: "BuilderId",
                table: "UserAnswer",
                newName: "WorkerID");

            migrationBuilder.RenameColumn(
                name: "BuilderId",
                table: "PostInvite",
                newName: "WorkerID");

            migrationBuilder.RenameIndex(
                name: "IX_PostInvite_BuilderId",
                table: "PostInvite",
                newName: "IX_PostInvite_WorkerID");

            migrationBuilder.RenameColumn(
                name: "BuilderID",
                table: "Group",
                newName: "WorkerID");

            migrationBuilder.RenameIndex(
                name: "IX_Group_BuilderID",
                table: "Group",
                newName: "IX_Group_WorkerID");

            migrationBuilder.RenameColumn(
                name: "BuilderID",
                table: "Commitment",
                newName: "WorkerID");

            migrationBuilder.RenameIndex(
                name: "IX_Commitment_BuilderID",
                table: "Commitment",
                newName: "IX_Commitment_WorkerID");

            migrationBuilder.RenameColumn(
                name: "BuilderID",
                table: "AppliedPost",
                newName: "WorkerID");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedPost_BuilderID",
                table: "AppliedPost",
                newName: "IX_AppliedPost_WorkerID");

            migrationBuilder.RenameColumn(
                name: "BuilderSkillID",
                table: "WorkerSkills",
                newName: "WorkerSkillID");

            migrationBuilder.RenameIndex(
                name: "IX_BuilderSkills_SkillID",
                table: "WorkerSkills",
                newName: "IX_WorkerSkills_SkillID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkerSkills",
                table: "WorkerSkills",
                columns: new[] { "WorkerSkillID", "SkillID" });

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "WorkerID", "PostID" },
                keyValues: new object[] { 4, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 105, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "WorkerID", "PostID" },
                keyValues: new object[] { 1, 3 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "WorkerID", "PostID" },
                keyValues: new object[] { 2, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "WorkerID", "PostID" },
                keyValues: new object[] { 3, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 105, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 74, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 81, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 89, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 97, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 105, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 105, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "9cf514d1-8b64-461e-8eca-eb2798eab7f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "849ce6b2-9f4c-45f3-9aa6-af054f1924f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "f581e98c-8df9-47f1-8141-25d837eb0fbe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "8358c969-d245-44e9-9880-0c44d571e1b9");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 104, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17c76dfe-7a0b-4ac9-ab8b-ba95e588a135"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "52d2e5ef-a219-4382-a57f-aca20c309408", new DateTime(2023, 4, 11, 14, 36, 5, 58, DateTimeKind.Local).AddTicks(2060), "AQAAAAEAACcQAAAAEHhlg1D8w/CqQZ1PCIylPnn0jrxCv0dxQjhzFTvHg5mej9LycHgeZ/Cg9YlAZObOuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("319d2a06-92cc-434d-abce-7e8a33650a0d"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "389542ab-38c5-4b29-84cc-659c9e71c78d", new DateTime(2023, 4, 11, 14, 36, 5, 42, DateTimeKind.Local).AddTicks(1114), "AQAAAAEAACcQAAAAEL9aCR+taPl/EVvwx9qZRldvZfKARi3vzkH6UV15dpFszAAsBgGr14toiY5SkXJcUg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86b8070e-00c5-45de-8db7-199cee7350d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "f7b1c0b5-29f0-4bc4-b7ce-77f65a7e6852", new DateTime(2023, 4, 11, 14, 36, 5, 81, DateTimeKind.Local).AddTicks(8403), "AQAAAAEAACcQAAAAELeIpFvF76JFjDAUzdPkMEcwBmLKRA2Lhn5gDAwBqrZeBXAQ+ql6E95GEvCA1ucU/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f314589-0c7c-40a4-b5bc-c73639664922"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "922edf7f-cce8-4ed3-8030-43c32bd03e08", new DateTime(2023, 4, 11, 14, 36, 5, 50, DateTimeKind.Local).AddTicks(2168), "AQAAAAEAACcQAAAAEBzWD478X45udh29gFPHWddBuxcIT/3CUzo9rhUfx967i+B1CtYdq+Or9ednZOxERQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "3d363dbf-6b01-4417-aaa5-671dcd3dbc30", new DateTime(2023, 4, 11, 14, 36, 5, 89, DateTimeKind.Local).AddTicks(4759), "AQAAAAEAACcQAAAAEJFttXaLPfuAW1ZEHALrXehoN7ngXKCOehkGYM6Tmy0DMdKMQX4pQeY1XsgRqwsEYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "b767134b-19a9-4f8c-89b1-2d82a83d487d", new DateTime(2023, 4, 11, 14, 36, 5, 97, DateTimeKind.Local).AddTicks(1584), "AQAAAAEAACcQAAAAEJnyvGGYJjqsdQvuyHkAr+/iKALIZNKtTJLpuOPkVFZ/bbjeSobZAM7I1l7a9Ftygw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "e9e84611-d8b4-4479-af23-6ad675aa7cd6", new DateTime(2023, 4, 11, 14, 36, 5, 23, DateTimeKind.Local).AddTicks(2099), "AQAAAAEAACcQAAAAEEr92CyPhVFDvA1Ule4rLokOnFUzyJf7z3RQ/x447C4gEzGJUMOhvCdkOI4NKG4Jmw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0efd537b-4270-4991-b06d-35189daa0d72", new DateTime(2023, 4, 11, 14, 36, 5, 74, DateTimeKind.Local).AddTicks(522), "AQAAAAEAACcQAAAAEKAf0LWiiWlRydPDYjcZ48isQqw5qo9nKCC/k45A0tBNvbGT8JWOk7GChQzUC8qVfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "ca32ce91-eab1-4c22-9d7a-8bf7aac54552", new DateTime(2023, 4, 11, 14, 36, 5, 66, DateTimeKind.Local).AddTicks(1968), "AQAAAAEAACcQAAAAELq+aDV1QCjna/83kJbhVtzhZ/MAb0KEZ98XAus2Sy9t6pIZgOzRYxebaGVUc0jEqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "dc69fe6f-656b-49ce-a817-e08be5ad217a", new DateTime(2023, 4, 11, 14, 36, 5, 14, DateTimeKind.Local).AddTicks(9373), "AQAAAAEAACcQAAAAEClVZSMk/5nR1rTYfp1d2y8CO3wxdPEe1cpP9ZPaUCqjhCohwQmdDSpZjRGQMhXIvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "210aa9c2-66fa-4188-bb8d-e615a6b42f4e", new DateTime(2023, 4, 11, 14, 36, 5, 7, DateTimeKind.Local).AddTicks(182), "AQAAAAEAACcQAAAAEN0I7HiXARCxKv+2aAOGZPvB/MliAmqFeUgxt/a9hXB9rueCTN48RjwMMnQkHPqoXw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "9322e50a-6f7c-413a-a639-132ed81ccf51", new DateTime(2023, 4, 11, 14, 36, 5, 31, DateTimeKind.Local).AddTicks(1545), "AQAAAAEAACcQAAAAECXdnYQ5j5tcXm2T7gRYtEVHB8nz0D+7oV5XLdCbJtsmpsUsMgFOWwoRUveFrhqWUg==" });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 23, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 31, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 41, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 50, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 58, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 36, 5, 66, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.CreateIndex(
                name: "IX_Users_WorkerID",
                table: "Users",
                column: "WorkerID",
                unique: true,
                filter: "[WorkerID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_Workers_WorkerID",
                table: "AppliedPost",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Workers_WorkerID",
                table: "Commitment",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Workers_WorkerID",
                table: "Group",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostInvite_Workers_WorkerID",
                table: "PostInvite",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_Workers_WorkerID",
                table: "UserAnswer",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Workers_WorkerID",
                table: "Users",
                column: "WorkerID",
                principalTable: "Workers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerSkills_Skills_SkillID",
                table: "WorkerSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerSkills_Workers_WorkerSkillID",
                table: "WorkerSkills",
                column: "WorkerSkillID",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedPost_Workers_WorkerID",
                table: "AppliedPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Commitment_Workers_WorkerID",
                table: "Commitment");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Workers_WorkerID",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_PostInvite_Workers_WorkerID",
                table: "PostInvite");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_Workers_WorkerID",
                table: "UserAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Workers_WorkerID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerSkills_Skills_SkillID",
                table: "WorkerSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerSkills_Workers_WorkerSkillID",
                table: "WorkerSkills");

            migrationBuilder.DropIndex(
                name: "IX_Users_WorkerID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkerSkills",
                table: "WorkerSkills");

            migrationBuilder.RenameTable(
                name: "WorkerSkills",
                newName: "BuilderSkills");

            migrationBuilder.RenameColumn(
                name: "WorkerID",
                table: "Users",
                newName: "BuilderId");

            migrationBuilder.RenameColumn(
                name: "WorkerID",
                table: "UserAnswer",
                newName: "BuilderId");

            migrationBuilder.RenameColumn(
                name: "WorkerID",
                table: "PostInvite",
                newName: "BuilderId");

            migrationBuilder.RenameIndex(
                name: "IX_PostInvite_WorkerID",
                table: "PostInvite",
                newName: "IX_PostInvite_BuilderId");

            migrationBuilder.RenameColumn(
                name: "WorkerID",
                table: "Group",
                newName: "BuilderID");

            migrationBuilder.RenameIndex(
                name: "IX_Group_WorkerID",
                table: "Group",
                newName: "IX_Group_BuilderID");

            migrationBuilder.RenameColumn(
                name: "WorkerID",
                table: "Commitment",
                newName: "BuilderID");

            migrationBuilder.RenameIndex(
                name: "IX_Commitment_WorkerID",
                table: "Commitment",
                newName: "IX_Commitment_BuilderID");

            migrationBuilder.RenameColumn(
                name: "WorkerID",
                table: "AppliedPost",
                newName: "BuilderID");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedPost_WorkerID",
                table: "AppliedPost",
                newName: "IX_AppliedPost_BuilderID");

            migrationBuilder.RenameColumn(
                name: "WorkerSkillID",
                table: "BuilderSkills",
                newName: "BuilderSkillID");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerSkills_SkillID",
                table: "BuilderSkills",
                newName: "IX_BuilderSkills_SkillID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuilderSkills",
                table: "BuilderSkills",
                columns: new[] { "BuilderSkillID", "SkillID" });

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 4, 1 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 1, 3 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 2, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "AppliedPost",
                keyColumns: new[] { "BuilderID", "PostID" },
                keyValues: new object[] { 3, 4 },
                column: "AppliedDate",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "ContractorPosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 348, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 355, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 363, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 370, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "MaterialStores",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Other",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"),
                column: "ConcurrencyStamp",
                value: "68afd27d-6182-45d1-8f51-56f680c76cd2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"),
                column: "ConcurrencyStamp",
                value: "8d770045-40be-4b1b-95f5-4b93492e9f2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"),
                column: "ConcurrencyStamp",
                value: "70517c28-6d80-45d5-8c39-1385e7788b80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"),
                column: "ConcurrencyStamp",
                value: "4c53019a-db1e-47b7-9838-a1c541b83fd2");

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 378, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17c76dfe-7a0b-4ac9-ab8b-ba95e588a135"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "e5c9a133-aa0e-44bf-808b-9d4f4bbc80d3", new DateTime(2023, 4, 11, 14, 20, 42, 333, DateTimeKind.Local).AddTicks(5452), "AQAAAAEAACcQAAAAEGqf0znfHH1hZYwNcTuTRR4xMSaMzvCleVG0ZW/xcPG8Pw321bGeCepWW9At+ELeEA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("319d2a06-92cc-434d-abce-7e8a33650a0d"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "3690350b-a5a7-4fa3-9557-aab53b0954dd", new DateTime(2023, 4, 11, 14, 20, 42, 318, DateTimeKind.Local).AddTicks(2543), "AQAAAAEAACcQAAAAEKyuXcEmxEdyqSqV7SaJzKOL9KWJ/QeD1XCgx6foCAuXoT2lPcQMGejQNmuGZl0VHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86b8070e-00c5-45de-8db7-199cee7350d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "40fa85fa-f661-48e5-828f-3b0ddbac3dac", new DateTime(2023, 4, 11, 14, 20, 42, 355, DateTimeKind.Local).AddTicks(9308), "AQAAAAEAACcQAAAAEJVJlpwMOLCEqG7kdi4H/fc2wmhykUMT8JxnEm/bY/52bh1nKw3qx1AcprP84vUN9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f314589-0c7c-40a4-b5bc-c73639664922"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "deee18f5-bb4b-46f3-b9d0-e0ebba684b41", new DateTime(2023, 4, 11, 14, 20, 42, 325, DateTimeKind.Local).AddTicks(8974), "AQAAAAEAACcQAAAAEBZ+bgrAVsfKMsula5X3g2/xf3yPJVqznlHvFzAiIRoDB16xz7fuJMbM7D4637dOEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "d21e70c2-3bba-4728-837d-167550c6e7e0", new DateTime(2023, 4, 11, 14, 20, 42, 363, DateTimeKind.Local).AddTicks(3775), "AQAAAAEAACcQAAAAEDe8h8MS35ajei85erNclR9ExCU38PcbcYai5CCwVaPE3jao+Od/jRMmSh7uyAwoNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be21b564-a044-11ed-a8fc-0242ac120002"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "6f2d3a28-2c2b-4adb-80b2-d946a22b602a", new DateTime(2023, 4, 11, 14, 20, 42, 370, DateTimeKind.Local).AddTicks(8400), "AQAAAAEAACcQAAAAEIvnsfE1KxycrgSvPrBao4CEfEExXRMwJeFFI2C5ucUKDWmpRJxiVrEj8NGjssOvMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "c6e00883-7946-4fb8-8180-60b2742e51a1", new DateTime(2023, 4, 11, 14, 20, 42, 302, DateTimeKind.Local).AddTicks(9283), "AQAAAAEAACcQAAAAEC+Ngu0zNiWLngOR5To3+Dp+4knfqG0+rR1LkIEjAlZu8Lec8gVAMEbbflAEUmsV8g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "0bd0915b-cb61-4055-ac00-3661c67861b0", new DateTime(2023, 4, 11, 14, 20, 42, 348, DateTimeKind.Local).AddTicks(5022), "AQAAAAEAACcQAAAAEIOndq7pbjvO//NRz/b+Rx7CV3Jgj/+EXnV8lC8dFW68iXXr+PxQZmRuzQ4ho+SqMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "97cf7ece-aff0-496c-af2c-192aa76ff8fc", new DateTime(2023, 4, 11, 14, 20, 42, 341, DateTimeKind.Local).AddTicks(382), "AQAAAAEAACcQAAAAEIOsjF/JI2J+KCL4ySwv/6QooHqc1oW2fjdBr0ejrH2lEgDrcxlAW3ee1HJQRsPrNg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "97ef71b2-6e87-48ea-9ac4-7ff62986a470", new DateTime(2023, 4, 11, 14, 20, 42, 295, DateTimeKind.Local).AddTicks(2386), "AQAAAAEAACcQAAAAEMYzQdj0YOtlF0c39mT/jP7T4qS2r+vJcSMoipN8CzuwrN2JgVWZCDG5ug4G27rWkA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "5f2b76c9-4466-4993-9199-ab26ed454b3a", new DateTime(2023, 4, 11, 14, 20, 42, 287, DateTimeKind.Local).AddTicks(5622), "AQAAAAEAACcQAAAAEHtTJRx0LxFoEAmjdzl8yMaiDVdHe7UDoSvZRqakNqNFPlIn9mF+kuoYeRj32yvAXQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"),
                columns: new[] { "ConcurrencyStamp", "LastModifiedAt", "PasswordHash" },
                values: new object[] { "965ad311-e0bc-4a4e-9b45-c58df1d305fd", new DateTime(2023, 4, 11, 14, 20, 42, 310, DateTimeKind.Local).AddTicks(5757), "AQAAAAEAACcQAAAAECM0x6xL5htya7g9BpTYf5BNnat3ShT6axCL8NIr+4uhkK+FtOPGVTq8kFNBvo3gsQ==" });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 302, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 310, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 318, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 325, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 333, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedAt",
                value: new DateTime(2023, 4, 11, 14, 20, 42, 341, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.CreateIndex(
                name: "IX_Users_BuilderId",
                table: "Users",
                column: "BuilderId",
                unique: true,
                filter: "[BuilderId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedPost_Workers_BuilderID",
                table: "AppliedPost",
                column: "BuilderID",
                principalTable: "Workers",
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
                name: "FK_BuilderSkills_Workers_BuilderSkillID",
                table: "BuilderSkills",
                column: "BuilderSkillID",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commitment_Workers_BuilderID",
                table: "Commitment",
                column: "BuilderID",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Workers_BuilderID",
                table: "Group",
                column: "BuilderID",
                principalTable: "Workers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostInvite_Workers_BuilderId",
                table: "PostInvite",
                column: "BuilderId",
                principalTable: "Workers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_Workers_BuilderId",
                table: "UserAnswer",
                column: "BuilderId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Workers_BuilderId",
                table: "Users",
                column: "BuilderId",
                principalTable: "Workers",
                principalColumn: "Id");
        }
    }
}
