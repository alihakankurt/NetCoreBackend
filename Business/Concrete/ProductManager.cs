using System.Collections.Generic;
using Core.Utilities.Results;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [CacheAspect]
        public IDataResult<List<Product>> GetAll()
        {
            return DataResult<List<Product>>.FromSuccess(_productDal.GetAll(), Messages.ItemsBrought);
        }

        [CacheAspect]
        public IDataResult<Product> GetByProductId(int productId)
        {
            return DataResult<Product>.FromSuccess(_productDal.Get(p => p.ProductId == productId), Messages.ItemsBrought);
        }
    }
}
