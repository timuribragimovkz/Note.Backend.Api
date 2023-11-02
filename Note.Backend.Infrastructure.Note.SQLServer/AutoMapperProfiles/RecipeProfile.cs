using AutoMapper;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Models;
using Note.Backend.Infrastructure.SQLServer.Utilites;
using System.Formats.Tar;

namespace Note.Backend.Infrastructure.SQLServer.AutoMapperProfiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        //CreateMap<List<RecipeIngredient>, string>().ConvertUsing<RecipeIngredientListConverter>();
        CreateMap<Recipe, RecipeDto>()
            .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.Author.Id))
            .ForMember(dest => dest.IngredientIds, opt => opt.MapFrom(src => RecipeIngredientsJsonManager.SerializeIngredientsToJson(src.Ingredients.Select(ri => ri.Id.ToString()))))
            .ForMember(dest => dest.RecipeNutritionDataID, opt => opt.MapFrom(src => src.NutritionData.Id));
        //CreateMap<RecipeDto, Recipe>();
    }
}
