using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CosmeticsProject_Core.Migrations
{
    /// <inheritdoc />
    public partial class reo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(8095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "SalesReport",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(2234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(8641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(6263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 910, DateTimeKind.Local).AddTicks(43),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 180, DateTimeKind.Local).AddTicks(109));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(8764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "SalesReport",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(4963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(4110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(2553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 179, DateTimeKind.Local).AddTicks(721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 3, 59, 180, DateTimeKind.Local).AddTicks(109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 910, DateTimeKind.Local).AddTicks(43));
        }
    }
}
