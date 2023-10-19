using AutoMapper;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Context.Recipe;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

public class RecipeRepository : BaseSQLRepository<RecipeDto, Recipe, RecipeContext>, IRecipeRepository, IRepository
{
    public RecipeRepository(RecipeContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
