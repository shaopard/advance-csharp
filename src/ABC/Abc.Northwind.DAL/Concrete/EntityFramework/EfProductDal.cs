using Abc.Core.DataAccess.EntityFramework;
using Abc.Northwind.DAL.Abstract;
using Abc.Northwind.DAL.Concrete.EntityFramework.Contexts;
using Abc.Northwind.Entities.ConcreteTypes;

namespace Abc.Northwind.DAL.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}