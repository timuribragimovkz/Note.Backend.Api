using MediatR;

namespace Note.Backend.Application.Features.Recipe.Retrieve;

public record RecipeRetrieverRequest(string Id) : IRequest<RecipeRetrieverResponse>
{
}
