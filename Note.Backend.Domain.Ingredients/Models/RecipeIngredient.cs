using Note.Backend.Domain.Common.BaseModels;
using Note.Backend.Domain.Ingredients.Enums;

namespace Note.Backend.Domain.Ingredients.Models;

public class RecipeIngredient : BaseDomainEntity
{
    public string Name { get; private set; }
    public IngredientType IngredientType { get; private set; }
    public float ProteinsPercentage { get; private set; }
    public float FatsPercentage { get; private set; }
    public float CarbohydratesPercentage { get; private set; }
    public float Weight { get; private set; }

    public RecipeIngredient(string name, IngredientType ingredientType, float proteinsPercentage, float fatsPercentage,
        float carbohydratesPercentage, float weight)
    {
        Name = name;
        IngredientType = ingredientType;
        ProteinsPercentage = proteinsPercentage;
        FatsPercentage = fatsPercentage;
        CarbohydratesPercentage = carbohydratesPercentage;
        Weight = weight;
    }
}