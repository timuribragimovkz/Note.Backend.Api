using Note.Backend.Domain.Ingredients.Enums;
using Note.Backend.Domain.Ingredients.Models;

namespace Note.Backend.Domain.ShoppingList.Models;

public class ShoppingListIngredient
{
    public RecipeIngredient RecipeIngredient { get; set; }
    public IngredientType IngredientType { get; set; }

    public ShoppingListIngredient(RecipeIngredient recipeIngredient)
    {
        RecipeIngredient = recipeIngredient;
        IngredientType = recipeIngredient.IngredientType;
    }
}
