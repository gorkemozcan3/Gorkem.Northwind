using Gorkem.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gorkem.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        Product GetById(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
