using MediatR;

namespace Note.Backend.Application.Features.RecipeIngredient.GetAllRetrieve;

public record GetAllIngredientRetrieverRequest() :IRequest<GetAllIngredientRetrieverResponse>;