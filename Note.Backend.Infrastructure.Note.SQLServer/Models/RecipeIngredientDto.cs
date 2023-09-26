using Note.Backend.Domain.Ingredients.Enums;
using Note.Backend.Infrastructure.Common.Models;

namespace Note.Backend.Infrastructure.SQLServer.Models;

public class RecipeIngredientDto : BaseDto
{
    public string Name { get; init; }
    public IngredientType IngredientType { get; init; }
    public float ProteinsPercentage { get; init; }
    public float FatsPercentage { get; init; }
    public float CarbohydratesPercentage { get; init; }
    public float Weight { get; init; }
}