using DAL.DataContexts;
using DAL.Extensions;
using Interfaces.Repositories;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {

        public DataContext DataContext
        {
            get { return _context as DataContext; }
        }
        public ProductRepository(DataContext context)
            : base(context)
        {
        }


        public IEnumerable<Product> GetAllActive()
        {
            var all = _context.Products.ToList();
            return _context.Products.FilterGeneric().ToList();
        }

    }
}
