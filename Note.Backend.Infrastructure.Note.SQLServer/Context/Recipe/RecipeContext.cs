using Microsoft.EntityFrameworkCore;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Context.Recipe;

public class RecipeContext : DbContext
{
    public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
    {

    }
    public DbSet<RecipeDto> RecipeDtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeDto>()
            .ToTable("RecipeData");

        //modelBuilder.Entity<RecipeDto>()
        //    .HasNoKey();
        modelBuilder.Entity<RecipeDto>()
            .HasKey(r => r.Id); // Specify the Id property as the primary key
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.Name)
            .HasColumnType("nvarchar(255)");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.AuthorID)
            .HasColumnType("nvarchar(255)");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.Description)
            .HasColumnType("nvarchar(255)");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.FirstPublicationDateTime)
            .HasColumnType("bigint");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.LastUpdateDateTime)
            .HasColumnType("bigint");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.PreparationTime)
            .HasColumnType("bigint");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.CookingTime)
            .HasColumnType("bigint");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.Difficulty)
            .HasColumnType("tinyint");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.RecipeNutritionDataID)
            .HasColumnType("nvarchar(255)");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.IngredientID)
            .HasColumnType("nvarchar(255)");
        modelBuilder.Entity<RecipeDto>()
            .Property(r => r.PortionQuantity)
            .HasColumnType("tinyint");

        //modelBuilder.Entity<RecipeDto>()
        //    .HasOne(r => r.Author)
        //    .WithMany()
        //    .HasForeignKey(r => r.AuthorID)
        //    .IsRequired();
        //modelBuilder.Entity<RecipeDto>()
        //    .HasOne(r => r.RecipeIngredientDto)
        //    .WithMany()
        //    .HasForeignKey(r => r.IngredientID)
        //    .IsRequired();
        //modelBuilder.Entity<RecipeDto>()
        //    .HasOne(r => r.RecipeNutritionData)
        //    .WithMany()
        //    .HasForeignKey(r => r.RecipeNutritionDataID)
        //    .IsRequired();
    }
}
