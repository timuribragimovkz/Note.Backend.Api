using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;

namespace Note.Backend.Application.Features.RecipeIngredient.Retrieve;

public class IngredientRetrieverRequestHandler : IRequestHandler<IngredientRetrieverRequest, IngredientRetrieverResponse>
{
    private readonly IIngredientRepository _ingredientRepository;

    public IngredientRetrieverRequestHandler(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }

    public async Task<IngredientRetrieverResponse> Handle(IngredientRetrieverRequest request, CancellationToken cancellationToken)
    {
        var result = await _ingredientRepository.GetRequiredById(request.Id);

        return new IngredientRetrieverResponse(true, result.Id);
    }
}