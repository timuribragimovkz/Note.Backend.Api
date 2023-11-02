using MediatR;
using Note.Backend.Application.Features.RecipeIngredient.GetAllRetrieve;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;
using System.ComponentModel.DataAnnotations;

namespace Note.Backend.Application.Features.Recipe.GetAllRetriever;

public class GetAllRecipesRetrieverRequestHandler : IRequestHandler<GetAllRecipesRetrieverRequest, GetAllRecipesRetrieverResponse>
{
    private readonly IRecipeRepository _recipeRepository;

    public GetAllRecipesRetrieverRequestHandler(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public async Task<GetAllRecipesRetrieverResponse> Handle(GetAllRecipesRetrieverRequest getAllRecipesRetrieverRequest, CancellationToken cancellationToken)
    {
        var existingModel = await _recipeRepository.GetAll();
        var result = new List<GetAllRecipesRetrieverResponseItem>();
        foreach (var resultItem in existingModel)
        {
            result.Add(new GetAllRecipesRetrieverResponseItem(resultItem.Id, resultItem.Name, resultItem.Difficulty, resultItem.CookingTime, resultItem.PreparationTime));
        }


        return new GetAllRecipesRetrieverResponse(result);
    }
}
