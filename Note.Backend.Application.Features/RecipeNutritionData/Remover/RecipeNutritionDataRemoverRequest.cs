using MediatR;

namespace Note.Backend.Application.Features.RecipeNutritionData.Remover;

public record RecipeNutritionDataRemoverRequest(string NutritionDataID) : IRequest<RecipeNutritionDataRemoverResponse>
{
}
