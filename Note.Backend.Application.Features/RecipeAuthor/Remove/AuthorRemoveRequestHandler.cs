using MediatR;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;

namespace Note.Backend.Application.Features.RecipeAuthor.Remove;

public class AuthorRemoveRequestHandler : IRequestHandler<AuthorRemoveRequest, AuthorRemoveResponse>
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorRemoveRequestHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    public async Task<AuthorRemoveResponse> Handle(AuthorRemoveRequest request, CancellationToken cancellationToken)
    {
        var existedOne = await _authorRepository.DeleteById(request.Id);


        return new AuthorRemoveResponse(true);
    }
}
