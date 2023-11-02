using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Context.Recipe;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

public interface IRecipeRepository : IBaseSQLRepository<RecipeDto, Recipe, RecipeContext>
{
}