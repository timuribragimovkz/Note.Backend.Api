using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;
using System.Security.AccessControl;

namespace Note.Backend.Application.Features.RecipeIngredient.Remove;

public class IngredientRemoverRequestHandler : IRequestHandler<IngredientRemoverRequest,  IngredientRemoverResponse>
{
    private readonly IIngredientRepository _ingredientRepository;

    public IngredientRemoverRequestHandler(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }

    public async Task<IngredientRemoverResponse> Handle(IngredientRemoverRequest request, CancellationToken cancellationToken)
    {
        var existedOne = await _ingredientRepository.DeleteById(request.Id);

        return  new IngredientRemoverResponse(true);
    }
}
