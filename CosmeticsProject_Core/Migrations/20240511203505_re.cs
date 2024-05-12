using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CosmeticsProject_Core.Migrations
{
    /// <inheritdoc />
    public partial class re : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 59, DateTimeKind.Local).AddTicks(260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "SalesReport",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 58, DateTimeKind.Local).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 58, DateTimeKind.Local).AddTicks(1489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 58, DateTimeKind.Local).AddTicks(353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 57, DateTimeKind.Local).AddTicks(9105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 59, DateTimeKind.Local).AddTicks(2195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(5964));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(4641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 59, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "SalesReport",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 58, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(9367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 58, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(7873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 58, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(6010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 57, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 23, 35, 5, 59, DateTimeKind.Local).AddTicks(2195));
        }
    }
}
