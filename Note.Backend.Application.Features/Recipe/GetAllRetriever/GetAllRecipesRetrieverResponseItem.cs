using Note.Backend.Domain.Recipe.Enums;

namespace Note.Backend.Application.Features.Recipe.GetAllRetriever;

public record GetAllRecipesRetrieverResponseItem(string RecipeId, string Name, RecipeDifficulty RecipeDifficculty, TimeSpan RecipeCoocingTime, TimeSpan RecipePreparationTime)
{
    public GetAllRecipesRetrieverResponseItem ToResponseItem(Domain.Recipe.Models.DomainRecipe recipe)
    {
        return new GetAllRecipesRetrieverResponseItem(recipe.Id, recipe.Name, recipe.Difficulty, recipe.CookingTime, recipe.PreparationTime);
    }
} 