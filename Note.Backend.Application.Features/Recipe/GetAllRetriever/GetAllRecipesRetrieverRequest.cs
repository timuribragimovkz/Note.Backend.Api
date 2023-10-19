using MediatR;

namespace Note.Backend.Application.Features.Recipe.GetAllRetriever;

public record GetAllRecipesRetrieverRequest() : IRequest<GetAllRecipesRetrieverResponse>
{
}
