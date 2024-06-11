using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Characters_IdItem",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Items_ItemIdItem",
                table: "Backpacks");

            migrationBuilder.DropIndex(
                name: "IX_Backpacks_ItemIdItem",
                table: "Backpacks");

            migrationBuilder.DropColumn(
                name: "ItemIdItem",
                table: "Backpacks");

            migrationBuilder.CreateTable(
                name: "CharacterTitles",
                columns: table => new
                {
                    IdCharacter = table.Column<int>(type: "int", nullable: false),
                    IdTitle = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    AccuiredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTitles", x => new { x.IdCharacter, x.IdTitle });
                    table.ForeignKey(
                        name: "FK_CharacterTitles_Characters_IdCharacter",
                        column: x => x.IdCharacter,
                        principalTable: "Characters",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTitles_Titles_IdTitle",
                        column: x => x.IdTitle,
                        principalTable: "Titles",
                        principalColumn: "IdTitle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTitles_IdTitle",
                table: "CharacterTitles",
                column: "IdTitle");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Characters_IdCharacter",
                table: "Backpacks",
                column: "IdCharacter",
                principalTable: "Characters",
                principalColumn: "IdItem",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Items_IdItem",
                table: "Backpacks",
                column: "IdItem",
                principalTable: "Items",
                principalColumn: "IdItem",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Characters_IdCharacter",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Items_IdItem",
                table: "Backpacks");

            migrationBuilder.DropTable(
                name: "CharacterTitles");

            migrationBuilder.AddColumn<int>(
                name: "ItemIdItem",
                table: "Backpacks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Backpacks_ItemIdItem",
                table: "Backpacks",
                column: "ItemIdItem");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Characters_IdItem",
                table: "Backpacks",
                column: "IdItem",
                principalTable: "Characters",
                principalColumn: "IdItem",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Items_ItemIdItem",
                table: "Backpacks",
                column: "ItemIdItem",
                principalTable: "Items",
                principalColumn: "IdItem");
        }
    }
}
