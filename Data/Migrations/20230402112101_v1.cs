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
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionType", x => x.Id);
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
                    Place = table.Column<int>(type: "int", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Other",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Other", x => x.Id);
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
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
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
                    QuizRequired = table.Column<bool>(type: "bit", nullable: false),
                    ConstructionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accommodation = table.Column<bool>(type: "bit", nullable: false),
                    Transport = table.Column<bool>(type: "bit", nullable: false),
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
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitInStock = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoldQuantities = table.Column<int>(type: "int", nullable: false),
                    MaterialStoreID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<int>(type: "int", nullable: true),
                    ConstructionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quiz_ContractorPosts_PostID",
                        column: x => x.PostID,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quiz_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "Id");
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
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductTypes_Other_OtherID",
                        column: x => x.OtherID,
                        principalTable: "Other",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductTypes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Size_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Size",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorPostId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ReportProblem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_ContractorPosts_ContractorPostId",
                        column: x => x.ContractorPostId,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
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
                name: "PostInvite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorId = table.Column<int>(type: "int", nullable: true),
                    BuilderId = table.Column<int>(type: "int", nullable: true),
                    ContractorPostId = table.Column<int>(type: "int", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostInvite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostInvite_Builders_BuilderId",
                        column: x => x.BuilderId,
                        principalTable: "Builders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostInvite_ContractorPosts_ContractorPostId",
                        column: x => x.ContractorPostId,
                        principalTable: "ContractorPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostInvite_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
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
                        name: "FK_Users_MaterialStores_MaterialStoreID",
                        column: x => x.MaterialStoreID,
                        principalTable: "MaterialStores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkerContructionTypes",
                columns: table => new
                {
                    ConstructionTypeId = table.Column<int>(type: "int", nullable: false),
                    BuilderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerContructionTypes", x => new { x.ConstructionTypeId, x.BuilderId });
                    table.ForeignKey(
                        name: "FK_WorkerContructionTypes_Builders_BuilderId",
                        column: x => x.BuilderId,
                        principalTable: "Builders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerContructionTypes_ConstructionType_ConstructionTypeId",
                        column: x => x.ConstructionTypeId,
                        principalTable: "ConstructionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
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
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_BillDetail_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
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
                    WishSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    QuizId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_AppliedPost_Quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
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
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    SkillAssessment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BehaviourAssessment = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.UserID, x.ProductID, x.Id });
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_ProductTypes_TypeID",
                        column: x => x.TypeID,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
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
                name: "IdentitficationCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaceImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdentificateType = table.Column<int>(type: "int", nullable: false),
                    PreCodition = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentitficationCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentitficationCards_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavigateId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRefund = table.Column<bool>(type: "bit", nullable: false),
                    VnPayResponseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Users_UserId",
                        column: x => x.UserId,
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saves", x => new { x.Id, x.UserId });
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

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswer",
                columns: table => new
                {
                    BuilderId = table.Column<int>(type: "int", nullable: false),
                    AnswerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswer", x => new { x.BuilderId, x.AnswerID });
                    table.ForeignKey(
                        name: "FK_UserAnswer_Answers_AnswerID",
                        column: x => x.AnswerID,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswer_Builders_BuilderId",
                        column: x => x.BuilderId,
                        principalTable: "Builders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Xuất xứ" },
                    { 2, "Chất liệu" },
                    { 3, "Phong cách " },
                    { 4, "Vị trí " }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Image", "LastModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3850), "No Color" },
                    { 6, null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2946), "Màu vàng" },
                    { 7, null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2980), "Màu xám" }
                });

            migrationBuilder.InsertData(
                table: "ConstructionType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nhà ở" },
                    { 2, "Chung cư " },
                    { 3, "Công trình công cộng" }
                });

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "Id", "CompanyName", "CreateBy", "Description", "LastModifiedAt", "Website" },
                values: new object[,]
                {
                    { 1, null, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), null, new DateTime(2023, 4, 2, 18, 21, 1, 46, DateTimeKind.Local).AddTicks(4424), null },
                    { 2, null, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), null, new DateTime(2023, 4, 2, 18, 21, 1, 48, DateTimeKind.Local).AddTicks(116), null }
                });

            migrationBuilder.InsertData(
                table: "MaterialStores",
                columns: new[] { "Id", "CreateBy", "Description", "Experience", "Image", "LastModifiedAt", "Place", "TaxCode", "Website" },
                values: new object[,]
                {
                    { 1, new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"), "Với mục tiêu cung cấp nhiều gói sản phẩm phong phú về mẫu mã và các tính năng linh hoạt cho nhiều loại hình website như giới thiệu công ty, bán hàng, trang tin tức, thương mại điện tử… cùng với nhiều giao diện phong phú đa dạng độc đáo đã được VNS lọc chọn và đúc kết nhằm giới thiệu tới khách hàng với mong muốn có một website nhanh, đẹp, hiệu quả và giá cả hợp lý.", null, null, new DateTime(2023, 4, 2, 18, 21, 1, 49, DateTimeKind.Local).AddTicks(5689), null, null, "https://vinasoftware.com.vn/" },
                    { 2, new Guid("be21b564-a044-11ed-a8fc-0242ac120002"), null, null, null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(1670), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Other",
                columns: new[] { "Id", "Image", "LastModifiedAt", "Name" },
                values: new object[] { 1, null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3883), "No Other" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20efd516-f16c-41b3-b11d-bc908cd2056b"), "39357fb8-2bb8-4a2e-9193-7291044a19b5", "Contractor", "Contractor", "CONTRACTOR" },
                    { new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"), "850d412e-a6a4-4998-8644-3c1824bd8661", "Admin", "Admin", "ADMIN" },
                    { new Guid("a4fbc29e-9749-4ea0-bcaa-67fc9f104bd1"), "7545b5bf-0a38-4a34-8834-d36c79c5922e", "Store", "Store", "STORE" },
                    { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), "f059c2a6-78aa-48f6-940e-aa1bbf88987b", "User", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "LastModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3863), "No Size" },
                    { 2, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2538), "4.5L" },
                    { 3, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2555), "7.5L" },
                    { 4, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2994), "5M" },
                    { 5, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3007), "10M" },
                    { 7, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3458), "5L" },
                    { 8, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3473), "18L" }
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
                    { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9") },
                    { new Guid("52ec6e78-6732-43bf-adab-9cfa2e5da268"), new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9") },
                    { new Guid("dc48ba58-ddcb-41de-96fe-e41327e5f313"), new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Provider", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d7285fb7-835b-4680-a18c-673bd71f63e9"), 0, "18 Tô Ký , Huyện Châu Thành , Đà Nẵng", "https://i1-giaitri.vnecdn.net/2013/08/15/DK-02756-1376528749.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=mX89l0q4HQgntQ5wJesOcw", null, "08003b93-36e4-4858-bb2f-6e57007f7eed", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin15@gmail.com", false, "Admin", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 38, DateTimeKind.Local).AddTicks(4289), "Admin", false, null, null, null, null, "AQAAAAEAACcQAAAAENNi9E+TJTh6F7ZARJqcU7buOwW8c7T1+DYL/Ih8OWnx1jB6j2O63n4Cy25m99dOYQ==", "0909090909", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "admin15@gmail.com" });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "ContractorId", "CreateBy", "EndDate", "LastModifiedAt", "Note", "PaymentDate", "Reason", "StartDate", "Status", "StoreID", "TotalPrice", "Type" },
                values: new object[,]
                {
                    { 1, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), new DateTime(2023, 4, 7, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3670), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", null, null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3669), 5, 1, 500000m, 0 },
                    { 2, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), new DateTime(2023, 4, 7, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3745), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", null, null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3744), 5, 1, 60000000m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Builders",
                columns: new[] { "Id", "Certificate", "ConstructionType", "CreateBy", "Experience", "ExperienceDetail", "Image", "LastModifiedAt", "Place", "TypeID" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), null, null, null, new DateTime(2023, 4, 2, 18, 21, 1, 41, DateTimeKind.Local).AddTicks(6792), 60, new Guid("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0") },
                    { 2, null, null, new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"), null, null, null, new DateTime(2023, 4, 2, 18, 21, 1, 43, DateTimeKind.Local).AddTicks(2649), 61, new Guid("bd880489-5c76-4854-93ab-66e3a541bf24") },
                    { 3, null, null, new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"), null, null, null, new DateTime(2023, 4, 2, 18, 21, 1, 44, DateTimeKind.Local).AddTicks(8770), 61, new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") }
                });

            migrationBuilder.InsertData(
                table: "ContractorPosts",
                columns: new[] { "Id", "Accommodation", "Benefit", "ConstructionType", "ContractorID", "CreateBy", "Description", "EndDate", "EndTime", "LastModifiedAt", "NumberPeople", "PeopeRemained", "Place", "PostCategories", "ProjectName", "QuizRequired", "Required", "Salaries", "StarDate", "StartTime", "Status", "Title", "Transport", "ViewCount", "isApplied" },
                values: new object[,]
                {
                    { 1, true, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", "Nhà ở", 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:30", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(1893), 20, 0, 52, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", true, "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10000000 - 15000000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8:00", 3, "Tuyển dụng thợ xây lành nghề CẦN GẤP", true, 0, null },
                    { 2, true, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", "Tòa nhà/Chung cư", 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:30", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(1988), 20, 0, 52, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", true, "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10000000 - 15000000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8:00", 5, "(CẦN GẤP) Tuyển thợ xây ", true, 0, null },
                    { 3, true, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", "Công trình công cộng", 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "17:30", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2055), 20, 0, 52, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", false, "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10000000 - 15000000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8:00", 3, "Tuyển Công nhân xây dựng lành nghê ", true, 0, null },
                    { 4, false, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", null, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2191), 20, 0, 20, 1, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", false, "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10000000 - 15000000", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "Cần người làm dự án (GẤP)", false, 0, null },
                    { 5, false, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", null, 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2232), 30, 0, 14, 2, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", false, "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10000000 - 15000000", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "Tuyển dụng công nhân xây dựng", false, 0, null },
                    { 6, false, "<div>- Tăng lương 6 tháng một lần. Thưởng vào các ngày lễ tết. Cơ hội thăng tiến cao.</div><div>- Xe đưa rước hàng ngày</div><div>- Khám sức khỏe &amp; đi du lịch và các chế độ khác theo quy định của pháp luật Lao động</div>", null, 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), "<div>I. THÔNG TIN CHUNG</div><div>1. Quy trình công việc liên quan: Quy trình quản lí dự án (mảng bản vẽ, báo giá, tiến độ)</div><div>2. Cấp trực tiếp quản lý: Giám đốc dự án</div><div>3. Loại hợp đồng: Hợp đồng xác định có thời hạn/không thời hạn</div><div><br></div><div>II. MỤC ĐÍCH CÔNG VIỆC</div><div>Nắm bản vẽ của dự án từ lúc đấu thầu, hiểu rõ các spect của dự án để báo giá. Có khả năng bốc khối lượng để đối ứng với cá báo giá gấp, các hạng mục phát sinh. Khi dự án trúng thấu, có khả năng điều phối dự án ở vai trò quản lí thiết kế, quản lí tiến độ, hoặc quản lí chất lượng (đối với dự án quy mô nhỏ)</div><div><br></div><div>III. TRÁCH NHIỆM VÀ NHIỆM VỤ</div><div>1. Làm báo giá dự án Nhật và hỗ trợ giám đốc dự án đi đấu thầu</div><div>• Nắm rõ bản vẽ của dự án từ lúc đấu thầu</div><div>• Hiểu rõ các vật tư spect của ngành kết cấu thép để báo giá</div><div>• Có khả năng bốc khối lượng cho các dự án gấp</div><div>• Có khả năng lên các bản vẽ đề xuất bằng CAD</div><div>• Cùng với GDDA đi đấu thầu các dự án</div><div>• Tiếp khách, đối ứng khách khi có audit, khách về việt nam</div><div><br></div><div>2. Quản lí dự án trúng thầu mảng quản lí bản vẽ thiết kế, quản lí tiến độ</div><div>• Nắm rõ các thay đổi thiết kế, chỉ thị bản vẽ của khách để triển khai cho shop</div><div>• Sử dụng thành thạo Tekla hoặc phần mềm real 4 để xuất các giấy tờ phục vụ cho quản lí dự án</div><div>• Lên được kế hoạch sản xuất và quản lí sản xuất, xuất hàng</div><div><br></div><div>3. Đối ứng khách hàng</div><div>• Báo cáo tiến độ sản xuất, bản vẽ</div><div>• Tham gia chủ đạo trong các cuộc họp tiến độ với nhà máy</div><div><br></div><div>4 . Nghiên cứu &amp; Phát triển</div><div>• Tham gia nghiên cứu và phát triển giải pháp công nghệ sản xuất</div><div><br></div><div>5. Tổng kết và đúc kết kinh nghiệm quản lí dự án</div><div>• Tổng kết thường xuyên các vướng mắt trong tiến độ, bản vẽ . Các lỗi hay mắc phải, hướng xử lí</div><div>• Đối với NCR đóng vai trò chỉ huy xử lí (liên quan tiến độ, chất lượng)</div><div><br></div><div>6. Cost control</div><div>• Phối hợp với giám đốc dự án trong công tác giám sát ngân sách thực hiện</div><div><br></div><div>7. Nhiệm vụ khác</div><div>• Các nhiệm vụ khác được phân công</div>", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2263), 30, 0, 14, 2, "TPHCM - QUẬN 7 - TUYỂN DỤNG GẤP", false, "<div>1. Trình độ đào tạo:</div><div>• Bằng cấp tối thiểu: Cao đẳng, Đại học</div><div>• Chuyên ngành đào tạo: Xây dựng Dân dụng và Công nghiệp, Cơ khí</div><div>• Chứng chỉ, giấy phép hành nghề (nếu có): không yêu cầu.Ưu tiên nếu có chứng chỉ:….</div><div>• Trình độ Ngoại ngữ (tiếng anh, tiếng nhật, tiếng trung): Tiếng Nhật (bắt buộc, N2 đổ lên )</div><div><br></div><div>2. Kiến thức cần có:</div><div>• Sản phẩm dịch vụ của Công ty</div><div>• Kiến thức về lĩnh vực kết cấu thép (tiêu chuẩn, vật liệu, sản xuất, quy trình thi công, lắp dựng)</div><div><br></div><div>3. Năng lực cần thiết:</div><div>Năng lực quản lý</div><div>•Nếu có kinh nghiệm làm ở Nhật, hoặc ở công ty Nhật lâu năm càng tốt</div><div>Năng lực chuyên môn</div><div>•Có bằng cấp liên quan đến kết cấu thép Nhật càng tốt</div><div>•Kỹ năng vẽ CAD cơ bản, Sử dụng thành thạo Tekla hoặc phần mềm real 4</div><div>•Đọc hiểu bản vẽ lắp dựng, bản vẽ tổng thể, tiêu chuẩn đường hàn, tiêu chuẩn JASS 6, ASTM , …</div><div><br></div><div>Năng lực bổ trợ</div><div>• Kỹ năng giao tiếp</div><div>• Kỹ năng giải quyết vấn đề và ra quyết định</div><div>• Kỹ năng làm việc nhóm</div><div>• Kỹ năng sử dụng thành thạo tin học văn phòng</div><div><br></div><div>4. Thái độ hoặc tố chất</div><div>• Có tinh thần trách nhiệm</div><div>• Cẩn thận, tỉ mỉ, chủ động, cầu tiến</div><div><br></div><div>5. Yêu cầu khác:</div><div>•Có đủ sức khỏe để đáp ứng yêu cầu nhiệm vụ được giao</div><div>•Có thể đi công tác</div>", "10000000 - 15000000", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "Tuyển dụng công nhân xây dựng", false, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CreateBy", "CreatedBy", "Description", "Image", "LastModifiedAt", "MaterialStoreID", "Name", "SoldQuantities", "Status", "Unit", "UnitInStock", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Pháp", new Guid("00000000-0000-0000-0000-000000000000"), null, "Ngói lợp kiểu Pháp cổ điển", "https://sbo.vn/wp-content/uploads/2021/06/tam-lop-sinh-thai-onduline.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3319), 1, "Ngói lợp", 3000, true, "ton", 300000, 700m },
                    { 2, "Việt Nam", new Guid("00000000-0000-0000-0000-000000000000"), null, "Gạch 2 lỗ cao cấp đến từ thương hiệu nổi tiếng ", "http://www.phudien.vn/upload/Product%20400x200/G%E1%BA%A1ch%20tuynel%20-%20g%E1%BA%A1ch%206%20l%E1%BB%97%20lo%E1%BA%A1i%20nh%E1%BB%8F.png", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3334), 1, "Gạch lỗ", 1500, true, "ton", 300000, 40000m },
                    { 3, "Mỹ", new Guid("00000000-0000-0000-0000-000000000000"), null, "Sơn chống thấm Nippon", "https://nipponpaint.com.vn/sites/default/files/inline-images/son-chong-tham-la-gi-1.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3348), 1, "Sơn chống thấm", 1500, true, "ton", 2000, 1000000m },
                    { 4, "Việt Nam", new Guid("00000000-0000-0000-0000-000000000000"), null, "Cát mịn dành cho xây dựng đặc biệt dành cho ngôi nhà yêu dấu của bạn", "https://sbshouse.vn/wp-content/uploads/2020/09/cat-xay-dung.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3363), 1, "Cát Mịn", 50, true, "ton", 200000, 50000m },
                    { 5, "Việt Nam", new Guid("00000000-0000-0000-0000-000000000000"), null, "Xi măng Hà Tiên", "http://ximang.vn/Upload/48/Nam_2022/Thang_5/Ngay_31/ximang_vicemhatien1.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3377), 2, "Xi măng Hà Tiên", 300, true, "ton", 5000, 80000m },
                    { 6, "Việt Nam", new Guid("00000000-0000-0000-0000-000000000000"), null, "Gạch 4 lỗ", "https://imgcdn9h.store123doc.com/article/2019_1_w4/508-gach-4-lo-nua-duoc-su-dung-cung-voi-gach-4-lo-nguyen-de-xay-nha.jpeg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3391), 2, "Gạch 4 lỗ", 2000, true, "ton", 500000, 700000m },
                    { 7, "CMC", new Guid("00000000-0000-0000-0000-000000000000"), null, "- Màng sơn mịn có độ phủ cao, siêu bóng sang trọng,bám dính tốt\r\n\r\n- Hạn chế vết bẩn, vết nứt nhỏ, chống rêu mốc, độ bền màu cao\r\n\r\n- Thân thiện môi trường và an toàn cho sức khỏe\r\n\r\n- Bảo vệ 10 năm\r\n\r\n- Độ phủ lý thuyết: 12-14m2/lít/ lớp", "https://admin.mingstores.com/core/public/themes/mingstores/products/vx9kXzl3FacoKvdbZLki3kWM6nO3PimJ.jpg", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sơn Ngoại Thất Bóng Cao Cấp CMC ARMOS07 1 - 4.5L", 1500, true, "Lít", 200, 857000m },
                    { 20, "KANSAI PAINT", new Guid("00000000-0000-0000-0000-000000000000"), null, "- Sơn chống thấm Một thành phần Aqua Shield\r\n\r\n- Chống thấm tuyệt hảo\r\n\r\n- Kháng nước tuyệt đối\r\n\r\n- Che phủ vết nứt, co giãn tốt, dễ thi công (không chứa xi măng)\r\n\r\n", "https://admin.mingstores.com/core/public/themes/mingstores/products/OOUUL3p3xO6kV63bOCyr4qCMZBNDo2yc.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3406), 1, "K023 Sơn Kansai chống thấm Aqua Shield 5L, 18L", 100, true, "Lít", 1000, 960000m },
                    { 21, "INAX", new Guid("00000000-0000-0000-0000-000000000000"), null, "Sen cây nóng lạnh INAX BFV-515S là sản phẩm sen cây INAX  được thiết kế tay sen cài liền cùng thân sen cây thay vì để gắn tường, giúp cho tổng thể bộ sen cây trở nên gọn gàng, linh hoạt, đặc biệt phù hợp cả với những căn phòng tắm kích thước nhỏ, quý khách hàng vẫn có thể lắp đặt mẫu sen cây này và cảm nhận trải nghiệm khác biệt khi tắm vòi sen cây với bát sen lớn.\r\nMẫu thiết kế sen cây thuộc dòng sản phẩm SEN VÒI INAX có thiết kế đẹp mắt, sáng tạo từ kiểu dáng đến tính năng thích hợp cho mọi loại hình phòng tắm từ những phòng tắm đơn giản, nhỏ hẹp, đến những căn phòng tắm hiện đại, tiện nghi. ", "https://admin.mingstores.com/core/public/themes/mingstores/products/Mjzhtin7lD3gCUXksET0srIdUnABPNE3.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3510), 1, "SEN TẮM CÂY INAX BFV-515S", 1000, true, "Cái", 1200, 12485000m },
                    { 22, "INAX", new Guid("00000000-0000-0000-0000-000000000000"), null, "Là mẫu chậu rửa mặt Inax đặt bàn mới nhất 2017, sản phẩm tiêu biểu cho năm 2018", "https://admin.mingstores.com/core/public/themes/mingstores/products/JnyguIQW8EMvvUqcZ6BZnGSLOeL5OgpK.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3591), 1, "Chậu Rửa Lavabo Inax AL-536V", 100, true, "Cái", 100, 2046000m },
                    { 30, "NIRO GRANITE", new Guid("00000000-0000-0000-0000-000000000000"), null, "Gạch cao cấp đến từ thương hiệu nổi tiếng NIRO GRANITE", "https://admin.mingstores.com/core/public/themes/mingstores/products/Elgda4SYGE52gAn2wi5AEXipIEMqiYiB.jpg", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Gạch GCA-Clay Art 60x60", 1500, true, "Gạch", 200, 400000m },
                    { 31, "ARISTON", new Guid("00000000-0000-0000-0000-000000000000"), null, "Công suất định mức: 4500(W)\r\nHình dáng: Hình tròn\r\nĐiện năng: 220V\r\nChế độ vòi sen: 5\r\nÁp lực nước tối thiểu: 30/0,3 Kpa/bar\r\nÁp lực nước tối đa: 380/3.8 Kpa/bar\r\nKích thước (DxCxR): 350 X 80\r\nTrọng lượng: 2 kg\r\nKhông có bơm trợ lực", "https://admin.mingstores.com/core/public/themes/mingstores/products/MbcC070BBSf4q97sgghpjBbqFiNr7JEP.jpg", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aures Smart Round RMC-45E-VN", 1500, true, "Bộ", 200, 3200000m },
                    { 32, "TOTO", new Guid("00000000-0000-0000-0000-000000000000"), null, "Thiết kế nguyên khối sang trọng, hiện đại\r\nNắp bàn cầu đóng êm, kèm vòi rửa nước lạnh Eco-washer\r\nBề mặt nước rộng giúp ngăn mùi hiệu quả\r\nThiết kế thân kín, vành kín tiện dụng cho việc vệ sinh hàng ngày\r\nCông nghệ CeFiONtect giúp lòng bàn cầu siêu nhẵn, hạn chế tối đa các vết bẩn, vi khuẩn\r\nCông nghệ xả G-Max êm, mạnh mẽ hiệu quả", "https://admin.mingstores.com/core/public/themes/mingstores/products/UYZ61ie7Z7i5Hmjd6D7XyUWhBZVL7y8v.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(2702), 1, "Bồn cầu một khối TOTO MS904E4", 1500, true, "Bộ", 200, 19037000m },
                    { 33, "INAX", new Guid("00000000-0000-0000-0000-000000000000"), null, "Dòng sản phẩm bồn cầu INAX AC-1017R 1 khối cao cấp đến từ thương hiệu thiết bị vệ sinh INAX\r\nBệt Inax AC-1017R CW-KA22AVN 1 khối với thiết kế mới đơn giản, gọn gàng và sang trọng hơn kết hợp với những tính năng cải tiến\r\nCông nghệ ECO-X xã xoáy cuốn trôi mọi vết bẩn\r\nCông nghệ Aqua Ceramic giúp bề mạt men sứ trắng sáng trong suốt thời gian sữ dụng\r\nCông nghệ chống khuẩn HYPERKILAMIC kháng khuẩn độc quyền của INAX Nhật Bản. \r\nE-Clean: Chức năng phun rửa  tự động\r\nEvaClean: Chức năng vệ sinh phụ nữ\r\nCozyCare: Chức năng sưởi ấm bệ ngồi\r\nX-Fresh: Chức năng khử mùi nhanh \r\nEcoPower: Chức năng tiết kiệm điện “1 lần chạm” (8 tiếng sau tự khôi phục)\r\nDung tích két nước nóng: 0.67L (lít) Vòi phun rửa:\r\nVòi phun rửa và vòi phun dùng riêng cho phụ nữ đều là loại trượt tự động.  \r\nThiết bị an toàn: Rơ-le nhiệt, cảm ứng từ kiểm soát nhiệt độ cao, phao ngắt để thiết bị ngừng hoạt động khi không đủ nước, cảm ứng tự ngắt khi gặp sự cố. \r\nNước cấp: Nối trực tiếp từ đường ống nước ", "https://admin.mingstores.com/core/public/themes/mingstores/products/ryBdemssBcpSt6vbeQdirRUMcBszbZKt.jpg", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bồn Cầu Thông Minh INAX AC-1017R/CW-KA22AVN", 1500, true, "Bộ", 200, 26301000m },
                    { 34, "NIRO GRANITE", new Guid("00000000-0000-0000-0000-000000000000"), null, "Màu sắc: vàng, xám, trắng, đen\r\nKích thước: 30x60, 60x60", "https://admin.mingstores.com/core/public/themes/mingstores/products/U3SmJsX6rBhkAPyQ3Xym2wlyoNTH6pGz.jpg", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "GFS Gạch Granite Fusion Bán Bóng/Sần", 1500, true, "Cái", 200, 520000m },
                    { 35, "JINMEI", new Guid("00000000-0000-0000-0000-000000000000"), null, "ông nghệ sản xuất tủ lavabo của chúng tôi đã được chuyên nghiệp hóa qua nhiều năm phát triển, với phần khung bên ngoài được làm bằng nhôm, là cấu trúc chính hỗ trợ, giúp toàn bộ tủ chắc chắn, bên cạnh phần bản lề được làm bằng INOX 304 dày, giúp cho việc vận hành được trơn tru, ổn định.\r\n- Các bộ phận chính đều được làm bằng thép không gỉ 304 (INOX 304), tăng độ bền cho sản phẩm trong quá trình sử dụng.\r\n- Cấu hình cạnh và tay nắm cửa được làm bằng máy vát 45 độ đặc biệt, góc nhôm được gắn chặt vào thành bên trong tủ, để bề mặt sản phẩm mịn & tinh tế, tạo sự thoải mái khi sử dụng.\r\n\r\n- Việc sử dụng nhôm để làm vật liệu chính sản xuất tủ Lavabo là lựa chọn tối ưu nhất hiện nay, không chỉ có độ bền cao, nhôm hoàn toàn không độc hại với môi trường cũng như người sử dụng. Một số ưu điểm chính của nhôm:\r\n  + Trọng lượng nhẹ, độ bền cao, khả năng chịu lực lớn.\r\n  + Độ cứng tốt, không dễ biến dạng.\r\n  + Không thấm nước trong môi trường có độ ẩm cao, không bắt lửa và chịu được tác động mạnh.\r\n  + Lớp sơn phủ bền màu, chống ăn mòn do thời tiết hoặc hóa chất thông thường.\r\n  + Tạo không gian sang trọng, thoải mái và tiện lợi.", "https://admin.mingstores.com/core/public/themes/mingstores/products/P5GERhsHMvYboHFoSTcetoIuHKJJApvD.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3074), 1, "Tủ Lavabo JM843", 1500, true, "Bộ", 200, 9520000m },
                    { 36, "KANSAI PAINT", new Guid("00000000-0000-0000-0000-000000000000"), null, "Sơn ngoại thất câo cấp đến từ thương hiệu Kansai nổi tiếng", "https://admin.mingstores.com/core/public/themes/mingstores/products/JnLYt6lx4OLgmoplQoxTPU1e9SBjZf9a.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3127), 1, "K015 Sơn Kansai chống thấm Water Proof 4L, 17L", 1500, true, "Lít", 200, 750000m },
                    { 37, "COSMOS", new Guid("00000000-0000-0000-0000-000000000000"), null, "KARI SQUARE STEP LIGHT (3W) mang đến ánh sáng tinh tế đến gia đình bạn ", "https://admin.mingstores.com/core/public/themes/mingstores/products/N23c1P48S9v157cAYlNRc35gS92VeYVE.jpg", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KARI SQUARE STEP LIGHT (3W)", 1500, true, "Cái", 200, 460000m },
                    { 38, "NIRO GRANITE", new Guid("00000000-0000-0000-0000-000000000000"), null, "GHR Gạch Granite Hardrock Mờ/Bán bóng ", "https://admin.mingstores.com/core/public/themes/mingstores/products/6TauBDiJiwnvQaJTuCl9D0SYHFayTRHk.jpg", new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3271), 1, "GHR Gạch Granite Hardrock Mờ/Bán bóng", 1500, true, "Viên", 200, 360000m }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "FromSystem", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, true, "Xây dựng", new Guid("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0") },
                    { 2, true, "Sơn tường", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") },
                    { 3, true, "Lát gạch", new Guid("bd880489-5c76-4854-93ab-66e3a541bf24") },
                    { 4, true, "Thạch Cao", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") },
                    { 5, true, "Điện", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") },
                    { 6, true, "Nước", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") },
                    { 7, true, "Hàn Sắt", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") },
                    { 8, true, "Ốp lát", new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Provider", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b57b172a-a044-11ed-a8fc-0242ac120002"), 0, "56 Nguyễn Duy Trinh, Huyện An Lão, Bình Định", "https://baodautu.vn/Images/chicong/2018/11/28/thi-truong-vat-lieu-xay-dung-mua-kinh-doanh-da-thay-doi1543390455.jpg", null, "2fd5e015-ab68-47be-aec7-66d75fd4d50d", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "store123@gmail.com", false, "TPHCM", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 48, DateTimeKind.Local).AddTicks(166), "Cửa Hàng Vật Liệu", false, null, 1, null, null, "AQAAAAEAACcQAAAAEEJcIU2prOwPCoY4LZfqkM4Wb2WsIiZpGqJWclQIbQIgvz2J5X26LTA70KLp3LJuFQ==", "0924516734", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "0924516734" },
                    { new Guid("be21b564-a044-11ed-a8fc-0242ac120002"), 0, "56 Nguyễn Duy Trinh, Huyện Hàm Tân, Bình Thuận", "data:image/jpeg;base64,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", null, "ab403de7-c0c9-4284-a063-9f636b8ba988", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "store2@gmail.com", false, "Cần Thơ", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 49, DateTimeKind.Local).AddTicks(5736), "VLXD", false, null, 2, null, null, "AQAAAAEAACcQAAAAEBbYTBbvESMkXQOGgs6qFn5edFRHbD2Md+tJfXaF0ikNjHLqu/NHcEyr4V7PKfJmWg==", "09245167342", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "09245167342" },
                    { new Guid("d7285fb7-835b-4680-a18c-673bd71f63d6"), 0, "56 Nguyễn Duy Trinh, Huyện Mỏ Cày Nam, Bến Tre", "https://www.vietnamworks.com/_next/image?url=https%3A%2F%2Fimages.vietnamworks.com%2Fpictureofcompany%2F69%2F11128477.png&w=128&q=75", null, "fbc9b07e-85b0-4409-a7e3-f1f8a6c312ed", 2, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "contractor2@gmail.com", false, "Công Ty Cổ Phần Đầu Tư Bất Động Sản", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 46, DateTimeKind.Local).AddTicks(4445), "Taseco", false, null, null, null, null, "AQAAAAEAACcQAAAAEImkhbOt0TGWR1KTh39cBK3Sy9JCfewQR9MZZF0GEpWyKwJwoPwkN+/i8DRcK58rog==", "09987654321", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "0987654321" },
                    { new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7"), 0, "56 Nguyễn Duy Trinh, Huyện Gia Bình, Bắc Ninh", "https://www.vietnamworks.com/_next/image?url=https%3A%2F%2Fimages.vietnamworks.com%2Fpictureofcompany%2F78%2F11127264.png&w=128&q=75", null, "40b5a7cd-ec2a-45cd-ab0d-eee1f8450691", 1, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "contractor@gmail.com", false, "Công Ty Cổ Phần Xây Dựng Và Công Nghiệp", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 44, DateTimeKind.Local).AddTicks(8845), "NSN", false, null, null, null, null, "AQAAAAEAACcQAAAAEPNZXylUn1+DIZqGeeDi2vdehstrQTNeka/bf8ED+tpCMYxnW8FP8ufGORlcXNEY/Q==", "0912345678", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "0912345678" }
                });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "Id", "BillID", "Price", "ProductID", "ProductTypeId", "Quantity" },
                values: new object[,]
                {
                    { 2, 1, 150000m, 21, null, 8 },
                    { 3, 1, 450000m, 22, null, 7 },
                    { 5, 2, 20000m, 1, null, 5 },
                    { 6, 2, 150000m, 2, null, 8 },
                    { 7, 2, 45000m, 3, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "ContractorPostSkills",
                columns: new[] { "ContractorPostID", "SkillID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 5, 1 },
                    { 1, 2 },
                    { 4, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 6, 4 },
                    { 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "ContractorPostType",
                columns: new[] { "ContractorPostID", "TypeID" },
                values: new object[,]
                {
                    { 1, new Guid("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0") },
                    { 2, new Guid("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0") },
                    { 1, new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreateBy", "IsRead", "LastModifiedAt", "Message", "NavigateId", "Title", "Type", "UserID" },
                values: new object[,]
                {
                    { 1, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), false, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3804), "Someone has saved your post", 1, "New Notification", 0, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7") },
                    { 2, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), false, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3821), "Someone has applied your post", 1, "New Notification", 0, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7") },
                    { 3, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), false, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3836), "Create commitment successfully", 1, "New Notification", 0, new Guid("d7285fb7-835b-4680-a18c-673bd71f63d7") }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoriesID", "ProductID", "Name" },
                values: new object[,]
                {
                    { 1, 7, "Mỹ" },
                    { 2, 7, "Sơn ngoại thất" },
                    { 1, 20, "Niro – Indonesia" },
                    { 2, 20, "Lít" },
                    { 4, 20, "Sơn ngoại thất" },
                    { 1, 21, "Nhật Bản" },
                    { 2, 21, "Cái" },
                    { 4, 21, "Nhà tắm" },
                    { 1, 22, "Nhật Bản" },
                    { 2, 22, "Cái" },
                    { 4, 22, "Nhà tắm" },
                    { 1, 30, "Mỹ" },
                    { 2, 30, "Gạch bóng" },
                    { 1, 31, "Mỹ" },
                    { 2, 31, "Thép" },
                    { 1, 32, "Mỹ" },
                    { 2, 32, "Cái" },
                    { 3, 32, "Ý" },
                    { 4, 32, "Nhà vệ sinh" },
                    { 1, 33, "Mỹ" },
                    { 2, 33, "Cái" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoriesID", "ProductID", "Name" },
                values: new object[,]
                {
                    { 3, 33, "Ý" },
                    { 4, 33, "Nhà vệ sinh" },
                    { 1, 34, "Niro – Indonesia" },
                    { 2, 34, "Cái" },
                    { 1, 35, "Niro – Indonesia" },
                    { 2, 35, "Bộ" },
                    { 4, 35, "Nhà tắm" },
                    { 1, 36, "Ý" },
                    { 2, 36, "Bộ" },
                    { 4, 36, "Sơn nội thất" },
                    { 1, 37, "Ý" },
                    { 2, 37, "Bộ" },
                    { 4, 37, "Phòng khách" },
                    { 1, 38, "Niro – Indonesia" },
                    { 2, 38, "Cái" },
                    { 4, 38, "Nội thất" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "ColorId", "Label", "OtherID", "ProductID", "Quantity", "SizeID", "Status" },
                values: new object[,]
                {
                    { 12, 1, null, 1, 7, 5, 2, 3 },
                    { 13, 1, null, 1, 7, 10, 3, 3 },
                    { 50, 6, null, 1, 34, 5, 4, 3 },
                    { 51, 6, null, 1, 34, 3, 5, 3 },
                    { 52, 7, null, 1, 34, 5, 4, 3 },
                    { 53, 7, null, 1, 34, 5, 5, 3 },
                    { 60, 1, null, 1, 20, 5, 7, 3 },
                    { 61, 1, null, 1, 20, 3, 8, 3 }
                });

            migrationBuilder.InsertData(
                table: "Quiz",
                columns: new[] { "Id", "LastModifiedAt", "Name", "PostID", "TypeID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3987), "Bài test thợ xây ", 1, new Guid("4ace8fcb-95eb-48c0-9deb-240e8b4e10e0") },
                    { 2, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(4006), "Bài test thợ sơn ", 1, new Guid("ce9fa65b-d005-46b6-953e-e6462a59cfb3") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "BuilderId", "ConcurrencyStamp", "ContractorId", "CreateBy", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "IdNumber", "LastModifiedAt", "LastName", "LockoutEnabled", "LockoutEnd", "MaterialStoreID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Provider", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("d39ae0a6-9b2d-4421-be4a-cc294cec054f"), 0, "41 Nguyễn Duy Trinh, Huyện Tân Yên, Bắc Giang", "https://scontent.fsgn5-3.fna.fbcdn.net/v/t1.6435-9/86186750_1329130013936346_7257030880831471616_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=174925&_nc_ohc=Z1GTPvzRt7wAX_WbRZ5&_nc_ht=scontent.fsgn5-3.fna&oh=00_AfAYtaD2dHE_84_-PSlDqLaeyBlH9zJ3b308pHcTWucCXw&oe=642552F2", 2, "d7ce0cdd-1d50-4fca-9355-9988a2cf2927", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhoaidoan1@gmail.com", false, "Thinh", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 41, DateTimeKind.Local).AddTicks(6866), "Nguyen Anh", false, null, null, null, null, "AQAAAAEAACcQAAAAEN4Pjesxkh74Lth6oscELvmymBWqBaAEJle/rY5kKEVRepwrmQUBVpRRbwWWM6M++g==", "0937341639", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "namhoaidoan1@gmail.com" },
                    { new Guid("d7285fb7-835b-4680-a18c-673bd71f63d9"), 0, "41 Nguyễn Duy Trinh, Huyện Đông Hải, Bạc Liêu", "https://i1-giaitri.vnecdn.net/2013/08/15/DK-02756-1376528749.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=mX89l0q4HQgntQ5wJesOcw", 1, "62bb4344-a399-420b-8ff1-dcba42113f4f", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhoaidoan15@gmail.com", false, "Hoai Nam", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 40, DateTimeKind.Local).AddTicks(652), "Doan Vu", false, null, null, null, null, "AQAAAAEAACcQAAAAEGlV3hbaw7Zm3RwD5n/92gkxlO9/f2nISbQ+3bY+OKdb4S5WCjUrMqisxkoSOtTWsQ==", "0879411575", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "namhoaidoan15@gmail.com" },
                    { new Guid("d91f9ece-25a7-4dc6-adde-186b12c04d56"), 0, "56 Nguyễn Duy Trinh, Huyện Chợ Đồn, Bắc Kạn", "https://scontent.fsgn5-3.fna.fbcdn.net/v/t1.6435-9/86186750_1329130013936346_7257030880831471616_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=174925&_nc_ohc=Z1GTPvzRt7wAX_WbRZ5&_nc_ht=scontent.fsgn5-3.fna&oh=00_AfAYtaD2dHE_84_-PSlDqLaeyBlH9zJ3b308pHcTWucCXw&oe=642552F2", 3, "6e0d141f-794a-4770-8969-63129a6d7e75", null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "namhoaidoan12@gmail.com", false, "Hieu", 0, null, new DateTime(2023, 4, 2, 18, 21, 1, 43, DateTimeKind.Local).AddTicks(2842), "Nguyen Anh", false, null, null, null, null, "AQAAAAEAACcQAAAAEEDWWDBRkac0MV7RVJHcXqXlJZGgDGV7XByTuyyUHhk3XNGLRH2d1CziHgpPAZSCGQ==", "0101010101", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "xxx", false, "namhoaidoan12@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "WorkerContructionTypes",
                columns: new[] { "BuilderId", "ConstructionTypeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "AppliedPost",
                columns: new[] { "BuilderID", "PostID", "AppliedDate", "GroupID", "QuizId", "Status", "WishSalary" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3904), null, 1, 6, null },
                    { 2, 1, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3921), null, 1, 6, null },
                    { 3, 1, new DateTime(2023, 4, 2, 18, 21, 1, 51, DateTimeKind.Local).AddTicks(3933), null, 1, 6, null }
                });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "Id", "BillID", "Price", "ProductID", "ProductTypeId", "Quantity" },
                values: new object[] { 1, 1, 200000m, 20, 60, 5 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Name", "QuizId" },
                values: new object[,]
                {
                    { 1, "Búa tạ, cáo búa  đều là những loại gì?", 1 },
                    { 2, "Quá trình phá hủy một tòa nhà được gọi là _______ ?", 1 },
                    { 3, "Khi một ngôi nhà sử dụng năng lượng mặt trời, bạn thường sẽ thấy ________ trên mái nhà.?", 1 },
                    { 4, "Tên khác của một bức tường không chịu lực là gì?", 1 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Name", "QuestionId", "isCorrect" },
                values: new object[,]
                {
                    { 1, "Máy khoan", 1, false },
                    { 2, "Búa", 1, true },
                    { 3, "Cưa", 1, false },
                    { 4, "Vặn vít", 1, false },
                    { 5, "Phá dỡ", 2, true },
                    { 6, "Ràng buộc ", 2, false },
                    { 7, "Cốt thép", 2, false },
                    { 8, "Đùn", 2, false },
                    { 9, "Ăng-ten", 3, false },
                    { 10, "Giếng trời ", 3, false },
                    { 11, "Tấm", 3, true },
                    { 12, "Ống", 3, false },
                    { 13, "Bươm bướm", 4, false },
                    { 14, "Màn ", 4, false },
                    { 15, "Đảng", 4, true },
                    { 16, "Chỉ", 4, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppliedPost_BuilderID",
                table: "AppliedPost",
                column: "BuilderID");

            migrationBuilder.CreateIndex(
                name: "IX_AppliedPost_GroupID",
                table: "AppliedPost",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AppliedPost_QuizId",
                table: "AppliedPost",
                column: "QuizId");

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
                name: "IX_BillDetail_ProductTypeId",
                table: "BillDetail",
                column: "ProductTypeId",
                unique: true,
                filter: "[ProductTypeId] IS NOT NULL");

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
                name: "IX_Carts_TypeID",
                table: "Carts",
                column: "TypeID");

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
                name: "IX_IdentitficationCards_UserID",
                table: "IdentitficationCards",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserID",
                table: "Notifications",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInvite_BuilderId",
                table: "PostInvite",
                column: "BuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInvite_ContractorId",
                table: "PostInvite",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInvite_ContractorPostId",
                table: "PostInvite",
                column: "ContractorPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoriesID",
                table: "ProductCategories",
                column: "CategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MaterialStoreID",
                table: "Products",
                column: "MaterialStoreID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ColorId",
                table: "ProductTypes",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_OtherID",
                table: "ProductTypes",
                column: "OtherID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductID",
                table: "ProductTypes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_SizeID",
                table: "ProductTypes",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_PostID",
                table: "Quiz",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_TypeID",
                table: "Quiz",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ContractorPostId",
                table: "Reports",
                column: "ContractorPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ProductId",
                table: "Reports",
                column: "ProductId");

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
                name: "IX_UserAnswer_AnswerID",
                table: "UserAnswer",
                column: "AnswerID");

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
                name: "IX_WorkerContructionTypes_BuilderId",
                table: "WorkerContructionTypes",
                column: "BuilderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppliedPost");

            migrationBuilder.DropTable(
                name: "BillDetail");

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
                name: "IdentitficationCards");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PostInvite");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Saves");

            migrationBuilder.DropTable(
                name: "UserAnswer");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "WorkerContructionTypes");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "ConstructionType");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Other");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Builders");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "MaterialStores");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "ContractorPosts");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Contractors");
        }
    }
}
