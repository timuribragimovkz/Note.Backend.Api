using Note.Backend.Domain.ShoppingList.Options;

namespace Note.Backend.Api.StartupExtensions;

public static class OptionsRegistration
{
    public static IServiceCollection RegisterOptions(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<IngredientPriceList>(config.GetSection("IngredientPriceListPerKilo"));

        return services;
    }
}