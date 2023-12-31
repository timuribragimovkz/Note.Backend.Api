﻿using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Backend.Application.Features.Recipe.Create;
using Note.Backend.Application.Features.Recipe.Edit;
using Note.Backend.Application.Features.Recipe.GetAllRetriever;
using Note.Backend.Application.Features.Recipe.Remove;
using Note.Backend.Application.Features.Recipe.Retrieve;

namespace Note.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    private readonly IMediator _mediator;

    public RecipeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("AddRecipe")]
    [HttpPost]
    public async Task<RecipeCreatorResponse> AddRecipe(RecipeCreatorRequest request)
    {
        return await _mediator.Send(request);
    }

    [Route("EditRecipe")]
    [HttpPost]
    public async Task<RecipeEditorResponse> EditRecipeById(RecipeEditorRequest request)
    {
        return await _mediator.Send(request);
    }

    [Route("GetRequiredAssembledRecipeById")]
    [HttpPost]
    public async Task<RecipeRetrieverResponse> GetRecipeById(RecipeRetrieverRequest request)
    {
        return await _mediator.Send(request);
    }

    [Route("GetAllRecipes")]
    [HttpGet]
    public async Task<GetAllRecipesRetrieverResponse> GetAllRecipes()
    {
        var request = new GetAllRecipesRetrieverRequest();
        return await _mediator.Send(request);
    }
    [Route("DeleteRecipe")]
    [HttpPost]
    public async Task<RecipeRemoveResponse> DeleteRecipe(RecipeRemoveRequest request)
    {
        return await _mediator.Send(request);
    }
}
