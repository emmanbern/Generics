using System;
using DAL.DataContexts;
using DAL.Repositories;
using Interfaces;

namespace DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public IProductRepository Products { get; set; }

        IProductRepository IUnitOfWork.Products => throw new NotImplementedException();

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
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
