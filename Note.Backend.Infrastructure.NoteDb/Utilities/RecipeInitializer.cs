// using Note.Backend.Domain.Note.Enums;
// using Note.Backend.Domain.Note.Models;
// using Note.Backend.Infrastructure.NoteDb.DataBase;
// using Note.Backend.Infrastructure.NoteDb.Models;
// using System.Xml.Linq;
//
// namespace Note.Backend.Infrastructure.NoteDb.Utilities;
//
// public class RecipeInitializer
// {
//     public static List<RecipeDto> GenerateSampleRecipe()
//     {
//         //Ingredient Database 
//         var Tomato = new DomainIngredientData("Tomato", IngredientType.Vegetable, 1, 1, 4, 50, id: Guid.NewGuid().ToString());
//         var Cabbage = new DomainIngredientData("Cabbage",IngredientType.Vegetable, 1, 2, 3, 30, id: Guid.NewGuid().ToString());
//         var FriedChicken = new DomainIngredientData("FriedChicken", IngredientType.Meat, 4, 2, 4, 20, id: Guid.NewGuid().ToString());
//         var Cucumber = new DomainIngredientData("Cucumber",IngredientType.Vegetable, 1, 1, 1, 60, id: Guid.NewGuid().ToString());
//         var Onion = new DomainIngredientData("Onion", IngredientType.Vegetable, 1, 1, 1, 10, id: Guid.NewGuid().ToString());
//
//         var result = new List<RecipeDto>();
//
//         var r1 = CompileRecipe(
//             new List<DomainIngredientData>()
//             {
//                 Tomato,
//                 Cabbage,
//                 FriedChicken
//             },
//             "Tim",
//             "Tear all of the compounds and mix.",
//             "Cesar",
//             new TimeSpan(60),
//             new TimeSpan(45),
//             RecipeDifficulty.Easy);
//         result.Add(r1);
//
//         var r2 = CompileRecipe(new List<DomainIngredientData>() 
//             { 
//                 Tomato, 
//                 Cucumber, 
//                 Onion 
//              },
//             "Yuriy", 
//             "Combain all and mix.", 
//             "greck", 
//             new TimeSpan(110), new TimeSpan(25), 
//             RecipeDifficulty.Easy); 
//         result.Add(r2);
//         return result;
//     }
//
//     private static RecipeDto CompileRecipe(IEnumerable<DomainIngredientData> ingredients,
//         string authorName,
//         string description,
//         string name,
//         TimeSpan cookingTime,
//         TimeSpan preprationTime,
//         RecipeDifficulty difficulty)
//     {
//         var nutrition = new DomainNutritionData(ingredients);
//         var author = new DomainAuthor(authorName);
//         var recipe = new DomainRecipe(name, author, description,
//             preprationTime, cookingTime, difficulty, nutrition,
//             ingredients.ToList(), 1);
//         return RecipeDto.ToDto(recipe);
//     }
// }
