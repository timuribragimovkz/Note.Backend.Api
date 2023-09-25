// using Note.Backend.Domain.Note.Models;
// using Note.Backend.Infrastructure.NoteDb.Utilities;
//
// namespace Note.Backend.Infrastructure.NoteDb.Models;
//
// public class ShoppingListDto
// {
//     public List<DomainIngredientData> IngredientList { get; set; }
//     public float TotalCost { get; set; }
//     public float TotalWeight { get; set; }
//
//     public DomainShoppingListIngredient FromDtoShop()
//     {
//         var domainList = new DomainShoppingListIngredient()
//         {
//             IngredientList = IngredientList,
//             TotalCost = TotalCost,
//             TotalWeight = TotalWeight
//         };
//         return domainList;
//     }
//     public ShoppingListDto ToDtoShopping(DomainShoppingListIngredient domainShoppingListIngredient)
//     {
//         var ShoppinhDto = new ShoppingListDto()
//         {
//             IngredientList = domainShoppingListIngredient.IngredientList,
//             TotalCost = domainShoppingListIngredient.TotalCost,
//             TotalWeight = domainShoppingListIngredient.TotalWeight,
//         };
//         return ShoppinhDto;
//     }
// }
