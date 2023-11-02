using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Infrastructure.NoteDb.Common;
using System.Text.Json;
using System;

namespace Note.Backend.Infrastructure.SQLServer.Utilites;

public class RecipeIngredientsJsonManager 
{
    public static string SerializeIngredientsToJson(IEnumerable<string> ingredients)
    {
        string json = JsonSerializer.Serialize(ingredients);

        return json;
    }

    public static IEnumerable<string> DeserializeJsonToIngredients(string jsonString)
    {
        // Use JsonSerializer to deserialize the JSON string back to IEnumerable<string>
        IEnumerable<string> ingredients = JsonSerializer.Deserialize<IEnumerable<string>>(jsonString);
        return ingredients;
    }
}
