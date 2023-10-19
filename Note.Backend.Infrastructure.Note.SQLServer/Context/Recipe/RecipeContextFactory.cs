using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Note.Backend.Infrastructure.SQLServer.Context.Recipe;

public class RecipeContextFactory : IDesignTimeDbContextFactory<RecipeContext>
{
    public RecipeContext CreateDbContext(string[] args)
{
    var builder = new DbContextOptionsBuilder<RecipeContext>();

    IConfiguration configuration = new ConfigurationBuilder()
        .AddJsonFile("C:\\Users\\USER\\source\\repos\\Note.Backend.Api\\RecipeApi\\Note.Backend.Api\\appsettings.json")
        .Build();

    var connectionString = configuration.GetConnectionString("RecipeDb");
    builder.UseSqlServer(connectionString);

    return new RecipeContext(builder.Options);
}
}
