using MediatR;
using Note.Backend.Infrastructure.SQLServer.DataBase;

namespace Note.Backend.Application.Features.RecipeIngredient.Create;

public class IngredientCreatorRequestHandler : IRequestHandler<IngredientCreatorRequest, IngredientCreatorResponse>
{
    private readonly IIngredientRepository _ingredientRepository;

    public IngredientCreatorRequestHandler(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }

    public async Task<IngredientCreatorResponse> Handle(IngredientCreatorRequest request, CancellationToken cancellationToken)
    {
        var model = request.ToRecipeIngredient();
        var id = await _ingredientRepository.Insert(model);

        return new IngredientCreatorResponse(!string.IsNullOrEmpty(id));
    }
}