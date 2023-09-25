using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Backend.Application.Features.RecipeIngredient.Create;
using Note.Backend.Application.Features.RecipeIngredient.Edit;
using Note.Backend.Application.Features.RecipeIngredient.Retrieve;

namespace Note.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class IngredientsController  : ControllerBase
{
    private readonly IMediator _mediator;

    public IngredientsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("AddRecipeIngredient")]
    [HttpPost]
    public async Task<IngredientCreatorResponse> AddRecipeIngredient(IngredientCreatorRequest request)
    {
        return await _mediator.Send(request);
    }
    
    [Route("EditRecipeIngredient")]
    [HttpPost]
    public async Task<IngredientEditorResponse> EditRecipeIngredientById(IngredientEditorRequest request)
    {
        return await _mediator.Send(request);
    }
    [Route("GetRecipeIngredientById")]
    [HttpPost]
    public async Task<IngredientRetrieverResponse> GetRecipeIngredientById(IngredientRetrieverRequest request)
    {
        return await _mediator.Send(request);
    }
}