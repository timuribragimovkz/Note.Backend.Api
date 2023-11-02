using MediatR;
using Note.Backend.Application.Features.RecipeIngredient.Retrieve;
using Note.Backend.Infrastructure.SQLServer.Assemblers;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.Recipe.Retrieve;

public class RecipeRetrieverRequestHandler : IRequestHandler<RecipeRetrieverRequest, RecipeRetrieverResponse>
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IRecipeAssembler _recipeAssembler;

    public RecipeRetrieverRequestHandler(IRecipeRepository recipeRepository, IRecipeAssembler recipeAssembler)
    {
        _recipeRepository = recipeRepository;
        _recipeAssembler = recipeAssembler;
    }

    public async Task<RecipeRetrieverResponse> Handle(RecipeRetrieverRequest request, CancellationToken cancellationToken)
    {
        var result = await _recipeRepository.GetRequiredById(request.Id);
        result.RecalculateByPortion(request.Portions);
        
        return new RecipeRetrieverResponse(result);
    }
}
