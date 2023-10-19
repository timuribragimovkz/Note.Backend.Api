using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Backend.Application.Features.RecipeAuthor.Create;
using Note.Backend.Application.Features.RecipeAuthor.Remove;
using Note.Backend.Application.Features.RecipeAuthor.Retrieve;

namespace Note.Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("AddRecipeAuthor")]
    [HttpPost]
    public async Task<AuthorCreatorResponse> AddRecipeIngredient(AuthorCreatorRequest request)
    {
        return await _mediator.Send(request);
    }

    [Route("GetRecipeAuthorById")]
    [HttpPost]
    public async Task<AuthorRetrieverResponse> GetRecipeIngredientById(AuthorRetrieverRequest request)
    {
        return await _mediator.Send(request);
    }

    [Route("DeleteRecipeAuthor")]
    [HttpPost]
    public async Task<AuthorRemoveResponse> DeleteRecipeAuthor(AuthorRemoveRequest request)
    {
        return await _mediator.Send(request);
    }
}
