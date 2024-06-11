using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backpacks",
                columns: table => new
                {
                    IdCharacter = table.Column<int>(type: "int", nullable: false),
                    IdItem = table.Column<int>(type: "int", nullable: false),
                    Ammount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backpacks", x => new { x.IdCharacter, x.IdItem });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Backpacks");
        }
    }
}
