using System.Linq;
using sorteio.models;

public class Pagination<TEntity> where TEntity : class
{

    public static (int, int) CalcPageOffset(PageRequest request)
    {
        int skip = (request.Number - 1) * request.Limit;
        int take = skip + request.Limit;
        return (take, skip);
    }

    public static IQueryable<TEntity> For(IQueryable<TEntity> dbSet, PageRequest pageRequest)
    {
        (int take, int skip) = CalcPageOffset(pageRequest);
        return dbSet.Take(take).Skip(skip);
    }
}
