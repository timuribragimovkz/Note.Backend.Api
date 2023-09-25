namespace Note.Backend.Domain.Common.BaseModels;

public class BaseDomainEntity
{
    public string Id { get; init; }
    
    public BaseDomainEntity(string? id = null)
    {
        Id = id ?? Guid.NewGuid().ToString();
    }
}