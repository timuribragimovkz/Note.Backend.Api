using MediatR;
using Note.Backend.Application.Features.RecipeIngredient.GetAllRetrieve;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.Recipe.GetAllRetriever;

public class GetAllRecipesRetrieverRequestHandler : IRequestHandler<GetAllRecipesRetrieverRequest, GetAllRecipesRetrieverResponse>
{
    private readonly IRecipeRepository _recipeRepository;

    public GetAllRecipesRetrieverRequestHandler(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }   

    public async Task<GetAllRecipesRetrieverResponse> Handle(GetAllRecipesRetrieverRequest getAllRecipesRetrieverRequest, CancellationToken cancellationToken)
    {
        return new GetAllRecipesRetrieverResponse(await _recipeRepository.GetAll());
    }
}
