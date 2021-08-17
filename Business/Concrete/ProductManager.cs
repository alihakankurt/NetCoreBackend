using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.Aspects.Autofac.Caching;
using Business.BusinessAspects.Autofac;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [SecuredOperation("Admin")]
        [CacheAspect]
        public IDataResult<Product> GetByProductId(int productId)
        {
            return DataResult<Product>.FromSuccess(_productDal.Get(p => p.ProductId == productId), Messages.ItemsBrought);
        }
    }
}
