using Note.Backend.Domain.Recipe.Models;

namespace Note.Backend.Application.Features.Recipe.Create;

public record RecipeCreatorResponse(Domain.Recipe.Models.Recipe recipe)
{
}
