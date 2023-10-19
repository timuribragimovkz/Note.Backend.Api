using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Note.Backend.Domain.Common.BaseModels;
using Note.Backend.Domain.Common.Enums;
using Note.Backend.Infrastructure.Common.Exceptions;
using Note.Backend.Infrastructure.Common.Models;

namespace Note.Backend.Infrastructure.SQLServer.Repositories;

public class BaseSQLRepository<TDto, TDomain, TContext> : IBaseSQLRepository<TDto, TDomain, TContext>
    where TDto : BaseDto
    where TDomain : BaseDomainEntity
    where TContext : DbContext

{
    private readonly DbContext _dbContext;
    private readonly IMapper _mapper;
    protected DbSet<TDto> Table => _dbContext.Set<TDto>();

    protected BaseSQLRepository(TContext context, IMapper mapper)
    {
        _dbContext = context;
        _mapper = mapper;
    }

    public async Task<string> Insert(TDomain model)
    {
        var dto = _mapper.Map<TDto>(model);
        await Table.AddAsync(dto);

        await _dbContext.SaveChangesAsync();

        return model.Id;
    }

    public async Task<TDomain> GetRequiredById(string id)
    {
        var foundDto = await GetById(id);
        if (foundDto == null)
        {
            throw new InfrastructureException("Model not found", ErrorCode.ModelNotFound);
        }

        return _mapper.Map<TDomain>(foundDto);
    }

    public async Task<TDomain> GetById(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new InfrastructureException("Id not provided", ErrorCode.IdNotProvided);
        }

        var foundDto = await Table.FindAsync(id);

        return _mapper.Map<TDomain>(foundDto);
    }

    public async Task<string> DeleteById(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new InfrastructureException("Id not provided", ErrorCode.IdNotProvided);
        }

        var foundDto = await Table.FindAsync(id);
        Table.Remove(foundDto);
        await _dbContext.SaveChangesAsync();

        return foundDto.Id;
    }

    public async Task<List<TDomain>> GetAll()
    {
        return await Table.Select(x => _mapper.Map<TDomain>(x)).ToListAsync();
    }

    public async Task<string> UpdateRequiredById(string id, TDomain model)
    {
        var existingDto = await Table.FirstOrDefaultAsync(x => x.Id == id);
        if (existingDto == null)
        {
            throw new InfrastructureException("Model not found", ErrorCode.ModelNotFound);
        }
        var updateDto = _mapper.Map<TDto>(model);

        Table.Remove(existingDto);
        //await _dbContext.SaveChangesAsync();
        
        var addResult = await Table.AddAsync(updateDto);
        await _dbContext.SaveChangesAsync();
        
        return addResult.Entity.Id;
    }
}