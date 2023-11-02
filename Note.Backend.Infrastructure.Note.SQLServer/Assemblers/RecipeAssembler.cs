using AutoMapper;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.Common.Common;
using Note.Backend.Infrastructure.NoteDb.Common;
using Note.Backend.Infrastructure.SQLServer.Models;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;
using Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;
using Note.Backend.Infrastructure.SQLServer.Utilites;

namespace Note.Backend.Infrastructure.SQLServer.Assemblers;

public class RecipeAssembler : IRecipeAssembler, IScopedService
{
    private readonly IIngredientRepository _ingredientRepository;
    private readonly IAuthorRepository _authorRepository;
    private readonly IRecipeNutritionDataRepository _recipeNutritionDataRepository;
    private readonly IMapper _mapper;

    public RecipeAssembler(IIngredientRepository ingredientRepository, IAuthorRepository authorRepository, 
        IRecipeNutritionDataRepository recipeNutritionDataRepository, IMapper mapper)
    {
        _ingredientRepository = ingredientRepository;
        _authorRepository = authorRepository;
        _recipeNutritionDataRepository = recipeNutritionDataRepository;
        _mapper = mapper;
    }

    public async Task<Recipe> AssembleForRecipePageRequiredFromDto(RecipeDto dto)
    {
        var ingredients = new List<RecipeIngredient>();
        var ingredientsDtoList = RecipeIngredientsJsonManager.DeserializeJsonToIngredients(dto.IngredientIds);


        foreach (var ingredientDtoId in ingredientsDtoList)
        {
            var recipeIngredient = await _ingredientRepository.GetRequiredById(ingredientDtoId);
            ingredients.Add(recipeIngredient);
        }

        var author = await _authorRepository.GetRequiredById(dto.AuthorId);

        var nutritionData = await _recipeNutritionDataRepository.GetRequiredById(dto.RecipeNutritionDataID);
        
        var recipe = _mapper.Map<Recipe>(dto);
        recipe.Assemble(ingredients, author,nutritionData);

        return recipe;
    }
}