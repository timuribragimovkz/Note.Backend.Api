using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note.Backend.Infrastructure.SQLServer.Migrations.RecipeNutritionData
{
    /// <inheritdoc />
    public partial class NutritionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
           name: "RecipeNutritionData",
           columns: table => new
           {
               Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
               TotalProteinWeight = table.Column<int>(type: "tinyint", nullable: false),
               TotalProteinCalories = table.Column<int>(type: "tinyint", nullable: false),
               TotalFatWeight = table.Column<int>(type: "tinyint", nullable: false),
               TotalFatCalories = table.Column<int>(type: "tinyint", nullable: false),
               TotalCarbWeight = table.Column<int>(type: "tinyint", nullable: false),
               TotalCarbCalories = table.Column<int>(type: "tinyint", nullable: false),
               TotalCalories = table.Column<int>(type: "tinyint", nullable: false)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_RecipeNutritionData", x => x.Id);
           });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
           name: "RecipeNutritionData");
        }
    }
}
