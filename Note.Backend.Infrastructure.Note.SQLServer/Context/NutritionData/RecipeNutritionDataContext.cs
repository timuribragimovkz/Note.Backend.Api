using Microsoft.EntityFrameworkCore;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Context.NutritionData;

public class RecipeNutritionDataContext : DbContext
{
    public RecipeNutritionDataContext(DbContextOptions<RecipeNutritionDataContext> options) : base(options)
    {

    }
    public DbSet<RecipeNutritionDataDto> RecipeNutritionDataDtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeNutritionDataDto>()
            .ToTable("RecipeNutritionData");

        modelBuilder.Entity<RecipeNutritionDataDto>()
            .Property(r => r.TotalProteinWeight)
            .HasColumnType("tinyint");
        modelBuilder.Entity<RecipeNutritionDataDto>()
            .Property(r => r.TotalProteinCalories)
            .HasColumnType("tinyint");
        modelBuilder.Entity<RecipeNutritionDataDto>()
            .Property(r => r.TotalFatWeight)
            .HasColumnType("tinyint");
        modelBuilder.Entity<RecipeNutritionDataDto>()
            .Property(r => r.TotalFatCalories)
            .HasColumnType("tinyint");
        modelBuilder.Entity<RecipeNutritionDataDto>()
            .Property(r => r.TotalCarbWeight)
            .HasColumnType("tinyint");
        modelBuilder.Entity<RecipeNutritionDataDto>()
            .Property(r => r.TotalCarbCalories)
            .HasColumnType("tinyint");
        modelBuilder.Entity<RecipeNutritionDataDto>()
            .Property(r => r.TotalCalories)
            .HasColumnType("tinyint");
    }
}
