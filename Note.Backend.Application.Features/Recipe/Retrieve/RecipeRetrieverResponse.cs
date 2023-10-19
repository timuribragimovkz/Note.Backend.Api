using Note.Backend.Domain.Recipe.Enums;

namespace Note.Backend.Application.Features.Recipe.Retrieve;

public record RecipeRetrieverResponse(string Name, RecipeDifficulty Difficulty, TimeSpan CookingTime, TimeSpan PreparationTime)
{
}
