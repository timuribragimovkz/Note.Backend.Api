using MediatR;
using Note.Backend.Domain.Ingredients.Enums;

namespace Note.Backend.Application.Features.RecipeIngredient.Edit;

public record IngredientEditorRequest(string Id, string Name,
    IngredientType IngredientType,
    float ProteinsPercentage,
    float FatsPercentage,
    float CarbohydratesPercentage,
    float Weight) : IRequest<IngredientEditorResponse>
{
    public Domain.Ingredients.Models.RecipeIngredient ToRecipeIngredient()
    {
        return new Domain.Ingredients.Models.RecipeIngredient(Name, IngredientType, ProteinsPercentage, FatsPercentage,
            CarbohydratesPercentage, Weight);
    }
};