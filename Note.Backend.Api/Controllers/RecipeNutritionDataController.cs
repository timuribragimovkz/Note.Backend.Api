﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Backend.Application.Features.RecipeNutritionData.Retriever;

namespace Note.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeNutritionDataController
{
    private readonly IMediator _mediator;

    public RecipeNutritionDataController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetRecipeNutritionDataById")]
    [HttpPost]
    public async Task<RecipeNutritionDataRetrieverResponse> GetRecipeIngredientById(RecipeNutritionDataRetrieverRequest request)
    {
        return await _mediator.Send(request);
    }
}