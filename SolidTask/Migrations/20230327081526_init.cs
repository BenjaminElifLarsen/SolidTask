using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolidTask.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "AnimalSequence");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [AnimalSequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBird = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carnivores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [AnimalSequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBird = table.Column<bool>(type: "bit", nullable: false),
                    EatenFoodToday = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carnivores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Herbavores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [AnimalSequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBird = table.Column<bool>(type: "bit", nullable: false),
                    GrassedToday = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herbavores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Carnivores");

            migrationBuilder.DropTable(
                name: "Herbavores");

            migrationBuilder.DropSequence(
                name: "AnimalSequence");
        }
    }
}
