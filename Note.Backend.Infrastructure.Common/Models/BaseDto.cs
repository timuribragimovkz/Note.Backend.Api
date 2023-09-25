using System.ComponentModel.DataAnnotations;

namespace Note.Backend.Infrastructure.Common.Models;

public class BaseDto
{
    [Key]
    public string Id { get; set; }

    public void SetId()
    {
        Id = string.IsNullOrEmpty(Id) ? Guid.NewGuid().ToString() : Id;
    }


}