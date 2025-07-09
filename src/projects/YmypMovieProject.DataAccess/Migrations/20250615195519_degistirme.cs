using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Degistirme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(4)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2c592e50-de01-4b69-aaeb-28854401fb14"), new DateTime(2025, 6, 15, 19, 55, 18, 492, DateTimeKind.Utc).AddTicks(2188), "", true, false, "Belgesel", null },
                    { new Guid("554a7f64-a862-4a32-afda-f7c8ad64ba60"), new DateTime(2025, 6, 15, 19, 55, 18, 492, DateTimeKind.Utc).AddTicks(2171), "", true, false, "Bilim Kurgu", null },
                    { new Guid("849c21b7-9b23-42e5-89e0-dbdd39af2d55"), new DateTime(2025, 6, 15, 19, 55, 18, 492, DateTimeKind.Utc).AddTicks(2193), "", true, false, "Korku", null },
                    { new Guid("9800428f-2ee2-42de-9381-b40ab853c4c6"), new DateTime(2025, 6, 15, 19, 55, 18, 492, DateTimeKind.Utc).AddTicks(2156), "", true, false, "Aksiyon", null },
                    { new Guid("b9637630-b82e-4182-8967-98f8bac4c910"), new DateTime(2025, 6, 15, 19, 55, 18, 492, DateTimeKind.Utc).AddTicks(2173), "", true, false, "Komedi", null },
                    { new Guid("f6b4e82e-8555-429b-a7a7-8fef2e31d7dc"), new DateTime(2025, 6, 15, 19, 55, 18, 492, DateTimeKind.Utc).AddTicks(2191), "", true, false, "Fantastik", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c592e50-de01-4b69-aaeb-28854401fb14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("554a7f64-a862-4a32-afda-f7c8ad64ba60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("849c21b7-9b23-42e5-89e0-dbdd39af2d55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9800428f-2ee2-42de-9381-b40ab853c4c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9637630-b82e-4182-8967-98f8bac4c910"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6b4e82e-8555-429b-a7a7-8fef2e31d7dc"));

            migrationBuilder.AlterColumn<double>(
                name: "IMDB",
                table: "Movies",
                type: "float(4)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

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
    }
}
