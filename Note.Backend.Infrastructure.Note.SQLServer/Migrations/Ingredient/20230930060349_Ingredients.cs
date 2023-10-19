//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace Note.Backend.Infrastructure.SQLServer.Migrations
//{
//    /// <inheritdoc />
//    public partial class Ingredients : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "IngredientData",
//                columns: table => new
//                {
//                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
//                    IngredientType = table.Column<byte>(type: "tinyint", nullable: false),
//                    ProteinsPercentage = table.Column<double>(type: "float", nullable: false),
//                    FatsPercentage = table.Column<double>(type: "float", nullable: false),
//                    CarbohydratesPercentage = table.Column<double>(type: "float", nullable: false),
//                    Weight = table.Column<double>(type: "float", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_IngredientData", x => x.Id);
//                });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "IngredientData");
//        }
//    }
//}
