using MediatR;
using Note.Backend.Application.Features.RecipeIngredient.Retrieve;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.Recipe.Retrieve;

public class RecipeRetrieverRequestHandler : IRequestHandler<RecipeRetrieverRequest, RecipeRetrieverResponse>
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeRetrieverRequestHandler(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public async Task<RecipeRetrieverResponse> Handle(RecipeRetrieverRequest request, CancellationToken cancellationToken)
    {
        var result = await _recipeRepository.GetById(request.Id);
        result.RecalculateByPortion(request.Portions);
        
        return new RecipeRetrieverResponse(result);
    }
}
