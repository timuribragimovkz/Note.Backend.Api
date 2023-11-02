namespace Note.Backend.Infrastructure.SQLServer.Assemblers;

public interface IRecipeCheckForExistAssembler
{
   Task<bool> CheckExistAuthor(string AuthorId);
   Task<bool> CHeckExistIngredient(string IngredientId);
}