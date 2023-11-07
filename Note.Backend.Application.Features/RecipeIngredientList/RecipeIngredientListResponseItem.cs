using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Domain.ShoppingList.Models;

namespace Note.Backend.Application.Features.RecipeIngredientList;

public record RecipeIngredientListResponseItem(float RecipeTotalCost, float RecipeTotalWeight, IEnumerable<string> IngredientNames)
{
    public static RecipeIngredientListResponseItem ToResponseItem(DomainShoppingList domainShoppingList)
    {
        var ingredientNames = new List<string>();
        foreach(var ingredient in domainShoppingList.Ingredients)
        {
            ingredientNames.Add(ingredient.Name);
        }
        return new RecipeIngredientListResponseItem(domainShoppingList.TotalCost, domainShoppingList.TotalWeight, ingredientNames);
    }
}
