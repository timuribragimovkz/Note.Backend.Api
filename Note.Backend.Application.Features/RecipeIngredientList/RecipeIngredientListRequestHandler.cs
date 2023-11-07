using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Note.Backend.Application.Features.Exceptions;
using Note.Backend.Domain.Common.Enums;
using Note.Backend.Domain.ShoppingList.Models;
using Note.Backend.Domain.ShoppingList.Options;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.RecipeIngredientList;

public class RecipeIngredientListRequestHandler :IRequestHandler<RecipeIngredientListRequest,RecipeIngredientListResponse> 
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IOptions<IngredientPriceList> _priceList;
    private readonly IConfiguration _configuration;
    public RecipeIngredientListRequestHandler(IRecipeRepository recipeRepository, IOptions<IngredientPriceList> priceList, IConfiguration configuration)
    {
        _recipeRepository = recipeRepository;
        _priceList = priceList;
        _configuration = configuration;
    }

    public async Task<RecipeIngredientListResponse> Handle(RecipeIngredientListRequest request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(request.RecipeId))
        {
            throw new ApplicationLayerException("Request RecipeId is null or empty", ErrorCode.IdNotProvided);
        }
        var existRecipe = await _recipeRepository.GetRequiredById(request.RecipeId);
        
        var shoppingList = new DomainShoppingList(existRecipe,_priceList);

        var shoppingListItems = shoppingList.ShoppingListIngredients.Select(RecipeIngredientListResponseItem.FromDomainIngredient).ToList();

        return new RecipeIngredientListResponse(shoppingListItems, shoppingList.TotalCost, shoppingList.TotalWeight);
    }
}
