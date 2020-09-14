using BasicApp.DataAccess.Abstract;
using BasicApp.Entitites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BasicApp.DataAccess.Concrete.EfCore
{
    public class EfCoreCategoryDal : EfCoreGenericRepository<Category,BasicContext>,ICategoryDal
    {
       
    }
}
