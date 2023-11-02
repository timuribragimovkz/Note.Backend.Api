using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;

namespace Note.Backend.Application.Features.RecipeNutritionData.Remover;

public class RecipeNutritionDataRemoverRequestHandler : IRequestHandler<RecipeNutritionDataRemoverRequest, RecipeNutritionDataRemoverResponse>
{
    private readonly IRecipeNutritionDataRepository _recipeNutritionDataRepository;

    public RecipeNutritionDataRemoverRequestHandler(IRecipeNutritionDataRepository recipeNutritionDataRepository)
    {
        _recipeNutritionDataRepository = recipeNutritionDataRepository;
    }

    public async Task<RecipeNutritionDataRemoverResponse> Handle(RecipeNutritionDataRemoverRequest request, CancellationToken cancellationToken)
    {
        var existOne = await _recipeNutritionDataRepository.DeleteById(request.NutritionDataID);
        return new RecipeNutritionDataRemoverResponse(true);
    }
}
