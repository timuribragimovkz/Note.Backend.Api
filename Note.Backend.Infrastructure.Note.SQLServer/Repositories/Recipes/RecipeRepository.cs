using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Note.Backend.Domain.Common.Enums;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.Common.Exceptions;
using Note.Backend.Infrastructure.SQLServer.Assemblers;
using Note.Backend.Infrastructure.SQLServer.Context.Recipe;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

public class RecipeRepository : BaseSQLRepository<RecipeDto, Recipe, RecipeContext>, IRecipeRepository, IRepository
{
    private readonly IRecipeAssembler _recipeAssembler;
    private readonly RecipeContext _context;
    public RecipeRepository(RecipeContext context, IMapper mapper, IRecipeAssembler recipeAssembler) : base(context, mapper)
    {
        _recipeAssembler = recipeAssembler;
        _context = context;
    }

    public override async Task<Recipe> GetRequiredById(string id)
    {
        var recipeDto = await GetRequiredRecipeDtoById(id);
        var recipe = await _recipeAssembler.AssembleForRecipePageRequiredFromDto(recipeDto);

        return recipe;
    }

    private async Task<RecipeDto> GetRequiredRecipeDtoById(string id)
    {
        var recipeDto = await _context.Set<RecipeDto>().FirstOrDefaultAsync(x => x.Id == id);
        if (recipeDto == null)
        {
            throw new Exception("RecipeDto not found by Id: {id}");
        }

        return recipeDto;
    }
    //public override Task<Recipe> GetById(string id)
    //{
    //    throw new Exception("Used get GetRequiredAssembledRecipeById");
    //}
}
