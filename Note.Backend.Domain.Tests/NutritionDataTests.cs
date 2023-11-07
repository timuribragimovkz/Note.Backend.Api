using Note.Backend.Domain.Common.Enums;
using Note.Backend.Domain.Common.Exceptions;
using Note.Backend.Domain.Ingredients.Enums;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.NutritionData.Calculator;
using Note.Backend.Domain.NutritionData.Models;
using Note.Backend.Domain.Recipe.Enums;
using Note.Backend.Domain.Recipe.Models;

namespace Note.Backend.Domain.Tests;

public class NutritionDataTests
{
    [Fact]
    public void Ensure_NutritionDataCalculator_Returns_Expected_Result()
    {
        //Preparation phase: create objects, define expected values
        //ExpectedValues
        const int totalCalories = 11880;

        //TestObject
        var ingredients = new List<CalculateNutritionDataInputIngredient>()
        {
            new(100, (float)0.4, (float)0.2, (float)0.5),
            new(2000, (float)0.4, (float)0.2, (float)0.5)
        };

        var input = new CalculateNutritionDataInput(ingredients, 2);

        //Action
        var result = NutritionDataCalculator.CalculateNutritionData(input);
        Assert.NotNull(result);

        //Asserts
        Assert.Equal(totalCalories, result.TotalCalories);
        Assert.Equal(4400, result.TotalCarbCalories);
        Assert.Equal(1050, result.TotalCarbWeight);
        Assert.Equal(3960, result.TotalFatCalories);
        Assert.Equal(420, result.TotalFatWeight);
        Assert.Equal(3520, result.TotalProteinCalories);
        Assert.Equal(840, result.TotalProteinWeight);

        var totalCaloriesFromMacro = result.TotalCarbCalories + result.TotalFatCalories + result.TotalProteinCalories;
        Assert.Equal(11880, totalCaloriesFromMacro);
    }

    [Fact]
    public void Ensure_Throws_DomainException_When_Ingredient_Already_Exists()
    {
        var recipeIngredient =
            new RecipeIngredient("ingr", IngredientType.Berries, 
                (float)0.1, (float)0.1, (float)0.1, 100);

        var recipe = new Recipe.Models.DomainRecipe("Hiho", new Author("Tim"), "no comment",
            DateTime.Now, DateTime.Now, 
            new TimeSpan(100), new TimeSpan(100), RecipeDifficulty.Easy,
            new List<RecipeIngredient>());
        recipe.AddIngredient(recipeIngredient);
        Assert.Contains(recipeIngredient, recipe.Ingredients);

        var exception = Assert.Throws<DomainException>(() => recipe.AddIngredient(recipeIngredient));
        Assert.Equal(ErrorCode.IngredientAlreadyExists, exception.ErrorCode);
        Assert.Equal($"Provided ingredient with Id: {recipeIngredient.Id} already exists in this recipe", exception.Message);
    }
}