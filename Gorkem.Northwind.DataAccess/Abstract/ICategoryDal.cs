using Gorkem.Core.DataAccess;
using Gorkem.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gorkem.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        // IEntityRepository Categorye göre çalışıyor
        // Custom operations gelebilir...
    }
}
