using DAL.DataContexts;
using Interfaces.Repositories;
using Model;

namespace DAL.Repositories
{
    public class PromotionRepository : BaseRepository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(DataContext context) : base(context)
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
