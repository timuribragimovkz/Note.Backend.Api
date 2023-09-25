namespace Note.Backend.Domain.NutritionData.Models;

public record CalculateNutritionDataInputIngredient(float Weight, float ProteinsPercentage, float FatsPercentage,
    float CarbohydratesPercentage);