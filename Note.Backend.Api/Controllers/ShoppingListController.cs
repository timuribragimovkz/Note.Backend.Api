using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Backend.Application.Features.RecipeIngredientList;
using Note.Backend.Application.Features.RecipeNutritionData.Retriever;

namespace Note.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]

public class ShoppingListController
{
    private readonly IMediator _mediator;

    public ShoppingListController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("get-recipe-shopping-list-by-recipe-id")]
    [HttpPost]
    public async Task<RecipeIngredientListResponse> GetRecipeShoppingListByRecipeId(RecipeIngredientListRequest request)
    {
        return await _mediator.Send(request);
    }
}
