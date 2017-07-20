using Model.Extensions;
using System.Linq;

namespace DAL.Extensions
{
    public static class GenericExtensions
    {

        public static IQueryable<T> WhereActiveAndVisible<T>(this IQueryable<T> sources)
            where T : class, IActive, IVisible
        {
            return sources
                .WhereActive()
                .WhereVisible();
        }

        public static IQueryable<T> WhereActive<T>(this IQueryable<T> sources)
            where T : class, IActive
        {
            return sources.Where(t => t.IsActive);
        }

        public static IQueryable<T> WhereVisible<T>(this IQueryable<T> sources)
            where T : class, IVisible
        {
            return sources.Where(t => t.IsVisible);
        }
    }
}
