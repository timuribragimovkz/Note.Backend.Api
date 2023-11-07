using Note.Backend.Domain.ShoppingList.Models;

namespace Note.Backend.Application.Features.RecipeIngredientList;

public record RecipeIngredientListResponse(IEnumerable<RecipeIngredientListResponseItem> ShoppingListItems, float TotalCost, float TotalWeight)
{
}
