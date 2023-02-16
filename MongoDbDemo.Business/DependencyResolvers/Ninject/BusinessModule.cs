using MongoDbDemo.Business.Abstract;
using MongoDbDemo.Business.Concrete.Managers;
using MongoDbDemo.DataAccess.Abstract;
using MongoDbDemo.DataAccess.Concrete.MongoDb;
using Ninject.Modules;

namespace MongoDbDemo.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductDal>().To<MdProductDal>().InSingletonScope();
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
        }
    }
}
