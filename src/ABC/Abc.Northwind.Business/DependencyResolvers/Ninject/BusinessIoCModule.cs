using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Business.Concrete;
using Abc.Northwind.DAL.Abstract;
using Abc.Northwind.DAL.Concrete.EntityFramework;

using Ninject.Modules;

namespace Abc.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessIoCModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();
        }
    }
}