using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;

namespace Note.Backend.Application.Features.RecipeIngredient.GetAllRetrieve;

public class GetAllIngredientRetrieverRequestHandler : IRequestHandler<GetAllIngredientRetrieverRequest, GetAllIngredientRetrieverResponse>
{
    private readonly IIngredientRepository _ingredientRepository;

    public GetAllIngredientRetrieverRequestHandler(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }

    public async Task<GetAllIngredientRetrieverResponse> Handle(GetAllIngredientRetrieverRequest request, CancellationToken cancellationToken)
    {
        return new GetAllIngredientRetrieverResponse(await _ingredientRepository.GetAll());
    }
}