using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Application.Features.RecipeAuthor.Retrieve;

public record AuthorRetrieverResponse(string Name, string Id)
{
}
