// namespace Note.Backend.Infrastructure.Common.Models;
//
// public class IngredientDataDto : BaseDto
// {
//     public string Name { get; set; }
//     public IngredientType IngredientType { get; set; }
//     public float ProteinsPercentage { get; set; }
//     public float FatsPercentage { get; set; }
//     public float CarbohydratesPercentage { get; set; }
//     public int Weight { get; set; }
//
//     public DomainIngredientData FromDto()
//     {
//         return new DomainIngredientData(Name, IngredientType, ProteinsPercentage, FatsPercentage, CarbohydratesPercentage, Weight, Id);
//
//     }
//
//     // wht a fuck Tima
//     public IngredientDataDto ToDto(DomainIngredientData domainIngredientData)
//     {
//         return new IngredientDataDto()
//         {
//             Id = domainIngredientData.Id,
//             Name = domainIngredientData.Name,
//             IngredientType = domainIngredientData.IngredientType,
//             ProteinsPercentage = domainIngredientData.ProteinsPercentage,
//             FatsPercentage = domainIngredientData.FatsPercentage,
//             CarbohydratesPercentage = domainIngredientData.CarbohydratesPercentage,
//             Weight = domainIngredientData.Weight
//         };
//     }
// }
