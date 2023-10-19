using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;

namespace Note.Backend.Application.Features.RecipeNutritionData.Retriever;

public class RecipeNutritionDataRetrieverRequestHandler : IRequestHandler<RecipeNutritionDataRetrieverRequest, RecipeNutritionDataRetrieverResponse>
{
    private readonly IRecipeNutritionDataRepository _recipeNutritionDataRepository;

    public RecipeNutritionDataRetrieverRequestHandler(IRecipeNutritionDataRepository recipeNutritionDataRepository)
    {
        _recipeNutritionDataRepository = recipeNutritionDataRepository;
    }

    public async Task<RecipeNutritionDataRetrieverResponse> Handle(RecipeNutritionDataRetrieverRequest request, CancellationToken cancellationToken)
    {
        var model = await _recipeNutritionDataRepository.GetRequiredById(request.Id);

        return new RecipeNutritionDataRetrieverResponse(model);
    }
}
