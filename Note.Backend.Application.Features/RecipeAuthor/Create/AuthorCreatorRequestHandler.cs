using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;

namespace Note.Backend.Application.Features.RecipeAuthor.Create;

public class AuthorCreatorRequestHandler : IRequestHandler<AuthorCreatorRequest, AuthorCreatorResponse>
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorCreatorRequestHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<AuthorCreatorResponse> Handle(AuthorCreatorRequest request, CancellationToken cancellationToken)
    {
        var model = request.ToRecipeAuthor();
        var id = await _authorRepository.Insert(model);

        return new AuthorCreatorResponse(!string.IsNullOrEmpty(id));
    }
}
