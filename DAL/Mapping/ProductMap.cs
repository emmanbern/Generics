using Model;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {

        public ProductMap()
        {

            HasKey(i => i.Id);
            Property(p => p.Id);
            Property(p => p.IsActive);
            Property(p => p.IsVisible);
        }
    }
}
