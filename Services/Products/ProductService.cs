using Interfaces.DAL;
using Interfaces.Service;
using Services.BaseServices;

namespace Services.Products
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IUnitOfWork unitOfwork) : base(unitOfwork) { }

    }
}
