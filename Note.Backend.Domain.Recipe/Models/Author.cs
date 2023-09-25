using Note.Backend.Domain.Common.BaseModels;

namespace Note.Backend.Domain.Recipe.Models;

public class Author : BaseDomainEntity
{
    public Author(string name,string? id = null) : base(id)
    {
       
        Name = name;
    }
   
    public string Name { get; init; }
}