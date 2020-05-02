using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopSolution.Data.Migrations
{
    public partial class add_asp_net_core_identity_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 1, 0, 18, 1, 937, DateTimeKind.Local).AddTicks(6270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 1, 0, 17, 28, 448, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 5, 1, 0, 18, 1, 957, DateTimeKind.Local).AddTicks(2378));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 1, 0, 17, 28, 448, DateTimeKind.Local).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 1, 0, 18, 1, 937, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 5, 1, 0, 17, 28, 466, DateTimeKind.Local).AddTicks(9107));
        }
    }
}
