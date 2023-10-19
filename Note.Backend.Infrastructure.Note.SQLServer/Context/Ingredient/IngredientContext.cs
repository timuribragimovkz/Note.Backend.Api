using Microsoft.EntityFrameworkCore;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Context.Ingredient;

public class IngredientContext : DbContext
{
    public IngredientContext(DbContextOptions<IngredientContext> options) : base(options)
    {

    }
    public DbSet<RecipeIngredientDto> IngredientDataDtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeIngredientDto>()
            .ToTable("IngredientData");

        modelBuilder.Entity<RecipeIngredientDto>()
            .Property(r => r.Name)
            .HasColumnType("nvarchar(255)");
        modelBuilder.Entity<RecipeIngredientDto>()
            .Property(r => r.ProteinsPercentage)
            .HasColumnType("float");
        modelBuilder.Entity<RecipeIngredientDto>()
            .Property(r => r.FatsPercentage)
            .HasColumnType("float");
        modelBuilder.Entity<RecipeIngredientDto>()
            .Property(r => r.CarbohydratesPercentage)
            .HasColumnType("float");
        modelBuilder.Entity<RecipeIngredientDto>()
            .Property(r => r.Weight)
            .HasColumnType("float");
    }
}
