using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Note.Backend.Infrastructure.SQLServer.Context.NutritionData;

public class RecipeNutritionDataContextFactory : IDesignTimeDbContextFactory<RecipeNutritionDataContext>
{
    public RecipeNutritionDataContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<RecipeNutritionDataContext>();

        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("C:\\Users\\USER\\source\\repos\\Note.Backend.Api\\RecipeApi\\Note.Backend.Api\\appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("RecipeNutritionDataDb");
        builder.UseSqlServer(connectionString);

        return new RecipeNutritionDataContext(builder.Options);
    }
}
