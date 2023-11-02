using Note.Backend.Domain.Recipe.Enums;
using Note.Backend.Infrastructure.Common.Models;

namespace Note.Backend.Infrastructure.SQLServer.Models;

public class RecipeDto : BaseDto
{

    public string Name { get; init; } // check string.IsNullOrEmpty, regex 
    public string AuthorId { get; init; } // check if exist, throw
    public string Description { get; private set; } // check string.IsNullOrEmpty, regex
    public DateTime FirstPublicationDateTime { get; private set; } // Datetime.Now
    public DateTime LastUpdateDateTime { get; private set; } // Datetime.Now
    public TimeSpan PreparationTime { get; private set; } //from request
    public TimeSpan CookingTime { get; private set; } //from request
    public RecipeDifficulty Difficulty { get; private set; } //from request
    public string RecipeNutritionDataID { get; private set; } // 1)create to domain, 2) add to db 3) use DtoId
    public string IngredientIds { get; private set; } // check if exits
    public int PortionQuantity { get; private set; } = 1;

    public void SetIngredientsJson(string ingredientsJson)
    {
        IngredientIds = ingredientsJson;
    }
}
