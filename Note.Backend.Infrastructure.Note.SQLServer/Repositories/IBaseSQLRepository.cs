using Microsoft.EntityFrameworkCore;
using Note.Backend.Domain.Common.BaseModels;
using Note.Backend.Infrastructure.Common.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories;

public interface IBaseSQLRepository<TDto, TDomain, TContext>
        where TDto : BaseDto
        where TDomain : BaseDomainEntity
        where TContext : DbContext

{
    Task<string> Insert(TDomain model);
    Task<TDomain> GetRequiredById(string id);
    Task<TDomain> GetById(string id);
    Task<string> DeleteById(string id);
    Task<List<TDomain>> GetAll();
    Task<string> UpdateRequiredById(string id, TDomain model);
}