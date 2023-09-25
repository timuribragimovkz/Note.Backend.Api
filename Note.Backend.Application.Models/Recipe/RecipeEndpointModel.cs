using Note.Backend.Domain.Note.Enums;
namespace Note.Backend.Application.Models.Recipe;

public class RecipeEndpointModel
{
    public string Name { get; set; }
    public string Id { get; set; }

    public RecipeDifficulty RecipeDifficulty { get; set; }
}
