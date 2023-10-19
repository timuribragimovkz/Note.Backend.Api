

using Microsoft.EntityFrameworkCore;
using Note.Backend.Infrastructure.SQLServer.Context.Author;
using Note.Backend.Infrastructure.SQLServer.Context.Ingredient;
using Note.Backend.Infrastructure.SQLServer.Context.NutritionData;
using Note.Backend.Infrastructure.SQLServer.Context.Recipe;

namespace Note.Backend.Api.StartupExtensions;

public static class SQLServerDataBaseRegistration
{
    public static IServiceCollection RegisterSQLServerIngredientData(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetSection("ConnectionStrings:IngredientDataDb").Value;
        services.AddEntityFrameworkSqlServer().AddDbContext<IngredientContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
    public static IServiceCollection RegisterSQLServerAuthor(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetSection("ConnectionStrings:AuthorDb").Value;
        services.AddEntityFrameworkSqlServer().AddDbContext<AuthorContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
    public static IServiceCollection RegisterSQLServerNutritionData(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetSection("ConnectionStrings:RecipeNutritionDataDb").Value;
        services.AddEntityFrameworkSqlServer().AddDbContext<RecipeNutritionDataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
    public static IServiceCollection RegisterSQLServerRecipe(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetSection("ConnectionStrings:RecipeDb").Value;
        services.AddEntityFrameworkSqlServer().AddDbContext<RecipeContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}
