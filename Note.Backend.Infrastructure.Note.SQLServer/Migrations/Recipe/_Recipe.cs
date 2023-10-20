using Microsoft.EntityFrameworkCore.Migrations;

namespace Note.Backend.Infrastructure.SQLServer.Migrations.Recipe;

public class _Recipe : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "IngredientData",
            columns: table => new
            {
                Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                AuthorID = table.Column<byte>(type: "nvarchar(255)", nullable: false),
                Description = table.Column<double>(type: "nvarchar(255)", nullable: false),
                FirstPublicationDateTime = table.Column<double>(type: "bigint", nullable: false),
                LastUpdateDateTime = table.Column<double>(type: "bigint", nullable: false),
                PreparationTime = table.Column<double>(type: "bigint", nullable: false),
                CookingTime = table.Column<double>(type: "bigint", nullable: false),
                Difficulty = table.Column<double>(type: "tinyint", nullable: false),
                RecipeNutritionDataID = table.Column<double>(type: "nvarchar(255)", nullable: false),
                IngredientID = table.Column<double>(type: "nvarchar(255)", nullable: false),
                PortionQuantity = table.Column<double>(type: "tinyint", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RecipeData", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "RecipeData");
    }
}
