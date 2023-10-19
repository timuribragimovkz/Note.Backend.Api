using MediatR;
using Note.Backend.Application.Features.RecipeAuthor.Remove;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.Recipe.Remove;

public class RecipeRemoveRequestHandler : IRequestHandler<RecipeRemoveRequest, RecipeRemoveResponse>
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeRemoveRequestHandler(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }
    public async Task<RecipeRemoveResponse> Handle(RecipeRemoveRequest request, CancellationToken cancellationToken)
    {
        var existedOne = await _recipeRepository.DeleteById(request.Id);


        return new RecipeRemoveResponse(true);
    }
}
