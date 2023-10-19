using Note.Backend.Application.Services.Common;
using Note.Backend.Infrastructure.NoteDb.Common;
using Note.Backend.Infrastructure.SQLServer.Repositories;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;
using Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Api.StartupExtensions;

public static class ScrutorServicesRegistration
{
    public static IServiceCollection RegisterServicesWithScrutorIngredient(this IServiceCollection services)
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
    public static IServiceCollection RegisterServicesWithScrutorAuthor(this IServiceCollection services)
    {
        services.Scan(scan =>
        scan.FromAssemblies(
            typeof(AuthorRepository).Assembly
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
    public static IServiceCollection RegisterServicesWithScrutorNutritionData(this IServiceCollection services)
    {
        services.Scan(scan =>
        scan.FromAssemblies(
            typeof(RecipeNutritionDataRepository).Assembly
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
    public static IServiceCollection RegisterServicesWithScrutorRecipe(this IServiceCollection services)
    {
        services.Scan(scan =>
        scan.FromAssemblies(
            typeof(RecipeRepository).Assembly
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