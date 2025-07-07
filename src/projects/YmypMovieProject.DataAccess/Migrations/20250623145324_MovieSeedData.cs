using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MovieSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("bdd2dc63-da31-4062-ad30-ea0d691cdc94"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d24eb5e5-b8b6-4806-bd9c-e9cf5cf5c126"));

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("168f76a2-71cd-4b6c-9a18-62e69e0ef04f"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(991), null, true, false, "Bilim Kurgu", null },
                    { new Guid("53081c0d-e74a-4837-a32e-b2d94af84811"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(997), null, true, false, "Belgesel", null },
                    { new Guid("7d005188-0db7-4cca-ae02-e9ca4e8baa00"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(994), null, true, false, "Komedi", null },
                    { new Guid("bd67f801-81b8-4314-9519-06ffd2e0d32a"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1005), null, true, false, "Korku", null },
                    { new Guid("c49cbfe8-de21-4905-9f2e-03a391479d42"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(999), null, true, false, "Fantastik", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2f6e9a3c-14ee-4800-b642-81cf167bcc0a"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1146), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("9ddecf3f-cecc-4ac4-9aa3-2986e82eb5b7"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1149), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("f01dede9-cf3b-4abc-9f30-405f9ee4f114"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1158), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("fea472f0-50ca-460d-812a-8d657b81f24d"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1155), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("6f161ba1-f2f8-4dff-bb30-e26d99d96245"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1190), "Interstellar movie Nolan..", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.7m, null, true, false, "Interstellar", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bd5ce6d6-c5d4-4164-a33a-5824e02d7fb2"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1196), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ee2451fd-673c-43d1-9172-cb6d21d3cb10"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 6, 23, 14, 53, 23, 559, DateTimeKind.Utc).AddTicks(1185), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("168f76a2-71cd-4b6c-9a18-62e69e0ef04f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53081c0d-e74a-4837-a32e-b2d94af84811"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d005188-0db7-4cca-ae02-e9ca4e8baa00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd67f801-81b8-4314-9519-06ffd2e0d32a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c49cbfe8-de21-4905-9f2e-03a391479d42"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2f6e9a3c-14ee-4800-b642-81cf167bcc0a"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("9ddecf3f-cecc-4ac4-9aa3-2986e82eb5b7"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("f01dede9-cf3b-4abc-9f30-405f9ee4f114"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("fea472f0-50ca-460d-812a-8d657b81f24d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6f161ba1-f2f8-4dff-bb30-e26d99d96245"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bd5ce6d6-c5d4-4164-a33a-5824e02d7fb2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ee2451fd-673c-43d1-9172-cb6d21d3cb10"));

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4032b92d-ee8e-4464-8368-2a9af4e4347d"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4269), null, true, false, "Belgesel", null },
                    { new Guid("543704e6-58e5-4503-a28c-b1c627c4aef4"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4266), null, true, false, "Komedi", null },
                    { new Guid("67f4c34c-1a29-45d0-9243-8ed0a6f69272"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4252), null, true, false, "Bilim Kurgu", null },
                    { new Guid("b2acfd08-439c-4752-a62c-f72e64c06a05"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4278), null, true, false, "Korku", null },
                    { new Guid("e82f5437-a887-4ded-a1ce-6a56ee3d0c2e"), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4272), null, true, false, "Fantastik", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("5c692a91-4453-4db5-be77-34e5feffde1e"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4480), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("b27cdf16-bc5d-4def-aeb6-f542f842c355"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4478), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("bdd2dc63-da31-4062-ad30-ea0d691cdc94"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4487), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("d24eb5e5-b8b6-4806-bd9c-e9cf5cf5c126"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 22, 36, 24, 813, DateTimeKind.Utc).AddTicks(4490), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null }
                });
        }
    }
}
