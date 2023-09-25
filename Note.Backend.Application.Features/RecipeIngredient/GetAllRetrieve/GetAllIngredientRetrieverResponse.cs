namespace Note.Backend.Application.Features.RecipeIngredient.GetAllRetrieve;

public record GetAllIngredientRetrieverResponse(IEnumerable<Domain.Ingredients.Models.RecipeIngredient> Ingredients);