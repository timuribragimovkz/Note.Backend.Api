//using Note.Backend.Domain.Note.Enums;
//using Note.Backend.Domain.Note.Models;
//using Note.Backend.Infrastructure.Common.Models;
//using Note.Backend.Infrastructure.NoteDb.Common;
//using Note.Backend.Infrastructure.NoteDb.Models;
//using Note.Backend.Infrastructure.NoteDb.Utilities;

//namespace Note.Backend.Infrastructure.NoteDb.DataBase;

//public class IngredientDataDb : IIngredientDataDb, ISingletonService
//{
//    private readonly List<IngredientDataDto> _ingredients = IngredientInitializer.IngredientGeneratorSample().ToList();

//    public IEnumerable<DomainIngredientData> GetAllIngredients()
//    {
//        var domainIngredients = _ingredients.Select(x => x.FromDto());

//        return domainIngredients;
//    }

//    public DomainIngredientData GetRequiredById(string id)
//    {
//        var domainRecipe = GetById(id);

//        if (domainRecipe == null)
//        {
//            throw new Exception("Model not found");
//        }

//        return domainRecipe;
//    }
//    public void AddIngredient(DomainIngredientData domainIngredientData)
//    {
//        if (domainIngredientData == null)
//        {
//            throw new Exception("Ingredient is not provided");
//        }
//        _ingredients.Add(IngredientDataDto.ToDto(domainIngredientData));
//    }
    
//    public void CreateIngredient(string name, IngredientType type, float protPers, float fatPers, float carbPers, int weight)
//    {
//        var newIngredient = new DomainIngredientData(
//            name,
//            type,
//            protPers,
//            fatPers,
//            carbPers,
//            weight);
//        _ingredients.Add(IngredientDataDto.ToDto(newIngredient));
//    }

//    private DomainIngredientData GetById(string id)
//    {
//        if (string.IsNullOrWhiteSpace(id))
//        {
//            throw new Exception("Id not found");
//        }
//        var ingredient = _ingredients.FirstOrDefault(x => x.Id == id).FromDto();
//        return ingredient;
//    }
//}
