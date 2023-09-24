namespace dotnet_example.Models;

public class QueryParams
{
    private const int _maxPageSize = 50;
    private int _pageSize = 10;

    public int Page { get; set; } = 1;

    public int PageSize
    {
        get {
            return _pageSize;
        }
        set {
            if (value > _maxPageSize)
            {
                _pageSize = _maxPageSize;
            } else {
                _pageSize = value;
            }

        }
    }
}