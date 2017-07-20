using DAL.DataContexts;
using DAL.Extensions;
using Interfaces.Repositories;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class PromotionRepository : BaseRepository<Promotion>, IPromotionRepository
    {
        public DataContext Context { get { return Context as DataContext; } }

        public PromotionRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<Promotion> GetAllPromotionActive()
        {
            return Context.Promotions.FilterGeneric().ToList();
        }



    }
}
