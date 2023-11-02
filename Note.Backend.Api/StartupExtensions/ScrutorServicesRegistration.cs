using Note.Backend.Infrastructure.Common.Common;
using Note.Backend.Infrastructure.NoteDb.Common;
using Note.Backend.Infrastructure.SQLServer.Repositories;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;
using Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Api.StartupExtensions;

public static class ScrutorServicesRegistration
{
    public static IServiceCollection RegisterServicesWithScrutor(this IServiceCollection services)
    {
        services.Scan(scan =>
        scan.FromAssemblies()
                .FromApplicationDependencies()
                .AddClasses(classes => classes.AssignableTo<IScrutorService>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime()
                .AddClasses(classes => classes.AssignableTo<IScopedService>())
                .AsImplementedInterfaces()
                .WithScopedLifetime()
                .AddClasses(classes => classes.AssignableTo<IRepository>())
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        return services;
    }

}