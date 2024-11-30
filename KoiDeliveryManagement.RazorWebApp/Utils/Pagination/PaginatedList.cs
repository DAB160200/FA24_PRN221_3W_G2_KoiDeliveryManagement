using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;

namespace KoiDeliveryManagement.RazorWebApp.Utils.Pagination;

public class PaginatedList<T> : List<T>
{
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }

    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

        AddRange(items);
    }

    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;

    public static PaginatedList<T> Create(IList<T> sourceItems, int pageIndex, int pageSize)
    {
        var count = sourceItems.Count();
        var items = sourceItems.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        return new PaginatedList<T>(items, count, pageIndex, pageSize);
    }
}
