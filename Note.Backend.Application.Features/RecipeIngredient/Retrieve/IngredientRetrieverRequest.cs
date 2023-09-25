using MediatR;

namespace Note.Backend.Application.Features.RecipeIngredient.Retrieve;

public record IngredientRetrieverRequest(string Id) :IRequest<IngredientRetrieverResponse>;