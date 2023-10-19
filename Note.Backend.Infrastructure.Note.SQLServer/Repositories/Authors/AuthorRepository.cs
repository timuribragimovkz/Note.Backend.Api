using AutoMapper;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Context.Author;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Authors;

public class AuthorRepository : BaseSQLRepository<AuthorDto, Author, AuthorContext>, IAuthorRepository, IRepository
{
    public AuthorRepository(AuthorContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
