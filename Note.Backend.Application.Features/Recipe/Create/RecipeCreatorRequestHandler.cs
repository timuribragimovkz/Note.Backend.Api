using MediatR;
using Note.Backend.Infrastructure.SQLServer.Assemblers;
using Note.Backend.Infrastructure.SQLServer.Repositories.Authors;
using Note.Backend.Infrastructure.SQLServer.Repositories.Ingredients;
using Note.Backend.Infrastructure.SQLServer.Repositories.NutritionData;
using Note.Backend.Infrastructure.SQLServer.Repositories.Recipes;

namespace Note.Backend.Application.Features.Recipe.Create;

public class RecipeCreatorRequestHandler : IRequestHandler<RecipeCreatorRequest, RecipeCreatorResponse>
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IRecipeCheckForExistAssembler _recipeCheckForExistAssembler;
    private readonly IIngredientRepository _ingredientRepository;
    private readonly IAuthorRepository _authorRepository;
    private readonly IRecipeNutritionDataRepository _recipeNutritionDataRepository;

    public RecipeCreatorRequestHandler(IRecipeRepository recipeRepository, IRecipeAssembler recipeAssembler, IRecipeCheckForExistAssembler recipeCheckForExistAssembler, IIngredientRepository ingredientRepository, IAuthorRepository authorRepository, IRecipeNutritionDataRepository recipeNutritionDataRepository)
    {
        _recipeRepository = recipeRepository;
        _recipeCheckForExistAssembler = recipeCheckForExistAssembler;  
        _ingredientRepository = ingredientRepository;
        _authorRepository = authorRepository;
        _recipeNutritionDataRepository = recipeNutritionDataRepository;
        
    }

    public async Task<RecipeCreatorResponse> Handle(RecipeCreatorRequest request, CancellationToken cancellationToken)
    {
        if (request == null)
        {
            throw new Exception("Your request is empty");
        }
        var isExistAuhor = await _recipeCheckForExistAssembler.CheckExistAuthor(request.AuthorId);
        var author = await _authorRepository.GetRequiredById(request.AuthorId);

        var ingredients = new List<Domain.Ingredients.Models.RecipeIngredient>();
        foreach (var ingredientId in request.IngredientIds)
        {
            var isExistingredient = await _recipeCheckForExistAssembler.CHeckExistIngredient(ingredientId);
            var existIngredient = await _ingredientRepository.GetRequiredById(ingredientId);
            ingredients.Add(existIngredient);
        }
        //check request propetry for null etc,
        //check if Author exist
        //check if ingredientIds exist
        //foreach ingredientIds var ingredients = new List<RecipeIngredient>().Add(_ingredientRepository.GetRequiredById())

        // var nutritionData = nutritionDataCalc.CalcForIng(inredients) => _nutritionDataRepos.Insert()

        //var recipe = new Recipe();
        var CookongTime = new TimeSpan(
            request.DaysCooking,
            request.HoursCooking,
            request.MinutesCooking,
            request.SecondsCooking);

        var PreparationTime = new TimeSpan(
            request.DaysPreparation,
            request.HoursPreparation,
            request.MinutesPreparation,
            request.SecondsPreparation);

        var recipe = new Domain.Recipe.Models.Recipe(
            request.Name,
            author,
            request.Description,
            request.FirstPublicationDateTime,
            request.LastUpdateDateTime,
            PreparationTime,
            CookongTime,
            request.Difficulty,
            ingredients);

        recipe.RecalculateByPortion(1);

        await _recipeNutritionDataRepository.Insert(recipe.NutritionData);

        var id = await _recipeRepository.Insert(recipe);

        return new RecipeCreatorResponse(id);
    }
}
