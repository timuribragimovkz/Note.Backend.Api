using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.Recipe.Edit;

public class RecipeEditorRequestHandler : IRequestHandler<RecipeEditorRequest, RecipeEditorResponse>
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeEditorRequestHandler(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public async Task<RecipeEditorResponse> Handle(RecipeEditorRequest request, CancellationToken cancellationToken)
    {
        var updateRecipe = await _recipeRepository.UpdateRequiredById(request.Id, request.ToRecipe());
        return new RecipeEditorResponse();
    }
}
