using MediatR;
using Note.Backend.Application.Features.RecipeIngredient.Create;
using Note.Backend.Domain.Recipe.Models;

namespace Note.Backend.Application.Features.RecipeAuthor.Create;

public record AuthorCreatorRequest(string Name) : IRequest<AuthorCreatorResponse>
{
    public Author ToRecipeAuthor()
    {
        return new Author(Name);
    }
}
