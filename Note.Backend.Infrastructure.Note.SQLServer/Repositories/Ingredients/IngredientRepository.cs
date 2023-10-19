using AutoMapper;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Infrastructure.SQLServer.Context.Ingredient;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;

public class IngredientRepository : BaseSQLRepository<RecipeIngredientDto, RecipeIngredient, IngredientContext>, IIngredientRepository, IRepository
{
    public IngredientRepository(IngredientContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
    // .Where(b => b.Rating < 3)
    // .ExecuteUpdate(setters => setters.SetProperty(b => b.IsVisible, false));
    // .SetProperty(b => b.IsVisible, false)
    // .SetProperty(b => b.Rating, 0)
    // Table.Where(x=>x.Id == id).ExecuteUpdateAsync(s=>s
    //     .SetProperty(x=>x.))
}
