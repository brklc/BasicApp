using BasicApp.DataAccess.Abstract;
using BasicApp.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BasicApp.DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, BasicContext>, IProductDal
    {

        
    }
}
