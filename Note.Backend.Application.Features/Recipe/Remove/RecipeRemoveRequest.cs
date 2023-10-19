using MediatR;

namespace Note.Backend.Application.Features.Recipe.Remove;

public record RecipeRemoveRequest(string Id) : IRequest<RecipeRemoveResponse>
{
}
