using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Infrastructure.SQLServer.Context;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;

public interface IIngredientRepository : IBaseSQLRepository<RecipeIngredientDto, RecipeIngredient, IngredientContext>
{
    
}
