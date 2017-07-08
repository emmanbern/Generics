using Model;
using System.Data.Entity;

namespace DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }


        public DbSet<Product> Products { get; set; }
    }
}
