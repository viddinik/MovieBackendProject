using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
