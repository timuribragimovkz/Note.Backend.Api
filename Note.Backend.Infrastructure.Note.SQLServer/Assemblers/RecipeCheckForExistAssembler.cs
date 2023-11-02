using Note.Backend.Infrastructure.Common.Common;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;

namespace Note.Backend.Infrastructure.SQLServer.Assemblers;

public class RecipeCheckForExistAssembler : IRecipeCheckForExistAssembler, IScopedService
{
    private readonly IRecipeAssembler _recipeAssembler;
    private readonly IAuthorRepository _authorRepository;
    private readonly IIngredientRepository _ingredientRepository;

    public RecipeCheckForExistAssembler(IRecipeAssembler recipeAssembler, IAuthorRepository authorRepository, IIngredientRepository ingredientRepository)
    {
        _recipeAssembler = recipeAssembler;
        _authorRepository = authorRepository;
        _ingredientRepository = ingredientRepository;
    }

    public async Task<bool> CheckExistAuthor(string AuthorId)
    {
        if (string.IsNullOrEmpty(AuthorId))
        {
            throw new Exception("Author Id is empty");
        }
        
        var existAuthor = await _authorRepository.GetById(AuthorId);

        if (existAuthor == null)
        {
            return false;
        }
        return true;   
    }

    public async Task<bool> CHeckExistIngredient(string IngredientId)
    {
        if (string.IsNullOrEmpty(IngredientId))
        {
            throw new Exception("Ingredient Id is empty");
        }

        var existIngredient = await _ingredientRepository.GetById(IngredientId);

        if (existIngredient == null)
        {
            return false;
        }
        return true;
    }
}
