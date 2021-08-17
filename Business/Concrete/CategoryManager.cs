using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> GetByCategoryId(int categoryId)
        {
            return DataResult<Category>.FromSuccess(_categoryDal.Get(c => c.CategoryId == categoryId), Messages.ItemsBrought);
        }
    }
}
