using Interfaces;
using System;

namespace DAL.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        int Complete();
    }
}
