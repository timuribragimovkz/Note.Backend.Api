using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Enums;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.Common.Models;

namespace Note.Backend.Infrastructure.SQLServer.Models;

public class RecipeDto : BaseDto
{
    public string Name { get; init; }
    public string AuthorID { get; init; }
    public AuthorDto Author { get; private set; }
    public string Description { get; private set; }
    public DateTime FirstPublicationDateTime { get; private set; }
    public DateTime LastUpdateDateTime { get; private set; }
    public TimeSpan PreparationTime { get; private set; }
    public TimeSpan CookingTime { get; private set; }
    public RecipeDifficulty Difficulty { get; private set; }
    public string RecipeNutritionDataID { get; private set; }
    public RecipeNutritionDataDto RecipeNutritionData { get; private set; }
    //public RecipeNutritionData NutritionData { get; private set; }
    public string IngredientID { get; private set; }
    public RecipeIngredientDto RecipeIngredientDto { get; private set; }
    public List<RecipeIngredient> Ingredients { get; private set; }
    public int PortionQuantity { get; private set; } = 1;
}
