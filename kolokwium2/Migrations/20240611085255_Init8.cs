using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class Init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdItem",
                table: "Characters",
                newName: "IdCharacter");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "IdCharacter", "CurrentWeight", "FirstName", "LastName", "MaxWeight" },
                values: new object[,]
                {
                    { 1, 67, "jan", "nowak", 80 },
                    { 2, 55, "stefan", "koski", 60 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "IdItem", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, "okulary", 20 },
                    { 2, "pilka", 15 }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "IdTitle", "Name" },
                values: new object[,]
                {
                    { 1, "dada" },
                    { 2, "fafa" }
                });

            migrationBuilder.InsertData(
                table: "Backpacks",
                columns: new[] { "IdCharacter", "IdItem", "Ammount" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 1, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "CharacterTitles",
                columns: new[] { "IdCharacter", "IdTitle", "AccuiredAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 1, 13, 25, 13, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 3, 1, 13, 25, 13, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Backpacks",
                keyColumns: new[] { "IdCharacter", "IdItem" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Backpacks",
                keyColumns: new[] { "IdCharacter", "IdItem" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterTitles",
                keyColumns: new[] { "IdCharacter", "IdTitle" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterTitles",
                keyColumns: new[] { "IdCharacter", "IdTitle" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "IdCharacter",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "IdCharacter",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "IdItem",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "IdItem",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "IdTitle",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "IdTitle",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "IdCharacter",
                table: "Characters",
                newName: "IdItem");
        }
    }
}
