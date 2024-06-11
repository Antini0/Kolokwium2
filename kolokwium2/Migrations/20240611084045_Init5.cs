using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemIdItem",
                table: "Backpacks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CurrentWeight = table.Column<int>(type: "int", nullable: false),
                    MaxWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.IdItem);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backpacks_IdItem",
                table: "Backpacks",
                column: "IdItem");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Characters_IdItem",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Items_ItemIdItem",
                table: "Backpacks");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Backpacks_IdItem",
                table: "Backpacks");

            migrationBuilder.DropIndex(
                name: "IX_Backpacks_ItemIdItem",
                table: "Backpacks");

            migrationBuilder.DropColumn(
                name: "ItemIdItem",
                table: "Backpacks");
        }
    }
}
