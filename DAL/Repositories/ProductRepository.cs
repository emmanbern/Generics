using DAL.DataContexts;
using Interfaces;
using Model;

namespace DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context)
            : base(context)
        {
        }

        public DataContext Context
        {
            get
            {
                return Context as DataContext;
            }
        }
    }
}
