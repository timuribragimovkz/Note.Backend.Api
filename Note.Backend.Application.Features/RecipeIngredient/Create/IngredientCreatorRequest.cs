using MediatR;
using Note.Backend.Domain.Ingredients.Enums;

namespace Note.Backend.Application.Features.RecipeIngredient.Create;

public record IngredientCreatorRequest(
    string Name,
    IngredientType IngredientType,
    float ProteinsPercentage,
    float FatsPercentage,
    float CarbohydratesPercentage,
    float Weight) : IRequest<IngredientCreatorResponse>
{
    public Domain.Ingredients.Models.RecipeIngredient ToRecipeIngredient()
    {
        return new Domain.Ingredients.Models.RecipeIngredient(Name, IngredientType, ProteinsPercentage, FatsPercentage,
            CarbohydratesPercentage, Weight);
    }
}