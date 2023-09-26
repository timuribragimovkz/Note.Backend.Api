using AutoMapper;
using Note.Backend.Infrastructure.SQLServer.Migrations;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.AutoMapperProfiles;

public class RecipeIngredientProfile : Profile
{
    public RecipeIngredientProfile()
    {
        CreateMap<RecipeIngredient, RecipeIngredientDto>();
        CreateMap<RecipeIngredientDto, RecipeIngredient>();
    }
}