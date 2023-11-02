using MediatR;
using Note.Backend.Application.Features.RecipeIngredient.Retrieve;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;

namespace Note.Backend.Application.Features.RecipeAuthor.Retrieve;

public class AuthorRetrieverRequestHandler : IRequestHandler<AuthorRetrieverRequest, AuthorRetrieverResponse>
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorRetrieverRequestHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<AuthorRetrieverResponse> Handle(AuthorRetrieverRequest request, CancellationToken cancellationToken)
    {
        var result = await _authorRepository.GetById(request.Id);

        return new AuthorRetrieverResponse(true, result.Id);
    }
}
