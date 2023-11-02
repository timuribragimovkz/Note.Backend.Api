using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Note.Backend.Domain.Common.BaseModels;
using Note.Backend.Domain.Common.Enums;
using Note.Backend.Domain.Ingredients.Models;
using Note.Backend.Infrastructure.Common.Exceptions;
using Note.Backend.Infrastructure.Common.Models;
using Note.Backend.Infrastructure.SQLServer.Utilites;

namespace Note.Backend.Infrastructure.SQLServer.Repositories;

public class BaseSQLRepository<TDto, TDomain, TContext> : IBaseSQLRepository<TDto, TDomain, TContext>
    where TDto : BaseDto
    where TDomain : BaseDomainEntity
    where TContext : DbContext

{
    protected readonly DbContext DbContext;
    protected readonly IMapper Mapper;
    protected DbSet<TDto> Table => DbContext.Set<TDto>();

    protected BaseSQLRepository(TContext context, IMapper mapper)
    {
        DbContext = context;
        Mapper = mapper;
    }

    public async Task<string> Insert(TDomain model)
    {
        var dto = Mapper.Map<TDto>(model);
        await Table.AddAsync(dto);

        await DbContext.SaveChangesAsync();

        return model.Id;
    }

    public virtual async Task<TDomain> GetRequiredById(string id)
    {
        var foundDto = await GetById(id);
        if (foundDto == null)
        {
            throw new InfrastructureException("Model not found", ErrorCode.ModelNotFound);
        }

        return Mapper.Map<TDomain>(foundDto);
    }

    private async Task<TDomain> GetById(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new InfrastructureException("Id not provided", ErrorCode.IdNotProvided);
        }

        var foundDto = await Table.FindAsync(id);

        return Mapper.Map<TDomain>(foundDto);
    }

    public async Task<string> DeleteById(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new InfrastructureException("Id not provided", ErrorCode.IdNotProvided);
        }

        var foundDto = await Table.FindAsync(id);
        Table.Remove(foundDto);
        await DbContext.SaveChangesAsync();

        return foundDto.Id;
    }

    public async Task<List<TDomain>> GetAll()
    {
        return await Table.Select(x => Mapper.Map<TDomain>(x)).ToListAsync();
    }

    public async Task<string> UpdateRequiredById(string id, TDomain model)
    {
        var existingDto = await Table.FirstOrDefaultAsync(x => x.Id == id);
        if (existingDto == null)
        {
            throw new InfrastructureException("Model not found", ErrorCode.ModelNotFound);
        }
        var updateDto = Mapper.Map<TDto>(model);

        Table.Remove(existingDto);
        //await _dbContext.SaveChangesAsync();
        
        var addResult = await Table.AddAsync(updateDto);
        await DbContext.SaveChangesAsync();
        
        return addResult.Entity.Id;
    }

}