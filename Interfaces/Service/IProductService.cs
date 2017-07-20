using Model;
using System.Collections.Generic;

namespace Interfaces.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProductsActive();
    }
}
