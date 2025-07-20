using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniR.Domain.Common.Abstract;

namespace UniR.Contracts.Pagination;

public class PaginatedResult<TModel>
{
    public IReadOnlyCollection<TModel> Items { get; }
    public PaginationMetaData MetaData { get; }

    public PaginatedResult(IReadOnlyCollection<TModel> items, uint count, int pageNumber, int pageSize)
    {
        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be at least 1.");

        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be at least 1.");

        this.MetaData = new PaginationMetaData(pageNumber, (int)Math.Ceiling(count / (double)pageSize), count);

        Items = items ?? throw new ArgumentNullException(nameof(items));
    }

    public static async Task<PaginatedResult<T>> CreateAsync<T>(IQueryable<T> source, int pageNumber, int pageSize,
        CancellationToken cancellationToken = default)
    {
        var count = await source.CountAsync(cancellationToken);
        var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);
        return new PaginatedResult<T>(items, (uint)count, pageNumber, pageSize);
    }
}