

using Microsoft.EntityFrameworkCore;
using Note.Backend.Infrastructure.SQLServer.Context;

namespace Note.Backend.Api.StartupExtensions;

public static class SQLServerDataBaseRegistration
{
    public static IServiceCollection RegisterSQLServer(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetSection("ConnectionStrings:IngredientDataDb").Value;
        services.AddEntityFrameworkSqlServer().AddDbContext<IngredientContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        
        //services.Configure<IngredientDataDbOptions>(config.GetSection("IngredientDataDb"));
        return services;
    }
}
