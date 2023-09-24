using dotnet_example.Data.Persistence.Repository;
using dotnet_example.Models;
using dotnet_example.Repository;

namespace dotnet_example.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly BaseDataContext _context;

    public UnitOfWork(BaseDataContext context)
    {
        _context = context;
    }

    public IDataRepository<Company> Companies => new DataRepository<Company>(_context);

    public IDataRepository<Contact> Contacts => new DataRepository<Contact>(_context);

    public IBOLv2Repository v2BOLs => new BOLv2Repository(_context);

    public async Task<int> SaveChanges()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}