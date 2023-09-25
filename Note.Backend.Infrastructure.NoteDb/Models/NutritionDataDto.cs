// using Note.Backend.Domain.Note.Models;
// using Note.Backend.Infrastructure.NoteDb.DataBase;
//
// namespace Note.Backend.Infrastructure.NoteDb.Models;
//
// public class NutritionDataDto
// {
//     public float TotalProteins { get; set; }
//     public float TotalCarbohydrates { get; set; }
//     public float TotalFats { get; set; }
//     public float TotalCalories { get; set; }
//
//     public DomainNutritionData FromDto()
//     {
//         return new DomainNutritionData(TotalProteins, TotalCarbohydrates, TotalFats, TotalCalories);
//     }
//
//     public static NutritionDataDto ToDto(DomainNutritionData domainNutritionData)
//     {
//         return new NutritionDataDto()
//         {
//             TotalCalories = domainNutritionData.TotalCalories,
//             TotalFats = domainNutritionData.TotalFats,
//             TotalCarbohydrates = domainNutritionData.TotalCarbohydrates,
//             TotalProteins = domainNutritionData.TotalProteins
//
//         };
//     }
// }