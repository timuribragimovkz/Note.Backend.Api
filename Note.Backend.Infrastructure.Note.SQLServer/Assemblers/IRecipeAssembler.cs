using Note.Backend.Domain.Recipe.Models;
using Note.Backend.Infrastructure.SQLServer.Models;

namespace Note.Backend.Infrastructure.SQLServer.Assemblers;

public interface IRecipeAssembler
{
    Task<DomainRecipe> AssembleForRecipePageRequiredFromDto(RecipeDto dto);
}