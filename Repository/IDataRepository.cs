using dotnet_example.Models;

namespace dotnet_example.Repository;

public interface IDataRepository<T> where T : class
{
    PagedResponse<T> Get(int page = 1, int pageSize = 10);

    Task<T?> GetById(Guid id);

    Task<T> Add(T entity);

    void Update(T entity);

    void Delete(T entity);

    void DeleteRange(IEnumerable<T> entities);

    Task<int> Count();
}