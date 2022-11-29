using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagementSystem.Repository.Migrations
{
    public partial class OOOOOOOOOO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductBrandId = table.Column<int>(type: "int", nullable: false),
                    BrandsWebUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ColorBase64Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ColorFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ColorFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProductColorId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCurrencyUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductCurrencyId = table.Column<int>(type: "int", nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCurrencyUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductMeasurementId = table.Column<int>(type: "int", nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMeasurementUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductProjectId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVatUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProductVatId = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVatUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductWeightUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductWeightId = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWeightUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TechnicalWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExplanationWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsMixture = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductColorsId = table.Column<int>(type: "int", nullable: false),
                    ProductProjectId = table.Column<int>(type: "int", nullable: false),
                    ProductBrandId = table.Column<int>(type: "int", nullable: false),
                    ProductCurrencyId = table.Column<int>(type: "int", nullable: false),
                    ProductMeasurementId = table.Column<int>(type: "int", nullable: false),
                    ProductVatId = table.Column<int>(type: "int", nullable: false),
                    ProductWeightId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductColors_ProductColorsId",
                        column: x => x.ProductColorsId,
                        principalTable: "ProductColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductCurrencyUnits_ProductCurrencyId",
                        column: x => x.ProductCurrencyId,
                        principalTable: "ProductCurrencyUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductMeasurementUnits_ProductMeasurementId",
                        column: x => x.ProductMeasurementId,
                        principalTable: "ProductMeasurementUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductProjects_ProductProjectId",
                        column: x => x.ProductProjectId,
                        principalTable: "ProductProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductVatUnits_ProductVatId",
                        column: x => x.ProductVatId,
                        principalTable: "ProductVatUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductWeightUnits_ProductWeightId",
                        column: x => x.ProductWeightId,
                        principalTable: "ProductWeightUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Ofis Ürünleri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Polen Haşere", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "İzolasyon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "İnşaat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Montaj Asma", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Tadilat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Tamir", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Maskeleme", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Kaydırmaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "İç Cephe Boyalar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Dış Cephe Boyalar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Tinerler", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "ActiveDateUpdate", "BrandsName", "BrandsWebUrl", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "LogoBase64Content", "LogoFileName", "LogoFilePath", "ProductBrandId", "ProductFeaturesId", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BBBBb", "AAAA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "dfgvgrfg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, null, null, null, 0, 0, "sddsad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "ActiveDateUpdate", "Code", "ColorBase64Content", "ColorFileName", "ColorFilePath", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ProductColorId", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Sarı", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "ProductCurrencyUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ProductCurrencyId", "ProductFeaturesId", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "dfgvgrfg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "BBBBb", 0, 0, "AAAA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "ProductMeasurementUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ProductMeasurementId", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "XXX", 0, "xx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "ProductProjects",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ProductFeaturesId", "ProductProjectId", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Aaa", 0, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "ProductVatUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "Code", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ProductVatId", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "XXX", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "ProductWeightUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ProductWeightId", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "XXX", 0, "X1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActiveDateUpdate", "Barcode", "CategoryId", "Code", "CreateDate", "CreateUserId", "ExpirationDate", "Explanation", "ExplanationWebUrl", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "IsMixture", "LogoBase64Content", "LogoFileName", "LogoFilePath", "Name", "PurchasePrice", "SalePrice", "Stock", "TechnicalWebUrl", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AS123", 1, "123AS", new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3886), 0, new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3884), "hghghggh", "dlld", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, "ad", "sdf", "sdsdf", "Test Ürün1", 10m, 15m, 1, "dfsd", new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3887), 0 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "ProductBrandId", "ProductColorsId", "ProductCurrencyId", "ProductId", "ProductMeasurementId", "ProductProjectId", "ProductVatId", "ProductWeightId", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3599), new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3588), 1, 1, new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3599), 1, 1, 1, new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3600), 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, new DateTime(2022, 11, 11, 15, 26, 18, 749, DateTimeKind.Local).AddTicks(3598), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductBrandId",
                table: "ProductFeatures",
                column: "ProductBrandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductColorsId",
                table: "ProductFeatures",
                column: "ProductColorsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductCurrencyId",
                table: "ProductFeatures",
                column: "ProductCurrencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductMeasurementId",
                table: "ProductFeatures",
                column: "ProductMeasurementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductProjectId",
                table: "ProductFeatures",
                column: "ProductProjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductVatId",
                table: "ProductFeatures",
                column: "ProductVatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductWeightId",
                table: "ProductFeatures",
                column: "ProductWeightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductCurrencyUnits");

            migrationBuilder.DropTable(
                name: "ProductMeasurementUnits");

            migrationBuilder.DropTable(
                name: "ProductProjects");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductVatUnits");

            migrationBuilder.DropTable(
                name: "ProductWeightUnits");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
