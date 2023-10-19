using MediatR;
using Note.Backend.Domain.Recipe.Enums;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Migrations;

namespace Note.Backend.Application.Features.Recipe.Edit;

public record RecipeEditorRequest(
    string Id,
    string Name,
    Author Author,
    string Description,
    DateTime FirstPublicationDateTime,
    DateTime LastUpdateDateTime,
    TimeSpan PreparationTime,
    TimeSpan CookingTime,
    RecipeDifficulty Difficulty,
    List<Domain.Ingredients.Models.RecipeIngredient> Ingredients) : IRequest<RecipeEditorResponse>
{
    public Domain.Recipe.Models.Recipe ToRecipe()
    {
        return new Domain.Recipe.Models.Recipe(Name, Author, Description, FirstPublicationDateTime,
         LastUpdateDateTime, PreparationTime, CookingTime, Difficulty, Ingredients);
    }
}
