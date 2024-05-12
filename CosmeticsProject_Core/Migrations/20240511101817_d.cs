using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CosmeticsProject_Core.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_NationalNo",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NationalNo",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(4641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "SalesReport",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(9367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(7873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(6010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 910, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalNo",
                table: "Users",
                column: "NationalNo",
                unique: true,
                filter: "[NationalNo] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_NationalNo",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NationalNo",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(8095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "SalesReport",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(2234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 909, DateTimeKind.Local).AddTicks(809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(8641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 908, DateTimeKind.Local).AddTicks(6263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 186, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 7, 55, 910, DateTimeKind.Local).AddTicks(43),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 18, 17, 187, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalNo",
                table: "Users",
                column: "NationalNo",
                unique: true);
        }
    }
}
