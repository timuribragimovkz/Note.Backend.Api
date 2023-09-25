using Note.Backend.Application.Services.Common;
using Note.Backend.Infrastructure.NoteDb.Common;
using Note.Backend.Infrastructure.SQLServer.Repositories;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;

namespace Note.Backend.Api.StartupExtensions;

public static class ScrutorServicesRegistration
{
    public static IServiceCollection RegisterServicesWithScrutor(this IServiceCollection services)
    {
        services.Scan(scan =>
        scan.FromAssemblies(
            typeof(IngredientRepository).Assembly
            )
                .FromApplicationDependencies()
                .AddClasses(classes => classes.AssignableTo<ISingletonService>())
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