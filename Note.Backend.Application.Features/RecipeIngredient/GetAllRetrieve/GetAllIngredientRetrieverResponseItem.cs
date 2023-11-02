using Note.Backend.Application.Features.Recipe.GetAllRetriever;

namespace Note.Backend.Application.Features.RecipeIngredient.GetAllRetrieve;

public record GetAllIngredientRetrieverResponseItem(string IngredientId, string IngredientName, float IngredientWeight)
{
    public GetAllIngredientRetrieverResponseItem ToResponseItem(Domain.Ingredients.Models.RecipeIngredient recipeIngredient)
    {
        return new GetAllIngredientRetrieverResponseItem(recipeIngredient.Id, recipeIngredient.Name, recipeIngredient.Weight);
    }
}
