using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Note.Backend.Infrastructure.SQLServer.Context.Recipe;

namespace Note.Backend.Infrastructure.SQLServer.Migrations.Recipe
{
    [DbContext(typeof(RecipeContext))]
    partial class RecipeContextModelSnapShot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Note.Backend.Infrastructure.SQLServer.Models.RecipeDto", b =>
            {
                b.Property<string>("RecipeId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(255)");

                b.Property<string>("AutorId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(255)");

                b.Property<double>("FirstPublicationDateTime")
                    .HasColumnType("tinyint");

                b.Property<double>("LastUpdateDateTime")
                    .HasColumnType("tinyint");

                b.Property<double>("PreparationTime")
                    .HasColumnType("tinyint");

                b.Property<double>("CookingTime")
                    .HasColumnType("tinyint");

                b.Property<byte>("Difficulty")
                    .HasColumnType("tinyint");

                b.Property<string>("NutritionId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("RecipeIngredientId")
                    .HasColumnType("nvarchar(450)");

                b.Property<double>("PortionQuantity")
                    .HasColumnType("tinyint");

                b.HasKey("Id");

                b.ToTable("RecipeData", (string)null);
            });
#pragma warning restore 612, 618
        }
    }
}
