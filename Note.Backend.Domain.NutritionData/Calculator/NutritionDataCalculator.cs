using Note.Backend.Domain.NutritionData.Constants;
using Note.Backend.Domain.NutritionData.Models;

namespace Note.Backend.Domain.NutritionData.Calculator;

public class NutritionDataCalculator 
{
    public static CalculateNutritionDataOutput CalculateNutritionData(CalculateNutritionDataInput input)
    {
        var totalProteinWeight = 0;
        var totalProteinCalories = 0;
        var totalFatWeight = 0;
        var totalFatCalories = 0;
        var totalCarbWeight = 0;
        var totalCarbCalories = 0;
        
        foreach (var ingredient in input.RecipeIngredients)
        {
            totalProteinWeight += Convert.ToInt32(ingredient.Weight * ingredient.ProteinsPercentage);
            totalProteinCalories += Convert.ToInt32(totalProteinWeight * NutritionConstants.ProteinCaloriesPerGram);
            
            totalFatWeight += Convert.ToInt32(ingredient.Weight * ingredient.FatsPercentage);
            totalFatCalories += Convert.ToInt32(totalFatWeight * NutritionConstants.FatCaloriesPerGram);
            
            totalCarbWeight += Convert.ToInt32(ingredient.Weight * ingredient.CarbohydratesPercentage);
            totalCarbCalories += Convert.ToInt32(totalCarbWeight * NutritionConstants.CarbCaloriesPerGram);
        }

        var totalCalories = totalProteinCalories + totalFatCalories + totalCarbCalories;
        
        return new CalculateNutritionDataOutput(totalProteinWeight, totalProteinCalories, totalFatWeight,
            totalFatCalories, totalCarbWeight, totalCarbCalories, totalCalories);
    }
}