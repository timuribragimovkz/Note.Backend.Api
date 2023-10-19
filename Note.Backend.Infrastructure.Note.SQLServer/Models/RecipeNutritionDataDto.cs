using Note.Backend.Infrastructure.Common.Models;

namespace Note.Backend.Infrastructure.SQLServer.Models;

public class RecipeNutritionDataDto : BaseDto
{
    public int TotalProteinWeight { get; set; }
    public int TotalProteinCalories { get; set; }
    public int TotalFatWeight { get; set; }
    public int TotalFatCalories { get; set; }
    public int TotalCarbWeight { get; set; }
    public int TotalCarbCalories { get; set; }
    public int TotalCalories { get; set; }
}
