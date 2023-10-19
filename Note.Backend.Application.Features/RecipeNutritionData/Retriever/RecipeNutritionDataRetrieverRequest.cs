using MediatR;

namespace Note.Backend.Application.Features.RecipeNutritionData.Retriever;

public record RecipeNutritionDataRetrieverRequest(string Id) : IRequest<RecipeNutritionDataRetrieverResponse>
{
}
