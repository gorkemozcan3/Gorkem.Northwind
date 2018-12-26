using Gorkem.Core.DataAccess;
using Gorkem.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gorkem.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        // IEntityRepository Producta göre çalışıyor
        // Custom operations gelebilir...

    }
}
