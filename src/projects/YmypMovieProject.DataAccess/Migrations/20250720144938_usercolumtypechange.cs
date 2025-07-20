using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class usercolumtypechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f2f843f-9f90-4578-8a73-39adcdd1706c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8627b99e-2353-4bea-9a65-538789a67339"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad25b17f-2c54-4629-985a-ffca90d2fcaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1394197-c0c6-40a6-bed0-a8147195c665"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e221768e-6e0f-413c-bdcf-0de3be90ebbb"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("383ff54f-8e28-4353-a06a-94e269d3ad7a"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("64ad0a6f-7a78-4ed5-ba13-596a6987ba37"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("bf0848f0-c881-45a5-94a9-42deffb774a2"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("e6494cdf-0e44-49eb-9309-8082c28f9f41"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0efb7e37-439e-4d8f-bf2e-46951bd18255"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9aae3cef-f2da-464e-8e75-0de14517e42d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aa07b5c7-1af8-4f4c-96fa-6910c6eb8eb7"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("05657d1c-3b06-40fd-b4fd-7b5b471f6120"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7239), null, true, false, "Korku", null },
                    { new Guid("65303e8a-dd56-4ecb-8e26-098c070fba4b"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7229), null, true, false, "Komedi", null },
                    { new Guid("7273912e-16bc-4f94-84ef-0e4417605988"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7226), null, true, false, "Bilim Kurgu", null },
                    { new Guid("99d4b41f-c0e8-4572-a938-f09004f3495b"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7231), null, true, false, "Belgesel", null },
                    { new Guid("99efee70-c270-4c50-ba47-211c7b3fb4c9"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7234), null, true, false, "Fantastik", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("83b1116d-c36e-4e0b-9c5d-721a2edb4feb"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7465), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("96dfff2d-1d69-43d9-b2b4-42483ce4e094"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7459), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("d449cb1f-40a0-449b-a57f-d3527503d2a8"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7456), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("da87c3f6-493d-4dfd-8e5a-2e2cb9fc636d"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7454), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("70b28f64-1d02-4caf-a386-7d83bcec85b5"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7507), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("7697f9a1-315c-4489-a616-94bb20481ba8"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7503), "Interstellar movie Nolan..", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.7m, null, true, false, "Interstellar", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b11dbd1c-93a8-4fc9-820b-a3d68440957c"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7497), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05657d1c-3b06-40fd-b4fd-7b5b471f6120"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65303e8a-dd56-4ecb-8e26-098c070fba4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7273912e-16bc-4f94-84ef-0e4417605988"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99d4b41f-c0e8-4572-a938-f09004f3495b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99efee70-c270-4c50-ba47-211c7b3fb4c9"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("83b1116d-c36e-4e0b-9c5d-721a2edb4feb"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("96dfff2d-1d69-43d9-b2b4-42483ce4e094"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d449cb1f-40a0-449b-a57f-d3527503d2a8"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("da87c3f6-493d-4dfd-8e5a-2e2cb9fc636d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("70b28f64-1d02-4caf-a386-7d83bcec85b5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7697f9a1-315c-4489-a616-94bb20481ba8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b11dbd1c-93a8-4fc9-820b-a3d68440957c"));

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 13, 19, 13, 9, 398, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1f2f843f-9f90-4578-8a73-39adcdd1706c"), new DateTime(2025, 7, 13, 19, 13, 9, 398, DateTimeKind.Utc).AddTicks(9646), null, true, false, "Bilim Kurgu", null },
                    { new Guid("8627b99e-2353-4bea-9a65-538789a67339"), new DateTime(2025, 7, 13, 19, 13, 9, 398, DateTimeKind.Utc).AddTicks(9658), null, true, false, "Fantastik", null },
                    { new Guid("ad25b17f-2c54-4629-985a-ffca90d2fcaf"), new DateTime(2025, 7, 13, 19, 13, 9, 398, DateTimeKind.Utc).AddTicks(9654), null, true, false, "Belgesel", null },
                    { new Guid("e1394197-c0c6-40a6-bed0-a8147195c665"), new DateTime(2025, 7, 13, 19, 13, 9, 398, DateTimeKind.Utc).AddTicks(9651), null, true, false, "Komedi", null },
                    { new Guid("e221768e-6e0f-413c-bdcf-0de3be90ebbb"), new DateTime(2025, 7, 13, 19, 13, 9, 398, DateTimeKind.Utc).AddTicks(9667), null, true, false, "Korku", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("383ff54f-8e28-4353-a06a-94e269d3ad7a"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(215), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("64ad0a6f-7a78-4ed5-ba13-596a6987ba37"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(231), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("bf0848f0-c881-45a5-94a9-42deffb774a2"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(212), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("e6494cdf-0e44-49eb-9309-8082c28f9f41"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(225), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0efb7e37-439e-4d8f-bf2e-46951bd18255"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(363), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("9aae3cef-f2da-464e-8e75-0de14517e42d"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(290), "Interstellar movie Nolan..", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.7m, null, true, false, "Interstellar", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("aa07b5c7-1af8-4f4c-96fa-6910c6eb8eb7"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 13, 19, 13, 9, 399, DateTimeKind.Utc).AddTicks(281), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
