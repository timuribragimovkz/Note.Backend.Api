using MediatR;
using Note.Backend.Domain.ShoppingList.Models;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.RecipeIngredientList;

public class RecipeIngredientListRequestHandler :IRequestHandler<RecipeIngredientListRequest,RecipeIngredientListResponse> 
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeIngredientListRequestHandler(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public async Task<RecipeIngredientListResponse> Handle(RecipeIngredientListRequest request, CancellationToken cancellationToken)
    {
        var existRecipe = await _recipeRepository.GetRequiredById(request.RecipeId);
        var newShoppingList = new DomainShoppingList(existRecipe);
        var newShoppingListItem = RecipeIngredientListResponseItem.ToResponseItem(newShoppingList);

        return new RecipeIngredientListResponse(newShoppingListItem);
    }
}
