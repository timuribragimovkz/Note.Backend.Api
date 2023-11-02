using MediatR;
using Note.Backend.Domain.Recipe.Enums;

namespace Note.Backend.Application.Features.Recipe.Create;

public record RecipeCreatorRequest(
    string Name,
    string AuthorId,
    string Description,
    DateTime FirstPublicationDateTime,
    DateTime LastUpdateDateTime,
    int DaysPreparation,
    int HoursPreparation,
    int MinutesPreparation,
    int SecondsPreparation,
    int DaysCooking, 
    int HoursCooking,
    int MinutesCooking,
    int SecondsCooking,
    RecipeDifficulty Difficulty,
    List<string> IngredientIds
    ) : IRequest<RecipeCreatorResponse>
{ }
