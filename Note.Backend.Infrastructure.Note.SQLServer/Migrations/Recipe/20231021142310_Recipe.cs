using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note.Backend.Infrastructure.SQLServer.Migrations.Recipe
{
    /// <inheritdoc />
    public partial class Recipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "RecipeData",
              columns: table => new
              {
                  Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                  Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                  AuthorId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                  Description = table.Column<string>(type: "nvarchar(255)", nullable: false),
                  FirstPublicationDateTime = table.Column<int>(type: "bigint", nullable: false),
                  LastUpdateDateTime = table.Column<int>(type: "bigint", nullable: false),
                  PreparationTime = table.Column<int>(type: "bigint", nullable: false),
                  CookingTime = table.Column<int>(type: "bigint", nullable: false),
                  Difficulty = table.Column<int>(type: "tinyint", nullable: false),
                  RecipeNutritionDataID = table.Column<string>(type: "nvarchar(255)", nullable: false),
                  IngredientIds = table.Column<string>(type: "nvarchar(255)", nullable: false),
                  PortionQuantity = table.Column<int>(type: "tinyint", nullable: false),
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
}
