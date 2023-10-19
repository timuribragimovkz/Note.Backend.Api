using MediatR;

namespace Note.Backend.Application.Features.RecipeAuthor.Retrieve;

public record AuthorRetrieverRequest(string Id) : IRequest<AuthorRetrieverResponse>
{
}
