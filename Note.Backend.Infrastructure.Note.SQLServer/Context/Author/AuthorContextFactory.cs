using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Note.Backend.Infrastructure.SQLServer.Context.Ingredient;

namespace Note.Backend.Infrastructure.SQLServer.Context.Author;

public class AuthorContextFactory : IDesignTimeDbContextFactory<AuthorContext>
{
    public AuthorContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<AuthorContext>();

        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("C:\\Users\\USER\\source\\repos\\Note.Backend.Api\\RecipeApi\\Note.Backend.Api\\appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("AuthorDb");
        builder.UseSqlServer(connectionString);

        return new AuthorContext(builder.Options);
    }
}
