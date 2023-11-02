using AutoMapper;
using Note.Backend.Infrastructure.SQLServer.Migrations;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.AutoMapperProfiles;

public class RecipeIngredientProfile : Profile
{
    public RecipeIngredientProfile()
    {
        CreateMap<Domain.Ingredients.Models.RecipeIngredient, RecipeIngredientDto>();
        CreateMap<RecipeIngredientDto, Domain.Ingredients.Models.RecipeIngredient>();
    }
}