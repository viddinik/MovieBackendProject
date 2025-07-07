using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "IMDB",
                table: "Movies",
                type: "float(4)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("06b6df2b-f585-43d0-8018-a43465cd758a"), new DateTime(2025, 6, 13, 22, 5, 43, 767, DateTimeKind.Utc).AddTicks(2825), "", true, false, "Fantastik", null },
                    { new Guid("5693e47f-80f2-415e-820c-f72a08fe6d68"), new DateTime(2025, 6, 13, 22, 5, 43, 767, DateTimeKind.Utc).AddTicks(2828), "", true, false, "Korku", null },
                    { new Guid("668d6839-39bb-43f7-85ed-ce2f01fb4b57"), new DateTime(2025, 6, 13, 22, 5, 43, 767, DateTimeKind.Utc).AddTicks(2804), "", true, false, "Bilim Kurgu", null },
                    { new Guid("a1392bff-68eb-42c1-92cc-1bce434c829a"), new DateTime(2025, 6, 13, 22, 5, 43, 767, DateTimeKind.Utc).AddTicks(2797), "", true, false, "Aksiyon", null },
                    { new Guid("c1c82cd8-8502-49c0-a09f-2a6b0d2b417e"), new DateTime(2025, 6, 13, 22, 5, 43, 767, DateTimeKind.Utc).AddTicks(2807), "", true, false, "Komedi", null },
                    { new Guid("ff6003ae-7bd0-4563-b818-d4fc23dff437"), new DateTime(2025, 6, 13, 22, 5, 43, 767, DateTimeKind.Utc).AddTicks(2822), "", true, false, "Belgesel", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06b6df2b-f585-43d0-8018-a43465cd758a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5693e47f-80f2-415e-820c-f72a08fe6d68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("668d6839-39bb-43f7-85ed-ce2f01fb4b57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1392bff-68eb-42c1-92cc-1bce434c829a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1c82cd8-8502-49c0-a09f-2a6b0d2b417e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff6003ae-7bd0-4563-b818-d4fc23dff437"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<double>(
                name: "IMDB",
                table: "Movies",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(4)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
