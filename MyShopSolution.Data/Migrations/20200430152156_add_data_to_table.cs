using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopSolution.Data.Migrations
{
    public partial class add_data_to_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 30, 22, 21, 55, 439, DateTimeKind.Local).AddTicks(8694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 30, 19, 59, 57, 74, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "Home Title", "This is Home page of MyShopSolution" },
                    { "Home description", "This is description of MyShopSolution" },
                    { "Home keyowrd", "This is keyword of MyShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "Vi-VN", true, "Tiếng Việt" },
                    { "En-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "DateCreated", "Price", "PromotionPrice", "SeoAlias" },
                values: new object[] { 1, new DateTime(2020, 4, 30, 22, 21, 55, 458, DateTimeKind.Local).AddTicks(753), 100000m, 80000m, null });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "Vi-VN", "Áo Nam", "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" },
                    { 3, 2, "Vi-VN", "Áo Nữ", "ao-nu", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang nữ" },
                    { 2, 1, "En-US", "Men Shirt", "men-shirt", "The fasion shirt products for man", "The fasion shirt products for man" },
                    { 4, 2, "En-US", "Woman Shirt", "woman-shirt", "The fasion shirt products for woman", "The fasion shirt products for woman" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "Áo khoác gucci", "Áo khoác gucci", "Vi-VN", "Áo khoác gucci", 1, "ao-khoac-gucci", "Áo khoác gucci", "Áo khoác gucci" },
                    { 2, "Gucci jacket", "Gucci jacket", "En-US", "Gucci jacket", 1, "gucci-jacket", "Gucci jacket", "Gucci jacket" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home description");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home keyowrd");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Title");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "En-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "Vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 30, 19, 59, 57, 74, DateTimeKind.Local).AddTicks(2489),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 30, 22, 21, 55, 439, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.CreateTable(
                name: "a",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_a", x => x.id);
                });
        }
    }
}
