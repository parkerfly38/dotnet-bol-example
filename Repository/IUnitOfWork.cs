using dotnet_example.Models;

namespace dotnet_example.Repository;

public interface IUnitOfWork : IDisposable
{
    IDataRepository<Company> Companies { get; }
    IDataRepository<Contact> Contacts { get; }
    IBOLv2Repository v2BOLs { get; }
    Task<int> SaveChanges();
}