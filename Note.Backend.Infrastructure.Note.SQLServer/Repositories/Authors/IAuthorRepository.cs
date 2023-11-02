using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Context.Author;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Authors
{
    public interface IAuthorRepository : IBaseSQLRepository<AuthorDto, Author, AuthorContext>
    {
        Task<Author> GetRequiredByName(string name);
    }
}