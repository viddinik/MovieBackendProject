using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DirektorModelBuilderCreatedAndAddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BirthTime",
                table: "Directors");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Directors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4032b92d-ee8e-4464-8368-2a9af4e4347d"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4269), null, true, false, "Belgesel", null },
                    { new Guid("543704e6-58e5-4503-a28c-b1c627c4aef4"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4266), null, true, false, "Komedi", null },
                    { new Guid("67f4c34c-1a29-45d0-9243-8ed0a6f69272"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4252), null, true, false, "Bilim Kurgu", null },
                    { new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4234), null, true, false, "Aksiyon", null },
                    { new Guid("b2acfd08-439c-4752-a62c-f72e64c06a05"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4278), null, true, false, "Korku", null },
                    { new Guid("e82f5437-a887-4ded-a1ce-6a56ee3d0c2e"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4272), null, true, false, "Fantastik", null }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("5c692a91-4453-4db5-be77-34e5feffde1e"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4480), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("b27cdf16-bc5d-4def-aeb6-f542f842c355"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4478), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4471), "British-American film director, producer, and screenwriter.", "Christopher", null, true, false, "Nolan", null },
                    { new Guid("bdd2dc63-da31-4062-ad30-ea0d691cdc94"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4487), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("d24eb5e5-b8b6-4806-bd9c-e9cf5cf5c126"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4490), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4032b92d-ee8e-4464-8368-2a9af4e4347d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("543704e6-58e5-4503-a28c-b1c627c4aef4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67f4c34c-1a29-45d0-9243-8ed0a6f69272"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2acfd08-439c-4752-a62c-f72e64c06a05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e82f5437-a887-4ded-a1ce-6a56ee3d0c2e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("5c692a91-4453-4db5-be77-34e5feffde1e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b27cdf16-bc5d-4def-aeb6-f542f842c355"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b3401950-fc04-481f-9be8-28043b9b762c"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("bdd2dc63-da31-4062-ad30-ea0d691cdc94"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d24eb5e5-b8b6-4806-bd9c-e9cf5cf5c126"));

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Directors");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthTime",
                table: "Directors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

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
    }
}
