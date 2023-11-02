using MediatR;

namespace Note.Backend.Application.Features.RecipeAuthor.Retrieve;

public record AuthorRetrieverRequest(string Name) : IRequest<AuthorRetrieverResponse>
{
}
