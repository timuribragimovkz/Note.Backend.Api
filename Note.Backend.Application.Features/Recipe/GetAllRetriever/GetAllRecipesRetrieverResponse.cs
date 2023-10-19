namespace Note.Backend.Application.Features.Recipe.GetAllRetriever;

public record GetAllRecipesRetrieverResponse(IEnumerable<Domain.Recipe.Models.Recipe> Recipes)
{
}
