using MediatR;

namespace Note.Backend.Application.Features.RecipeIngredientList;

public record RecipeIngredientListRequest(string RecipeId) : IRequest<RecipeIngredientListResponse>
{
}
