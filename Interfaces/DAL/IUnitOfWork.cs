using Interfaces.Repositories;
using System;

namespace Interfaces.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IPromotionRepository Promotions { get; }
        int Complete();
    }
}
