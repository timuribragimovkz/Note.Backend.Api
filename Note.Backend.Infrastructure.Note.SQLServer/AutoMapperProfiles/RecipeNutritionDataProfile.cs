using AutoMapper;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.AutoMapperProfiles;

public class RecipeNutritionDataProfile : Profile
{
    public RecipeNutritionDataProfile()
    {
        CreateMap<RecipeNutritionData, RecipeNutritionDataDto>();
        CreateMap<RecipeNutritionDataDto, RecipeNutritionData>();
    }
}
