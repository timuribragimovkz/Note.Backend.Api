using Note.Backend.Domain.Ingredients.Enums;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Domain.ShoppingList.Models;

namespace Note.Backend.Application.Features.RecipeIngredientList;

public record RecipeIngredientListResponseItem(string IngredientName, float WeightToBuy, float TotalCost, IngredientType type)
{
    public static RecipeIngredientListResponseItem FromDomainIngredient(ShoppingListIngredient ingredient)
    {
        return new RecipeIngredientListResponseItem(
            ingredient.RecipeIngredient.Name,
            ingredient.RecipeIngredient.Weight,
            ingredient.IngredientPrice,
            ingredient.RecipeIngredient.IngredientType);
    }
}