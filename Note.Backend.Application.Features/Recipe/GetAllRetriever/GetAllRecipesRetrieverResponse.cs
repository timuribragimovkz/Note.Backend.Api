namespace Note.Backend.Application.Features.Recipe.GetAllRetriever;

public record GetAllRecipesRetrieverResponse(IEnumerable<GetAllRecipesRetrieverResponseItem> Recipes)
{
}
