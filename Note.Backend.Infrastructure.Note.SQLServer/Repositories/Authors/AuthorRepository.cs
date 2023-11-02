using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Note.Backend.Domain.Common.Enums;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.Common.Exceptions;
using Note.Backend.Infrastructure.SQLServer.Context.Author;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Authors;

public class AuthorRepository : BaseSQLRepository<AuthorDto, Author, AuthorContext>, IAuthorRepository, IRepository
{
    public AuthorRepository(AuthorContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<Author> GetRequiredByName(string name)
    {
        var foundAuthor = await Table.FirstOrDefaultAsync(x => x.Name == name);
        if (foundAuthor == null)
        {
            throw new InfrastructureException($"Author not found by name: {name}", ErrorCode.AuthorNotFound);
        }
        
        return Mapper.Map<Author>(foundAuthor);
    }
}
