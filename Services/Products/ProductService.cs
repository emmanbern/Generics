using Interfaces.DAL;
using Interfaces.Service;
using Model;
using Services.BaseServices;
using System.Collections.Generic;

namespace Services.Products
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IUnitOfWork unitOfwork) : base(unitOfwork) { }



        public IEnumerable<Product> GetProductsActive()
        {
            return _unitOfWork.Products.GetAllActive();
        }

    }
}
