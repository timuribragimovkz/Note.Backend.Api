using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Note.Backend.Infrastructure.SQLServer.Context;

public class IngredientContextFactory : IDesignTimeDbContextFactory<IngredientContext>
{
    public IngredientContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<IngredientContext>();

        // var pathToUse = string.Empty;
        // var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        // foreach (var assembly in assemblies)
        // {
        //     var basePath = Path.GetDirectoryName(assembly.Location);
        //     if (File.Exists($"{basePath}/appsettings.json"))
        //     {
        //         pathToUse = basePath;
        //     }
        // }
        
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("/Users/timuribragimov/Desktop/sources3/Note.Backend.Api/Note.Backend.Api/appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("IngredientDataDb");
        builder.UseSqlServer(connectionString);

        return new IngredientContext(builder.Options);
    }
}