using Microsoft.EntityFrameworkCore;
using dotnet_example.Data;
using dotnet_example.Repository;
using dotnet_example.Models;

namespace dotnet_example.Data.Persistence.Repository;

public class DataRepository<T> : IDataRepository<T> where T : BaseModel
{
    protected readonly BaseDataContext _context;

    public DataRepository(BaseDataContext context)
    {
        _context = context;
    }

    public PagedResponse<T> Get(int page = 1, int pageSize = 10)
    {
        return PagedResponse<T>.ToPagedResponse(
            _context.Set<T>().OrderBy(x => x.CreatedDate), page, pageSize
        );
    }

    public async Task<T?> GetById(Guid id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<T> Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return entity;
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void DeleteRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public async Task<int> Count()
    {
        return await _context.Set<T>().CountAsync();
    }
}