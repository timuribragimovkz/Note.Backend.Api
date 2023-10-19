using AutoMapper;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Context.NutritionData;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;

public class RecipeNutritionDataRepository : BaseSQLRepository<RecipeNutritionDataDto, RecipeNutritionData, RecipeNutritionDataContext>, IRecipeNutritionDataRepository, IRepository
{
    public RecipeNutritionDataRepository(RecipeNutritionDataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
