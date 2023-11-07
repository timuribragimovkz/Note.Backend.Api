using Note.Backend.Domain.Common.BaseModels;
using Note.Backend.Domain.Common.Enums;
using Note.Backend.Domain.Common.Exceptions;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Enums;

namespace Note.Backend.Domain.Recipe.Models;

public class DomainRecipe : BaseDomainEntity
{
    public string Name { get; init; }
    public Author Author { get; private set; }
    public string Description { get; private set; }
    public DateTime FirstPublicationDateTime { get; private set; }
    public DateTime LastUpdateDateTime { get; private set; }
    public TimeSpan PreparationTime { get; private set; }
    public TimeSpan CookingTime { get; private set; }
    public RecipeDifficulty Difficulty { get; private set; }
    public RecipeNutritionData NutritionData { get; private set; }
    public List<RecipeIngredient> Ingredients { get; private set; }
    public int PortionQuantity { get; private set; } = 1;

    public DomainRecipe(string name, Author author, string description, DateTime firstPublicationDateTime,
        DateTime lastUpdateDateTime, TimeSpan preparationTime, TimeSpan cookingTime, RecipeDifficulty difficulty,
        List<RecipeIngredient> ingredients)
    {
        Name = name;
        Author = author;
        Description = description;
        FirstPublicationDateTime = firstPublicationDateTime;
        LastUpdateDateTime = lastUpdateDateTime;
        PreparationTime = preparationTime;
        CookingTime = cookingTime;
        Difficulty = difficulty;
        var nutritionData = new RecipeNutritionData();
        nutritionData.Recalculate(ingredients, 1);
        NutritionData = nutritionData;
        Ingredients = ingredients;
    }
    public DomainRecipe() { }

    public void Assemble(List<RecipeIngredient> ingredients, Author author, RecipeNutritionData recipeNutritionData)
    {
        Ingredients = ingredients;
        Author = author;
        NutritionData = recipeNutritionData;
    }
    public void AddIngredient(RecipeIngredient ingredient)
    {
        if (Ingredients.Any(x => x.Id == ingredient.Id))
        {
            throw new DomainException($"Provided ingredient with Id: {ingredient.Id} already exists in this recipe",
                ErrorCode.IngredientAlreadyExists);
        }

        Ingredients.Add(ingredient);

        NutritionData.Recalculate(Ingredients, PortionQuantity);
    }
    public void RecalculateByPortion(int portion)
    {
        NutritionData.Recalculate(Ingredients, PortionQuantity);
    }
}