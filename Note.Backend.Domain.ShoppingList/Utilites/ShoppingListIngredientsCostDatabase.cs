namespace Note.Backend.Domain.ShoppingList.Utilites;

public class ShoppingListIngredientsCostDatabase
{
    public static string CreateIngredientCostExamples()
    {
        string IngredientCostJson = @"{
            'Tomato': 0.5,
            'Cucumber': 1.0,
            'Spagetti': 1.2,
            'Milk': 2.0
        }";
        return IngredientCostJson;
    }
}
