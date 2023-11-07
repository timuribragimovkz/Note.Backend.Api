using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Backend.Application.Features.RecipeIngredientList;
using Note.Backend.Application.Features.RecipeNutritionData.Retriever;

namespace Note.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]

public class RecipeShoppingListController
{
    private readonly IMediator _mediator;

    public RecipeShoppingListController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetRecipeShoppingListById")]
    [HttpPost]
    public async Task<RecipeIngredientListResponse> GetRecipeShoppingListById(RecipeIngredientListRequest request)
    {
        return await _mediator.Send(request);
    }
}
