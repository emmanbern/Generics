using Model;
using System.Collections.Generic;

namespace Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {

        IEnumerable<Product> GetAllActive();
    }
}
