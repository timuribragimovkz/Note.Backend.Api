using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Assemblers;
using Note.Backend.Infrastructure.SQLServer.Context.Recipe;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

public class RecipeRepository : BaseSQLRepository<RecipeDto, Recipe, RecipeContext>, IRecipeRepository, IRepository
{
    private readonly IRecipeAssembler _recipeAssembler;
    public RecipeRepository(RecipeContext context, IMapper mapper, IRecipeAssembler recipeAssembler) : base(context, mapper)
    {
        _recipeAssembler = recipeAssembler;
    }

    public async Task<Recipe> GetRecipeById(string id)
    {
        var recipeDto = await GetRequiredRecipeDtoById(id);

        var recipe = await _recipeAssembler.AssembleForRecipePageRequiredFromDto(recipeDto);

        return recipe;
    }
    
    private async Task<RecipeDto> GetRequiredRecipeDtoById(string id)
    {
        var recipeDto = await DbContext.Set<RecipeDto>().FirstOrDefaultAsync(x => x.Id == id);
        if (recipeDto == null)
        {
            throw new Exception("RecipeDto not found by Id: {id}");
        }

        return recipeDto;
    }
}
