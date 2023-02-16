using MongoDbDemo.Business.Abstract;
using MongoDbDemo.DataAccess.Abstract;
using MongoDbDemo.Entities.Concrete;

namespace MongoDbDemo.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
    }
}
