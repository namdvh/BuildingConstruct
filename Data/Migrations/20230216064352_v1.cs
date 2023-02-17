using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentitficationCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaceImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentitficationCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ContractorPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benefit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Required = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<int>(type: "int", nullable: false),
                    PostCategories = table.Column<int>(type: "int", nullable: false),
                    Salaries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    NumberPeople = table.Column<int>(type: "int", nullable: false),
                    PeopeRemained = table.Column<int>(type: "int", nullable: false),
                    isApplied = table.Column<bool>(type: "bit", nullable: true),
                    ContractorID = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractorPosts_Contractors_ContractorID",
                        column: x => x.ContractorID,
                        principalTable: "Contractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractorId = table.Column<int>(type: "int", nullable: true),
                    StoreID = table.Column<int>(type: "int", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bill_MaterialStores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "MaterialStores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitInStock = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoldQuantities = table.Column<int>(type: "int", nullable: false),
                    MaterialStoreID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_MaterialStores_MaterialStoreID",
                        column: x => x.MaterialStoreID,
                        principalTable: "MaterialStores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Builders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: true),
                    Place = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Builders_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromSystem = table.Column<bool>(type: "bit", nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractorPostType",
                columns: table => new
                {
                    ContractorPostID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorPostType", x => new { x.TypeID, x.ContractorPostID });
                    table.ForeignKey(
                        name: "FK_ContractorPostType_ContractorPosts_ContractorPostID",
                        column: x => x.ContractorPostID,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractorPostType_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SmallBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmallBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmallBills_Bill_BillID",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    CategoriesID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductID, x.CategoriesID });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoriesID",
                        column: x => x.CategoriesID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    BillID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Bill_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuilderPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCategories = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salaries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    BuilderID = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuilderPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuilderPosts_Builders_BuilderID",
                        column: x => x.BuilderID,
                        principalTable: "Builders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuilderID = table.Column<int>(type: "int", nullable: false),
                    PostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Builders_BuilderID",
                        column: x => x.BuilderID,
                        principalTable: "Builders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VerifyID = table.Column<int>(type: "int", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractorId = table.Column<int>(type: "int", nullable: true),
                    BuilderId = table.Column<int>(type: "int", nullable: true),
                    MaterialStoreID = table.Column<int>(type: "int", nullable: true),
                    Provider = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Builders_BuilderId",
                        column: x => x.BuilderId,
                        principalTable: "Builders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_IdentitficationCards_VerifyID",
                        column: x => x.VerifyID,
                        principalTable: "IdentitficationCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_MaterialStores_MaterialStoreID",
                        column: x => x.MaterialStoreID,
                        principalTable: "MaterialStores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BuilderSkills",
                columns: table => new
                {
                    BuilderSkillID = table.Column<int>(type: "int", nullable: false),
                    SkillID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuilderSkills", x => new { x.BuilderSkillID, x.SkillID });
                    table.ForeignKey(
                        name: "FK_BuilderSkills_Builders_BuilderSkillID",
                        column: x => x.BuilderSkillID,
                        principalTable: "Builders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuilderSkills_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractorPostSkills",
                columns: table => new
                {
                    ContractorPostID = table.Column<int>(type: "int", nullable: false),
                    SkillID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorPostSkills", x => new { x.SkillID, x.ContractorPostID });
                    table.ForeignKey(
                        name: "FK_ContractorPostSkills_ContractorPosts_ContractorPostID",
                        column: x => x.ContractorPostID,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractorPostSkills_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillID = table.Column<int>(type: "int", nullable: true),
                    SmallBillID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetail_Bill_BillID",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillDetail_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillDetail_SmallBills_SmallBillID",
                        column: x => x.SmallBillID,
                        principalTable: "SmallBills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BuilderPostSkill",
                columns: table => new
                {
                    BuilderPostID = table.Column<int>(type: "int", nullable: false),
                    SkillID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuilderPostSkill", x => new { x.SkillID, x.BuilderPostID });
                    table.ForeignKey(
                        name: "FK_BuilderPostSkill_BuilderPosts_BuilderPostID",
                        column: x => x.BuilderPostID,
                        principalTable: "BuilderPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuilderPostSkill_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuilderPostType",
                columns: table => new
                {
                    BuilderPostID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuilderPostType", x => new { x.TypeID, x.BuilderPostID });
                    table.ForeignKey(
                        name: "FK_BuilderPostType_BuilderPosts_BuilderPostID",
                        column: x => x.BuilderPostID,
                        principalTable: "BuilderPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuilderPostType_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppliedPost",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false),
                    BuilderID = table.Column<int>(type: "int", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AppliedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliedPost", x => new { x.PostID, x.BuilderID });
                    table.ForeignKey(
                        name: "FK_AppliedPost_Builders_BuilderID",
                        column: x => x.BuilderID,
                        principalTable: "Builders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppliedPost_ContractorPosts_PostID",
                        column: x => x.PostID,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppliedPost_Group_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Group",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupMember_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupMember_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.UserID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commitment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    BuilderID = table.Column<int>(type: "int", nullable: false),
                    ContractorID = table.Column<int>(type: "int", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: true),
                    OptionalTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salaries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commitment", x => new { x.Id, x.PostID, x.BuilderID, x.ContractorID });
                    table.ForeignKey(
                        name: "FK_Commitment_Builders_BuilderID",
                        column: x => x.BuilderID,
                        principalTable: "Builders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commitment_ContractorPosts_PostID",
                        column: x => x.PostID,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commitment_Contractors_ContractorID",
                        column: x => x.ContractorID,
                        principalTable: "Contractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commitment_Group_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Group",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Commitment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorPostId = table.Column<int>(type: "int", nullable: true),
                    BuilderPostId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saves", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_Saves_BuilderPosts_BuilderPostId",
                        column: x => x.BuilderPostId,
                        principalTable: "BuilderPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Saves_ContractorPosts_ContractorPostId",
                        column: x => x.ContractorPostId,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Saves_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Builders",
                columns: new[] { "Id", "Certificate", "CreateBy", "Experience", "ExperienceDetail", "LastModifiedAt", "Place", "TypeID" },
                values: new object[,]
                {
                    { 1, null, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), null, null, new DateTime(2023, 2, 16, 13, 43, 51, 470, DateTimeKind.Local).AddTicks(1912), 60, null },
                    { 2, null, new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"), null, null, new DateTime(2023, 2, 16, 13, 43, 51, 476, DateTimeKind.Local).AddTicks(2088), 61, null }
                });

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "CompanyName", "CreateBy", "Description", "LastModifiedAt", "Website" },
                values: new object[,]
                {
                    { 1, null, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), null, new DateTime(2023, 2, 16, 13, 43, 51, 482, DateTimeKind.Local).AddTicks(2090), null },
                    { 2, null, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), null, new DateTime(2023, 2, 16, 13, 43, 51, 488, DateTimeKind.Local).AddTicks(2691), null }
                });

            migrationBuilder.InsertData(
                table: "MaterialStores",
                columns: new[] { "Id", "CreateBy", "Description", "Experience", "Image", "LastModifiedAt", "Place", "TaxCode", "Website" },
                values: new object[,]
                {
                    { 1, new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"), "Với mục tiêu cung cấp nhiều gói sản phẩm phong phú về mẫu mã và các tính năng linh hoạt cho nhiều loại hình website như giới thiệu công ty, bán hàng, trang tin tức, thương mại điện tử… cùng với nhiều giao diện phong phú đa dạng độc đáo đã được VNS lọc chọn và đúc kết nhằm giới thiệu tới khách hàng với mong muốn có một website nhanh, đẹp, hiệu quả và giá cả hợp lý.", null, null, new DateTime(2023, 2, 16, 13, 43, 51, 494, DateTimeKind.Local).AddTicks(2688), 0, null, "https://vinasoftware.com.vn/" },
                    { 2, new Guid("be21b564-a044-11ed-a8fc-0242ac120002"), null, null, null, new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2765), 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), "65571474-8e3e-4d8b-aa95-691b02e672ba", "Contractor", "Contractor", "CONTRACTOR" },
                    { new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"), "06dfe791-4dc5-4a4f-85fb-270498e3929b", "Admin", "Admin", "ADMIN" },
                    { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), "11d7e0e5-e3d5-4ce7-be20-aa2c813a2533", "Store", "Store", "STORE" },
                    { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), "344d553f-a0ab-4157-909f-55137899a4c4", "User", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0"), "Thợ xây" },
                    { new Guid("bd880489-5c76-4854-93ab-66e3a541bf24"), "Thợ hồ" },
                    { new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3"), "Thợ sơn" },
                    { new Guid("cf9fa65b-d005-46b6-953e-e6462a59cfb3"), "Thợ hàn" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("b57b172a-a044-11ed-a8fc-0242ac120002") },
                    { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), new Guid("be21b564-a044-11ed-a8fc-0242ac120002") },
                    { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6") },
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7") },
                    { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9") }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "ContractorId", "CreateBy", "EndDate", "LastModifiedAt", "Note", "PaymentDate", "StartDate", "Status", "StoreID", "TotalPrice", "Type" },
                values: new object[,]
                {
                    { 1, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3061), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", null, null, 3, 1, 2000m, 0 },
                    { 2, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3112), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", null, null, 3, 1, 2000m, 1 }
                });

            migrationBuilder.InsertData(
                table: "BuilderPosts",
                columns: new[] { "Id", "BuilderID", "CreateBy", "Description", "LastModifiedAt", "Place", "PostCategories", "Salaries", "Status", "Title", "Views" },
                values: new object[,]
                {
                    { 1, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3020), 52, 1, "10.000.000 - 15.000.000", 3, "Ứng Tuyển Công Ty Xây Dựng 1", 0 },
                    { 2, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3031), 50, 2, "10.000.000 - 15.000.000", 3, "Ứng Tuyển Công Ty Xây Dựng 2", 0 },
                    { 3, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3039), 51, 1, "10.000.000 - 15.000.000", 3, "Ứng Tuyển Công Ty Xây Dựng 3", 0 }
                });

            migrationBuilder.InsertData(
                table: "ContractorPosts",
                columns: new[] { "Id", "Benefit", "ContractorID", "CreateBy", "Description", "EndDate", "LastModifiedAt", "NumberPeople", "PeopeRemained", "Place", "PostCategories", "ProjectName", "Required", "Salaries", "StarDate", "Status", "Title", "ViewCount", "isApplied" },
                values: new object[,]
                {
                    { 1, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2899), 20, 0, 52, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10.000.000 - 15.000.000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tuyển dụng công nhân xây dựng", 0, null },
                    { 2, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2912), 20, 0, 52, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10.000.000 - 15.000.000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tuyển dụng công nhân xây dựng", 0, null },
                    { 3, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2928), 20, 0, 52, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10.000.000 - 15.000.000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tuyển dụng công nhân xây dựng", 0, null },
                    { 4, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2937), 20, 0, 20, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10.000.000 - 15.000.000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tuyển dụng công nhân xây dựng", 0, null },
                    { 5, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2945), 30, 0, 14, 2, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10.000.000 - 15.000.000", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tuyển dụng công nhân xây dựng", 0, null },
                    { 6, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(2956), 30, 0, 14, 2, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10.000.000 - 15.000.000", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tuyển dụng công nhân xây dựng", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CreatedBy", "Description", "Image", "MaterialStoreID", "Name", "SoldQuantities", "Unit", "UnitInStock", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Pháp", null, "Ngói lợp kiểu Pháp cổ điển", "https://hailongtiles.com/sites/default/files/styles/213x213/public/sanphamlamphuc/092021/ngoi_mui_hai_lop_biet_thu_phap.jpg?itok=Bc8v69y6", 1, "Ngói lợp", 3000, "ton", 300000, 700m },
                    { 2, "Việt Nam", null, "Gạch 2 lỗ", "data:image/jpeg;base64,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", 1, "Gạch lỗ", 1500, "ton", 300000, 500m },
                    { 3, "Mỹ", null, "Sơn chống thấm Nippon", "https://nipponpaint.com.vn/sites/default/files/inline-images/son-chong-tham-la-gi-1.jpg", 1, "Sơn chống thấm", 1500, "ton", 2000, 1000000m },
                    { 4, "Việt Nam", null, "Cát mịn dành cho xây dựng", "https://sbshouse.vn/wp-content/uploads/2020/09/cat-xay-dung.jpg", 1, "Cát Mịn", 50, "ton", 200000, 100m },
                    { 5, "Việt Nam", null, "Xi măng Hà Tiên", "http://ximang.vn/Upload/48/Nam_2022/Thang_5/Ngay_31/ximang_vicemhatien1.jpg", 2, "Xi măng Hà Tiên", 300, "ton", 5000, 80000m },
                    { 6, "Việt Nam", null, "Gạch 4 lỗ", "data:image/jpeg;base64,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", 2, "Gạch 4 lỗ", 2000, "ton", 500000, 600m },
                    { 7, "Pháp", null, "Gạch hoa lát cổ điển, màu trắng đen tương thích với các kiến trúc cổ", "http://anhduongphat.vn/wp-content/uploads/2020/03/gach-bong-trang-tri-hoa-van.jpg", 1, "Gạch Hoa Cổ Điển", 1500, "ton", 30000, 50000m },
                    { 20, "Kangaroo", null, "Description 1", null, 1, "Product 1", 100, "ton", 1000, 4000m },
                    { 21, "Sony", null, "Description 2", null, 1, "Product 2", 1000, "ton", 1200, 5000m },
                    { 22, "Samsung", null, "Description 3", null, 1, "Product 3", 100, "ton", 100, 6000m }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "FromSystem", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, true, "Xây dựng", new Guid("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0") },
                    { 2, true, "Sơn tường", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") },
                    { 3, true, "Lát gạch", new Guid("bd880489-5c76-4854-93ab-66e3a541bf24") },
                    { 4, true, "Thạch Cao", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Provider", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName", "VerifyID" },
                values: new object[,]
                {
                    { new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"), 0, "Q2", null, null, "56f1a4aa-820a-4365-9531-7882be5626f7", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "store@gmail.com", false, "Store", 0, null, new DateTime(2023, 2, 16, 13, 43, 51, 488, DateTimeKind.Local).AddTicks(2705), "Store", false, null, 1, null, null, "AQAAAAEAACcQAAAAEOOX44ufwSnNRNwBQUK9tfJJHOnMrqa9iNH7nqfOFsPaByFax+Gc8hV69GfSevWJAg==", "0924516734", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "0924516734", null },
                    { new Guid("be21b564-a044-11ed-a8fc-0242ac120002"), 0, "Q2", null, null, "0050a252-bf04-4705-beb7-6aa9d52dde94", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "store2@gmail.com", false, "Store2", 0, null, new DateTime(2023, 2, 16, 13, 43, 51, 494, DateTimeKind.Local).AddTicks(2702), "Store2", false, null, 2, null, null, "AQAAAAEAACcQAAAAENUGzbx8Ra7rfKs8UfkKtoBpfUw+tW8hg1/Ij64Kmss1/HoraippWc9LNW4/L7kPjg==", "09245167342", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "09245167342", null },
                    { new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"), 0, "18, Phuoc Thien, Nhon Trach, Dong Nai", null, 2, "d3f4943d-99b1-49e8-8d2e-bdda16b9f4c9", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhoaidoan1@gmail.com", false, "Thinh", 0, null, new DateTime(2023, 2, 16, 13, 43, 51, 470, DateTimeKind.Local).AddTicks(1932), "Nguyen", false, null, null, null, null, "AQAAAAEAACcQAAAAEBCQwE+nJbBdQ5My3SW/gfxD/ARe4jOyUEwE10lvMG/5Rcacinhbh34ifKQgWR02cg==", "0937341639", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "namhoaidoan1@gmail.com", null },
                    { new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), 0, "Q2", "https://www.vietnamworks.com/_next/image?url=https%3A%2F%2Fimages.vietnamworks.com%2Fpictureofcompany%2F69%2F11128477.png&w=128&q=75", null, "d7cc3cdf-9bed-4986-bf37-f30124f674d5", 2, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "contractor2@gmail.com", false, "Công Ty Cổ Phần Đầu Tư Bất Động Sản", 0, null, new DateTime(2023, 2, 16, 13, 43, 51, 482, DateTimeKind.Local).AddTicks(2106), "Taseco", false, null, null, null, null, "AQAAAAEAACcQAAAAEMJEMdpTp370MNow+hn4fijEgfyDbC63YpXjEXQukbsY1B6Ml3TAq3preCxphMXGpg==", "09987654321", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "0987654321", null },
                    { new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), 0, "Q2", "https://www.vietnamworks.com/_next/image?url=https%3A%2F%2Fimages.vietnamworks.com%2Fpictureofcompany%2F78%2F11127264.png&w=128&q=75", null, "a0f237a4-c300-402a-adf0-35ce001a2f7c", 1, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "contractor@gmail.com", false, "Công Ty Cổ Phần Xây Dựng Và Công Nghiệp", 0, null, new DateTime(2023, 2, 16, 13, 43, 51, 476, DateTimeKind.Local).AddTicks(2099), "NSN", false, null, null, null, null, "AQAAAAEAACcQAAAAEB80z7g5KTykdGU5LeX0vc68K3BfD/zTWLympVVGRnzrMat+W9DSvHHYNWRV44o7nA==", "0912345678", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "0912345678", null },
                    { new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), 0, "18, Phuoc Thien, Nhon Trach, Dong Nai", null, 1, "cbd2f3b2-ce7e-49ca-be5a-52a5737bb70c", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhoaidoan15@gmail.com", false, "Hoai", 0, null, new DateTime(2023, 2, 16, 13, 43, 51, 464, DateTimeKind.Local).AddTicks(728), "Nam", false, null, null, null, null, "AQAAAAEAACcQAAAAEE5dhCFOoEJRpcJCQEaLwNi7YA/ZWogU2PU3wh0qFRtu9w75u0FToUh5LcT2cVkDPQ==", "0879411575", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, "xxx", false, "namhoaidoan15@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "Id", "BillID", "Price", "ProductID", "Quantity", "SmallBillID" },
                values: new object[,]
                {
                    { 1, 1, 20000m, 20, 5, null },
                    { 2, 1, 150000m, 21, 8, null },
                    { 3, 1, 45000m, 22, 7, null }
                });

            migrationBuilder.InsertData(
                table: "SmallBills",
                columns: new[] { "Id", "BillID", "EndDate", "PaymentDate", "StartDate", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3123), null, new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3124), 3, 20000m },
                    { 2, 2, new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3133), null, new DateTime(2023, 2, 16, 13, 43, 51, 500, DateTimeKind.Local).AddTicks(3135), 3, 45000m }
                });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "Id", "BillID", "Price", "ProductID", "Quantity", "SmallBillID" },
                values: new object[] { 5, 2, 20000m, 1, 5, 1 });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "Id", "BillID", "Price", "ProductID", "Quantity", "SmallBillID" },
                values: new object[] { 6, 2, 150000m, 2, 8, 1 });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "Id", "BillID", "Price", "ProductID", "Quantity", "SmallBillID" },
                values: new object[] { 7, 2, 45000m, 3, 7, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AppliedPost_BuilderID",
                table: "AppliedPost",
                column: "BuilderID");

            migrationBuilder.CreateIndex(
                name: "IX_AppliedPost_GroupID",
                table: "AppliedPost",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ContractorId",
                table: "Bill",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_StoreID",
                table: "Bill",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_BillID",
                table: "BillDetail",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_ProductID",
                table: "BillDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_SmallBillID",
                table: "BillDetail",
                column: "SmallBillID");

            migrationBuilder.CreateIndex(
                name: "IX_BuilderPosts_BuilderID",
                table: "BuilderPosts",
                column: "BuilderID");

            migrationBuilder.CreateIndex(
                name: "IX_BuilderPostSkill_BuilderPostID",
                table: "BuilderPostSkill",
                column: "BuilderPostID");

            migrationBuilder.CreateIndex(
                name: "IX_BuilderPostType_BuilderPostID",
                table: "BuilderPostType",
                column: "BuilderPostID");

            migrationBuilder.CreateIndex(
                name: "IX_Builders_TypeID",
                table: "Builders",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BuilderSkills_SkillID",
                table: "BuilderSkills",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductID",
                table: "Carts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Commitment_BuilderID",
                table: "Commitment",
                column: "BuilderID");

            migrationBuilder.CreateIndex(
                name: "IX_Commitment_ContractorID",
                table: "Commitment",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Commitment_GroupID",
                table: "Commitment",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Commitment_PostID",
                table: "Commitment",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Commitment_UserId",
                table: "Commitment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorPosts_ContractorID",
                table: "ContractorPosts",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorPostSkills_ContractorPostID",
                table: "ContractorPostSkills",
                column: "ContractorPostID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorPostType_ContractorPostID",
                table: "ContractorPostType",
                column: "ContractorPostID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_BuilderID",
                table: "Group",
                column: "BuilderID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_GroupId",
                table: "GroupMember",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_TypeID",
                table: "GroupMember",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserID",
                table: "Notifications",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoriesID",
                table: "ProductCategories",
                column: "CategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MaterialStoreID",
                table: "Products",
                column: "MaterialStoreID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductID",
                table: "ProductTypes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Saves_BuilderPostId",
                table: "Saves",
                column: "BuilderPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Saves_ContractorPostId",
                table: "Saves",
                column: "ContractorPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Saves_UserId",
                table: "Saves",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TypeId",
                table: "Skills",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SmallBills_BillID",
                table: "SmallBills",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BuilderId",
                table: "Users",
                column: "BuilderId",
                unique: true,
                filter: "[BuilderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ContractorId",
                table: "Users",
                column: "ContractorId",
                unique: true,
                filter: "[ContractorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MaterialStoreID",
                table: "Users",
                column: "MaterialStoreID",
                unique: true,
                filter: "[MaterialStoreID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_VerifyID",
                table: "Users",
                column: "VerifyID",
                unique: true,
                filter: "[VerifyID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppliedPost");

            migrationBuilder.DropTable(
                name: "BillDetail");

            migrationBuilder.DropTable(
                name: "BuilderPostSkill");

            migrationBuilder.DropTable(
                name: "BuilderPostType");

            migrationBuilder.DropTable(
                name: "BuilderSkills");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Commitment");

            migrationBuilder.DropTable(
                name: "ContractorPostSkills");

            migrationBuilder.DropTable(
                name: "ContractorPostType");

            migrationBuilder.DropTable(
                name: "GroupMember");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Saves");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "SmallBills");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "BuilderPosts");

            migrationBuilder.DropTable(
                name: "ContractorPosts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Builders");

            migrationBuilder.DropTable(
                name: "IdentitficationCards");

            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.DropTable(
                name: "MaterialStores");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
