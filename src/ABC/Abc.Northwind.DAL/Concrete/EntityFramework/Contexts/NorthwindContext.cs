using System.Data.Entity;

using Abc.Northwind.DAL.Concrete.EntityFramework.Mappings;
using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.DAL.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}