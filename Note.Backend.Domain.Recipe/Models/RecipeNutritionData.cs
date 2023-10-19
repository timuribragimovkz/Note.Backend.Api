using Note.Backend.Domain.Common.BaseModels;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.NutritionData.Calculator;
using Note.Backend.Domain.NutritionData.Models;

namespace Note.Backend.Domain.Recipe.Models;

public class RecipeNutritionData : BaseDomainEntity
{
    public int TotalProteinWeight { get; set; }
    public int TotalProteinCalories { get; set; }
    public int TotalFatWeight { get; set; }
    public int TotalFatCalories { get; set; }
    public int TotalCarbWeight { get; set; }
    public int TotalCarbCalories { get; set; }
    public int TotalCalories { get; set; }

    public void Recalculate(IEnumerable<RecipeIngredient> recipeIngredients, int portionQuantity)
    {
        var nutritionDataOutput = NutritionDataCalculator.CalculateNutritionData(CalculateNutritionDataInput.FromRecipeDomain(recipeIngredients, portionQuantity));

        SetPropertyValues(nutritionDataOutput);
    }

    private void SetPropertyValues(CalculateNutritionDataOutput nutritionDataOutput)
    {
        TotalProteinWeight = nutritionDataOutput.TotalProteinWeight;
        TotalProteinCalories = nutritionDataOutput.TotalProteinCalories;
        TotalFatWeight = nutritionDataOutput.TotalFatWeight;
        TotalFatCalories = nutritionDataOutput.TotalFatCalories;
        TotalCarbWeight = nutritionDataOutput.TotalCarbWeight;
        TotalCarbCalories = nutritionDataOutput.TotalCarbCalories;
        TotalCalories = nutritionDataOutput.TotalCalories;
    }
}