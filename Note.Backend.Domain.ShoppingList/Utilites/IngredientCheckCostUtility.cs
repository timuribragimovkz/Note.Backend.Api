using Newtonsoft.Json;
using System.Text.Json;

namespace Note.Backend.Domain.ShoppingList.Utilites;

public class IngredientCheckCostUtility
{
    private Dictionary<string, float> ingredientCosts;

    public IngredientCheckCostUtility(string json)
    {
        if(json == null)
        {
            throw new Exception("Your request json is empty");
        }
        ingredientCosts = JsonConvert.DeserializeObject<Dictionary<string, float>>(json);
    }

    public float GetIngredientCost(string ingredientName)
    {
        if (ingredientCosts.ContainsKey(ingredientName))
        {
            return ingredientCosts[ingredientName];
        }
        else
        {
            Console.WriteLine($"Ingredient '{ingredientName}' not found.");
            return 0;
        }
    }
}
