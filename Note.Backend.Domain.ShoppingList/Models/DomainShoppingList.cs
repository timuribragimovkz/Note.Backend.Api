using Microsoft.Extensions.Options;
using Note.Backend.Domain.Common.Enums;
using Note.Backend.Domain.Common.Exceptions;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Domain.ShoppingList.Options;

namespace Note.Backend.Domain.ShoppingList.Models;

public class DomainShoppingList
{
    public float TotalCost { get; private set; }
    public float TotalWeight { get; init; }
    private IngredientPriceList PriceList { get; init; }
    public List<ShoppingListIngredient> ShoppingListIngredients { get; init; }

    public DomainShoppingList(DomainRecipe recipe, IOptions<IngredientPriceList> priceList)
    {
        TotalWeight = recipe.Ingredients.Select(x => x.Weight).Sum();
        PriceList = priceList.Value;
        ShoppingListIngredients = new List<ShoppingListIngredient>();
        
        foreach (var ingredient in recipe.Ingredients)
        {
            var price = PriceList.PriceList.FirstOrDefault(x => x.Name == ingredient.Name)?.Price;
            if(price == null)
            {
                throw new DomainException($"Price not found for: {ingredient.Name}", ErrorCode.IngredientPriceNotFound);
            }
            ShoppingListIngredients.Add(new ShoppingListIngredient(ingredient, (float)price));
        }
    }
}

