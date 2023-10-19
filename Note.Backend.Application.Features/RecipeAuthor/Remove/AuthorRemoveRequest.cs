using MediatR;

namespace Note.Backend.Application.Features.RecipeAuthor.Remove;

public record AuthorRemoveRequest(string Id) : IRequest<AuthorRemoveResponse>;
