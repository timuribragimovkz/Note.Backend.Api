// using Note.Backend.Domain.Note.Enums;
// using Note.Backend.Domain.Note.Models;
// using Note.Backend.Infrastructure.NoteDb.DataBase;
//
// namespace Note.Backend.Infrastructure.NoteDb.EndPointModel;
//
// public class RecipeEndtiont
// {
//     public string Name { get; set; }
//     public string Id { get; set; }
//     public RecipeDifficulty RecipeDifficulty { get; set; }
//     public TimeSpan PreparationTime { get; set; }
//     public TimeSpan CookingTime { get; set; }
//
//
//     public static RecipeEndtiont ToEndPoint(DomainRecipe domainRecipe)
//     {
//         var endPoint = new RecipeEndtiont()
//         {
//             Name = domainRecipe.Name,
//             Id = domainRecipe.Id,
//             RecipeDifficulty = domainRecipe.Difficulty,
//             PreparationTime = domainRecipe.PreparationTime,
//             CookingTime = domainRecipe.CookingTime
//         };
//         return endPoint;
//     }
//
//
// }
