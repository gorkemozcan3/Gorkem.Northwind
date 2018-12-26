using Gorkem.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gorkem.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
