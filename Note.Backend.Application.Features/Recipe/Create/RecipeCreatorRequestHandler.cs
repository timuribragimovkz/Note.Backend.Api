using MediatR;
using Note.Backend.Application.Features.RecipeAuthor.Create;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.Recipe.Create;

public class RecipeCreatorRequestHandler : IRequestHandler<RecipeCreatorRequest, RecipeCreatorResponse>
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeCreatorRequestHandler(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public async Task<RecipeCreatorResponse> Handle(RecipeCreatorRequest request, CancellationToken cancellationToken)
    {
        var model = request.ToRecipe();
        var id = await _recipeRepository.Insert(model);

        return new RecipeCreatorResponse(model);
    }
}
