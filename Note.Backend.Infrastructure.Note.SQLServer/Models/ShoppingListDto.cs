
namespace Note.Backend.Infrastructure.SQLServer.Models;

public class ShoppingListDto
{
    public float TotalCost { get; set; }
    public float TotalWeight { get; set; }
    public List<string> IngredientIds { get; set; }
}
