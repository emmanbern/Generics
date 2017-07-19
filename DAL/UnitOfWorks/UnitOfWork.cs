using DAL.DataContexts;
using DAL.Repositories;
using Interfaces.DAL;
using Interfaces.Repositories;

namespace DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public IProductRepository Products { get; }
        public IPromotionRepository Promotions { get; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Promotions = new PromotionRepository(_context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
