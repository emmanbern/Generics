using Model;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class PromotionMap : EntityTypeConfiguration<Promotion>
    {

        public PromotionMap()
        {
            HasKey(k => k.Id);
            Property(p => p.IsActive);
            Property(p => p.IsVisible);
        }
    }
}
