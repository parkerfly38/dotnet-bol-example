using System.Linq.Dynamic.Core;

namespace dotnet_example.Models;

public class PagedResponse<T>
{
    public PagedResponse(IEnumerable<T> items, int count, int pageNumber, int pageSize)
    {
        PageInfo = new PageInfo {
            CurrentPage = pageNumber,
            RowsPerPage = pageSize,
            TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            TotalRows = count
        };
        this.Items = items;
    }

    public PageInfo PageInfo { get; set; }

    public IEnumerable<T> Items { get; set; }

    public static PagedResponse<T> ToPagedResponse(
        IQueryable<T> items, int pageNumber, int pageSize
    )
    {
        var count = items.Count();
        var data = items.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        return new PagedResponse<T>(data, count, pageNumber, pageSize);
    }
}

public class PageInfo
{
    public bool HasPreviousPage
    {
        get 
        { 
            return (CurrentPage > 1);
        }
    }

    public bool HasNextPage
    {
        get
        {
            return (CurrentPage < TotalPages);
        }
    }

    public int TotalPages { get; set; }

    public int CurrentPage { get; set; }

    public int RowsPerPage { get; set; }

    public int TotalRows { get; set; }
}