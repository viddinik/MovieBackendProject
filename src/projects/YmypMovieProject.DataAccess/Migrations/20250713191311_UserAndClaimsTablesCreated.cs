using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserAndClaimsTablesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37997abc-1240-4cb5-8a9c-43498d3767cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8074a0b2-1079-49af-b097-ac291968dba4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("836d93e2-9395-4bf6-957e-87383a472e8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95f726b4-b935-46d2-88ce-4a61bb33d89b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbb6cb90-edb1-4534-a39a-82292011e782"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("0acc4131-352c-43da-a9c0-4ed3128467ed"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("25a9fc9c-9047-4e0d-8ca9-5bc9ff5d3db2"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("735b01c8-ed69-4970-9ec9-6bb128353f3e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("750dbcbb-c2c2-46f6-8178-efc2240de627"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("02431c64-8fcd-4e5b-9c74-8070a0c7b6a1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bca6c7a6-5cbe-42d9-9c3d-48b27a1fd8df"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f8abea42-7e96-4bd9-92b3-45d165b495c6"));

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("37997abc-1240-4cb5-8a9c-43498d3767cc"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1781), null, true, false, "Bilim Kurgu", null },
                    { new Guid("8074a0b2-1079-49af-b097-ac291968dba4"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1786), null, true, false, "Belgesel", null },
                    { new Guid("836d93e2-9395-4bf6-957e-87383a472e8d"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1788), null, true, false, "Fantastik", null },
                    { new Guid("95f726b4-b935-46d2-88ce-4a61bb33d89b"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1793), null, true, false, "Korku", null },
                    { new Guid("bbb6cb90-edb1-4534-a39a-82292011e782"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1783), null, true, false, "Komedi", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0acc4131-352c-43da-a9c0-4ed3128467ed"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1925), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("25a9fc9c-9047-4e0d-8ca9-5bc9ff5d3db2"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1933), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("735b01c8-ed69-4970-9ec9-6bb128353f3e"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1930), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("750dbcbb-c2c2-46f6-8178-efc2240de627"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1922), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("02431c64-8fcd-4e5b-9c74-8070a0c7b6a1"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1964), "Interstellar movie Nolan..", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.7m, null, true, false, "Interstellar", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bca6c7a6-5cbe-42d9-9c3d-48b27a1fd8df"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1970), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f8abea42-7e96-4bd9-92b3-45d165b495c6"), new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"), new DateTime(2025, 7, 9, 20, 44, 58, 415, DateTimeKind.Utc).AddTicks(1959), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("b3401950-fc04-481f-9be8-28043b9b762c"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
