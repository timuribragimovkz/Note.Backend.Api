using Note.Backend.Domain.Ingredients.Models;

namespace Note.Backend.Domain.NutritionData.Models;

public record CalculateNutritionDataInput(IEnumerable<CalculateNutritionDataInputIngredient> RecipeIngredients,
    int PortionQuantity)
{
    public static CalculateNutritionDataInput FromRecipeDomain(IEnumerable<RecipeIngredient> recipeIngredients, int portionQuantity)
    {
        return new CalculateNutritionDataInput(recipeIngredients.Select(x =>
            new CalculateNutritionDataInputIngredient(
                x.Weight, x.ProteinsPercentage, x.FatsPercentage, x.CarbohydratesPercentage)), portionQuantity);
    }
};