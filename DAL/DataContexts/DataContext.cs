using Model;
using System.Data.Entity;

namespace DAL.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }


        public DbSet<Product> Products { get; set; }
    }
}
