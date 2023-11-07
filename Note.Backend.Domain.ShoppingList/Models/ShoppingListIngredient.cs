using Note.Backend.Domain.Ingredients.Enums;
using Note.Backend.Domain.Ingredients.Models;

namespace Note.Backend.Domain.ShoppingList.Models;

public class ShoppingListIngredient
{
    public RecipeIngredient RecipeIngredient { get; init; }
    public float IngredientPrice { get; init; }

    public ShoppingListIngredient(RecipeIngredient recipeIngredient, float price)
    {
        RecipeIngredient = recipeIngredient;
        IngredientPrice = price;
    }
}
