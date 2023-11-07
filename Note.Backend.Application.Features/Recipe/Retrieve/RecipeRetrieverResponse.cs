using Note.Backend.Domain.Recipe.Enums;

namespace Note.Backend.Application.Features.Recipe.Retrieve;

public record RecipeRetrieverResponse(Domain.Recipe.Models.DomainRecipe recipe)
{
}
