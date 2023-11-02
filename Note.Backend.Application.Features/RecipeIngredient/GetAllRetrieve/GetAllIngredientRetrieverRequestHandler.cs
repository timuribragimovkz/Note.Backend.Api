using MediatR;
using Note.Backend.Application.Features.Recipe.GetAllRetriever;
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
        var existingModel = await _ingredientRepository.GetAll();
        var result = new List<GetAllIngredientRetrieverResponseItem>();
        foreach (var resultItem in existingModel)
        {
            result.Add(new GetAllIngredientRetrieverResponseItem(resultItem.Id, resultItem.Name, resultItem.Weight));
        }
        return new GetAllIngredientRetrieverResponse(result);
    }
}