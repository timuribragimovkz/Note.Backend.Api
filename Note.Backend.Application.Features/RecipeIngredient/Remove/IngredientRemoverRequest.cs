using MediatR;

namespace Note.Backend.Application.Features.RecipeIngredient.Remove;

public record IngredientRemoverRequest(string Id) : IRequest<IngredientRemoverResponse>
{
}
