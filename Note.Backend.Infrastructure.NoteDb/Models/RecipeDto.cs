// using Note.Backend.Domain.Note.Enums;
// using Note.Backend.Domain.Note.Models;
// using Note.Backend.Infrastructure.Common.Models;
// using Note.Backend.Infrastructure.NoteDb.Common;
// using System.Collections.Generic;
//
// namespace Note.Backend.Infrastructure.NoteDb.Models;
//
// public class RecipeDto : BaseDto
// {
//     public string Name { get; set; }
//     public AuthorDto Author { get; set; }
//     public string Description { get; set; }
//     public TimeSpan PrepartionTime { get; set; }
//     public TimeSpan CookingTime { get; set; }
//     public RecipeDifficulty Difficulty { get; set; }
//     public NutritionDataDto NutritionData { get; set; }
//     public IEnumerable<DomainIngredientData> Ingredients { get; set; }
//     public int Portions { get; set; }
//
//     public DomainRecipe FromDto()
//     {
//         return new DomainRecipe(Name, Author.FromDto(), Description, PrepartionTime,
//             CookingTime, Difficulty, NutritionData.FromDto(), Ingredients.ToList(), Portions, Id);
//     }
//
//     public static RecipeDto ToDto(DomainRecipe domainRecipe)
//     {
//         return new RecipeDto()
//         {
//             Name = domainRecipe.Name,
//             Author = AuthorDto.ToDto(domainRecipe.Author),
//             Description = domainRecipe.Description ?? string.Empty,
//             PrepartionTime = domainRecipe.PreparationTime,
//             CookingTime = domainRecipe.CookingTime,
//             Difficulty = domainRecipe.Difficulty,
//             NutritionData = NutritionDataDto.ToDto(domainRecipe.NutritionData),
//             Ingredients = domainRecipe.Ingredients,
//             Portions = domainRecipe.PortionQuantity,
//             Id = domainRecipe.Id,
//
//         };
//     }
//
// }
