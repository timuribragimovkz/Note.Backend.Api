namespace Note.Backend.Domain.NutritionData.Models;

public record CalculateNutritionDataOutput(int TotalProteinWeight, int TotalProteinCalories,
    int TotalFatWeight, int TotalFatCalories, int TotalCarbWeight, int TotalCarbCalories, int TotalCalories);