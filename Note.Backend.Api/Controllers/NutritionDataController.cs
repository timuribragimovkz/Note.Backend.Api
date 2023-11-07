using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Backend.Application.Features.RecipeNutritionData.Remover;
using Note.Backend.Application.Features.RecipeNutritionData.Retriever;

namespace Note.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NutritionDataController
{
    private readonly IMediator _mediator;

    public NutritionDataController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetRecipeNutritionDataById")]
    [HttpPost]
    public async Task<RecipeNutritionDataRetrieverResponse> GetRecipeIngredientById(RecipeNutritionDataRetrieverRequest request)
    {
        return await _mediator.Send(request);
    }

    [Route("RemoveRecipeNutritionDataById")]
    [HttpPost]
    public async Task<RecipeNutritionDataRemoverResponse> RemoveRecipeIngredientById(RecipeNutritionDataRemoverRequest request)
    {
        return await _mediator.Send(request);
    }
}
