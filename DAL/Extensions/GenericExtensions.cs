using Model.Extensions;
using System.Linq;

namespace DAL.Extensions
{
    public static class GenericExtensions
    {

        public static IQueryable<T> FilterGeneric<T>(this IQueryable<T> sources) where T : class, IActive
        {
            return sources.Where(t => t.IsActive && t.IsVisible);
        }
    }
}
