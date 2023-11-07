using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Domain.ShoppingList.Utilites;
using System.Runtime.CompilerServices;

namespace Note.Backend.Domain.ShoppingList.Models;

public class DomainShoppingList
{
    public float TotalCost { get; set; } = 0;
    public float TotalWeight { get; set; } = 0;
    public List<RecipeIngredient> Ingredients { get; set;}

    public DomainShoppingList(DomainRecipe recipe)
    {
        Ingredients = recipe.Ingredients;
        var IngredientString = ShoppingListIngredientsCostDatabase.CreateIngredientCostExamples();
        IngredientCheckCostUtility ingredientCheckCost = new IngredientCheckCostUtility(IngredientString);

        foreach(var ingredient in Ingredients)
        {
            string ingredientName = ingredient.Name;
            float ingredientCost = ingredientCheckCost.GetIngredientCost(ingredientName);
            TotalCost += ingredientCost;
            TotalWeight += recipe.PortionQuantity;
        }

    }
}

