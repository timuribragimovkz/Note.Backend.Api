// using Note.Backend.Domain.Note.Models;
// using Note.Backend.Infrastructure.NoteDb.Common;
// using Note.Backend.Infrastructure.NoteDb.EndPointModel;
// using Note.Backend.Infrastructure.NoteDb.Models;
// using Note.Backend.Infrastructure.NoteDb.Utilities;
//
// namespace Note.Backend.Infrastructure.NoteDb.DataBase;
//
// public class RecipeDb : IRecipeDb, ISingletonService
// {
//     private readonly List<RecipeDto> _recipe = RecipeInitializer.GenerateSampleRecipe();
//
//     public IEnumerable<DomainRecipe> GetAllRecipies()
//     {
//         var domainRecipe = _recipe.Select(x => x.FromDto());
//
//         return domainRecipe;
//     }
//
//     public DomainRecipe GetRequiredById(string id)
//     {
//         var domainRecipe = GetById(id);
//
//         if (domainRecipe == null)
//         {
//             throw new Exception("Model not found");
//         }
//
//         return domainRecipe;
//     }
//     public void SetIngredient(DomainIngredientData ingredient, DomainRecipe domain)
//     {
//         if (ingredient == null)
//         {
//             throw new Exception("Ingredient not provided");
//         }
//         if (domain == null)
//         {
//             throw new Exception("Recipe not found");
//         }
//         var index = _recipe.FindIndex(x => x.Id == domain.Id);
//         var recipe = _recipe[index].FromDto();
//         recipe.Ingredients.ToList().Add(ingredient);
//         _recipe[index] = RecipeDto.ToDto(recipe);
//     }
//
//     public void AddRecipe(DomainRecipe domainRecipe)
//     {
//         if (domainRecipe == null)
//         {
//             throw new Exception("Model not provided");
//         }
//
//         var recipeDto = RecipeDto.ToDto(domainRecipe);
//
//         _recipe.Add(recipeDto);
//     }
//
//     public void Update(DomainRecipe domainRecipe)
//     {
//         var foundNote = GetRequiredById(domainRecipe.Id);
//
//         var index = _recipe.FindIndex(x => x.Id == domainRecipe.Id);
//
//         _recipe[index] = RecipeDto.ToDto(domainRecipe);
//     }
//
//     public void DeleteById(string id)
//     {
//         var foundNote = _recipe.FirstOrDefault(x => x.Id == id);
//
//         if (foundNote != null)
//         {
//             _recipe.Remove(foundNote);
//         }
//     }
//
//     private DomainRecipe GetById(string id)
//     {
//         if (string.IsNullOrEmpty(id))
//         {
//             throw new Exception("Id not provided");
//         }
//
//         var domainRecipe = _recipe.FirstOrDefault(x => x.Id == id)?.FromDto();
//
//         return domainRecipe;
//     }
//
// }
