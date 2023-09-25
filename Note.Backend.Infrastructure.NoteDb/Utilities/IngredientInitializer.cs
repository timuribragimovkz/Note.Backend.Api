//using Note.Backend.Domain.Note.Enums;
//using Note.Backend.Domain.Note.Models;
//using Note.Backend.Infrastructure.Common.Models;
//using Note.Backend.Infrastructure.NoteDb.Models;

//namespace Note.Backend.Infrastructure.NoteDb.Utilities;

//public class IngredientInitializer
//{
//    public static new List<IngredientDataDto> IngredientGeneratorSample()
//    {
//        var Tomato = CompileIngredient("Tomato", IngredientType.Vegetable, 1, 1, 4, 50, id: Guid.NewGuid().ToString());
//        var Cabbage = CompileIngredient("Cabbage", IngredientType.Vegetable, 1, 2, 3, 30, id: Guid.NewGuid().ToString());
//        var FriedChicken = CompileIngredient("FriedChicken", IngredientType.Meat, 4, 2, 4, 20, id: Guid.NewGuid().ToString());
//        var Cucumber = CompileIngredient("Cucumber", IngredientType.Vegetable, 1, 1, 1, 60, id: Guid.NewGuid().ToString());
//        var Onion = CompileIngredient("Onion", IngredientType.Vegetable, 1, 1, 1, 10, id: Guid.NewGuid().ToString());
//        var result = new List<IngredientDataDto>();
//        result.Add(Tomato);
//        result.Add(Cabbage);
//        result.Add(FriedChicken);
//        result.Add(Onion);
//        result.Add(Cucumber);
//        return result;
//    }

//    private static IngredientDataDto CompileIngredient(
//        string name,
//        IngredientType ingredientType,
//        float proteinPers,
//        float fatsPers,
//        float carbPers,
//        int weight,
//        string id)
//    {
//        var result = new DomainIngredientData(
//            name,
//            ingredientType,
//            proteinPers,
//            fatsPers,
//            carbPers,
//            weight,
//            id);

//        var dto = new BaseDto() as IngredientDataDto;
//        dto.ToDto()
//        return dto;
//    }

//}
