using Gorkem.Northwind.Business.Abstract;
using Gorkem.Northwind.DataAccess.Abstract;
using Gorkem.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gorkem.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
