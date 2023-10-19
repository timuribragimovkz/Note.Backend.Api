using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Context.NutritionData;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;

public interface IRecipeNutritionDataRepository : IBaseSQLRepository<RecipeNutritionDataDto, RecipeNutritionData, RecipeNutritionDataContext>
{
}