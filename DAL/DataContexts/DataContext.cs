using DAL.Mapping;
using Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

            modelBuilder.Conventions
                .Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions
                .Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new PromotionMap());
        }
    }
}
