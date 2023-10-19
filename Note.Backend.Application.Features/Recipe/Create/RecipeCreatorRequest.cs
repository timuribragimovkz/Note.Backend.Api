using MediatR;
using Note.Backend.Domain.Recipe.Enums;
using Note.Backend.Domain.Recipe.Models;

namespace Note.Backend.Application.Features.Recipe.Create;

public record RecipeCreatorRequest(
    string Name,
    Author Author,
    string Description,
    DateTime FirstPublicationDateTime,
    DateTime LastUpdateDateTime,
    TimeSpan PreparationTime,
    TimeSpan CookingTime,
    RecipeDifficulty Difficulty,
    List<Domain.Ingredients.Models.RecipeIngredient> Ingredients) : IRequest<RecipeCreatorResponse>
{
    public Domain.Recipe.Models.Recipe ToRecipe()
    {
        return new Domain.Recipe.Models.Recipe(Name, Author, Description, FirstPublicationDateTime,
         LastUpdateDateTime, PreparationTime, CookingTime, Difficulty,
        Ingredients);
    }
}
