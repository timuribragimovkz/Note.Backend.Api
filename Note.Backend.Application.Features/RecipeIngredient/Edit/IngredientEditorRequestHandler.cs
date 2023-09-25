using MediatR;
using Note.Backend.Infrastructure.SQLServer.DataBase;

namespace Note.Backend.Application.Features.RecipeIngredient.Edit;

public class IngredientEditorRequestHandler : IRequestHandler<IngredientEditorRequest,IngredientEditorResponse>
{
    private readonly IIngredientRepository _ingredientRepository;

    public IngredientEditorRequestHandler(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }

    public async Task<IngredientEditorResponse> Handle(IngredientEditorRequest request, CancellationToken cancellationToken)
    {
        var updateResult = await _ingredientRepository.UpdateRequiredById(request.Id, request.ToRecipeIngredient());

        return new IngredientEditorResponse(updateResult);
    }
}